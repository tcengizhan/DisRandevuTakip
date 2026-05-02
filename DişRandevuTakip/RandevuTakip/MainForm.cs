using System;
using System.Collections.Generic;
using System.Windows.Forms;
using RandevuTakip.Data;
using RandevuTakip.Models;

namespace RandevuTakip
{
    public partial class MainForm : Form
    {
        private readonly RandevuRepository _randevuRepository = new RandevuRepository();
        private bool _sadeceBugun;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            VerileriGuncelle();
        }

        private void btnYeniRandevu_Click(object sender, EventArgs e)
        {
            using (var randevuForm = new RandevuForm())
            {
                if (randevuForm.ShowDialog() == DialogResult.OK)
                {
                    _randevuRepository.Add(randevuForm.Randevu);
                    VerileriGuncelle();
                }
            }
        }

        private void btnRandevuGuncelle_Click(object sender, EventArgs e)
        {
            var seciliRandevu = SeciliRandevuGetir();

            if (seciliRandevu == null)
            {
                MessageBox.Show("Lütfen güncellenecek randevuyu seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var randevuForm = new RandevuForm(seciliRandevu))
            {
                if (randevuForm.ShowDialog() == DialogResult.OK)
                {
                    _randevuRepository.Update(randevuForm.Randevu);
                    VerileriGuncelle();
                }
            }
        }

        private void btnRandevuSil_Click(object sender, EventArgs e)
        {
            var seciliRandevu = SeciliRandevuGetir();

            if (seciliRandevu == null)
            {
                MessageBox.Show("Lütfen silinecek randevuyu seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var cevap = MessageBox.Show(
                "Seçili randevuyu silmek istediğinize emin misiniz?",
                "Silme Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (cevap == DialogResult.Yes)
            {
                _randevuRepository.Delete(seciliRandevu.Id);
                VerileriGuncelle();
            }
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            VerileriGuncelle();
        }

        private void btnBugun_Click(object sender, EventArgs e)
        {
            _sadeceBugun = true;
            VerileriGuncelle();
        }

        private void btnTumRandevular_Click(object sender, EventArgs e)
        {
            _sadeceBugun = false;
            VerileriGuncelle();
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            VerileriGuncelle();
        }

        private void lblMenu1_Click(object sender, EventArgs e)
        {
            _sadeceBugun = false;
            VerileriGuncelle();
        }

        private void lblMenu3_Click(object sender, EventArgs e)
        {
            using (var tedaviNotlariForm = new TedaviNotlariForm(SeciliRandevuGetir()))
            {
                tedaviNotlariForm.ShowDialog();
            }

            VerileriGuncelle();
        }

        private void dgvRandevular_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnRandevuGuncelle_Click(sender, e);
            }
        }

        private void VerileriGuncelle()
        {
            try
            {
                List<Randevu> randevular = _sadeceBugun
                    ? _randevuRepository.GetToday(txtArama.Text)
                    : _randevuRepository.Search(txtArama.Text);

                dgvRandevular.DataSource = null;
                dgvRandevular.DataSource = randevular;
                GridKolonlariniDuzenle();

                lblKayitSayisi.Text = $"{randevular.Count} randevu listeleniyor";
                lblListeBaslik.Text = _sadeceBugun ? "Bugünkü Randevular" : "Randevu Listesi";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Randevular listelenirken hata oluştu. Veritabanı bağlantısını ve SQL tablosunu kontrol ediniz.\n\n" + ex.Message,
                    "Veritabanı Hatası",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private Randevu SeciliRandevuGetir()
        {
            if (dgvRandevular.CurrentRow == null)
            {
                return null;
            }

            return dgvRandevular.CurrentRow.DataBoundItem as Randevu;
        }

        private void GridKolonlariniDuzenle()
        {
            if (dgvRandevular.Columns.Count == 0)
            {
                return;
            }

            foreach (DataGridViewColumn column in dgvRandevular.Columns)
            {
                column.Visible = false;
            }

            KolonGoster("Id", "No", 55);
            KolonGoster("Kisi", "Hasta Adı Soyadı", 180);
            KolonGoster("Telefon", "Telefon", 115);
            KolonGoster("Tarih", "Tarih", 95, "dd.MM.yyyy");
            KolonGoster("SaatText", "Saat", 75);
            KolonGoster("TedaviTuru", "Tedavi Türü", 145);
            KolonGoster("Durum", "Durum", 100);
            KolonGoster("Notlar", "Not", 230);
        }

        private void KolonGoster(string propertyName, string baslik, int genislik, string format = null)
        {
            if (!dgvRandevular.Columns.Contains(propertyName))
            {
                return;
            }

            var column = dgvRandevular.Columns[propertyName];
            column.Visible = true;
            column.HeaderText = baslik;
            column.Width = genislik;

            if (!string.IsNullOrWhiteSpace(format))
            {
                column.DefaultCellStyle.Format = format;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using RandevuTakip.Data;
using RandevuTakip.Models;

namespace RandevuTakip
{
    public partial class TedaviNotlariForm : Form
    {
        private readonly TedaviNotuRepository _tedaviNotuRepository = new TedaviNotuRepository();
        private readonly Randevu _seciliRandevu;

        public TedaviNotlariForm()
        {
            InitializeComponent();
        }

        public TedaviNotlariForm(Randevu randevu) : this()
        {
            _seciliRandevu = randevu;
        }

        private void TedaviNotlariForm_Load(object sender, EventArgs e)
        {
            if (_seciliRandevu != null)
            {
                lblListeBaslik.Text = "Seçili Randevunun Tedavi Notları";
            }

            VerileriGuncelle();
        }

        private void btnYeniTedaviNotu_Click(object sender, EventArgs e)
        {
            using (var tedaviNotuForm = _seciliRandevu == null ? new TedaviNotuForm() : new TedaviNotuForm(_seciliRandevu))
            {
                if (tedaviNotuForm.ShowDialog() == DialogResult.OK)
                {
                    _tedaviNotuRepository.Add(tedaviNotuForm.TedaviNotu);
                    VerileriGuncelle();
                }
            }
        }

        private void btnTedaviNotuGuncelle_Click(object sender, EventArgs e)
        {
            var seciliNot = SeciliTedaviNotuGetir();
            if (seciliNot == null)
            {
                MessageBox.Show("Lütfen güncellenecek tedavi notunu seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var tedaviNotuForm = new TedaviNotuForm(seciliNot))
            {
                if (tedaviNotuForm.ShowDialog() == DialogResult.OK)
                {
                    _tedaviNotuRepository.Update(tedaviNotuForm.TedaviNotu);
                    VerileriGuncelle();
                }
            }
        }

        private void btnTedaviNotuSil_Click(object sender, EventArgs e)
        {
            var seciliNot = SeciliTedaviNotuGetir();
            if (seciliNot == null)
            {
                MessageBox.Show("Lütfen silinecek tedavi notunu seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var cevap = MessageBox.Show(
                "Seçili tedavi notunu silmek istediğinize emin misiniz?",
                "Silme Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (cevap == DialogResult.Yes)
            {
                _tedaviNotuRepository.Delete(seciliNot.TedaviNotuId);
                VerileriGuncelle();
            }
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            VerileriGuncelle();
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            if (_seciliRandevu == null)
            {
                VerileriGuncelle();
            }
        }

        private void dgvTedaviNotlari_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnTedaviNotuGuncelle_Click(sender, e);
            }
        }

        private void VerileriGuncelle()
        {
            try
            {
                List<TedaviNotu> notlar = _seciliRandevu == null
                    ? _tedaviNotuRepository.Search(txtArama.Text)
                    : _tedaviNotuRepository.GetByRandevuId(_seciliRandevu.Id);

                dgvTedaviNotlari.DataSource = null;
                dgvTedaviNotlari.DataSource = notlar;
                GridKolonlariniDuzenle();
                lblKayitSayisi.Text = $"{notlar.Count} tedavi notu listeleniyor";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tedavi notları listelenirken hata oluştu.\n\n" + ex.Message, "Veritabanı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private TedaviNotu SeciliTedaviNotuGetir()
        {
            if (dgvTedaviNotlari.CurrentRow == null)
            {
                return null;
            }

            return dgvTedaviNotlari.CurrentRow.DataBoundItem as TedaviNotu;
        }

        private void GridKolonlariniDuzenle()
        {
            if (dgvTedaviNotlari.Columns.Count == 0)
            {
                return;
            }

            foreach (DataGridViewColumn column in dgvTedaviNotlari.Columns)
            {
                column.Visible = false;
            }

            KolonGoster("TedaviNotuId", "No", 55);
            KolonGoster("HastaAdi", "Hasta", 170);
            KolonGoster("TedaviTarihi", "Tedavi Tarihi", 110, "dd.MM.yyyy");
            KolonGoster("TedaviTuru", "Tedavi Türü", 140);
            KolonGoster("Aciklama", "Tedavi Notu", 320);
            KolonGoster("RandevuBilgisi", "Randevu", 220);
        }

        private void KolonGoster(string propertyName, string baslik, int genislik, string format = null)
        {
            if (!dgvTedaviNotlari.Columns.Contains(propertyName))
            {
                return;
            }

            var column = dgvTedaviNotlari.Columns[propertyName];
            column.Visible = true;
            column.HeaderText = baslik;
            column.Width = genislik;

            if (!string.IsNullOrWhiteSpace(format))
            {
                column.DefaultCellStyle.Format = format;
            }
        }

        private void pnlListeKart_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

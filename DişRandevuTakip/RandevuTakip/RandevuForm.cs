using System;
using System.Windows.Forms;
using RandevuTakip.Models;

namespace RandevuTakip
{
    public partial class RandevuForm : Form
    {
        private readonly Randevu _duzenlenenRandevu;

        public Randevu Randevu { get; private set; }

        public RandevuForm()
        {
            InitializeComponent();
            AlanlariHazirla();
        }

        public RandevuForm(Randevu randevu) : this()
        {
            _duzenlenenRandevu = randevu;

            txtKisi.Text = randevu.Kisi;
            txtTelefon.Text = randevu.Telefon;
            txtNotlar.Text = randevu.Notlar;
            dtpTarih.Value = randevu.Tarih;
            dtpSaat.Value = DateTime.Today.Add(randevu.Saat);
            SecimAyarla(cmbTedaviTuru, randevu.TedaviTuru);
            SecimAyarla(cmbDurum, randevu.Durum);

            Text = "Randevu Güncelle";
            lblFormBaslik.Text = "Randevu Güncelle";
            btnKaydet.Text = "Güncelle";
        }

        private void AlanlariHazirla()
        {
            cmbTedaviTuru.Items.Clear();
            cmbTedaviTuru.Items.AddRange(new object[]
            {
                "Muayene",
                "Diş Temizliği",
                "Dolgu",
                "Kanal Tedavisi",
                "Diş Çekimi",
                "Kontrol Randevusu"
            });
            cmbTedaviTuru.SelectedIndex = 0;

            cmbDurum.Items.Clear();
            cmbDurum.Items.AddRange(new object[]
            {
                "Bekliyor",
                "Tamamlandı",
                "İptal Edildi"
            });
            cmbDurum.SelectedIndex = 0;

            dtpTarih.Value = DateTime.Today;
            dtpSaat.Value = DateTime.Today.AddHours(9);
        }

        private void SecimAyarla(ComboBox comboBox, string deger)
        {
            if (string.IsNullOrWhiteSpace(deger))
            {
                return;
            }

            if (!comboBox.Items.Contains(deger))
            {
                comboBox.Items.Add(deger);
            }

            comboBox.SelectedItem = deger;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKisi.Text))
            {
                MessageBox.Show("Lütfen hasta adını giriniz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKisi.Focus();
                return;
            }

            Randevu = new Randevu
            {
                Id = _duzenlenenRandevu == null ? 0 : _duzenlenenRandevu.Id,
                Kisi = txtKisi.Text.Trim(),
                Telefon = txtTelefon.Text.Trim(),
                Tarih = dtpTarih.Value.Date,
                Saat = dtpSaat.Value.TimeOfDay,
                TedaviTuru = cmbTedaviTuru.Text.Trim(),
                Durum = cmbDurum.Text.Trim(),
                Notlar = txtNotlar.Text.Trim()
            };

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}

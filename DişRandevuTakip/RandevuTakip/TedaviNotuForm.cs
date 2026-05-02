using System;
using System.Collections.Generic;
using System.Windows.Forms;
using RandevuTakip.Data;
using RandevuTakip.Models;

namespace RandevuTakip
{
    public partial class TedaviNotuForm : Form
    {
        private readonly RandevuRepository _randevuRepository = new RandevuRepository();
        private readonly TedaviNotu _duzenlenenNot;
        private readonly Randevu _seciliRandevu;

        public TedaviNotu TedaviNotu { get; private set; }

        public TedaviNotuForm()
        {
            InitializeComponent();
            AlanlariHazirla();
        }

        public TedaviNotuForm(Randevu randevu) : this()
        {
            _seciliRandevu = randevu;
            if (randevu != null)
            {
                SeciliDegerAyarla(cmbRandevu, randevu.Id);
                SecimAyarla(cmbTedaviTuru, randevu.TedaviTuru);
                dtpTedaviTarihi.Value = randevu.Tarih;
            }
        }

        public TedaviNotuForm(TedaviNotu not) : this()
        {
            _duzenlenenNot = not;
            SeciliDegerAyarla(cmbRandevu, not.RandevuId);
            SecimAyarla(cmbTedaviTuru, not.TedaviTuru);
            txtAciklama.Text = not.Aciklama;
            dtpTedaviTarihi.Value = not.TedaviTarihi;
            Text = "Tedavi Notu Güncelle";
            lblFormBaslik.Text = "Tedavi Notu Güncelle";
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
                "Kontrol"
            });
            cmbTedaviTuru.SelectedIndex = 0;

            dtpTedaviTarihi.Value = DateTime.Today;
            RandevulariYukle();
        }

        private void RandevulariYukle()
        {
            List<Randevu> randevular = _randevuRepository.GetAll();
            cmbRandevu.DataSource = randevular;
            cmbRandevu.DisplayMember = "RandevuBilgisi";
            cmbRandevu.ValueMember = "Id";
        }

        private void SeciliDegerAyarla(ComboBox comboBox, int? deger)
        {
            if (!deger.HasValue)
            {
                return;
            }

            try
            {
                comboBox.SelectedValue = deger.Value;
            }
            catch
            {
                // Listedeki kayıt bulunamazsa seçim boş kalabilir.
            }
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

            comboBox.Text = deger;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (cmbRandevu.SelectedValue == null)
            {
                MessageBox.Show("Tedavi notu için randevu seçiniz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(cmbTedaviTuru.Text))
            {
                MessageBox.Show("Tedavi türünü giriniz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbTedaviTuru.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAciklama.Text))
            {
                MessageBox.Show("Tedavi açıklamasını giriniz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAciklama.Focus();
                return;
            }

            TedaviNotu = new TedaviNotu
            {
                TedaviNotuId = _duzenlenenNot == null ? 0 : _duzenlenenNot.TedaviNotuId,
                RandevuId = Convert.ToInt32(cmbRandevu.SelectedValue),
                TedaviTuru = cmbTedaviTuru.Text.Trim(),
                Aciklama = txtAciklama.Text.Trim(),
                TedaviTarihi = dtpTedaviTarihi.Value.Date
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

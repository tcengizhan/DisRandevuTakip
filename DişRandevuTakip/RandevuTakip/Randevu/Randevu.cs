using System;

namespace RandevuTakip.Models
{
    public class Randevu
    {
        public int Id { get; set; }
        public string Kisi { get; set; }
        public string Telefon { get; set; }
        public DateTime Tarih { get; set; }
        public TimeSpan Saat { get; set; }
        public string TedaviTuru { get; set; }
        public string Durum { get; set; }
        public string Notlar { get; set; }
        public DateTime OlusturmaTarihi { get; set; }

        public string SaatText
        {
            get
            {
                return Saat.ToString(@"hh\:mm");
            }
        }

        public string RandevuBilgisi
        {
            get
            {
                return $"{Tarih:dd.MM.yyyy} - {Saat:hh\\:mm} - {Kisi}";
            }
        }

        public override string ToString()
        {
            return $"{Tarih:dd.MM.yyyy} - {Saat:hh\\:mm} - {Kisi}";
        }
    }
}

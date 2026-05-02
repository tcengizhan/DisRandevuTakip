using System;

namespace RandevuTakip.Models
{
    public class TedaviNotu
    {
        public int TedaviNotuId { get; set; }
        public int? RandevuId { get; set; }
        public string TedaviTuru { get; set; }
        public string Aciklama { get; set; }
        public DateTime TedaviTarihi { get; set; }
        public DateTime OlusturmaTarihi { get; set; }

        public string HastaAdi { get; set; }
        public string RandevuBilgisi { get; set; }
    }
}

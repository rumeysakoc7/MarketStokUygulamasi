using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStokUygulamsı_
{
    public class StokHareket
    {
        public int UrunID { get; set; }
        public string IslemTuru { get; set; }
        public int IslemID { get; set; }
        public int Miktar { get; set; }
        public DateTime IslemTarihi { get; set; }
        public int Kullanici_ID { get; set; }
        public string UrunAdi { get; set; }
        public decimal ToplamTutar { get; set; }
        public string KullaniciAdi { get; set; }
    }
}

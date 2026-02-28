using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStokUygulamsı_
{
    public class Alis
    {
            public int AlisID { get; set; }
            public int UrunID { get; set; }
            public int TedarikciId { get; set; }
            public int Miktar { get; set; }
            public decimal AlisFiyat { get; set; }
            public decimal ToplamMaliyet { get; set; }
            public DateTime AlisTarihi { get; set; }
            public int KullaniciId { get; set; }
         public string UrunAdi { get; set; }
        public string TedarikciAdi { get; set; }
        public string FirmaAdi { get; set; }

    }
}

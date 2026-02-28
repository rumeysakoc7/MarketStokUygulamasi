using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStokUygulamsı_
{
    public class Satis
    {
            public int SatisID { get; set; }
            public int UrunID { get; set; }
            public int Miktar { get; set; }
            public decimal BirimFiyat { get; set; }
            public decimal ToplamFiyat { get; set; }
            public int Musteri_Id { get; set; }
            public DateTime SatisTarihi { get; set; }

             public int Kullanici_ID { get; set; }
        public string UrunAdi { get; set; } 
        public string MusteriAdi { get; set; } 

    }

}


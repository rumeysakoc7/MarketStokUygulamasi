using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStokUygulamsı_
{
    public class Urun
    {
        public int UrunID { get; set; }
        public string UrunAdi { get; set; }
        public int KategoriID { get; set; }
        public string KategoriAdi { get; set; }
        public string FirmaAdi { get; set; }
        public int TedarikciID { get; set; }

        public int StokMiktari { get; set; }
        public decimal Fiyat { get; set; }
        public decimal Alis_Fiyat { get; set; }

        public string Urun_resim { get; set; }
        public bool Durum { get; set; }

        public decimal AlisFiyat { get; set; }

         public string TedarikciAdSoyad { get; set; }
    }
}

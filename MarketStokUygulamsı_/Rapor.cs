using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStokUygulamsı_
{
    public class Rapor
    {
        public int RaporID { get; set; }
        public DateTime RaporTarihi { get; set; }
        public decimal Toplam_Satis { get; set; }
        public decimal Toplam_Maliyet { get; set; }
        public decimal Kar_Orani { get; set; }
        public int Satilan_Toplam_Urun { get; set; }
        public int En_Cok_Satan_UrunID { get; set; }
    }
}

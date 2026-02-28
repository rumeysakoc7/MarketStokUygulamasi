using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStokUygulamsı_
{ 
        public class SepetItem
        {
            public int UrunID { get; set; }
            public string UrunAdi { get; set; }
            public decimal BirimFiyat { get; set; }
            public int Miktar { get; set; }
            public decimal ToplamFiyat { get; set; }
        }
    
}

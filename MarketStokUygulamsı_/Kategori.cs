using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStokUygulamsı_
{
   public class Kategori
    {
        public int KategoriID { get; set; }
        public string KategoriAdi { get; set; }
        public string Aciklama { get; set; }
        public bool Durum { get; set; }
    }
}

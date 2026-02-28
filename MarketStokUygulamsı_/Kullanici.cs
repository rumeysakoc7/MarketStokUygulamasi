using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStokUygulamsı_
{
    public class Kullanici
    {
        public int KullaniciID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public string Yetki { get; set; }
        public string KullaniciTelNo { get; set; }
        public DateTime OlusturmaTarihi { get; set; }
        public bool Durum { get; set; }

    }
}

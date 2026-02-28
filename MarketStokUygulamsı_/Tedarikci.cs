using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStokUygulamsı_
{
    public class Tedarikci
    {

        public int TedarikciID { get; set; }
        public string TedarikciAdi { get; set; }
        public string TedarikciSoyadi { get; set; }
        public string FirmaAdi { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
        public bool Durum { get; set; }
    }
}

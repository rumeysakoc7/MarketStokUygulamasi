using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace MarketStokUygulamsı_
{
    public partial class Formanasayfa : Form
    {
        private string yetki;

        public Formanasayfa(string kullaniciYetki)
        {
            InitializeComponent();
            yetki = kullaniciYetki;

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            if (yetki == "Admin")
            {
                btnurun.Enabled = true;
                btnkategori.Enabled = true;
                btnkullanici.Enabled = true;
                btnmusteri.Enabled = true;
                btntedarikci.Enabled = true;
                btnsatis.Enabled = true;
                btnalis.Enabled = true;
                btnlog.Enabled = true;
                buttonstokhareket.Enabled = true;
                buttonRaporlar.Enabled = true;
                buttonsatısdetay.Enabled = true;
            }
            else if (yetki == "Personel")
            {

                btnurun.Enabled = true;
                btnkategori.Enabled = true;
                btnkullanici.Enabled = false;
                btnmusteri.Enabled = true;
                btntedarikci.Enabled = false;
                btnsatis.Enabled = true;
                btnalis.Enabled = true;
                btnlog.Enabled = false;
                buttonstokhareket.Enabled = true;
                buttonRaporlar.Enabled = false;
                buttonsatısdetay.Enabled = true;
            }

        }

        private void btnurun_Click(object sender, EventArgs e)
        {
            FormUrunler urunFormu = new FormUrunler();
            urunFormu.Show();
        }

        private void Formanasayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnkategori_Click(object sender, EventArgs e)
        {
            FormKategoriler kategoriFormu = new FormKategoriler();
            kategoriFormu.Show();
        }

        private void btnkullanici_Click(object sender, EventArgs e)
        {
            FormKullaniciBilgi kullaniciBilgiFormu = new FormKullaniciBilgi();
            kullaniciBilgiFormu.Show();
        }

        private void btnmusteri_Click(object sender, EventArgs e)
        {
            FormMusteriBilgi musteriBilgiFormu = new FormMusteriBilgi();
            musteriBilgiFormu.Show();
        }

        private void btntedarikci_Click(object sender, EventArgs e)
        {
            FormTedarikciler TedarikciFormu = new FormTedarikciler();
            TedarikciFormu.Show();
        }

        private void btnsatis_Click(object sender, EventArgs e)
        {
            FormSatis satisFormu = new FormSatis();
            satisFormu.Show();
        }

        private void btnalis_Click(object sender, EventArgs e)
        {
            FormAlis alisFormu = new FormAlis();
            alisFormu.Show();
        }

        private void btnlog_Click(object sender, EventArgs e)
        {
            FormLog logFormu = new FormLog();
            logFormu.Show();
        }

        private void buttonstokhareket_Click(object sender, EventArgs e)
        {
            FormStokHareketleri stokHareketleriFormu = new FormStokHareketleri();
            stokHareketleriFormu.Show();
        }

        private void buttonsatısdetay_Click(object sender, EventArgs e)
        {
            FormSatisDetay satisDetayFormu = new FormSatisDetay();
            satisDetayFormu.Show();
        }

        private void buttonRaporlar_Click(object sender, EventArgs e)
        {
            FormRapor raporFormu = new FormRapor();
            raporFormu.Show();
        }
    }
}

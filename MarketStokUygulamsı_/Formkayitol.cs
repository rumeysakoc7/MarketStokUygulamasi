using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Data.SqlTypes;

namespace MarketStokUygulamsı_
{
    public partial class Formkayitol : Form
    {
        private readonly DatabaseHelper _databaseHelper;
        public Formkayitol()
        {
            InitializeComponent();
            _databaseHelper = new DatabaseHelper();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad = txtBoxad.Text;
            string soyad = txtBoxsoyad.Text;
            string kullaniciAdi = txtBoxkullaniciad.Text;
            string sifre =MD5_Sifreleme.MD5_Olustur(txtBoxsifre.Text);
            string yetki = comboBoxyetki.Text;
            string telefon = mskdTctboxtelno.Text;

            if (string.IsNullOrEmpty(ad) || string.IsNullOrEmpty(soyad) || string.IsNullOrEmpty(kullaniciAdi) ||
        string.IsNullOrEmpty(sifre) || string.IsNullOrEmpty(yetki) || string.IsNullOrEmpty(telefon))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                return;
            }


            try
            {
                string sqlEkle = "INSERT INTO Kullanicilar (Adi, Soyadi, KullaniciAdi, Sifre, Yetki, KullaniciTelNo) VALUES (@Ad, @Soyad,@KullaniciAdi, @Sifre, @Yetki, @Telefon)";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Ad", ad),
                    new SqlParameter("@Soyad", soyad),
                    new SqlParameter("@KullaniciAdi", kullaniciAdi),
                    new SqlParameter("@Sifre", sifre),
                    new SqlParameter("@Yetki", yetki),
                    new SqlParameter("@Telefon", telefon)
                };
                int result = _databaseHelper.ExecuteNonQuery(sqlEkle, parameters);

                if (result > 0)
                {
                    MessageBox.Show("Kullanıcı başarı ile kaydedildi.");
                    this.Close();
                    Formgiris geriDon = new Formgiris();
                    geriDon.Show();
                }
                else
                {
                    MessageBox.Show("Kullanıcı kaydı başarısız!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu:" + ex.Message);
            }
        }

        private void buttoniptal_Click(object sender, EventArgs e)
        {
            this.Close();
            Formgiris girisFormu = new Formgiris();
            girisFormu.Show();
        }
    }
}

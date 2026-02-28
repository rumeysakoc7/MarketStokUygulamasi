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

namespace MarketStokUygulamsı_
{
    public partial class Formsifremiunuttum : Form
    {
        private readonly DatabaseHelper _databaseHelper;
        public Formsifremiunuttum()
        {
            InitializeComponent();
            _databaseHelper = new DatabaseHelper();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = textBoxkullaniciad.Text;
            string telefon = maskedTextBoxtelno.Text;
            string yeniSifre =MD5_Sifreleme.MD5_Olustur(textBoxsifre.Text);
            string sifreTekrar =MD5_Sifreleme.MD5_Olustur(textBoxsifreyeni.Text);

            
            if (string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(telefon) ||
                string.IsNullOrEmpty(yeniSifre) || string.IsNullOrEmpty(sifreTekrar))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                return;
            }

           
            if (yeniSifre != sifreTekrar)
            {
                MessageBox.Show("Şifreler uyuşmuyor! Lütfen tekrar deneyiniz.");
                return;
            }

            
            try
            {
                
                string kontrolQuery = "SELECT COUNT(*) FROM Kullanicilar WHERE KullaniciAdi = @KullaniciAdi AND KullaniciTelNo = @Telefon";
                SqlParameter[] kontrolParameters = new SqlParameter[]
               {
                     new SqlParameter("@KullaniciAdi", kullaniciAdi),
                     new SqlParameter("@Telefon", telefon)
               };

                int sonuc = Convert.ToInt32(_databaseHelper.ExecuteQuery(kontrolQuery, kontrolParameters).Rows[0][0]);

                    if (sonuc == 0)
                    {
                        MessageBox.Show("Kullanıcı adı veya telefon numarası hatalı!");
                        return;
                    }
                

                string guncelleQuery = "UPDATE Kullanicilar SET Sifre = @YeniSifre WHERE KullaniciAdi = @KullaniciAdi AND KullaniciTelNo = @Telefon";
                SqlParameter[] guncelleParameters = new SqlParameter[]
                 {
                    new SqlParameter("@YeniSifre", yeniSifre),
                    new SqlParameter("@KullaniciAdi", kullaniciAdi),
                    new SqlParameter("@Telefon", telefon)
                 };

                int result = _databaseHelper.ExecuteNonQuery(guncelleQuery, guncelleParameters);

                if (result > 0)
                    {
                        MessageBox.Show("Şifre başarıyla güncellendi.");
                        this.Close(); 
                        Formgiris girisFormu = new Formgiris();
                        girisFormu.Show();
                    }
                    else
                    {
                        MessageBox.Show("Şifre güncelleme başarısız!");
                    }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
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

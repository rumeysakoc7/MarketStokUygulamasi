using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.Sql;

namespace MarketStokUygulamsı_
{
    public partial class Formgiris : Form
    {

        private readonly DatabaseHelper _databaseHelper;

        public Formgiris()
        {
            InitializeComponent();
            _databaseHelper = new DatabaseHelper();
        }

        private void linkLabeloturum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
            Formkayitol oturumAcForm = new Formkayitol();
            oturumAcForm.Show();
            this.Hide();
        }
      

        private void button1_Click(object sender, EventArgs e)
        {
            string kullanici = txtboxkullaniciAd.Text;
            string sifre =MD5_Sifreleme.MD5_Olustur(txtboxsifre.Text);

            if (string.IsNullOrEmpty(kullanici) || string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("Lütfen Kullanıcı Adı ve Şifre alanlarını doldurunuz.");
                return;
            }

            try
            {
                string sqlSorgu = "SELECT KullaniciID, Yetki, Durum FROM Kullanicilar WHERE KullaniciAdi=@KullaniciAdi AND Sifre=@Sifre";
                SqlParameter[] parameters = new SqlParameter[]
                {
            new SqlParameter("@KullaniciAdi", kullanici),
            new SqlParameter("@Sifre", sifre)
                };

                DataTable resultTable = _databaseHelper.ExecuteQuery(sqlSorgu, parameters);
                if (resultTable.Rows.Count > 0)
                {
                    bool durum = Convert.ToBoolean(resultTable.Rows[0]["Durum"]);
                    if (durum)
                    {
                        int kullaniciID = Convert.ToInt32(resultTable.Rows[0]["KullaniciID"]);
                        string yetki = resultTable.Rows[0]["Yetki"].ToString();

                        KullaniciErisim.KullaniciID = kullaniciID;
                        KullaniciErisim.KullaniciYetkisi = yetki;

                        MessageBox.Show("Giriş başarılı!");

                        Formanasayfa gecis = new Formanasayfa(yetki);
                        gecis.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Hesabınız pasif. Lütfen yöneticiniz ile iletişime geçiniz.");
                    }
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı veya Şifre yanlış.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri tabanı bağlantısında bir hata oluştu. Lütfen biraz sonra tekrar deneyiniz.\n" + ex.Message);
            }

        }

        private void linklabelsifre_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            Formsifremiunuttum sifremiunuttumForm = new Formsifremiunuttum();
            sifremiunuttumForm.Show();
            this.Hide();
        }

        private void Formgiris_Load(object sender, EventArgs e)
        {

        }
    }
}

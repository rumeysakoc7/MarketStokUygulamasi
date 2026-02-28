using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;


namespace MarketStokUygulamsı_
{
    public class Kayitol
    {
        private readonly DatabaseHelper _dbHelper = new DatabaseHelper();


        public bool KullaniciSorgu(string kullaniciAdi, string telefon)
        {
            string sqlKontrol = "SELECT COUNT(*) FROM Kullanicilar WHERE KullaniciAdi = @KullaniciAdi OR KullaniciTelNo = @Telefon";
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@KullaniciAdi", kullaniciAdi),
            new SqlParameter("@Telefon", telefon)
            };

            int result = Convert.ToInt32(_dbHelper.ExecuteScalar(sqlKontrol, parameters));

            return result > 0;
        }

        public bool AddUser(Kullanici kullanici)
        {
            string sqlEkle = "INSERT INTO Kullanicilar (Adi, Soyadi, KullaniciAdi, Sifre, Yetki, KullaniciTelNo, OlusturmaTarihi, Durum) " +
                             "VALUES (@Ad, @Soyad, @KullaniciAdi, @Sifre, @Yetki, @KullaniciTelNo, @OlusturmaTarihi, @Durum)";
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@Ad", kullanici.Ad),
            new SqlParameter("@Soyad", kullanici.Soyad),
            new SqlParameter("@KullaniciAdi", kullanici.KullaniciAdi),
            new SqlParameter("@Sifre", kullanici.Sifre),
            new SqlParameter("@Yetki", kullanici.Yetki),
            new SqlParameter("@KullaniciTelNo", kullanici.KullaniciTelNo),
            new SqlParameter("@OlusturmaTarihi", kullanici.OlusturmaTarihi),
            new SqlParameter("@Durum", kullanici.Durum)
            };

            int result = _dbHelper.ExecuteNonQuery(sqlEkle, parameters);
            return result > 0;
        }
    }
}

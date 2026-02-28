using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace MarketStokUygulamsı_
{
    public class KullanciRepository
    {
        private readonly DatabaseHelper _dbHelper;
        public KullanciRepository()
        {
            _dbHelper = new DatabaseHelper();
        }


        public DataTable GetKullanicilar(bool? durum = null)
        {
            string query = "SELECT KullaniciID, Adi, Soyadi, KullaniciAdi, Yetki, OlusturmaTarihi, KullaniciTelNo, Sifre, Durum FROM Kullanicilar";

            if (durum.HasValue)
            {
                query += " WHERE Durum = @Durum";
            }

            SqlParameter[] parameters = durum.HasValue
                ? new SqlParameter[] { new SqlParameter("@Durum", durum.Value) }
                : new SqlParameter[] { };

            return _dbHelper.ExecuteQuery(query, parameters);
        }


        // Kullanıcı ekleme
        public bool AddKullanici(Kullanici kullanici)
        {
            string query = @"INSERT INTO Kullanicilar 
                        (Adi, Soyadi, KullaniciAdi, Sifre, Yetki, OlusturmaTarihi, KullaniciTelNo) 
                        VALUES (@Adi, @Soyadi, @KullaniciAdi, @Sifre, @Yetki, @OlusturmaTarihi, @KullaniciTelNo)";
            SqlParameter[] parameters = {
            new SqlParameter("@Adi", kullanici.Ad),
            new SqlParameter("@Soyadi", kullanici.Soyad),
            new SqlParameter("@KullaniciAdi", kullanici.KullaniciAdi),
            new SqlParameter("@Sifre", kullanici.Sifre),
            new SqlParameter("@Yetki", kullanici.Yetki),
            new SqlParameter("@KullaniciTelNo", kullanici.KullaniciTelNo),
            new SqlParameter("@OlusturmaTarihi", DateTime.Now)
        };
            return _dbHelper.ExecuteNonQuery(query, parameters) > 0;
        }


        public bool UpdateKullanici(Kullanici kullanici)
        {
            string query = @"UPDATE Kullanicilar 
                         SET Adi = @Adi, Soyadi = @Soyadi, KullaniciAdi = @KullaniciAdi, 
                             Sifre = @Sifre, Yetki = @Yetki, KullaniciTelNo = @KullaniciTelNo
                         WHERE KullaniciID = @KullaniciID";
            SqlParameter[] parameters = {
            new SqlParameter("@KullaniciID", kullanici.KullaniciID),
            new SqlParameter("@Adi", kullanici.Ad),
            new SqlParameter("@Soyadi", kullanici.Soyad),
            new SqlParameter("@KullaniciAdi", kullanici.KullaniciAdi),
            new SqlParameter("@Sifre", kullanici.Sifre),
            new SqlParameter("@Yetki", kullanici.Yetki),
            new SqlParameter("@KullaniciTelNo", kullanici.KullaniciTelNo),
        };
            return _dbHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool UpdateKullaniciDurum(int kullaniciID)
        {
            string query = "UPDATE Kullanicilar SET Durum = 1 WHERE KullaniciID = @KullaniciID"; 
            SqlParameter[] parameters = {
        new SqlParameter("@KullaniciID", kullaniciID)
    };

            return _dbHelper.ExecuteNonQuery(query, parameters) > 0;
        }
        public bool DeleteKullaniciPasif(int kullaniciID)
            {
                string query = "UPDATE Kullanicilar SET Durum = 0 WHERE KullaniciID = @KullaniciID";
                SqlParameter[] parameters = { new SqlParameter("@KullaniciID", kullaniciID) };
                return _dbHelper.ExecuteNonQuery(query, parameters) > 0;
            }
        
    }
}


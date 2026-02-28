using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace MarketStokUygulamsı_
{
    public class TedarikciRepository

    {
        private readonly DatabaseHelper _dbHelper;
        public TedarikciRepository()
        {
            _dbHelper = new DatabaseHelper();
        }


        public List<Tedarikci> GetTedarikciler(string arama = "", bool? aktifDurum = null)
        {
            string query = "SELECT TedarikciID, TedarikciAdi, TedarikciSoyadi, FirmaAdi, TelNo, Adres, Durum FROM Tedarikciler";

            if (!string.IsNullOrEmpty(arama))
            {
                query += " WHERE (TedarikciAdi LIKE @arama OR FirmaAdi LIKE @arama)";
            }

            if (aktifDurum.HasValue)
            {
                if (query.Contains("WHERE"))
                {
                    query += " AND Durum = @durum";
                }
                else
                {
                    query += " WHERE Durum = @durum";
                }
            }

            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@arama", "%" + arama + "%"),
        new SqlParameter("@durum", aktifDurum.HasValue ? (object)aktifDurum.Value : DBNull.Value)
            };

            DataTable dt = _dbHelper.ExecuteQuery(query, parameters);

            List<Tedarikci> tedarikciler = new List<Tedarikci>();
            foreach (DataRow row in dt.Rows)
            {
                tedarikciler.Add(new Tedarikci
                {
                    TedarikciID = Convert.ToInt32(row["TedarikciID"]),
                    TedarikciAdi = row["TedarikciAdi"].ToString(),
                    TedarikciSoyadi = row["TedarikciSoyadi"].ToString(),
                    FirmaAdi = row["FirmaAdi"].ToString(),
                    Telefon = row["TelNo"].ToString(),
                    Adres = row["Adres"].ToString(),
                    Durum = Convert.ToBoolean(row["Durum"])
                });
            }

            return tedarikciler;
        }


        public bool AddTedarikci(Tedarikci tedarikci)
        {
            string query = "INSERT INTO Tedarikciler (TedarikciAdi,TedarikciSoyadi, FirmaAdi, TelNo, Adres) VALUES (@TedarikciAdi,@TedarikciSoyadi, @FirmaAdi, @Telefon, @Adres)";
            SqlParameter[] parameters = {
                new SqlParameter("@TedarikciAdi", tedarikci.TedarikciAdi),
                new SqlParameter("@TedarikciSoyadi", tedarikci.TedarikciSoyadi),
                new SqlParameter("@FirmaAdi", tedarikci.FirmaAdi),
                new SqlParameter("@Telefon", tedarikci.Telefon),
                new SqlParameter("@Adres", tedarikci.Adres)
            };
            return _dbHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        // Mevcut tedarikçiyi günceller
        public bool UpdateTedarikci(Tedarikci tedarikci)
        {
            string query = "UPDATE Tedarikciler SET TedarikciAdi = @TedarikciAdi,TedarikciSoyadi = @TedarikciSoyadi, FirmaAdi = @FirmaAdi, TelNo = @Telefon, Adres = @Adres WHERE TedarikciID = @TedarikciID";
            SqlParameter[] parameters = {
                new SqlParameter("@TedarikciID", tedarikci.TedarikciID),
                new SqlParameter("@TedarikciAdi", tedarikci.TedarikciAdi),
                new SqlParameter("@TedarikciSoyadi", tedarikci.TedarikciSoyadi),
                new SqlParameter("@FirmaAdi", tedarikci.FirmaAdi),
                new SqlParameter("@Telefon", tedarikci.Telefon),
                new SqlParameter("@Adres", tedarikci.Adres)
            };
            return _dbHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        // Belirtilen ID'ye sahip tedarikçiyi siler(yani pasif hale getirir)
        public bool DeleteTedarikci(int tedarikciID)
        {
            string query = "UPDATE Tedarikciler SET Durum = 0 WHERE TedarikciID = @TedarikciID";
            SqlParameter[] parameters = {
        new SqlParameter("@TedarikciID", tedarikciID)
    };
            return _dbHelper.ExecuteNonQuery(query, parameters) > 0;

        }

        public bool UpdateDurumAktif(int tedarikciID)
        {
            string query = "UPDATE Tedarikciler SET Durum = 1 WHERE TedarikciID = @TedarikciID";
            SqlParameter[] parameters = {
        new SqlParameter("@TedarikciID", tedarikciID)
    };
            return _dbHelper.ExecuteNonQuery(query, parameters) > 0;
        }

    }
}

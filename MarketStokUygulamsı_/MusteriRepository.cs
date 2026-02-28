using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace MarketStokUygulamsı_
{
    public class MusteriRepository
    {
        private readonly DatabaseHelper _dbHelper = new DatabaseHelper();

        public List<Musteri> GetMusteriler(string arama = "", bool? aktifDurum = null)
        {
            string query = "SELECT MusteriID, MusteriAd, MusteriSoyad, M_Tel_No, Durum FROM Musteriler";

            if (!string.IsNullOrEmpty(arama))
            {
                query += " WHERE (MusteriAd LIKE @arama OR MusteriSoyad LIKE @arama)";
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

            List<Musteri> musteriler = new List<Musteri>();
            foreach (DataRow row in dt.Rows)
            {
                musteriler.Add(new Musteri
                {
                    MusteriID = Convert.ToInt32(row["MusteriID"]),
                    MusteriAd = row["MusteriAd"].ToString(),
                    MusteriSoyad = row["MusteriSoyad"].ToString(),
                    M_Tel_No = row["M_Tel_No"].ToString(),
                    Durum = Convert.ToBoolean(row["Durum"])
                });
            }
            return musteriler;
        }


        public bool AddMusteri(Musteri musteri)
        {
            string query = "INSERT INTO Musteriler (MusteriAd, MusteriSoyad, M_Tel_No) VALUES (@MusteriAd, @MusteriSoyad, @Telefon)";
            SqlParameter[] parameters = {
            new SqlParameter("@MusteriAd", musteri.MusteriAd),
            new SqlParameter("@MusteriSoyad", musteri.MusteriSoyad),
            new SqlParameter("@Telefon", musteri.M_Tel_No)
        };

            return _dbHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool UpdateMusteriDurum(int musteriID, bool durum)
        {
            string query = "UPDATE Musteriler SET Durum = 1 WHERE MusteriID=@MusteriID";
            SqlParameter[] parameters = {
        new SqlParameter("@MusteriID", musteriID)
    };

            return _dbHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool UpdateMusteri(Musteri musteri)
        {
            string query = "UPDATE Musteriler SET MusteriAd = @MusteriAd, MusteriSoyad = @MusteriSoyad, M_Tel_No = @Telefon WHERE MusteriID = @MusteriID";
            SqlParameter[] parameters = {
            new SqlParameter("@MusteriID", musteri.MusteriID),
            new SqlParameter("@MusteriAd", musteri.MusteriAd),
            new SqlParameter("@MusteriSoyad", musteri.MusteriSoyad),
            new SqlParameter("@Telefon", musteri.M_Tel_No)
        };

            return _dbHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool DeleteMusteri(int musteriID)
        {
            string query = "UPDATE Musteriler SET Durum = 0 WHERE MusteriID = @MusteriID";
            SqlParameter[] parameters = {
        new SqlParameter("@MusteriID", musteriID)
    };

            return _dbHelper.ExecuteNonQuery(query, parameters) > 0;
        }


        public List<Musteri> GetAktifMusteriler(string arama = "")
        {
            string query = string.IsNullOrEmpty(arama)
                ? "SELECT MusteriID, MusteriAd, MusteriSoyad, M_Tel_No FROM Musteriler WHERE Durum = 1"
                : "SELECT MusteriID, MusteriAd, MusteriSoyad, M_Tel_No FROM Musteriler WHERE (MusteriAd LIKE @arama OR MusteriSoyad LIKE @arama) AND Durum = 1";

            SqlParameter[] parameters = string.IsNullOrEmpty(arama)
                ? Array.Empty<SqlParameter>()
                : new SqlParameter[] { new SqlParameter("@arama", "%" + arama + "%") };

            DataTable dt = _dbHelper.ExecuteQuery(query, parameters);

            List<Musteri> musteriler = new List<Musteri>();
            foreach (DataRow row in dt.Rows)
            {
                musteriler.Add(new Musteri
                {
                    MusteriID = Convert.ToInt32(row["MusteriID"]),
                    MusteriAd = row["MusteriAd"].ToString(),
                    MusteriSoyad = row["MusteriSoyad"].ToString(),
                    M_Tel_No = row["M_Tel_No"].ToString()
                });
            }
            return musteriler;
        }


    }
}


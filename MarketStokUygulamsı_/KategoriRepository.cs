using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace MarketStokUygulamsı_
{
    public class KategoriRepository
    {
        private readonly DatabaseHelper _dbHelper;
        public KategoriRepository()
        {
            _dbHelper = new DatabaseHelper();
        }

        public List<Kategori> GetKategoriler(string arama = "", bool? durum = null)
        {
            string query = "SELECT KategoriID, KategoriAdi, Aciklama, Durum FROM Kategoriler WHERE 1=1";

            List<SqlParameter> parameters = new List<SqlParameter>();

            if (!string.IsNullOrEmpty(arama))
            {
                query += " AND KategoriAdi LIKE @arama";
                parameters.Add(new SqlParameter("@arama", "%" + arama + "%"));
            }

            // Durum filtresi ekle
            if (durum.HasValue)
            {
                query += " AND Durum = @durum";
                parameters.Add(new SqlParameter("@durum", durum.Value));
            }

            DataTable dt = _dbHelper.ExecuteQuery(query, parameters.ToArray());

            List<Kategori> kategoriler = new List<Kategori>();
            foreach (DataRow row in dt.Rows)
            {
                kategoriler.Add(new Kategori
                {
                    KategoriID = Convert.ToInt32(row["KategoriID"]),
                    KategoriAdi = row["KategoriAdi"].ToString(),
                    Aciklama = row["Aciklama"]?.ToString(),
                    Durum = Convert.ToBoolean(row["Durum"])
                });
            }
            return kategoriler;
        }

        public bool AddKategori(Kategori kategori)
        {
            string query = "INSERT INTO Kategoriler (KategoriAdi, Aciklama) VALUES (@KategoriAdi, @Aciklama)";
            SqlParameter[] parameters = {
                new SqlParameter("@KategoriAdi", kategori.KategoriAdi),
                new SqlParameter("@Aciklama", kategori.Aciklama)
            };
            return _dbHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool UpdateKategori(Kategori kategori)
        {
            string query = "UPDATE Kategoriler SET KategoriAdi = @KategoriAdi, Aciklama = @Aciklama WHERE KategoriID = @KategoriID";
            SqlParameter[] parameters = {
                new SqlParameter("@KategoriID", kategori.KategoriID),
                new SqlParameter("@KategoriAdi", kategori.KategoriAdi),
                new SqlParameter("@Aciklama", kategori.Aciklama)
            };
            return _dbHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool DeleteKategoriPasif(int kategoriID)
        {
            string query = "UPDATE Kategoriler SET Durum = 0 WHERE KategoriID = @KategoriID";
            SqlParameter[] parameters = { new SqlParameter("@KategoriID", kategoriID) };
            return _dbHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool UpdateKategoriDurum(int kategoriID)
        {
            string query = "UPDATE Kategoriler SET Durum = 1 WHERE KategoriID = @KategoriID";
            SqlParameter[] parameters = {
        new SqlParameter("@KategoriID", kategoriID)
    };

            return _dbHelper.ExecuteNonQuery(query, parameters) > 0;
        }
      
    }

}

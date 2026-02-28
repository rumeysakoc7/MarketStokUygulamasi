using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace MarketStokUygulamsı_
{
    public class UrunRepository
    {
        private readonly DatabaseHelper _dbHelper = new DatabaseHelper();

        public List<Urun> GetUrunler(string arama = "", bool? durum = null)
        {
            string query = string.IsNullOrEmpty(arama)
                ? "SELECT u.UrunID, u.UrunAdi, u.StokMiktari, u.Fiyat, u.Urun_resim, u.KategoriID, u.Alis_Fiyat, k.KategoriAdi, t.TedarikciID, t.FirmaAdi, u.Durum " +
                  "FROM Urunler u " +
                  "INNER JOIN Kategoriler k ON u.KategoriID = k.KategoriID " +
                  "INNER JOIN Tedarikciler t ON u.TedarikciID = t.TedarikciID"
                : "SELECT u.UrunID, u.UrunAdi, u.StokMiktari, u.Fiyat, u.Urun_resim, u.KategoriID, u.Alis_Fiyat, k.KategoriAdi, t.TedarikciID, t.FirmaAdi, u.Durum " +
                  "FROM Urunler u " +
                  "INNER JOIN Kategoriler k ON u.KategoriID = k.KategoriID " +
                  "INNER JOIN Tedarikciler t ON u.TedarikciID = t.TedarikciID " +
                  "WHERE u.UrunAdi LIKE @arama";

            if (durum.HasValue)
            {
                if (query.Contains("WHERE"))
                {
                    query += " AND u.Durum = @durum";
                }
                else
                {
                    query += " WHERE u.Durum = @durum";
                }
            }

            List<SqlParameter> parameters = new List<SqlParameter>
    {
        new SqlParameter("@arama", "%" + arama + "%")
    };

            if (durum.HasValue)
            {
                parameters.Add(new SqlParameter("@durum", durum.Value));
            }

            DataTable dt = _dbHelper.ExecuteQuery(query, parameters.ToArray());

            List<Urun> urunler = new List<Urun>();
            foreach (DataRow row in dt.Rows)
            {
                urunler.Add(new Urun
                {
                    UrunID = Convert.ToInt32(row["UrunID"]),
                    UrunAdi = row["UrunAdi"].ToString(),
                    KategoriID = Convert.ToInt32(row["KategoriID"]),
                    StokMiktari = Convert.ToInt32(row["StokMiktari"]),
                    Fiyat = Convert.ToDecimal(row["Fiyat"]),
                    Alis_Fiyat = Convert.ToDecimal(row["Alis_Fiyat"]),
                    KategoriAdi = row["KategoriAdi"].ToString(),
                    TedarikciID = Convert.ToInt32(row["TedarikciID"]),
                    FirmaAdi = row["FirmaAdi"]?.ToString(),
                    Urun_resim = row["Urun_resim"].ToString(),
                    Durum = Convert.ToBoolean(row["Durum"])
                });
            }

            return urunler;
        }


        public bool AddUrun(Urun urun)
        {
            string query = "INSERT INTO Urunler (UrunAdi, KategoriID,TedarikciID, StokMiktari, Fiyat, Alis_Fiyat, Urun_resim)" +
                "VALUES (@UrunAdi, @KategoriID, @TedarikciID, @StokMiktari, @Fiyat, @Alis_Fiyat, @Urun_resim)";
            SqlParameter[] parameters = {
            new SqlParameter("@UrunAdi", urun.UrunAdi),
            new SqlParameter("@KategoriID", urun.KategoriID),
            new SqlParameter("@TedarikciID", urun.TedarikciID),
            new SqlParameter("@StokMiktari", urun.StokMiktari),
            new SqlParameter("@Fiyat", urun.Fiyat),
            new SqlParameter("@Alis_Fiyat", urun.Alis_Fiyat),
            new SqlParameter("@Urun_resim", urun.Urun_resim)
        };
            return _dbHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool UpdateUrun(Urun urun)
        {
            string query = "UPDATE Urunler SET UrunAdi = @UrunAdi, KategoriID = @KategoriID, TedarikciID = @TedarikciID, " +
                           "StokMiktari = @StokMiktari, Fiyat = @Fiyat, Alis_Fiyat = @Alis_Fiyat, Urun_resim = @Urun_resim WHERE UrunID = @UrunID";
            SqlParameter[] parameters = {
            new SqlParameter("@UrunID", urun.UrunID),
            new SqlParameter("@UrunAdi", urun.UrunAdi),
            new SqlParameter("@KategoriID", urun.KategoriID),
            new SqlParameter("@TedarikciID", urun.TedarikciID),
            new SqlParameter("@StokMiktari", urun.StokMiktari),
            new SqlParameter("@Fiyat", urun.Fiyat),
            new SqlParameter("@Alis_Fiyat", urun.Alis_Fiyat),
            new SqlParameter("@Urun_resim", urun.Urun_resim)
        };
            return _dbHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool UpdateUrunDurum(int urunId)
        {
            string query = "UPDATE Urunler SET Durum = 1 WHERE UrunID = @UrunID"; // Durumu aktif yap
            SqlParameter[] parameters = {
        new SqlParameter("@UrunID", urunId)
    };

            return _dbHelper.ExecuteNonQuery(query, parameters) > 0;
        }
        public bool SetUrunDurumPasif(int urunId)
        {
            string query = "UPDATE Urunler SET Durum = 0 WHERE UrunID = @UrunID"; // Durumu 0 (pasif) yap
            SqlParameter[] parameters = { new SqlParameter("@UrunID", urunId) };
            return _dbHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        
        public bool UpdateStokMiktariazalt(int urunID, int miktar)
        {
            string query = "UPDATE Urunler SET StokMiktari = StokMiktari - @Miktar " +
                           "WHERE UrunID = @UrunID AND StokMiktari >= @Miktar AND Durum = 1"; 
            SqlParameter[] parameters = {
                new SqlParameter("@UrunID", urunID),
                new SqlParameter("@Miktar", Math.Abs(miktar)) 
            };
            return _dbHelper.ExecuteNonQuery(query, parameters) > 0;
        }


        public bool UpdateStokMiktariarttir(int urunID, int miktar)
        {
            string query = "UPDATE Urunler SET StokMiktari = StokMiktari + @Miktar WHERE UrunID = @UrunID AND Durum = 1";
            SqlParameter[] parameters = {
        new SqlParameter("@UrunID", urunID),
        new SqlParameter("@Miktar", miktar)
    };
            return _dbHelper.ExecuteNonQuery(query, parameters) > 0;
        }


        public List<Urun> GetUrunlerForSatis(string arama = "")
        {
            string query = string.IsNullOrEmpty(arama)
                ? "SELECT u.UrunID, u.UrunAdi, k.KategoriAdi, u.Fiyat " +
                  "FROM Urunler u " +
                  "INNER JOIN Kategoriler k ON u.KategoriID = k.KategoriID " +
                  "WHERE u.Durum = 1" 
                : "SELECT u.UrunID, u.UrunAdi, k.KategoriAdi, u.Fiyat " +
                  "FROM Urunler u " +
                  "INNER JOIN Kategoriler k ON u.KategoriID = k.KategoriID " +
                  "WHERE u.UrunAdi LIKE @arama AND u.Durum = 1"; 

            SqlParameter[] parameters = string.IsNullOrEmpty(arama)
                ? Array.Empty<SqlParameter>()
                : new SqlParameter[] { new SqlParameter("@arama", "%" + arama + "%") };

            DataTable dt = _dbHelper.ExecuteQuery(query, parameters);

            List<Urun> urunler = new List<Urun>();
            foreach (DataRow row in dt.Rows)
            {
                urunler.Add(new Urun
                {
                    UrunID = Convert.ToInt32(row["UrunID"]),
                    UrunAdi = row["UrunAdi"].ToString(),
                    KategoriAdi = row["KategoriAdi"].ToString(),
                    Fiyat = Convert.ToDecimal(row["Fiyat"])
                });
            }
            return urunler;
        }
    
public List<Urun> GetUrunlerByKategori(int kategoriID)
        {
            string query = "SELECT u.UrunID, u.UrunAdi, k.KategoriAdi, u.Fiyat " +
                           "FROM Urunler u " +
                           "INNER JOIN Kategoriler k ON u.KategoriID = k.KategoriID " +
                           "WHERE u.KategoriID = @KategoriID";

            SqlParameter[] parameters = {
        new SqlParameter("@KategoriID", kategoriID)
    };

            DataTable dt = _dbHelper.ExecuteQuery(query, parameters);

            List<Urun> urunler = new List<Urun>();
            foreach (DataRow row in dt.Rows)
            {
                urunler.Add(new Urun
                {
                    UrunID = Convert.ToInt32(row["UrunID"]),
                    UrunAdi = row["UrunAdi"].ToString(),
                    KategoriAdi = row["KategoriAdi"].ToString(), 
                    Fiyat = Convert.ToDecimal(row["Fiyat"])
                    
                });
            }
            return urunler;
        }

        public int GetUrunID(string urunAdi)
        {
            string query = "SELECT UrunID FROM Urunler WHERE UrunAdi = @UrunAdi";

            SqlParameter[] parameters = {
            new SqlParameter("@UrunAdi", urunAdi)
        };

            DataTable dt = _dbHelper.ExecuteQuery(query, parameters);

            if (dt.Rows.Count > 0)
            {
                return Convert.ToInt32(dt.Rows[0]["UrunID"]);
            }

            return -1;
        }

        public List<Urun> GetUrunlerForAlis(string arama = "")
        {
            string query = string.IsNullOrEmpty(arama)
                ? @"SELECT  
            u.UrunID, 
            u.UrunAdi, 
            u.Fiyat, 
            u.Alis_Fiyat, 
            u.StokMiktari, 
            t.TedarikciID, 
            (t.TedarikciAdi + ' ' + t.TedarikciSoyadi) AS TedarikciAdSoyad, 
            t.FirmaAdi
        FROM Urunler u
        LEFT JOIN Tedarikciler t ON u.TedarikciID = t.TedarikciID
        WHERE u.Durum = 1 AND t.Durum = 1"
                : @"SELECT  
            u.UrunID, 
            u.UrunAdi, 
            u.Fiyat, 
            u.Alis_Fiyat, 
            u.StokMiktari, 
            t.TedarikciID, 
            (t.TedarikciAdi + ' ' + t.TedarikciSoyadi) AS TedarikciAdSoyad, 
            t.FirmaAdi
        FROM Urunler u
        LEFT JOIN Tedarikciler t ON u.TedarikciID = t.TedarikciID
        WHERE u.UrunAdi LIKE @arama AND u.Durum = 1 AND t.Durum = 1";

            SqlParameter[] parameters = string.IsNullOrEmpty(arama)
                ? Array.Empty<SqlParameter>()
                : new SqlParameter[] { new SqlParameter("@arama", "%" + arama + "%") };

            DataTable dt = _dbHelper.ExecuteQuery(query, parameters);

            List<Urun> urunler = new List<Urun>();
            foreach (DataRow row in dt.Rows)
            {
                urunler.Add(new Urun
                {
                    UrunID = Convert.ToInt32(row["UrunID"]),
                    UrunAdi = row["UrunAdi"].ToString(),
                    Fiyat = Convert.ToDecimal(row["Fiyat"]),
                    AlisFiyat = Convert.ToDecimal(row["Alis_Fiyat"]),
                    StokMiktari = Convert.ToInt32(row["StokMiktari"]),
                    TedarikciID = Convert.ToInt32(row["TedarikciID"]),
                    TedarikciAdSoyad = row["TedarikciAdSoyad"].ToString(),
                    FirmaAdi = row["FirmaAdi"].ToString()
                });
            }
            return urunler;
        }
        public bool SifirlaStokMiktari(int urunID)
        {
            string query = "UPDATE Urunler SET StokMiktari = 0 WHERE UrunID = @UrunID AND Durum = 1";
            SqlParameter[] parameters = {
        new SqlParameter("@UrunID", urunID)
    };
            return _dbHelper.ExecuteNonQuery(query, parameters) > 0;
        }


    }
}


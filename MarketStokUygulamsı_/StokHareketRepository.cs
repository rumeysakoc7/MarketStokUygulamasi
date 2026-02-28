using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace MarketStokUygulamsı_
{
    public class StokHareketRepository
    {
        private readonly DatabaseHelper _dbHelper;

        // Constructor
        public StokHareketRepository()
        {
            _dbHelper = new DatabaseHelper();
        }

        // Stok hareketini ekleyen metod
        public bool AddStokHareket(StokHareket hareket)
        {
            string query = "INSERT INTO StokHareketleri (UrunID, IslemTuru, Miktar, IslemTarihi, Kullanici_ID, ToplamTutar) " +
                           "VALUES (@UrunID, @IslemTuru, @Miktar, @IslemTarihi, @Kullanici_ID, @ToplamTutar)";

            SqlParameter[] parameters = {
            new SqlParameter("@UrunID", hareket.UrunID),
            new SqlParameter("@IslemTuru", hareket.IslemTuru),
            new SqlParameter("@Miktar", hareket.Miktar),
            new SqlParameter("@IslemTarihi", hareket.IslemTarihi),
            new SqlParameter("@Kullanici_ID", hareket.Kullanici_ID),
            new SqlParameter("@ToplamTutar", hareket.ToplamTutar)
        };

            return _dbHelper.ExecuteNonQuery(query, parameters) > 0;
        }


        public List<StokHareket> GetFilteredStokHareketleri(string urunAdi = null, string islemTuru = null, string kullaniciAdi = null, DateTime? tarih = null)

        {

            string query = @"
        SELECT 
            h.IslemID,
            h.UrunID,
            u.UrunAdi,
            h.IslemTuru,
            h.Miktar,
            h.IslemTarihi,
            h.Kullanici_ID AS KullaniciID,
            k.KullaniciAdi,
            h.ToplamTutar
        FROM StokHareketleri h
        LEFT JOIN Urunler u ON h.UrunID = u.UrunID
        LEFT JOIN Kullanicilar k ON h.Kullanici_ID = k.KullaniciID
        WHERE 1 = 1";

                List<SqlParameter> parameters = new List<SqlParameter>();

                if (!string.IsNullOrEmpty(urunAdi))
                {
                    query += " AND u.UrunAdi LIKE @UrunAdi";
                    parameters.Add(new SqlParameter("@UrunAdi", "%" + urunAdi + "%"));
                }

                if (!string.IsNullOrEmpty(islemTuru))
                {
                    query += " AND h.IslemTuru = @IslemTuru";
                    parameters.Add(new SqlParameter("@IslemTuru", islemTuru));
                }

                if (!string.IsNullOrEmpty(kullaniciAdi))
                {
                    query += " AND k.KullaniciAdi LIKE @KullaniciAdi";
                    parameters.Add(new SqlParameter("@KullaniciAdi", "%" + kullaniciAdi + "%"));
                }

                if (tarih.HasValue)
                {
                    query += " AND CAST(h.IslemTarihi AS DATE) = @Tarih";
                    parameters.Add(new SqlParameter("@Tarih", tarih.Value.Date));
                }

                DataTable dt = _dbHelper.ExecuteQuery(query, parameters.ToArray());
                List<StokHareket> hareketler = new List<StokHareket>();

                foreach (DataRow row in dt.Rows)
                {
                    hareketler.Add(new StokHareket
                    {
                        IslemID = Convert.ToInt32(row["IslemID"]),
                        UrunID = Convert.ToInt32(row["UrunID"]),
                        UrunAdi = row["UrunAdi"].ToString(),
                        IslemTuru = row["IslemTuru"].ToString(),
                        Miktar = Convert.ToInt32(row["Miktar"]),
                        IslemTarihi = Convert.ToDateTime(row["IslemTarihi"]),
                        Kullanici_ID = Convert.ToInt32(row["KullaniciID"]),
                        KullaniciAdi = row["KullaniciAdi"].ToString(),
                        ToplamTutar = Convert.ToDecimal(row["ToplamTutar"])
                    });
                }

                return hareketler;
            }


        }
    }

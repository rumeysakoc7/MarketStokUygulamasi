using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MarketStokUygulamsı_
{
    public class SatisRepository
    {
        private readonly DatabaseHelper _dbHelper = new DatabaseHelper();

        public bool AddSatis(Satis satis)
        {
            string query = "INSERT INTO Satislar (UrunID, Miktar, BirimFiyat, ToplamFiyat, Musteri_Id, SatisTarihi, Kullanici_ID) " +
                           "VALUES (@UrunID, @Miktar, @BirimFiyat, @ToplamFiyat, @Musteri_Id, @SatisTarihi, @Kullanici_ID)";
            SqlParameter[] parameters = {
                new SqlParameter("@UrunID", satis.UrunID),
                new SqlParameter("@Miktar", satis.Miktar),
                new SqlParameter("@BirimFiyat", satis.BirimFiyat),
                new SqlParameter("@ToplamFiyat", satis.ToplamFiyat),
                new SqlParameter("@Musteri_Id", satis.Musteri_Id),
                new SqlParameter("@SatisTarihi", satis.SatisTarihi),
                  new SqlParameter("@Kullanici_ID", satis.Kullanici_ID)
            };

            return _dbHelper.ExecuteNonQuery(query, parameters) > 0;
        }


        public string GetResimYoluFromDatabase(int urunID)
        {
            try
            {
                string query = "SELECT Urun_Resim FROM URUNLER WHERE UrunID = @UrunID";

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@UrunID", urunID)
                };

                DataTable result = _dbHelper.ExecuteQuery(query, parameters);

                if (result.Rows.Count > 0)
                {
                    string resimYolu = result.Rows[0]["Urun_Resim"].ToString()?.Replace("\"", "").Trim() ?? string.Empty;

                    if (!string.IsNullOrWhiteSpace(resimYolu))
                    {
                        if (File.Exists(resimYolu))
                        {
                            return resimYolu;
                        }
                        else
                        {
                            MessageBox.Show($"Resim dosyası bulunamadı: {resimYolu}",
                                             "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return string.Empty;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Veritabanında resim bilgisi bulunamadı.",
                                         "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return string.Empty;
                    }
                }
                else
                {
                    MessageBox.Show("Veritabanında belirtilen ürün bulunamadı.",
                                     "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }

        }

        private List<Satis> MapSatisList(string query, SqlParameter[] parameters)
        {
            DataTable dt = _dbHelper.ExecuteQuery(query, parameters);
            List<Satis> satislar = new List<Satis>();

            foreach (DataRow row in dt.Rows)
            {
                satislar.Add(new Satis
                {
                    SatisID = row["SatisID"] != DBNull.Value ? Convert.ToInt32(row["SatisID"]) : 0,
                    UrunID = row["UrunID"] != DBNull.Value ? Convert.ToInt32(row["UrunID"]) : 0,
                    UrunAdi = row["UrunAdi"] != DBNull.Value ? row["UrunAdi"].ToString() : string.Empty, 
                    Miktar = row["Miktar"] != DBNull.Value ? Convert.ToInt32(row["Miktar"]) : 0,
                    BirimFiyat = row["BirimFiyat"] != DBNull.Value ? Convert.ToDecimal(row["BirimFiyat"]) : 0,
                    ToplamFiyat = row["ToplamFiyat"] != DBNull.Value ? Convert.ToDecimal(row["ToplamFiyat"]) : 0,
                    Musteri_Id = row["Musteri_Id"] != DBNull.Value ? Convert.ToInt32(row["Musteri_Id"]) : 0,
                    MusteriAdi = row["MusteriAdi"] != DBNull.Value ? row["MusteriAdi"].ToString() : string.Empty, 
                    SatisTarihi = row["SatisTarihi"] != DBNull.Value ? Convert.ToDateTime(row["SatisTarihi"]) : DateTime.MinValue,
                    Kullanici_ID = row["Kullanici_ID"] != DBNull.Value ? Convert.ToInt32(row["Kullanici_ID"]) : 0,
                });
            }

            return satislar;
        }

        public List<Satis> GetSatislarFiltreli(string musteriAdi, string urunAdi, DateTime? secilenTarih)
        {
            try
            {
                StringBuilder query = new StringBuilder(@"
        SELECT 
            s.SatisID,
            s.UrunID,
            u.UrunAdi,
            s.Miktar,
            s.BirimFiyat,
            s.ToplamFiyat,
            s.SatisTarihi,
            s.Kullanici_ID,
            s.Musteri_Id,
            m.MusteriAd + ' ' + m.MusteriSoyad AS MusteriAdi
        FROM Satislar s
        INNER JOIN Urunler u ON s.UrunID = u.UrunID
        INNER JOIN Musteriler m ON s.Musteri_Id = m.MusteriID
        WHERE 1=1"); 
                List<SqlParameter> parameters = new List<SqlParameter>();

                if (!string.IsNullOrWhiteSpace(musteriAdi))
                {
                    query.Append(" AND (m.MusteriAd LIKE @MusteriAdi OR m.MusteriSoyad LIKE @MusteriAdi)");
                    parameters.Add(new SqlParameter("@MusteriAdi", $"%{musteriAdi}%"));
                }

                if (!string.IsNullOrWhiteSpace(urunAdi))
                {
                    query.Append(" AND u.UrunAdi LIKE @UrunAdi");
                    parameters.Add(new SqlParameter("@UrunAdi", $"%{urunAdi}%"));
                }

                if (secilenTarih.HasValue)
                {
                    query.Append(" AND CAST(s.SatisTarihi AS DATE) = @SecilenTarih");
                    parameters.Add(new SqlParameter("@SecilenTarih", secilenTarih.Value.Date));
                }
                return MapSatisList(query.ToString(), parameters.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veri çekme hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Satis>(); 
            }
        }



    }
}

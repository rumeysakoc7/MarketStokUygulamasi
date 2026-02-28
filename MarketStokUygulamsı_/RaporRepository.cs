using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace MarketStokUygulamsı_
{

    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Microsoft.Data.SqlClient;

    namespace MarketStokUygulamasi
    {

        public class RaporRepository
        {
            private readonly DatabaseHelper _dbHelper;

            public RaporRepository()
            {
                _dbHelper = new DatabaseHelper();
            }

            public bool HesaplaVeKaydetRapor(DateTime baslangicTarihi, DateTime bitisTarihi)
            {
                string query = @"
                INSERT INTO RAPOR (Toplam_Satis, Toplam_Maliyet, Kar_Orani, Satilan_Toplam_Urun, En_Cok_Satan_UrunID)
                SELECT 
                    SUM(S.BirimFiyat * S.Miktar) AS Toplam_Satis,
                    SUM(U.AlisFiyat * S.Miktar) AS Toplam_Maliyet,
                    (SUM(S.BirimFiyat * S.Miktar) - SUM(U.AlisFiyat * S.Miktar)) * 100 / NULLIF(SUM(S.BirimFiyat * S.Miktar), 0) AS Kar_Orani,
                    SUM(S.Miktar) AS Satilan_Toplam_Urun,
                    (SELECT TOP 1 S.UrunID
                     FROM Satislar S
                     WHERE S.SatisTarihi BETWEEN @BaslangicTarihi AND @BitisTarihi
                     GROUP BY S.UrunID
                     ORDER BY SUM(S.Miktar) DESC) AS En_Cok_Satan_UrunID
                FROM Satislar S
                JOIN URUNLER U ON S.UrunID = U.UrunID
                WHERE S.SatisTarihi BETWEEN @BaslangicTarihi AND @BitisTarihi";

                var parameters = new[]
                {
                new SqlParameter("@BaslangicTarihi", baslangicTarihi),
                new SqlParameter("@BitisTarihi", bitisTarihi)
            };

                try
                {
                    int rowsAffected = _dbHelper.ExecuteNonQuery(query, parameters);
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception("Rapor oluşturulurken bir hata oluştu: " + ex.Message);
                }
            }

            public List<Rapor> RaporlariGetir()
            {
                string query = "SELECT * FROM RAPOR";

                try
                {
                    DataTable dt = _dbHelper.ExecuteQuery(query);
                    var raporlar = new List<Rapor>();

                    foreach (DataRow row in dt.Rows)
                    {
                        raporlar.Add(new Rapor
                        {
                            RaporID = Convert.ToInt32(row["RaporID"]),
                            RaporTarihi = Convert.ToDateTime(row["Rapor_Tarihi"]),
                            Toplam_Satis = row["Toplam_Satis"] != DBNull.Value ? Convert.ToDecimal(row["Toplam_Satis"]) : 0,
                            Toplam_Maliyet = row["Toplam_Maliyet"] != DBNull.Value ? Convert.ToDecimal(row["Toplam_Maliyet"]) : 0,
                            Kar_Orani = row["Kar_Orani"] != DBNull.Value ? Convert.ToDecimal(row["Kar_Orani"]) : 0,
                            Satilan_Toplam_Urun = row["Satilan_Toplam_Urun"] != DBNull.Value ? Convert.ToInt32(row["Satilan_Toplam_Urun"]) : 0,
                            En_Cok_Satan_UrunID = row["En_Cok_Satan_UrunID"] != DBNull.Value ? Convert.ToInt32(row["En_Cok_Satan_UrunID"]) : 0
                        });
                    }

                    return raporlar;
                }
                catch (Exception ex)
                {
                    throw new Exception("Raporları getirirken bir hata oluştu: " + ex.Message);
                }
            }
        }
    }
}

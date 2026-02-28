using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace MarketStokUygulamsı_
{
   public class AlisRepository
    {
        private readonly DatabaseHelper _dbHelper = new DatabaseHelper();

        public bool AddAlis(Alis alis)
        {
            string query = "INSERT INTO Alislar (UrunID, Miktar, AlisFiyat, ToplamMaliyet, TedarikciId, AlisTarihi, KullaniciId) " +
                           "VALUES (@UrunID, @Miktar, @AlisFiyat, @ToplamMaliyet, @TedarikciId, @AlisTarihi, @KullaniciId)";
            SqlParameter[] parameters = {
                new SqlParameter("@UrunID", alis.UrunID),
                new SqlParameter("@Miktar", alis.Miktar),
                new SqlParameter("@AlisFiyat", alis.AlisFiyat),
                new SqlParameter("@ToplamMaliyet", alis.ToplamMaliyet),
                new SqlParameter("@TedarikciId", alis.TedarikciId),
                new SqlParameter("@AlisTarihi", alis.AlisTarihi),
                  new SqlParameter("@KullaniciId", alis.KullaniciId)
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

        private List<Alis> MapAlisList(string query, SqlParameter[] parameters)
        {
            DataTable dt = _dbHelper.ExecuteQuery(query, parameters);
            List<Alis> alislar = new List<Alis>();

            foreach (DataRow row in dt.Rows)
            {
                alislar.Add(new Alis
                {
                    AlisID = row["AlisID"] != DBNull.Value ? Convert.ToInt32(row["AlisID"]) : 0,
                    UrunID = row["UrunID"] != DBNull.Value ? Convert.ToInt32(row["UrunID"]) : 0,
                    UrunAdi = row["UrunAdi"] != DBNull.Value ? row["UrunAdi"].ToString() : string.Empty,
                    Miktar = row["Miktar"] != DBNull.Value ? Convert.ToInt32(row["Miktar"]) : 0,
                    AlisFiyat = row["AlisFiyat"] != DBNull.Value ? Convert.ToDecimal(row["AlisFiyat"]) : 0,
                    ToplamMaliyet = row["ToplamMaliyet"] != DBNull.Value ? Convert.ToDecimal(row["ToplamMaliyet"]) : 0,
                    TedarikciId = row["TedarikciId"] != DBNull.Value ? Convert.ToInt32(row["TedraikciId"]) : 0,
                    TedarikciAdi = row["TedarikciAdi"] != DBNull.Value ? row["TedarikciAdi"].ToString() : string.Empty,
                    AlisTarihi = row["AlisTarihi"] != DBNull.Value ? Convert.ToDateTime(row["AlisTarihi"]) : DateTime.MinValue,
                    KullaniciId = row["KullaniciId"] != DBNull.Value ? Convert.ToInt32(row["KullaniciId"]) : 0,
                    FirmaAdi = row["FirmaAdi"] != DBNull.Value ? row["FirmaAdi"].ToString() : string.Empty,
                });
            }

            return alislar;
        }

        public List<Alis> GetAlislarFiltreli(string tedarikciAdi, string urunAdi, DateTime? secilenTarih)
        {
            StringBuilder query = new StringBuilder(@"
        SELECT 
            a.AlisID,
            a.UrunID,
            u.UrunAdi,
            a.Miktar,
            a.AlisFiyat,
            a.ToplamMaliyet,
            a.AlisTarihi,
            a.KullaniciId,
            a.TedarikciId,
            t.TedarikciAdi
        FROM Alislar a
        INNER JOIN Urunler u ON a.UrunID = u.UrunID
        INNER JOIN Tedarikciler t ON a.TedarikciId = t.TedarikciID
        WHERE 1=1");

            List<SqlParameter> parameters = new List<SqlParameter>();

            if (!string.IsNullOrWhiteSpace(tedarikciAdi))
            {
                query.Append(" AND t.TedarikciAdi LIKE @TedarikciAdi");
                parameters.Add(new SqlParameter("@TedarikciAdi", $"%{tedarikciAdi}%"));
            }

            if (!string.IsNullOrWhiteSpace(urunAdi))
            {
                query.Append(" AND u.UrunAdi LIKE @UrunAdi");
                parameters.Add(new SqlParameter("@UrunAdi", $"%{urunAdi}%"));
            }

            if (secilenTarih.HasValue)
            {
                query.Append(" AND CAST(a.AlisTarihi AS DATE) = @SecilenTarih");
                parameters.Add(new SqlParameter("@SecilenTarih", secilenTarih.Value.Date));
            }

            return MapAlisList(query.ToString(), parameters.ToArray());
        }

        public void AddColumnToGrid(DataGridView dataGridView, string dataPropertyName, string headerText)
        {
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = dataPropertyName,
                HeaderText = headerText,
                Name = dataPropertyName
            });
        }
    }
}

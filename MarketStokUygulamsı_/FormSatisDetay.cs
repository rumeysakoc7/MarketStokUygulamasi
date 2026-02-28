using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketStokUygulamsı_
{
    public partial class FormSatisDetay : Form
    {
        private SatisRepository _satisRepository = new SatisRepository();

        public FormSatisDetay()
        {
            InitializeComponent();
        }

        private void VeriyiYukle()
        {
            try
            {
                // Parametreler boş bırakılacak, yani tüm satışlar yüklenecek
                string musteriAdi = string.Empty;
                string urunAdi = string.Empty;
                DateTime? secilenTarih = null;

                // Tüm satışları alıyoruz
                var satislar = _satisRepository.GetSatislarFiltreli(musteriAdi, urunAdi, secilenTarih);

                // Eğer veri yoksa, kullanıcıyı bilgilendiriyoruz
                if (satislar == null || satislar.Count == 0)
                {
                    MessageBox.Show("Veri bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Veriyi DataGridView'e yüklüyoruz
                dataGridViewsatisdetay.DataSource = satislar;
                dataGridViewsatisdetay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                // 'UrunAdi' kolonunun genişliğini ayarlıyoruz
                if (dataGridViewsatisdetay.Columns.Contains("UrunAdi"))
                {
                    dataGridViewsatisdetay.Columns["UrunAdi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                // Hata durumunda kullanıcıyı bilgilendiriyoruz
                MessageBox.Show($"Veri yüklenirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Filtrele()
        {
            try
            {
                // TextBox'lardan gelen değerleri al
                string musteriAdi = textBoxmusteriara.Text.Trim();
                string urunAdi = textBoxurunara.Text.Trim();
                DateTime? secilenTarih = dateTimePicker1.Value.Date;  // Tarih seçilirse

                // Eğer tarih kutusunda seçilen tarih bugünden önce değilse, tarih filtresi uygulanmasın
                if (secilenTarih == DateTime.MinValue)
                {
                    secilenTarih = null;
                }

                // Eğer hem müşteri adı hem de ürün adı boşsa, tüm satışları getir
                if (string.IsNullOrWhiteSpace(musteriAdi) && string.IsNullOrWhiteSpace(urunAdi) && secilenTarih == null)
                {
                    musteriAdi = string.Empty;
                    urunAdi = string.Empty;
                }

                // Filtreli satışları al
                var satislar = _satisRepository.GetSatislarFiltreli(musteriAdi, urunAdi, secilenTarih);

                // Veriyi DataGridView'e yüklüyoruz
                dataGridViewsatisdetay.DataSource = satislar;
                dataGridViewsatisdetay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                // 'UrunAdi' kolonunun genişliğini ayarlıyoruz
                if (dataGridViewsatisdetay.Columns.Contains("UrunAdi"))
                {
                    dataGridViewsatisdetay.Columns["UrunAdi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Filtreleme sırasında hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void FormSatisDetay_Load(object sender, EventArgs e)
        {
            VeriyiYukle();
        }

        private void textBoxmusteriara_TextChanged(object sender, EventArgs e)
        {
            Filtrele();
        }

        private void textBoxurunara_TextChanged(object sender, EventArgs e)
        {
            Filtrele();
        }

        private void dataGridViewsatisdetay_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewsatisdetay.Rows[e.RowIndex];

                int satisID = Convert.ToInt32(row.Cells["SatisID"].Value);
                string urunAdi = row.Cells["UrunAdi"].Value?.ToString() ?? "Ürün Adı Yok";
                string musteriAdi = row.Cells["MusteriAdi"].Value?.ToString() ?? "Müşteri Adı Yok";
                int miktar = Convert.ToInt32(row.Cells["Miktar"].Value);
                decimal birimFiyat = Convert.ToDecimal(row.Cells["BirimFiyat"].Value);
                decimal toplamFiyat = Convert.ToDecimal(row.Cells["ToplamFiyat"].Value);
                DateTime satisTarihi = Convert.ToDateTime(row.Cells["SatisTarihi"].Value);

                string mesaj = $@"
                           Satış Detayları:
                           ---------------------
                           Satış ID: {satisID}
                           Ürün Adı: {urunAdi}
                           Müşteri Adı: {musteriAdi}
                           Miktar: {miktar}
                           Birim Fiyat: {birimFiyat:C2}
                           Toplam Fiyat: {toplamFiyat:C2}
                           Satış Tarihi: {satisTarihi:dd/MM/yyyy}";

                MessageBox.Show(mesaj, "Satış Detayları", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Filtrele();
        }
    }
}

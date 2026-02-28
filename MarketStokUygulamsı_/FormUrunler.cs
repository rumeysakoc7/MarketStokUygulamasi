using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Data.SqlClient;
using System.Data.Sql;
using MarketStokUygulamsı_;


namespace MarketStokUygulamsı_
{
    public partial class FormUrunler : Form
    {


        private readonly UrunRepository _urunRepository = new UrunRepository();

        public FormUrunler()
        {
            InitializeComponent();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            string arama = textBoxaramacubugu.Text.Trim();

            if (string.IsNullOrEmpty(arama))
            {
               LoadUrunler("", true);
            }
            else
            {
                LoadUrunler(arama, null);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void FormUrunler_Load(object sender, EventArgs e)
        {
            dataGridViewUrunler.AllowUserToAddRows = false;
            checkBoxaktif.Checked = true;
            UrunleriFiltrele();
            LoadKategoriler();
            LoadTedarikciler();
            DusukStokUrunleriKontrolEt();
            

        }

        private void UrunleriFiltrele()
        {
            string arama = textBoxaramacubugu.Text.Trim();
            bool? durum = null;

            if (checkBoxaktif.Checked && !checkBoxpasif.Checked)
            {
                durum = true;
            }
            else if (!checkBoxaktif.Checked && checkBoxpasif.Checked)
            {
                durum = false;
            }

            LoadUrunler(arama, durum);
        }
        private void LoadUrunler(string arama = "", bool? durum = null)
        {
            try
            {
                dataGridViewUrunler.DataSource = _urunRepository.GetUrunler(arama, durum);
                ConfigureDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tedarikçiler yüklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigureDataGridView()
        {
            dataGridViewUrunler.Columns["TedarikciAdSoyad"].Visible = false;
            dataGridViewUrunler.Columns["AlisFiyat"].Visible = false;
            dataGridViewUrunler.Columns["UrunID"].Visible = false; // UrunID'yi gizle
            dataGridViewUrunler.Columns["KategoriID"].Visible = false; // KategoriID'yi gizle
            dataGridViewUrunler.Columns["Urun_resim"].HeaderText = "Resim Yolu";
            dataGridViewUrunler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


        }

        private void LoadKategoriler()
        {
            string query = "SELECT KategoriID, KategoriAdi FROM Kategoriler";
            DatabaseHelper dbHelper = new DatabaseHelper();
            DataTable dt = dbHelper.ExecuteQuery(query);
            comboBoxkategoriism.DataSource = dt;
            comboBoxkategoriism.DisplayMember = "KategoriAdi";
            comboBoxkategoriism.ValueMember = "KategoriID";
            comboBoxkategoriism.SelectedIndex = -1;
        }

        private void LoadTedarikciler()
        {
            string query = "SELECT TedarikciID, FirmaAdi FROM Tedarikciler";
            DatabaseHelper dbHelper = new DatabaseHelper();
            DataTable dt = dbHelper.ExecuteQuery(query);

            comboBoxfirmaisim.DataSource = dt;
            comboBoxfirmaisim.DisplayMember = "FirmaAdi";
            comboBoxfirmaisim.ValueMember = "TedarikciID";
            comboBoxfirmaisim.SelectedIndex = -1;

            AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();
            foreach (DataRow row in dt.Rows)
            {
                autoComplete.Add(row["FirmaAdi"].ToString());
            }
            comboBoxfirmaisim.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxfirmaisim.AutoCompleteSource = AutoCompleteSource.CustomSource;
            comboBoxfirmaisim.AutoCompleteCustomSource = autoComplete;
        }


        private void DusukStokUrunleriKontrolEt()
        {
            bool dusukStokVar = false; 

            foreach (DataGridViewRow satir in dataGridViewUrunler.Rows)
            {
                if (satir.Cells["StokMiktari"] != null &&
                    int.TryParse(satir.Cells["StokMiktari"].Value?.ToString(), out int stokMiktari))
                {
                    if (stokMiktari < 20) 
                    {
                        satir.DefaultCellStyle.BackColor = Color.Red; 
                        dusukStokVar = true; 
                    }
                }
            }

            if (dusukStokVar)
            {
                MessageBox.Show("Tedarik edilmesi gereken ürünler var.",
                                "Bilgilendirme",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }


        private void dataGridViewUrunler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
       
        private void buttonekle_Click(object sender, EventArgs e)
        {
            Urun urun = GetUrun();

            if (_urunRepository.AddUrun(urun))
            {
                MessageBox.Show("Ürün başarıyla eklendi!");
                LoadUrunler();
            }
            else
            {
                MessageBox.Show("Ürün eklenirken bir hata oluştu.");
            }
        }

        private Urun GetUrun()
        {
            return new Urun
            {
                UrunAdi = textBoxurunad.Text,
                KategoriID = Convert.ToInt32(comboBoxkategoriism.SelectedValue),
                TedarikciID = Convert.ToInt32(comboBoxfirmaisim.SelectedValue),
                StokMiktari = (int)numericUpDownstokmiktar.Value,
                Fiyat = Convert.ToDecimal(textBoxsatisfiyat.Text),
                Alis_Fiyat = Convert.ToDecimal(textBoxalisfiyat.Text),
                Urun_resim = textBoxresimyol.Text

            };

        }

        private void buttonguncelle_Click(object sender, EventArgs e)

        {
            if (dataGridViewUrunler.CurrentRow == null) return;

            if (string.IsNullOrEmpty(textBoxurunad.Text) || comboBoxkategoriism.SelectedIndex == -1 ||
            comboBoxfirmaisim.SelectedIndex == -1 || numericUpDownstokmiktar.Value == 0 ||
            string.IsNullOrEmpty(textBoxsatisfiyat.Text) || string.IsNullOrEmpty(textBoxalisfiyat.Text) || !decimal.TryParse(textBoxalisfiyat.Text, out decimal alisFiyat) || !decimal.TryParse(textBoxsatisfiyat.Text, out decimal fiyat))
            {
                MessageBox.Show("Lütfen tüm alanları doğru şekilde doldurduğunuzdan emin olun.", "Eksik Alan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Urun urun = new Urun
                {
                    UrunID = Convert.ToInt32(dataGridViewUrunler.CurrentRow.Cells["UrunID"].Value),
                    UrunAdi = textBoxurunad.Text,
                    KategoriID = Convert.ToInt32(comboBoxkategoriism.SelectedValue),
                    TedarikciID = Convert.ToInt32(comboBoxfirmaisim.SelectedValue),
                    StokMiktari = (int)numericUpDownstokmiktar.Value,
                    Fiyat = Convert.ToDecimal(textBoxsatisfiyat.Text),
                    Alis_Fiyat = Convert.ToDecimal(textBoxalisfiyat.Text),
                    Urun_resim = textBoxresimyol.Text
                };

                if (_urunRepository.UpdateUrun(urun))
                {
                    MessageBox.Show("Ürün başarıyla güncellendi!");
                    int urunId = urun.UrunID;
                    bool durumGuncellemeSonucu = _urunRepository.UpdateUrunDurum(urunId);
                    if (durumGuncellemeSonucu)
                    {
                        MessageBox.Show("Ürün durumu aktif hale getirildi.");
                    }
                    else
                    {
                        MessageBox.Show("Ürün durumu aktif hale getirilirken bir hata oluştu.");
                    }

                    LoadUrunler();
                }
                else
                {
                    MessageBox.Show("Ürün güncellenirken bir hata oluştu.");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonsil_Click(object sender, EventArgs e)

        {
            try
            {
                if (dataGridViewUrunler.CurrentRow == null)
                {
                    MessageBox.Show("Lütfen silmek istediğiniz ürünü seçin.");
                    return;
                }

                int urunId = Convert.ToInt32(dataGridViewUrunler.CurrentRow.Cells["UrunID"].Value);

                DialogResult dialogResult = MessageBox.Show(
                    "Bu ürünü silmek istiyorsunuz. Stok miktarı sıfırlanacak ve ürün pasif hale getirilecek. Emin misiniz?",
                    "Ürünü Sil",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (dialogResult == DialogResult.Yes)
                {
                    bool stokSifirlandi = _urunRepository.SifirlaStokMiktari(urunId);
                    bool urunPasifYapildi = _urunRepository.SetUrunDurumPasif(urunId);
                    if (stokSifirlandi && urunPasifYapildi)
                    {
                        MessageBox.Show("Ürün başarıyla silindi ve stok miktarı sıfırlandı!");
                        LoadUrunler(); 
                    }
                    else
                    {
                        MessageBox.Show("Ürün silinirken bir hata oluştu.");
                    }
                }
                else
                {
                    MessageBox.Show("Silme işlemi iptal edildi.");
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Veritabanı hatası: {sqlEx.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bilinmeyen bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttontemizle_Click(object sender, EventArgs e)
        {
            foreach (Control control in panelurungirisbilgi.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                else if (control is NumericUpDown)
                {
                    ((NumericUpDown)control).Value = ((NumericUpDown)control).Minimum;
                }
                else if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = -1;
                }

            }
            pictureBoxurunresim.Image = null;
            textBoxaramacubugu.Clear();
        }

        private void dataGridViewUrunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (e.RowIndex >= 0)
                {
                    textBoxurunad.Text = dataGridViewUrunler.Rows[e.RowIndex].Cells["UrunAdi"]?.Value?.ToString() ?? string.Empty;

                    numericUpDownstokmiktar.Value = Convert.ToDecimal(dataGridViewUrunler.Rows[e.RowIndex].Cells["StokMiktari"]?.Value ?? 0);

                    textBoxsatisfiyat.Text = dataGridViewUrunler.Rows[e.RowIndex].Cells["Fiyat"]?.Value?.ToString() ?? string.Empty;

                    textBoxalisfiyat.Text = dataGridViewUrunler.Rows[e.RowIndex].Cells["Alis_Fiyat"]?.Value?.ToString() ?? string.Empty;

                    string resimYolu = dataGridViewUrunler.Rows[e.RowIndex].Cells["Urun_resim"]?.Value?.ToString()?.Replace("\"", "").Trim() ?? string.Empty;
                    textBoxresimyol.Text = resimYolu;

                    comboBoxkategoriism.SelectedValue = dataGridViewUrunler.Rows[e.RowIndex].Cells["KategoriID"]?.Value;
                    comboBoxfirmaisim.SelectedValue = dataGridViewUrunler.Rows[e.RowIndex].Cells["TedarikciID"]?.Value;

                    if (!string.IsNullOrEmpty(resimYolu) && File.Exists(resimYolu))
                    {
                        pictureBoxurunresim.Image = Image.FromFile(resimYolu);
                        pictureBoxurunresim.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    else
                    {
                        pictureBoxurunresim.Image = null;
                        MessageBox.Show("Resim dosyası bulunamadı: " + resimYolu,
                                        "Hata",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ürün bilgileri alınırken bir hata oluştu:\n" + ex.Message,
                                "Hata",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void dataGridViewUrunler_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DatagridViewFormat.AutoFormatStatusColumns(dataGridViewUrunler, e);
        }

        private void checkBoxpasif_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxpasif.Checked)
            {
                checkBoxaktif.Checked = false;
            }
            UrunleriFiltrele();
        }

        private void checkBoxaktif_CheckedChanged_1(object sender, EventArgs e)
        {

            if (checkBoxaktif.Checked)
            {
                checkBoxpasif.Checked = false;
            }
            UrunleriFiltrele();
        }
    }
}

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
    public partial class FormKategoriler : Form
    {
        private readonly KategoriRepository _kategoriRepo = new KategoriRepository();
        public FormKategoriler()
        {
            InitializeComponent();

        }
        private void KategorileriYukle(string arama = "", bool? durum = null)
        {
            try
            {
                dataGridViewkategori.DataSource = _kategoriRepo.GetKategoriler(arama, durum);
                ConfigureDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kategoriler yüklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ConfigureDataGridView()
        {
            dataGridViewkategori.Columns["KategoriID"].Visible = false; 
            dataGridViewkategori.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void KategorileriFiltrele()
        {
            string arama = textBoxkategoriarama.Text.Trim();
            bool? durum = null;

            if (checkBoxaktif.Checked && !checkBoxpasif.Checked)
            {
                durum = true; 
            }
            else if (!checkBoxaktif.Checked && checkBoxpasif.Checked)
            {
                durum = false; 
            }

            KategorileriYukle(arama, durum);
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonekle_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxkategoriadi.Text))
                {
                    MessageBox.Show("Kategori Adı boş bırakılamaz.");
                    return;
                }

                var yeniKategori = new Kategori
                {
                    KategoriAdi = textBoxkategoriadi.Text,
                    Aciklama = textBoxkategoriaciklama.Text
                };

                if (_kategoriRepo.AddKategori(yeniKategori))
                {
                    MessageBox.Show("Kategori başarıyla eklendi.");
                    KategorileriYukle();
                    Temizle();
                }
                else
                {
                    MessageBox.Show("Kategori eklenirken bir hata oluştu.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kategori eklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonsil_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewkategori.CurrentRow == null)
                {
                    MessageBox.Show("Silmek için bir kategori seçmelisiniz.");
                    return;
                }

                int kategoriID = Convert.ToInt32(dataGridViewkategori.CurrentRow.Cells["KategoriID"].Value);

                if (_kategoriRepo.DeleteKategoriPasif(kategoriID))
                {
                    MessageBox.Show("Ürün başarıyla silindi!");
                    KategorileriYukle();
                }
                else
                {
                    MessageBox.Show("Ürün silinirken bir hata oluştu.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Kategori silinirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Temizle()
        {
            textBoxkategoriid.Clear();
            textBoxkategoriadi.Clear();
            textBoxkategoriaciklama.Clear();
            textBoxkategoriarama.Clear();
        }
        private void buttontemizle_Click(object sender, EventArgs e)
        {
            try
            {
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Form temizlenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonguncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(textBoxkategoriid.Text, out int kategoriID))
                {
                    MessageBox.Show("Geçerli bir Kategori ID seçmelisiniz.");
                    return;
                }


                var guncellenecekKategori = new Kategori
                {
                    KategoriID = kategoriID,
                    KategoriAdi = textBoxkategoriadi.Text,
                    Aciklama = textBoxkategoriaciklama.Text
                };

                if (_kategoriRepo.UpdateKategori(guncellenecekKategori))
                {
                    _kategoriRepo.UpdateKategoriDurum(kategoriID);
                    MessageBox.Show("Kategori başarıyla güncellendi.");
                    KategorileriYukle();
                    Temizle();
                }
                else
                {
                    MessageBox.Show("Kategori güncellenirken bir hata oluştu.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kategori güncellenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dataGridViewkategori_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void FormKategoriler_Load(object sender, EventArgs e)
        {
            try
            {   dataGridViewkategori.AllowUserToAddRows = false;
                checkBoxaktif.Checked = true;
                KategorileriFiltrele() ;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kategoriler yüklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dataGridViewkategori_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (e.RowIndex >= 0)
                {
                    textBoxkategoriid.Text = dataGridViewkategori.Rows[e.RowIndex].Cells[0].Value?.ToString() ?? string.Empty;
                    textBoxkategoriadi.Text = dataGridViewkategori.Rows[e.RowIndex].Cells[1].Value?.ToString() ?? string.Empty;
                    textBoxkategoriaciklama.Text = dataGridViewkategori.Rows[e.RowIndex].Cells[2].Value?.ToString() ?? string.Empty;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Kategori bilgileri alınırken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxkategoriarama_TextChanged(object sender, EventArgs e)
        {
            string arama = textBoxkategoriarama.Text.Trim();

            if (string.IsNullOrEmpty(arama))
            {
                KategorileriYukle("", true);
            }
            else
            {
                KategorileriYukle(arama, null);
            }
            
        }

        private void dataGridViewkategori_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DatagridViewFormat.AutoFormatStatusColumns(dataGridViewkategori, e);
        }

        private void checkBoxaktif_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxaktif.Checked)
            {
                checkBoxpasif.Checked = false; 
            }
            KategorileriFiltrele();
        
        }

        private void checkBoxpasif_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxpasif.Checked)
            {
                checkBoxaktif.Checked = false; 
            }
            KategorileriFiltrele();
        }
    }

}

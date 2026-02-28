using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MarketStokUygulamsı_
{
    public partial class FormMusteriBilgi : Form
    {
        private readonly MusteriRepository _musteriRepo = new MusteriRepository();
        public FormMusteriBilgi()
        {
            InitializeComponent();
        }

        private void FormMusteriBilgi_Load(object sender, EventArgs e)
        {
            dataGridViewmusteri.AllowUserToAddRows = false;
            checkBoxaktif.Checked = true;
            MusterileriFiltrele();

        }
        private void MusterileriYukle(string arama = "", bool? durum = null)
        {
            try
            {
                dataGridViewmusteri.DataSource = _musteriRepo.GetMusteriler(arama, durum);
                ConfigureDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Müşteriler yüklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MusterileriFiltrele()
        {
            string arama = textBoxmusteriarama.Text.Trim();
            bool? durum = null;

            // Aktif müşteriler için
            if (checkBoxaktif.Checked && !checkBoxpasif.Checked)
            {
                durum = true; // Sadece aktif müşteriler
            }
            // Pasif müşteriler için
            else if (!checkBoxaktif.Checked && checkBoxpasif.Checked)
            {
                durum = false; // Sadece pasif müşteriler
            }

            MusterileriYukle(arama, durum);
        }

        private void ConfigureDataGridView()
        {

            dataGridViewmusteri.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridViewmusteri.MultiSelect = false;
        }
        private void buttonekle_Click(object sender, EventArgs e)
        {
            try
            {
                // Alanların boş olup olmadığını kontrol et
                if (string.IsNullOrWhiteSpace(textBoxmusteriad.Text) ||
                    string.IsNullOrWhiteSpace(textBoxmusterisoyad.Text) ||
                    string.IsNullOrWhiteSpace(maskedTextBoxtelno.Text))
                {
                    MessageBox.Show("Tüm alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var musteri = new Musteri
                {
                    MusteriAd = textBoxmusteriad.Text,
                    MusteriSoyad = textBoxmusterisoyad.Text,
                    M_Tel_No = maskedTextBoxtelno.Text
                };

                if (_musteriRepo.AddMusteri(musteri))
                {
                    MessageBox.Show("Müşteri başarıyla eklendi.");
                    MusterileriYukle();
                    Temizle();
                }
                else
                {
                    MessageBox.Show("Müşteri eklenirken hata oluştu.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void buttonsil_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewmusteri.CurrentRow == null)
                {
                    MessageBox.Show("Silmek için bir müşteri seçiniz.");
                    return;
                }

                if (dataGridViewmusteri.CurrentCell == null)
                {
                    MessageBox.Show("Bir sütun seçin.");
                    return;
                }

                int musteriID = Convert.ToInt32(dataGridViewmusteri.CurrentRow.Cells["MusteriID"].Value);

                if (_musteriRepo.DeleteMusteri(musteriID))
                {
                    MessageBox.Show("Müşteri başarıyla silindi.");
                    MusterileriYukle();
                }
                else
                {
                    MessageBox.Show("Müşteri silinirken hata oluştu.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void buttonguncelle_Click(object sender, EventArgs e)
        {
            try
            {

                if (
                    string.IsNullOrWhiteSpace(textBoxmusteriad.Text) ||
                    string.IsNullOrWhiteSpace(textBoxmusterisoyad.Text) ||
                    string.IsNullOrWhiteSpace(maskedTextBoxtelno.Text))
                {
                    MessageBox.Show("Tüm alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                if (dataGridViewmusteri.CurrentRow == null)
                {
                    MessageBox.Show("Lütfen güncellemek istediğiniz müşteri kaydını seçin.");
                    return;
                }

                int musteriID = Convert.ToInt32(dataGridViewmusteri.CurrentRow.Cells["MusteriID"].Value);

                var musteri = new Musteri
                {
                    MusteriID = musteriID,
                    MusteriAd = textBoxmusteriad.Text,
                    MusteriSoyad = textBoxmusterisoyad.Text,
                    M_Tel_No = maskedTextBoxtelno.Text
                };

                if (_musteriRepo.UpdateMusteri(musteri))
                {
                    if (_musteriRepo.UpdateMusteriDurum(musteriID, musteri.Durum))
                    {
                        MessageBox.Show("Müşteri başarıyla güncellendi.");
                        MusterileriYukle();
                        Temizle();
                    }
                    else
                    {
                        MessageBox.Show("Müşteri durumu güncellenirken hata oluştu.");
                    }
                }
                else
                {
                    MessageBox.Show("Müşteri güncellenirken hata oluştu.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void Temizle()
        {

            textBoxmusteriad.Clear();
            textBoxmusterisoyad.Clear();
            maskedTextBoxtelno.Clear();
        }
        private void buttontemizle_Click(object sender, EventArgs e)
        {
            Temizle();

        }

        private void dataGridViewmusteri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                textBoxmusteriad.Text = dataGridViewmusteri.Rows[e.RowIndex].Cells["MusteriAd"].Value.ToString();
                textBoxmusterisoyad.Text = dataGridViewmusteri.Rows[e.RowIndex].Cells["MusteriSoyad"].Value.ToString();
                maskedTextBoxtelno.Text = dataGridViewmusteri.Rows[e.RowIndex].Cells["M_Tel_No"].Value.ToString();
            }
        }

        private void textBoxmusteriarama_TextChanged(object sender, EventArgs e)
        {
            string arama = textBoxmusteriarama.Text.Trim();

            if (string.IsNullOrEmpty(arama))
            {
                MusterileriYukle("", true);
            }
            else
            {
                MusterileriYukle(arama, null);
            }
        }

        private void dataGridViewmusteri_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewmusteri_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DatagridViewFormat.AutoFormatStatusColumns(dataGridViewmusteri, e);
        }

        private void checkBoxaktif_CheckedChanged_1(object sender, EventArgs e)
        {

            if (checkBoxaktif.Checked)
            {
                checkBoxpasif.Checked = false;
            }
            MusterileriFiltrele();
        }

        private void checkBoxpasif_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBoxpasif.Checked)
            {
                checkBoxaktif.Checked = false;
            }
            MusterileriFiltrele();
        }

        private void dataGridViewmusteri_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

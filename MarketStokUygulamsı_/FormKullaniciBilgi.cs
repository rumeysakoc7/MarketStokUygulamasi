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
    public partial class FormKullaniciBilgi : Form
    {
        private KullanciRepository _repo = new KullanciRepository();


        public FormKullaniciBilgi()
        {
            InitializeComponent();
        }

        private void KullaniciListele(bool? durum = null)
        {
            try
            {
                dataGridViewkullanicibilgi.DataSource = _repo.GetKullanicilar(durum);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri yüklenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void KullanicilariFiltrele()
        {
            bool? durum = null;

            
            if (checkBoxaktif.Checked && !checkBoxpasif.Checked)
            {
                durum = true; 
            }
            else if (!checkBoxaktif.Checked && checkBoxpasif.Checked)
            {
                durum = false; 
            }

            KullaniciListele( durum);
        }

        private void dataGridViewkullanicibilgi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridViewkullanicibilgi.Rows[e.RowIndex];

                    textBoxadi.Text = row.Cells["Adi"].Value?.ToString();
                    textBoxsoyadi.Text = row.Cells["Soyadi"].Value?.ToString();
                    textBoxkullaniciadi.Text = row.Cells["KullaniciAdi"].Value?.ToString();
                    textBoxsifre.Text = row.Cells["Sifre"].Value?.ToString();
                    maskedTextBoxtelno.Text = row.Cells["KullaniciTelNo"].Value?.ToString();
                    comboBoxyetki.Text = row.Cells["Yetki"].Value?.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonekle_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxadi.Text) ||
                    string.IsNullOrWhiteSpace(textBoxsoyadi.Text) ||
                    string.IsNullOrWhiteSpace(textBoxkullaniciadi.Text) ||
                    string.IsNullOrWhiteSpace(maskedTextBoxtelno.Text) ||
                    string.IsNullOrWhiteSpace(textBoxsifre.Text) ||
                    comboBoxyetki.SelectedIndex == -1)
                {
                    MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var kullanici = new Kullanici
                {
                    Ad = textBoxadi.Text,
                    Soyad = textBoxsoyadi.Text,
                    KullaniciAdi = textBoxkullaniciadi.Text,
                    Sifre = textBoxsifre.Text,
                    Yetki = comboBoxyetki.Text,
                    KullaniciTelNo = maskedTextBoxtelno.Text
                };

                if (_repo.AddKullanici(kullanici))
                {
                    MessageBox.Show("Kullanıcı başarıyla eklendi.");
                    KullaniciListele();
                    FormuTemizle();
                }
                else
                {
                    MessageBox.Show("Kullanıcı eklenirken hata oluştu.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormKullaniciBilgi_Load(object sender, EventArgs e)
        {
            dataGridViewkullanicibilgi.AllowUserToAddRows = false;
            checkBoxaktif.Checked = true;
            KullanicilariFiltrele();
        }

        private void buttonguncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewkullanicibilgi.CurrentRow == null)
                {
                    MessageBox.Show("Lütfen güncellemek istediğiniz kullanıcıyı seçin.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(textBoxadi.Text) ||
                    string.IsNullOrWhiteSpace(textBoxsoyadi.Text) ||
                    string.IsNullOrWhiteSpace(textBoxkullaniciadi.Text) ||
                    string.IsNullOrWhiteSpace(maskedTextBoxtelno.Text) ||
                    string.IsNullOrWhiteSpace(textBoxsifre.Text) ||
                    comboBoxyetki.SelectedIndex == -1)
                {
                    MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int kullaniciID = Convert.ToInt32(dataGridViewkullanicibilgi.CurrentRow.Cells["KullaniciID"].Value);
                var kullanici = new Kullanici
                {
                    KullaniciID = Convert.ToInt32(dataGridViewkullanicibilgi.CurrentRow.Cells["KullaniciID"].Value),
                    Ad = textBoxadi.Text,
                    Soyad = textBoxsoyadi.Text,
                    KullaniciAdi = textBoxkullaniciadi.Text,
                    Sifre = textBoxsifre.Text,
                    Yetki = comboBoxyetki.Text,
                    KullaniciTelNo = maskedTextBoxtelno.Text


                };

                if (_repo.UpdateKullanici(kullanici))
                {
                    _repo.UpdateKullaniciDurum(kullaniciID);
                    MessageBox.Show("Kullanıcı başarıyla güncellendi.");
                    KullaniciListele();
                    FormuTemizle();
                }
                else
                {
                    MessageBox.Show("Güncelleme sırasında hata oluştu.");
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
                if (dataGridViewkullanicibilgi.CurrentRow == null)
                {
                    MessageBox.Show("Lütfen silmek istediğiniz kullanıcıyı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (dataGridViewkullanicibilgi.CurrentRow == null)
                {
                    MessageBox.Show("Lütfen silmek istediğiniz kullanıcıyı seçin.");
                    return;
                }

                int kullaniciID = Convert.ToInt32(dataGridViewkullanicibilgi.CurrentRow.Cells["KullaniciID"].Value);

                if (_repo.DeleteKullaniciPasif(kullaniciID))
                {
                    MessageBox.Show("Kullanıcı başarıyla silindi.");
                    KullaniciListele();
                }
                else
                {
                    MessageBox.Show("Silme işlemi sırasında hata oluştu.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormuTemizle()
        {
            textBoxadi.Clear();
            textBoxsoyadi.Clear();
            textBoxkullaniciadi.Clear();
            textBoxsifre.Clear();
            comboBoxyetki.SelectedIndex = -1;
            maskedTextBoxtelno.Clear();
        }


        private void buttontemizle_Click(object sender, EventArgs e)
        {
            try
            {
                FormuTemizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Temizleme sırasında hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewkullanicibilgi_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DatagridViewFormat.AutoFormatStatusColumns(dataGridViewkullanicibilgi, e);
        }

        private void checkBoxaktif_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxaktif.Checked)
            {
                checkBoxpasif.Checked = false;
            }
            KullanicilariFiltrele();
        }

        private void checkBoxpasif_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxpasif.Checked)
            {
                checkBoxaktif.Checked = false;
            }
           KullanicilariFiltrele();
        }
    }

}

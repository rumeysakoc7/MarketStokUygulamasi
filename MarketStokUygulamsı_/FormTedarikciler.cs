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
    public partial class FormTedarikciler : Form
    {
        private readonly TedarikciRepository _tedarikciRepo = new TedarikciRepository();
        public FormTedarikciler()
        {
            InitializeComponent();
        }

        private void TedarikcileriYukle(string arama = "", bool? aktifDurum = null)
        {
            try
            {
                dataGridViewtedarikci.DataSource = _tedarikciRepo.GetTedarikciler(arama, aktifDurum);
                ConfigureDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tedarikçiler yüklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TedarikcileriFiltrele()
        {
            string arama = textBoxtedarikciarama.Text.Trim();
            bool? durum = null;

            if (checkBoxaktif.Checked && !checkBoxpasif.Checked)
            {
                durum = true;
            }
            else if (!checkBoxaktif.Checked && checkBoxpasif.Checked)
            {
                durum = false;
            }

            TedarikcileriYukle(arama, durum);
        }
        private void ConfigureDataGridView()
        {
            dataGridViewtedarikci.Columns["TedarikciID"].Visible = false; // TedarikciID'yi gizle
            dataGridViewtedarikci.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void buttonsil_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewtedarikci.CurrentRow == null)
                {
                    MessageBox.Show("Silmek için bir tedarikçi seçmelisiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int tedarikciID = Convert.ToInt32(dataGridViewtedarikci.CurrentRow.Cells["TedarikciID"].Value);

                if (_tedarikciRepo.DeleteTedarikci(tedarikciID))
                {
                    MessageBox.Show("Tedarikçi başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TedarikcileriYukle();
                }
                else
                {
                    MessageBox.Show("Tedarikçi silinirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tedarikçi silinirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)//buton ekle
        {

            try
            {
                if (string.IsNullOrWhiteSpace(textBoxtedarikciadi.Text) ||
                    string.IsNullOrWhiteSpace(textBoxtedarikcisoyad.Text) ||
                    string.IsNullOrWhiteSpace(textBoxfirmaad.Text) ||
                    string.IsNullOrWhiteSpace(maskedTextBoxtelno.Text) ||
                    string.IsNullOrWhiteSpace(textBoxadres.Text))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var yeniTedarikci = new Tedarikci
                {
                    TedarikciAdi = textBoxtedarikciadi.Text,
                    TedarikciSoyadi = textBoxtedarikcisoyad.Text,
                    FirmaAdi = textBoxfirmaad.Text,
                    Telefon = maskedTextBoxtelno.Text,
                    Adres = textBoxadres.Text
                };

                if (_tedarikciRepo.AddTedarikci(yeniTedarikci))
                {
                    MessageBox.Show("Tedarikçi başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TedarikcileriYukle();
                    Temizle();
                }
                else
                {
                    MessageBox.Show("Tedarikçi eklenirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tedarikçi eklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonguncelle_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxtedarikciadi.Text) ||
                   string.IsNullOrWhiteSpace(textBoxtedarikcisoyad.Text) ||
                   string.IsNullOrWhiteSpace(textBoxfirmaad.Text) ||
                   string.IsNullOrWhiteSpace(maskedTextBoxtelno.Text) ||
                   string.IsNullOrWhiteSpace(textBoxadres.Text))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (dataGridViewtedarikci.CurrentRow == null)
                {
                    MessageBox.Show("Lütfen güncellemek istedğiniz tedarikçi kaydını seçin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int tedarikciID = Convert.ToInt32(dataGridViewtedarikci.CurrentRow.Cells["TedarikciID"].Value);

                var guncellenecekTedarikci = new Tedarikci
                {
                    TedarikciID = tedarikciID,
                    TedarikciAdi = textBoxtedarikciadi.Text,
                    TedarikciSoyadi = textBoxtedarikcisoyad.Text,
                    FirmaAdi = textBoxfirmaad.Text,
                    Telefon = maskedTextBoxtelno.Text,
                    Adres = textBoxadres.Text
                };

                if (_tedarikciRepo.UpdateTedarikci(guncellenecekTedarikci))
                {
                    _tedarikciRepo.UpdateDurumAktif(tedarikciID);

                    MessageBox.Show("Tedarikçi başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TedarikcileriYukle();
                    Temizle();
                }
                else
                {
                    MessageBox.Show("Tedarikçi güncellenirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tedarikçi güncellenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Temizle()
        {

            textBoxtedarikciadi.Clear();
            textBoxfirmaad.Clear();
            maskedTextBoxtelno.Clear();
            textBoxadres.Clear();
            textBoxtedarikciarama.Clear();
            textBoxtedarikcisoyad.Clear();
        }
        private void buttontemizle_Click_1(object sender, EventArgs e)
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

        private void textBoxtedarikciarama_TextChanged(object sender, EventArgs e)
        {

            string arama = textBoxtedarikciarama.Text.Trim();

            if (string.IsNullOrEmpty(arama))
            {
                TedarikcileriYukle("", true);
            }
            else
            {
                TedarikcileriYukle(arama, null);
            }
        }

        private void FormTedarikciler_Load(object sender, EventArgs e)
        {
            try
            {
                checkBoxaktif.Checked = true;
                TedarikcileriFiltrele();
                dataGridViewtedarikci.AllowUserToAddRows = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tedarikçiler yüklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewtedarikci_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {

                    textBoxtedarikciadi.Text = dataGridViewtedarikci.Rows[e.RowIndex].Cells["TedarikciAdi"].Value?.ToString() ?? string.Empty;
                    textBoxtedarikcisoyad.Text = dataGridViewtedarikci.Rows[e.RowIndex].Cells["TedarikciSoyadi"].Value?.ToString() ?? string.Empty;
                    textBoxfirmaad.Text = dataGridViewtedarikci.Rows[e.RowIndex].Cells["FirmaAdi"].Value?.ToString() ?? string.Empty;
                    maskedTextBoxtelno.Text = dataGridViewtedarikci.Rows[e.RowIndex].Cells["Telefon"].Value?.ToString() ?? string.Empty;
                    textBoxadres.Text = dataGridViewtedarikci.Rows[e.RowIndex].Cells["Adres"].Value?.ToString() ?? string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tedarikçi bilgileri alınırken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dataGridViewtedarikci_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DatagridViewFormat.AutoFormatStatusColumns(dataGridViewtedarikci, e);
        }

        private void checkBoxaktif_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxaktif.Checked)
            {
                checkBoxpasif.Checked = false;
            }
            TedarikcileriFiltrele();
        }

        private void checkBoxpasif_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxpasif.Checked)
            {
                checkBoxaktif.Checked = false;
            }
            TedarikcileriFiltrele();
        }

        private void paneltedarikcibilgi_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

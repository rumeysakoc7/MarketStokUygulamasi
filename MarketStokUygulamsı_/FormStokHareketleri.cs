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
    public partial class FormStokHareketleri : Form
    {
        private readonly StokHareketRepository _repository;
        public FormStokHareketleri()
        {
            InitializeComponent();
            _repository = new StokHareketRepository();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ApplyFilters(object sender, EventArgs e)
        {
            try
            {
                var islemTuru = comboBoxstokhareket.SelectedIndex > 0
                    ? comboBoxstokhareket.SelectedItem.ToString()
                    : null;

                var hareketler = _repository.GetFilteredStokHareketleri(
                    textBoxurunad.Text.Trim(),       // Ürün adı
                    islemTuru,                      // İşlem türü (Ürün Alış / Ürün Satış)
                    textBoxkullaniciad.Text.Trim(), // Kullanıcı adı
                    dateTimePicker1.Value           // Tarih
                );

                dataGridViewstokhareket.DataSource = hareketler;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Filtre uygulanırken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void FormStokHareketleri_Load(object sender, EventArgs e)
        {
            LoadData();
            comboBoxstokhareket.SelectedIndex = 0;
            textBoxurunad.TextChanged += ApplyFilters;
            textBoxkullaniciad.TextChanged += ApplyFilters;
            comboBoxstokhareket.SelectedIndexChanged += ApplyFilters;
            dateTimePicker1.ValueChanged += ApplyFilters;

            dataGridViewstokhareket.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void LoadData()
        {
            try
            {
                var hareketler = _repository.GetFilteredStokHareketleri();
                dataGridViewstokhareket.DataSource = hareketler;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veriler yüklenirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewstokhareket_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
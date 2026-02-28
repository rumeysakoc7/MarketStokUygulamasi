using MarketStokUygulamsı_.MarketStokUygulamasi;
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
    public partial class FormRapor : Form
    {
        private readonly RaporRepository _RaporRepo = new RaporRepository();
        public FormRapor()
        {
            InitializeComponent();
            var databaseHelper = new DatabaseHelper();
            _RaporRepo = new RaporRepository();


        }
        private void FormRapor_Load(object sender, EventArgs e)
        {
            ListeleRaporlar();
            dataGridViewRapor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewRapor.AllowUserToAddRows = false;

        }
        private void ListeleRaporlar()
        {
            try
            {
                List<Rapor> raporlar = _RaporRepo.RaporlariGetir();
                dataGridViewRapor.DataSource = raporlar;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Raporları getirirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonraporhesap_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime baslangicTarihi = dateTimePickerbaslangic.Value.Date;
                DateTime bitisTarihi = dateTimePickerbitis.Value.Date;

                if (baslangicTarihi > bitisTarihi)
                {
                    MessageBox.Show("Başlangıç tarihi bitiş tarihinden büyük olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool sonuc = _RaporRepo.HesaplaVeKaydetRapor(baslangicTarihi, bitisTarihi);

                if (sonuc)
                {
                    MessageBox.Show("Rapor başarıyla oluşturuldu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListeleRaporlar();
                }
                else
                {
                    MessageBox.Show("Seçilen tarihlerde işlem bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}

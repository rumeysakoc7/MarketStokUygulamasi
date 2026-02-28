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
    public partial class FormAlis : Form
    {
        private readonly UrunRepository _urunRepo = new UrunRepository();
        private readonly AlisRepository _alisRepo = new AlisRepository();
        private readonly TedarikciRepository _tedarikciRepo = new TedarikciRepository();
        private readonly StokHareketRepository _stokRepo = new StokHareketRepository();
        private readonly List<Alissepet1> _alisSepeti = new List<Alissepet1>();
        public FormAlis()
        {
            InitializeComponent();
        }


        private void dataGridViewalis_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < dataGridViewalis.Rows.Count)
                {
                    textBoxurunad.Text = dataGridViewalis.Rows[e.RowIndex].Cells["UrunAdi"]?.Value?.ToString() ?? string.Empty;
                    textBoxalisfiyat.Text = dataGridViewalis.Rows[e.RowIndex].Cells["AlisFiyat"]?.Value?.ToString() ?? string.Empty;
                   textBoxtedarikci.Text = dataGridViewalis.Rows[e.RowIndex].Cells["FirmaAdi"]?.Value?.ToString() ?? string.Empty;

                    int urunID = Convert.ToInt32(dataGridViewalis.Rows[e.RowIndex].Cells["UrunID"]?.Value ?? 0);

                    string resimYolu = _alisRepo.GetResimYoluFromDatabase(urunID);

                    if (!string.IsNullOrEmpty(resimYolu))
                    {
                        Console.WriteLine($"Resim Yolu: {resimYolu}");
                        pictureBoxurunresimi.Image = Image.FromFile(resimYolu);
                        pictureBoxurunresimi.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    else
                    {
                        pictureBoxurunresimi.Image = null;
                    }
                }
                else
                {
                    MessageBox.Show("Geçersiz satır tıklaması.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonsepetekle_Click(object sender, EventArgs e)
        {
            try
            {
                var urunAdi = textBoxurunad.Text;
                if (string.IsNullOrEmpty(urunAdi))
                {
                    MessageBox.Show("Lütfen geçerli bir ürün seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(textBoxalisfiyat.Text, out decimal alisfiyat))
                {
                    MessageBox.Show("Fiyat geçerli bir sayı değil.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int adet = (int)numericUpDownmiktar.Value;

                if (adet <= 0)
                {
                    MessageBox.Show("Adet 0'dan büyük olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal toplamFiyat = alisfiyat * adet;

                var urun = new Alissepet1
                {
                    UrunAdi = urunAdi,
                    Miktar = adet,
                    AlisFiyat= alisfiyat,
                    ToplamMaliyet = toplamFiyat
                };

                _alisSepeti.Add(urun);

                listBoxalissepet.Items.Add($"{urun.UrunAdi} - {urun.Miktar} Adet - {urun.ToplamMaliyet:C}");

                decimal toplamTutar = _alisSepeti.Sum(x => x.ToplamMaliyet);
                textBoxtoplamtutar.Text = toplamTutar.ToString("C");

                MessageBox.Show("Ürün sepete eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void buttontedarikcidenal_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (_alisSepeti.Count == 0)
                {
                    MessageBox.Show("Sepet boş. Lütfen ürün ekleyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string urunAdi = textBoxurunad.Text.Trim();
                if (string.IsNullOrEmpty(urunAdi))
                {
                    MessageBox.Show("Lütfen geçerli bir ürün adı giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (dataGridViewalis.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Lütfen bir ürün ve tedarikçi seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int urunID = Convert.ToInt32(dataGridViewalis.SelectedRows[0].Cells["UrunID"].Value);
                int tedarikciID = Convert.ToInt32(dataGridViewalis.SelectedRows[0].Cells["TedarikciID"].Value);

                foreach (var item in _alisSepeti)
                {
                    decimal alisFiyat = item.AlisFiyat;
                    if (alisFiyat <= 0)
                    {
                        MessageBox.Show($"Ürün {item.UrunAdi} için geçerli bir alış fiyatı giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        continue;
                    }

                    int adet = item.Miktar;
                    if (adet <= 0)
                    {
                        MessageBox.Show($"Ürün {item.UrunAdi} için geçerli bir miktar giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        continue;
                    }

                    decimal toplamMaliyet = alisFiyat * adet;

                    
                    var alisIslemi = new Alis
                    {
                        UrunID = urunID,
                        Miktar = adet,
                        AlisFiyat = alisFiyat,
                        ToplamMaliyet = toplamMaliyet,
                        TedarikciId = tedarikciID,
                        AlisTarihi = DateTime.Now,
                        KullaniciId = KullaniciErisim.KullaniciID 
                    };

                    bool alisBasarili = _alisRepo.AddAlis(alisIslemi);
                    if (!alisBasarili)
                    {
                        MessageBox.Show($"Ürün {item.UrunAdi} için alış işlemi başarısız oldu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        continue;
                    }

                    
                    var stokHareket = new StokHareket
                    {
                        UrunID = urunID,
                        IslemTuru = "Ürün Alış",
                        Miktar = adet,
                        IslemTarihi = DateTime.Now,
                        ToplamTutar = toplamMaliyet,
                        Kullanici_ID = KullaniciErisim.KullaniciID
                    };

                    bool stokHareketiBasarili = _stokRepo.AddStokHareket(stokHareket);
                    if (!stokHareketiBasarili)
                    {
                        MessageBox.Show($"Stok hareketi kaydedilirken hata oluştu: {item.UrunAdi}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        continue;
                    }

                    
                    bool stokGuncellendi = _urunRepo.UpdateStokMiktariarttir(urunID, adet);
                    if (!stokGuncellendi)
                    {
                        MessageBox.Show($"Stok miktarı güncellenirken hata oluştu: {item.UrunAdi}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        continue;
                    }
                }

                
                _alisSepeti.Clear();
                SepetiGoster();
                UrunleriYukle();
                MessageBox.Show("Tedarikçi alım işlemi başarıyla tamamlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Tedarikçi alım işlemi sırasında hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonsepettensil_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxalissepet.SelectedIndex >= 0)
                {
                    listBoxalissepet.Items.RemoveAt(listBoxalissepet.SelectedIndex);

                    decimal toplamTutar = listBoxalissepet.Items
                        .Cast<string>()
                        .Sum(item => Convert.ToDecimal(item.Split('-')[2].Trim().Replace("₺", "")));

                    textBoxtoplamtutar.Text = toplamTutar.ToString("C");
                }
                else
                {
                    MessageBox.Show("Lütfen sepetten bir ürün seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void FormAlis_Load(object sender, EventArgs e)
        {
            try
            {
                UrunleriYukle();
                SepetiGoster();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Form yüklenirken hata oluştu: {ex.Message}");
            }
        }
        private void UrunleriYukle()
        {
            try
            {
                dataGridViewalis.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                var alisRepository = new AlisRepository();
                var urunler = _urunRepo.GetUrunlerForAlis();

                dataGridViewalis.Columns.Clear();
                dataGridViewalis.AutoGenerateColumns = false;

               
                alisRepository.AddColumnToGrid(dataGridViewalis, "UrunID", "ÜrünID");
                alisRepository.AddColumnToGrid(dataGridViewalis, "UrunAdi", "Ürün Adı");
                alisRepository.AddColumnToGrid(dataGridViewalis, "FirmaAdi", "Firma Adı");
                alisRepository.AddColumnToGrid(dataGridViewalis, "TedarikciID", "Tedarikçi ID");
                alisRepository.AddColumnToGrid(dataGridViewalis, "StokMiktari", "Stok Miktarı");
                alisRepository.AddColumnToGrid(dataGridViewalis, "Fiyat", "Satış Fiyatı");
                alisRepository.AddColumnToGrid(dataGridViewalis, "AlisFiyat", "Alış Fiyatı");
                alisRepository.AddColumnToGrid(dataGridViewalis, "TedarikciAdSoyad", "Tedarikçi Adı Ve Soyadı");

                dataGridViewalis.DataSource = urunler;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ürünler yüklenirken hata oluştu: {ex.Message}");
            }
        }

        private void SepetiGoster()
        {
            try
            {
                listBoxalissepet.Items.Clear();
                foreach (var item in _alisSepeti)
                {
                    listBoxalissepet.Items.Add($"{item.UrunAdi} - {item.Miktar} Adet - {item.ToplamMaliyet:C}");
                }

                textBoxtoplamtutar.Text = _alisSepeti.Sum(x => x.ToplamMaliyet).ToString("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Sepet gösterilirken hata oluştu: {ex.Message}");
            }
        }

        private void textBoxurunara_TextChanged(object sender, EventArgs e)
        {
           dataGridViewalis.DataSource = _urunRepo.GetUrunlerForAlis(textBoxurunara.Text);
        }
    }
}

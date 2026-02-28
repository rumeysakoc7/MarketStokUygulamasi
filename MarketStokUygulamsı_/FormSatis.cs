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
    public partial class FormSatis : Form

    {
        private readonly UrunRepository _urunRepository = new UrunRepository();

        private UrunRepository _urunRepo = new UrunRepository();
        private MusteriRepository _musteriRepo = new MusteriRepository();
        private SatisRepository _satisRepo = new SatisRepository();
        private readonly StokHareketRepository _stokRepo = new StokHareketRepository();
        private readonly List<SepetItem> _sepet = new List<SepetItem>();
        public FormSatis()
        {
            InitializeComponent();
        }

        private void FormSatis_Load(object sender, EventArgs e)
        {
            try
            {
                UrunleriYukle();
                MusterileriYukle();
                dataGridViewmusteribilgi.Columns["Durum"].Visible = false;
                SepetiGoster();
                KategorileriYukle();
                comboBoxkategorifiltrele.SelectedIndexChanged += comboBoxkategorifiltrele_SelectedIndexChanged;
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
                var urunler = _urunRepo.GetUrunlerForSatis();

                dataGridViewurunbilgi.Columns.Clear();

                dataGridViewurunbilgi.AutoGenerateColumns = false;
                dataGridViewurunbilgi.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "UrunID",
                    HeaderText = "ÜrünID",
                    Name = "UrunID"
                });
                dataGridViewurunbilgi.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "UrunAdi",
                    HeaderText = "Ürün Adı",
                    Name = "UrunAdi"
                });
                dataGridViewurunbilgi.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "KategoriAdi",
                    HeaderText = "Kategori Adı",
                    Name = "KategoriAdi"
                });
                dataGridViewurunbilgi.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Fiyat",
                    HeaderText = "Fiyat",
                    Name = "Fiyat"
                });

                dataGridViewurunbilgi.DataSource = urunler;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ürünler yüklenirken hata oluştu: {ex.Message}");
            }
        }

        private void MusterileriYukle()
        {
            try
            {
                var musteriler = _musteriRepo.GetAktifMusteriler();
                dataGridViewmusteribilgi.DataSource = musteriler;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Müşteriler yüklenirken hata oluştu: {ex.Message}");
            }
        }

        private void SepetiGoster()
        {
            try
            {
                listBoxsatissepet.Items.Clear();
                foreach (var item in _sepet)
                {
                    listBoxsatissepet.Items.Add($"{item.UrunAdi} - {item.Miktar} Adet - {item.ToplamFiyat:C}");
                }

                textBoxtoplamtutar.Text = _sepet.Sum(x => x.ToplamFiyat).ToString("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Sepet gösterilirken hata oluştu: {ex.Message}");
            }
        }

        private void buttonsepeteekle_Click(object sender, EventArgs e)
        {
            try
            {
                var urunAdi = textBoxurunad.Text;
                if (string.IsNullOrEmpty(urunAdi))
                {
                    MessageBox.Show("Lütfen geçerli bir ürün seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(textBoxfiyat.Text, out decimal fiyat))
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

                decimal toplamFiyat = fiyat * adet;

                var urun = new SepetItem
                {
                    UrunAdi = urunAdi,
                    Miktar = adet,
                    BirimFiyat = fiyat,
                    ToplamFiyat = toplamFiyat
                };

                _sepet.Add(urun); 

                listBoxsatissepet.Items.Add($"{urun.UrunAdi} - {urun.Miktar} Adet - {urun.ToplamFiyat:C}");

                decimal toplamTutar = _sepet.Sum(x => x.ToplamFiyat);
                textBoxtoplamtutar.Text = toplamTutar.ToString("C");

                MessageBox.Show("Ürün sepete eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttontemizle_Click(object sender, EventArgs e)
        {
            try
            {
                numericUpDownmiktar.Value = 0;
                textBoxurunad.Text = "";
                textBoxmusteriadsoyad.Text = "";
                textBoxfiyat.Text = "";
                numericUpDownmiktar.Value = 0;
                comboBoxstokhareket.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }
        }

        private int GetSelectedMusteriID()
        {
            if (dataGridViewmusteribilgi.CurrentRow == null)
                throw new Exception("Lütfen müşteri listesinde bir satır seçiniz.");

            var musteriIDCell = dataGridViewmusteribilgi.CurrentRow.Cells["MusteriID"];
            if (musteriIDCell == null)
                throw new Exception("Seçilen satırda 'MusteriID' bulunamadı.");

            if (musteriIDCell.Value == null || musteriIDCell.Value == DBNull.Value)
                throw new Exception("Seçilen satırdaki 'MusteriID' geçersiz.");

            return Convert.ToInt32(musteriIDCell.Value);
        }

        private void buttonsatisekle_Click(object sender, EventArgs e)
        {
            try
            {
                if (_sepet.Count == 0) throw new Exception("Sepet boş. Lütfen ürün ekleyiniz.");
                string musteriAdSoyad = textBoxmusteriadsoyad.Text;
                if (string.IsNullOrEmpty(musteriAdSoyad))
                    throw new Exception("Lütfen müşteri adı ve soyadı giriniz.");
                int musteriID;
                try
                {
                    musteriID = GetSelectedMusteriID();
                    MessageBox.Show($"Seçilen müşteri ID: {musteriID}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata: {ex.Message}", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Hata durumunda işlemi durdur
                }


                foreach (var item in _sepet)
                {
                    var satis = new Satis
                    {
                        UrunID = _urunRepo.GetUrunID(item.UrunAdi),
                        Miktar = item.Miktar,
                        BirimFiyat = item.BirimFiyat,
                        ToplamFiyat = item.ToplamFiyat,
                        Musteri_Id = musteriID,
                        SatisTarihi = DateTime.Now,
                        Kullanici_ID=KullaniciErisim.KullaniciID
                    };

                    _satisRepo.AddSatis(satis);
                    _stokRepo.AddStokHareket(new StokHareket
                    {
                        UrunID = satis.UrunID,
                        IslemTuru = "Ürün Satış",
                        Miktar = satis.Miktar,
                        IslemTarihi = DateTime.Now,
                        ToplamTutar = satis.BirimFiyat * satis.Miktar,
                        Kullanici_ID = KullaniciErisim.KullaniciID

                    });

                    _urunRepo.UpdateStokMiktariazalt(satis.UrunID, -item.Miktar);
                }

                MessageBox.Show("Satış işlemi başarıyla tamamlandı.");
                _sepet.Clear();
                SepetiGoster();
                UrunleriYukle();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Satış işlemi sırasında hata oluştu: {ex.Message}");
            }
        }

        private void buttonsepettensil_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxsatissepet.SelectedIndex >= 0)
                {
                    listBoxsatissepet.Items.RemoveAt(listBoxsatissepet.SelectedIndex);

                    decimal toplamTutar = listBoxsatissepet.Items
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


        private void dataGridViewurunbilgi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < dataGridViewurunbilgi.Rows.Count)
                {
                    textBoxurunad.Text = dataGridViewurunbilgi.Rows[e.RowIndex].Cells["UrunAdi"]?.Value?.ToString() ?? string.Empty;
                    textBoxfiyat.Text = dataGridViewurunbilgi.Rows[e.RowIndex].Cells["Fiyat"]?.Value?.ToString() ?? string.Empty;

                    int urunID = Convert.ToInt32(dataGridViewurunbilgi.Rows[e.RowIndex].Cells["UrunID"]?.Value ?? 0);

                    string resimYolu = _satisRepo.GetResimYoluFromDatabase(urunID);

                    if (!string.IsNullOrEmpty(resimYolu))
                    {
                        Console.WriteLine($"Resim Yolu: {resimYolu}");
                        pictureBoxurun.Image = Image.FromFile(resimYolu);
                        pictureBoxurun.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    else
                    {
                        pictureBoxurun.Image = null; 
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

        private void dataGridViewmusteribilgi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                  
                    var selectedRow = dataGridViewmusteribilgi.Rows[e.RowIndex];
                    var musteriID = selectedRow.Cells["MusteriID"]?.Value?.ToString();
                    var ad = selectedRow.Cells["MusteriAd"].Value?.ToString();
                    var soyad = selectedRow.Cells["MusteriSoyad"].Value?.ToString();

                    if (!string.IsNullOrEmpty(ad) && !string.IsNullOrEmpty(soyad))
                    {
                        textBoxmusteriadsoyad.Text = $"{ad} {soyad}";
                    }
                    else
                    {
                        textBoxmusteriadsoyad.Text = "Bilinmeyen müşteri.";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }
        }


        private void textBoxurunara_TextChanged(object sender, EventArgs e)
        {
            dataGridViewurunbilgi.DataSource = _urunRepository.GetUrunlerForSatis(textBoxurunara.Text);
        }

        private void textBoxmusteriara_TextChanged(object sender, EventArgs e)
        {
            dataGridViewmusteribilgi.DataSource = _musteriRepo.GetAktifMusteriler(textBoxmusteriara.Text);
        }

        private void KategorileriYukle()
        {
            try
            {
                KategoriRepository kategoriRepo = new KategoriRepository();
                List<Kategori> kategoriler = kategoriRepo.GetKategoriler();

                comboBoxkategorifiltrele.DataSource = kategoriler;
                comboBoxkategorifiltrele.DisplayMember = "KategoriAdi"; 
                comboBoxkategorifiltrele.ValueMember = "KategoriID";    
                comboBoxkategorifiltrele.SelectedIndex = -1;            
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kategoriler yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxkategorifiltrele_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxkategorifiltrele.SelectedValue != null && comboBoxkategorifiltrele.SelectedValue is int)
                {
                    int secilenKategoriID = Convert.ToInt32(comboBoxkategorifiltrele.SelectedValue);

                    UrunRepository urunRepo = new UrunRepository();
                    List<Urun> filtrelenmisUrunler = urunRepo.GetUrunlerByKategori(secilenKategoriID);

                    dataGridViewurunbilgi.DataSource = filtrelenmisUrunler;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ürünler filtrelenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

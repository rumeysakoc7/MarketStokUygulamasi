namespace MarketStokUygulamsı_
{
    partial class FormUrunler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUrunler));
            dataGridViewUrunler = new DataGridView();
            textBoxaramacubugu = new TextBox();
            buttonguncelle = new Button();
            buttonekle = new Button();
            buttonsil = new Button();
            buttontemizle = new Button();
            pictureBoxlogo = new PictureBox();
            panelurungirisbilgi = new Panel();
            textBoxalisfiyat = new TextBox();
            labelalisfiyat = new Label();
            comboBoxfirmaisim = new ComboBox();
            labelFirmaisim = new Label();
            textBoxresimyol = new TextBox();
            labelresimyol = new Label();
            label6 = new Label();
            textBoxsatisfiyat = new TextBox();
            numericUpDownstokmiktar = new NumericUpDown();
            comboBoxkategoriism = new ComboBox();
            textBoxurunad = new TextBox();
            labelsatisfiyat = new Label();
            labelstokmiktar = new Label();
            labelkategoriisim = new Label();
            labelurunisim = new Label();
            pictureBoxurunresim = new PictureBox();
            labelsctiginürün = new Label();
            checkBoxpasif = new CheckBox();
            checkBoxaktif = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUrunler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxlogo).BeginInit();
            panelurungirisbilgi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownstokmiktar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxurunresim).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewUrunler
            // 
            dataGridViewUrunler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dataGridViewCellStyle1.ForeColor = Color.Maroon;
            dataGridViewCellStyle1.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlLight;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridViewUrunler.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewUrunler.GridColor = Color.Maroon;
            dataGridViewUrunler.Location = new Point(40, 187);
            dataGridViewUrunler.Margin = new Padding(4, 3, 4, 3);
            dataGridViewUrunler.Name = "dataGridViewUrunler";
            dataGridViewUrunler.RowHeadersWidth = 51;
            dataGridViewUrunler.Size = new Size(1173, 645);
            dataGridViewUrunler.TabIndex = 0;
            dataGridViewUrunler.CellClick += dataGridViewUrunler_CellClick;
            dataGridViewUrunler.CellContentClick += dataGridViewUrunler_CellContentClick;
            dataGridViewUrunler.CellFormatting += dataGridViewUrunler_CellFormatting;
            // 
            // textBoxaramacubugu
            // 
            textBoxaramacubugu.BackColor = SystemColors.ScrollBar;
            textBoxaramacubugu.BorderStyle = BorderStyle.FixedSingle;
            textBoxaramacubugu.Location = new Point(1258, 184);
            textBoxaramacubugu.Name = "textBoxaramacubugu";
            textBoxaramacubugu.Size = new Size(411, 30);
            textBoxaramacubugu.TabIndex = 1;
            textBoxaramacubugu.TextChanged += textBox1_TextChanged;
            // 
            // buttonguncelle
            // 
            buttonguncelle.BackColor = Color.Transparent;
            buttonguncelle.FlatStyle = FlatStyle.Flat;
            buttonguncelle.ForeColor = Color.Maroon;
            buttonguncelle.Location = new Point(1291, 670);
            buttonguncelle.Name = "buttonguncelle";
            buttonguncelle.Size = new Size(180, 32);
            buttonguncelle.TabIndex = 10;
            buttonguncelle.Text = "GÜNCELLE";
            buttonguncelle.UseVisualStyleBackColor = false;
            buttonguncelle.Click += buttonguncelle_Click;
            // 
            // buttonekle
            // 
            buttonekle.BackColor = Color.Transparent;
            buttonekle.FlatStyle = FlatStyle.Flat;
            buttonekle.ForeColor = Color.Maroon;
            buttonekle.Location = new Point(1490, 670);
            buttonekle.Name = "buttonekle";
            buttonekle.Size = new Size(166, 32);
            buttonekle.TabIndex = 11;
            buttonekle.Text = "EKLE";
            buttonekle.UseVisualStyleBackColor = false;
            buttonekle.Click += buttonekle_Click;
            // 
            // buttonsil
            // 
            buttonsil.BackColor = Color.Transparent;
            buttonsil.FlatStyle = FlatStyle.Flat;
            buttonsil.ForeColor = Color.Maroon;
            buttonsil.Location = new Point(1291, 730);
            buttonsil.Name = "buttonsil";
            buttonsil.Size = new Size(180, 32);
            buttonsil.TabIndex = 12;
            buttonsil.Text = "SİL";
            buttonsil.UseVisualStyleBackColor = false;
            buttonsil.Click += buttonsil_Click;
            // 
            // buttontemizle
            // 
            buttontemizle.BackColor = Color.Transparent;
            buttontemizle.FlatStyle = FlatStyle.Flat;
            buttontemizle.ForeColor = Color.Maroon;
            buttontemizle.Location = new Point(1490, 730);
            buttontemizle.Name = "buttontemizle";
            buttontemizle.Size = new Size(166, 32);
            buttontemizle.TabIndex = 13;
            buttontemizle.Text = "TEMİZLE";
            buttontemizle.UseVisualStyleBackColor = false;
            buttontemizle.Click += buttontemizle_Click;
            // 
            // pictureBoxlogo
            // 
            pictureBoxlogo.Image = (Image)resources.GetObject("pictureBoxlogo.Image");
            pictureBoxlogo.Location = new Point(14, 3);
            pictureBoxlogo.Name = "pictureBoxlogo";
            pictureBoxlogo.Size = new Size(161, 119);
            pictureBoxlogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxlogo.TabIndex = 14;
            pictureBoxlogo.TabStop = false;
            // 
            // panelurungirisbilgi
            // 
            panelurungirisbilgi.BackColor = Color.Transparent;
            panelurungirisbilgi.BorderStyle = BorderStyle.FixedSingle;
            panelurungirisbilgi.Controls.Add(textBoxalisfiyat);
            panelurungirisbilgi.Controls.Add(labelalisfiyat);
            panelurungirisbilgi.Controls.Add(comboBoxfirmaisim);
            panelurungirisbilgi.Controls.Add(labelFirmaisim);
            panelurungirisbilgi.Controls.Add(textBoxresimyol);
            panelurungirisbilgi.Controls.Add(labelresimyol);
            panelurungirisbilgi.Controls.Add(label6);
            panelurungirisbilgi.Controls.Add(textBoxsatisfiyat);
            panelurungirisbilgi.Controls.Add(numericUpDownstokmiktar);
            panelurungirisbilgi.Controls.Add(comboBoxkategoriism);
            panelurungirisbilgi.Controls.Add(textBoxurunad);
            panelurungirisbilgi.Controls.Add(labelsatisfiyat);
            panelurungirisbilgi.Controls.Add(labelstokmiktar);
            panelurungirisbilgi.Controls.Add(labelkategoriisim);
            panelurungirisbilgi.Controls.Add(labelurunisim);
            panelurungirisbilgi.Location = new Point(1258, 233);
            panelurungirisbilgi.Name = "panelurungirisbilgi";
            panelurungirisbilgi.Size = new Size(411, 431);
            panelurungirisbilgi.TabIndex = 15;
            panelurungirisbilgi.Paint += panel1_Paint;
            // 
            // textBoxalisfiyat
            // 
            textBoxalisfiyat.BackColor = SystemColors.ScrollBar;
            textBoxalisfiyat.BorderStyle = BorderStyle.FixedSingle;
            textBoxalisfiyat.Location = new Point(172, 323);
            textBoxalisfiyat.Name = "textBoxalisfiyat";
            textBoxalisfiyat.Size = new Size(210, 30);
            textBoxalisfiyat.TabIndex = 25;
            // 
            // labelalisfiyat
            // 
            labelalisfiyat.AutoSize = true;
            labelalisfiyat.ForeColor = Color.Maroon;
            labelalisfiyat.Location = new Point(46, 330);
            labelalisfiyat.Name = "labelalisfiyat";
            labelalisfiyat.Size = new Size(101, 23);
            labelalisfiyat.TabIndex = 24;
            labelalisfiyat.Text = " Alış Fiyat:";
            // 
            // comboBoxfirmaisim
            // 
            comboBoxfirmaisim.BackColor = SystemColors.ScrollBar;
            comboBoxfirmaisim.FlatStyle = FlatStyle.Flat;
            comboBoxfirmaisim.FormattingEnabled = true;
            comboBoxfirmaisim.Location = new Point(172, 178);
            comboBoxfirmaisim.Name = "comboBoxfirmaisim";
            comboBoxfirmaisim.Size = new Size(210, 31);
            comboBoxfirmaisim.TabIndex = 23;
            // 
            // labelFirmaisim
            // 
            labelFirmaisim.AutoSize = true;
            labelFirmaisim.ForeColor = Color.Maroon;
            labelFirmaisim.Location = new Point(34, 187);
            labelFirmaisim.Name = "labelFirmaisim";
            labelFirmaisim.Size = new Size(106, 23);
            labelFirmaisim.TabIndex = 22;
            labelFirmaisim.Text = "Firma İsmi:";
            // 
            // textBoxresimyol
            // 
            textBoxresimyol.BackColor = SystemColors.ScrollBar;
            textBoxresimyol.BorderStyle = BorderStyle.FixedSingle;
            textBoxresimyol.Location = new Point(172, 382);
            textBoxresimyol.Name = "textBoxresimyol";
            textBoxresimyol.Size = new Size(210, 30);
            textBoxresimyol.TabIndex = 21;
            // 
            // labelresimyol
            // 
            labelresimyol.AutoSize = true;
            labelresimyol.ForeColor = Color.Maroon;
            labelresimyol.Location = new Point(37, 383);
            labelresimyol.Name = "labelresimyol";
            labelresimyol.Size = new Size(109, 23);
            labelresimyol.TabIndex = 18;
            labelresimyol.Text = "Resim yolu:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 8);
            label6.Name = "label6";
            label6.Size = new Size(171, 23);
            label6.TabIndex = 20;
            label6.Text = "Ürün Giriş Bilgileri";
            // 
            // textBoxsatisfiyat
            // 
            textBoxsatisfiyat.BackColor = SystemColors.ScrollBar;
            textBoxsatisfiyat.BorderStyle = BorderStyle.FixedSingle;
            textBoxsatisfiyat.Location = new Point(172, 273);
            textBoxsatisfiyat.Name = "textBoxsatisfiyat";
            textBoxsatisfiyat.Size = new Size(210, 30);
            textBoxsatisfiyat.TabIndex = 19;
            // 
            // numericUpDownstokmiktar
            // 
            numericUpDownstokmiktar.BackColor = SystemColors.ScrollBar;
            numericUpDownstokmiktar.BorderStyle = BorderStyle.FixedSingle;
            numericUpDownstokmiktar.Location = new Point(172, 227);
            numericUpDownstokmiktar.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDownstokmiktar.Name = "numericUpDownstokmiktar";
            numericUpDownstokmiktar.Size = new Size(212, 30);
            numericUpDownstokmiktar.TabIndex = 18;
            // 
            // comboBoxkategoriism
            // 
            comboBoxkategoriism.BackColor = SystemColors.ScrollBar;
            comboBoxkategoriism.FlatStyle = FlatStyle.Flat;
            comboBoxkategoriism.FormattingEnabled = true;
            comboBoxkategoriism.Location = new Point(172, 124);
            comboBoxkategoriism.Name = "comboBoxkategoriism";
            comboBoxkategoriism.Size = new Size(210, 31);
            comboBoxkategoriism.TabIndex = 16;
            // 
            // textBoxurunad
            // 
            textBoxurunad.BackColor = SystemColors.ScrollBar;
            textBoxurunad.BorderStyle = BorderStyle.FixedSingle;
            textBoxurunad.Location = new Point(172, 70);
            textBoxurunad.Name = "textBoxurunad";
            textBoxurunad.Size = new Size(210, 30);
            textBoxurunad.TabIndex = 15;
            // 
            // labelsatisfiyat
            // 
            labelsatisfiyat.AutoSize = true;
            labelsatisfiyat.ForeColor = Color.Maroon;
            labelsatisfiyat.Location = new Point(37, 280);
            labelsatisfiyat.Name = "labelsatisfiyat";
            labelsatisfiyat.Size = new Size(106, 23);
            labelsatisfiyat.TabIndex = 14;
            labelsatisfiyat.Text = "Satış Fiyat:";
            // 
            // labelstokmiktar
            // 
            labelstokmiktar.AutoSize = true;
            labelstokmiktar.ForeColor = Color.Maroon;
            labelstokmiktar.Location = new Point(25, 234);
            labelstokmiktar.Name = "labelstokmiktar";
            labelstokmiktar.Size = new Size(125, 23);
            labelstokmiktar.TabIndex = 13;
            labelstokmiktar.Text = "Stok Miktarı:";
            // 
            // labelkategoriisim
            // 
            labelkategoriisim.AutoSize = true;
            labelkategoriisim.ForeColor = Color.Maroon;
            labelkategoriisim.Location = new Point(14, 134);
            labelkategoriisim.Name = "labelkategoriisim";
            labelkategoriisim.Size = new Size(131, 23);
            labelkategoriisim.TabIndex = 11;
            labelkategoriisim.Text = "Kategori İsmi:";
            // 
            // labelurunisim
            // 
            labelurunisim.AutoSize = true;
            labelurunisim.ForeColor = Color.Maroon;
            labelurunisim.Location = new Point(55, 77);
            labelurunisim.Name = "labelurunisim";
            labelurunisim.Size = new Size(93, 23);
            labelurunisim.TabIndex = 10;
            labelurunisim.Text = "Ürün Adı:";
            // 
            // pictureBoxurunresim
            // 
            pictureBoxurunresim.BackColor = Color.Transparent;
            pictureBoxurunresim.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxurunresim.Location = new Point(1720, 187);
            pictureBoxurunresim.Name = "pictureBoxurunresim";
            pictureBoxurunresim.Size = new Size(141, 157);
            pictureBoxurunresim.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxurunresim.TabIndex = 16;
            pictureBoxurunresim.TabStop = false;
            // 
            // labelsctiginürün
            // 
            labelsctiginürün.AutoSize = true;
            labelsctiginürün.BackColor = Color.Transparent;
            labelsctiginürün.ForeColor = Color.Maroon;
            labelsctiginürün.Location = new Point(1694, 358);
            labelsctiginürün.Name = "labelsctiginürün";
            labelsctiginürün.Size = new Size(209, 23);
            labelsctiginürün.TabIndex = 17;
            labelsctiginürün.Text = "Seçtiğiniz ürünün resmi";
            // 
            // checkBoxpasif
            // 
            checkBoxpasif.AutoSize = true;
            checkBoxpasif.BackColor = Color.Transparent;
            checkBoxpasif.Location = new Point(1127, 157);
            checkBoxpasif.Name = "checkBoxpasif";
            checkBoxpasif.Size = new Size(86, 27);
            checkBoxpasif.TabIndex = 19;
            checkBoxpasif.Text = "PASİF";
            checkBoxpasif.UseVisualStyleBackColor = false;
            checkBoxpasif.CheckedChanged += checkBoxpasif_CheckedChanged;
            // 
            // checkBoxaktif
            // 
            checkBoxaktif.AutoSize = true;
            checkBoxaktif.BackColor = Color.Transparent;
            checkBoxaktif.Location = new Point(1020, 157);
            checkBoxaktif.Name = "checkBoxaktif";
            checkBoxaktif.Size = new Size(91, 27);
            checkBoxaktif.TabIndex = 20;
            checkBoxaktif.Text = "AKTİF";
            checkBoxaktif.UseVisualStyleBackColor = false;
            checkBoxaktif.CheckedChanged += checkBoxaktif_CheckedChanged_1;
            // 
            // FormUrunler
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1924, 944);
            Controls.Add(checkBoxaktif);
            Controls.Add(checkBoxpasif);
            Controls.Add(labelsctiginürün);
            Controls.Add(pictureBoxurunresim);
            Controls.Add(pictureBoxlogo);
            Controls.Add(buttonekle);
            Controls.Add(buttontemizle);
            Controls.Add(buttonsil);
            Controls.Add(buttonguncelle);
            Controls.Add(textBoxaramacubugu);
            Controls.Add(dataGridViewUrunler);
            Controls.Add(panelurungirisbilgi);
            Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormUrunler";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ürünler Sayfası";
            WindowState = FormWindowState.Maximized;
            Load += FormUrunler_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewUrunler).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxlogo).EndInit();
            panelurungirisbilgi.ResumeLayout(false);
            panelurungirisbilgi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownstokmiktar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxurunresim).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewUrunler;
        private TextBox textBoxaramacubugu;
        private Button buttonguncelle;
        private Button buttonekle;
        private Button buttonsil;
        private Button buttontemizle;
        private PictureBox pictureBoxlogo;
        private Panel panelurungirisbilgi;
        private TextBox textBoxsatisfiyat;
        private NumericUpDown numericUpDownstokmiktar;
        private ComboBox comboBoxkategoriism;
        private TextBox textBoxurunad;
        private Label labelsatisfiyat;
        private Label labelstokmiktar;
        private Label labelkategoriisim;
        private Label labelurunisim;
        private Label label6;
        private PictureBox pictureBoxurunresim;
        private TextBox textBoxresimyol;
        private Label labelresimyol;
        private Label labelsctiginürün;
        private ComboBox comboBoxfirmaisim;
        private Label labelFirmaisim;
        private TextBox textBoxalisfiyat;
        private Label labelalisfiyat;
        private CheckBox checkBoxpasif;
        private CheckBox checkBoxaktif;
    }
}

namespace MarketStokUygulamsı_
{
    partial class FormKategoriler
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKategoriler));
            dataGridViewkategori = new DataGridView();
            pictureBox1 = new PictureBox();
            labelkategoriadi = new Label();
            buttontemizle = new Button();
            buttonguncelle = new Button();
            buttonsil = new Button();
            buttonekle = new Button();
            textBoxkategoriadi = new TextBox();
            textBoxkategoriid = new TextBox();
            panelkategoribilgi = new Panel();
            labelkategorid = new Label();
            labelkategoriaciklama = new Label();
            textBoxkategoriaciklama = new TextBox();
            textBoxkategoriarama = new TextBox();
            labelkategoriarama = new Label();
            labelkategoribilgi = new Label();
            checkBoxpasif = new CheckBox();
            checkBoxaktif = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewkategori).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelkategoribilgi.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewkategori
            // 
            dataGridViewkategori.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dataGridViewCellStyle1.ForeColor = Color.Maroon;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewkategori.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewkategori.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dataGridViewCellStyle2.ForeColor = Color.Maroon;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionForeColor = Color.Gainsboro;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewkategori.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewkategori.GridColor = Color.Maroon;
            dataGridViewkategori.Location = new Point(38, 196);
            dataGridViewkategori.Margin = new Padding(5, 3, 5, 3);
            dataGridViewkategori.Name = "dataGridViewkategori";
            dataGridViewkategori.RowHeadersWidth = 51;
            dataGridViewkategori.Size = new Size(1209, 703);
            dataGridViewkategori.TabIndex = 0;
            dataGridViewkategori.CellClick += dataGridViewkategori_CellClick;
            dataGridViewkategori.CellContentClick += dataGridViewkategori_CellContentClick;
            dataGridViewkategori.CellFormatting += dataGridViewkategori_CellFormatting;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(38, 14);
            pictureBox1.Margin = new Padding(5, 3, 5, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(206, 130);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // labelkategoriadi
            // 
            labelkategoriadi.AutoSize = true;
            labelkategoriadi.ForeColor = Color.Maroon;
            labelkategoriadi.Location = new Point(66, 189);
            labelkategoriadi.Margin = new Padding(5, 0, 5, 0);
            labelkategoriadi.Name = "labelkategoriadi";
            labelkategoriadi.Size = new Size(124, 23);
            labelkategoriadi.TabIndex = 8;
            labelkategoriadi.Text = "Kategori Adı:";
            // 
            // buttontemizle
            // 
            buttontemizle.BackColor = Color.Transparent;
            buttontemizle.BackgroundImage = (Image)resources.GetObject("buttontemizle.BackgroundImage");
            buttontemizle.FlatStyle = FlatStyle.Flat;
            buttontemizle.ForeColor = Color.Maroon;
            buttontemizle.Location = new Point(262, 372);
            buttontemizle.Margin = new Padding(5, 3, 5, 3);
            buttontemizle.Name = "buttontemizle";
            buttontemizle.Size = new Size(194, 44);
            buttontemizle.TabIndex = 6;
            buttontemizle.Text = "TEMİZLE";
            buttontemizle.UseVisualStyleBackColor = false;
            buttontemizle.Click += buttontemizle_Click;
            // 
            // buttonguncelle
            // 
            buttonguncelle.BackColor = Color.Transparent;
            buttonguncelle.BackgroundImage = (Image)resources.GetObject("buttonguncelle.BackgroundImage");
            buttonguncelle.FlatStyle = FlatStyle.Flat;
            buttonguncelle.ForeColor = Color.Maroon;
            buttonguncelle.Location = new Point(72, 372);
            buttonguncelle.Margin = new Padding(5, 3, 5, 3);
            buttonguncelle.Name = "buttonguncelle";
            buttonguncelle.Size = new Size(180, 44);
            buttonguncelle.TabIndex = 5;
            buttonguncelle.Text = "GÜNCELLE";
            buttonguncelle.UseVisualStyleBackColor = false;
            buttonguncelle.Click += buttonguncelle_Click;
            // 
            // buttonsil
            // 
            buttonsil.BackColor = Color.Transparent;
            buttonsil.BackgroundImage = (Image)resources.GetObject("buttonsil.BackgroundImage");
            buttonsil.FlatStyle = FlatStyle.Flat;
            buttonsil.ForeColor = Color.Maroon;
            buttonsil.Location = new Point(262, 308);
            buttonsil.Margin = new Padding(5, 3, 5, 3);
            buttonsil.Name = "buttonsil";
            buttonsil.Size = new Size(194, 44);
            buttonsil.TabIndex = 4;
            buttonsil.Text = "SİL";
            buttonsil.UseVisualStyleBackColor = false;
            buttonsil.Click += buttonsil_Click;
            // 
            // buttonekle
            // 
            buttonekle.BackColor = Color.Transparent;
            buttonekle.BackgroundImage = (Image)resources.GetObject("buttonekle.BackgroundImage");
            buttonekle.FlatStyle = FlatStyle.Flat;
            buttonekle.ForeColor = Color.Maroon;
            buttonekle.Location = new Point(72, 308);
            buttonekle.Margin = new Padding(5, 3, 5, 3);
            buttonekle.Name = "buttonekle";
            buttonekle.Size = new Size(180, 44);
            buttonekle.TabIndex = 3;
            buttonekle.Text = "EKLE";
            buttonekle.UseVisualStyleBackColor = false;
            buttonekle.Click += buttonekle_Click;
            // 
            // textBoxkategoriadi
            // 
            textBoxkategoriadi.BackColor = SystemColors.ScrollBar;
            textBoxkategoriadi.BorderStyle = BorderStyle.FixedSingle;
            textBoxkategoriadi.Location = new Point(208, 182);
            textBoxkategoriadi.Margin = new Padding(5, 3, 5, 3);
            textBoxkategoriadi.Name = "textBoxkategoriadi";
            textBoxkategoriadi.Size = new Size(248, 30);
            textBoxkategoriadi.TabIndex = 1;
            // 
            // textBoxkategoriid
            // 
            textBoxkategoriid.BackColor = SystemColors.ScrollBar;
            textBoxkategoriid.BorderStyle = BorderStyle.FixedSingle;
            textBoxkategoriid.Location = new Point(208, 117);
            textBoxkategoriid.Margin = new Padding(5, 3, 5, 3);
            textBoxkategoriid.Name = "textBoxkategoriid";
            textBoxkategoriid.ReadOnly = true;
            textBoxkategoriid.Size = new Size(248, 30);
            textBoxkategoriid.TabIndex = 0;
            // 
            // panelkategoribilgi
            // 
            panelkategoribilgi.BackColor = Color.Transparent;
            panelkategoribilgi.BorderStyle = BorderStyle.FixedSingle;
            panelkategoribilgi.Controls.Add(labelkategorid);
            panelkategoribilgi.Controls.Add(labelkategoriaciklama);
            panelkategoribilgi.Controls.Add(textBoxkategoriaciklama);
            panelkategoribilgi.Controls.Add(textBoxkategoriarama);
            panelkategoribilgi.Controls.Add(labelkategoriarama);
            panelkategoribilgi.Controls.Add(labelkategoribilgi);
            panelkategoribilgi.Controls.Add(labelkategoriadi);
            panelkategoribilgi.Controls.Add(buttontemizle);
            panelkategoribilgi.Controls.Add(buttonguncelle);
            panelkategoribilgi.Controls.Add(buttonsil);
            panelkategoribilgi.Controls.Add(buttonekle);
            panelkategoribilgi.Controls.Add(textBoxkategoriadi);
            panelkategoribilgi.Controls.Add(textBoxkategoriid);
            panelkategoribilgi.Location = new Point(1312, 196);
            panelkategoribilgi.Margin = new Padding(4, 3, 4, 3);
            panelkategoribilgi.Name = "panelkategoribilgi";
            panelkategoribilgi.Size = new Size(494, 446);
            panelkategoribilgi.TabIndex = 9;
            // 
            // labelkategorid
            // 
            labelkategorid.AutoSize = true;
            labelkategorid.ForeColor = Color.Maroon;
            labelkategorid.Location = new Point(61, 125);
            labelkategorid.Margin = new Padding(5, 0, 5, 0);
            labelkategorid.Name = "labelkategorid";
            labelkategorid.Size = new Size(112, 23);
            labelkategorid.TabIndex = 30;
            labelkategorid.Text = "KategoriID:";
            // 
            // labelkategoriaciklama
            // 
            labelkategoriaciklama.AutoSize = true;
            labelkategoriaciklama.ForeColor = Color.Maroon;
            labelkategoriaciklama.Location = new Point(88, 257);
            labelkategoriaciklama.Margin = new Padding(5, 0, 5, 0);
            labelkategoriaciklama.Name = "labelkategoriaciklama";
            labelkategoriaciklama.Size = new Size(96, 23);
            labelkategoriaciklama.TabIndex = 29;
            labelkategoriaciklama.Text = "Açıklama:\r\n";
            // 
            // textBoxkategoriaciklama
            // 
            textBoxkategoriaciklama.BackColor = SystemColors.ScrollBar;
            textBoxkategoriaciklama.BorderStyle = BorderStyle.FixedSingle;
            textBoxkategoriaciklama.Location = new Point(208, 250);
            textBoxkategoriaciklama.Margin = new Padding(5, 3, 5, 3);
            textBoxkategoriaciklama.Name = "textBoxkategoriaciklama";
            textBoxkategoriaciklama.Size = new Size(248, 30);
            textBoxkategoriaciklama.TabIndex = 28;
            // 
            // textBoxkategoriarama
            // 
            textBoxkategoriarama.BackColor = SystemColors.ScrollBar;
            textBoxkategoriarama.BorderStyle = BorderStyle.FixedSingle;
            textBoxkategoriarama.Location = new Point(208, 54);
            textBoxkategoriarama.Margin = new Padding(4, 3, 4, 3);
            textBoxkategoriarama.Name = "textBoxkategoriarama";
            textBoxkategoriarama.Size = new Size(248, 30);
            textBoxkategoriarama.TabIndex = 27;
            textBoxkategoriarama.TextChanged += textBoxkategoriarama_TextChanged;
            // 
            // labelkategoriarama
            // 
            labelkategoriarama.AutoSize = true;
            labelkategoriarama.ForeColor = Color.Maroon;
            labelkategoriarama.Location = new Point(35, 61);
            labelkategoriarama.Margin = new Padding(4, 0, 4, 0);
            labelkategoriarama.Name = "labelkategoriarama";
            labelkategoriarama.Size = new Size(152, 23);
            labelkategoriarama.TabIndex = 26;
            labelkategoriarama.Text = "Kategori Arama:";
            // 
            // labelkategoribilgi
            // 
            labelkategoribilgi.AutoSize = true;
            labelkategoribilgi.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelkategoribilgi.Location = new Point(4, 10);
            labelkategoribilgi.Margin = new Padding(4, 0, 4, 0);
            labelkategoribilgi.Name = "labelkategoribilgi";
            labelkategoribilgi.Size = new Size(155, 23);
            labelkategoribilgi.TabIndex = 9;
            labelkategoribilgi.Text = "Kategori Bilgileri";
            // 
            // checkBoxpasif
            // 
            checkBoxpasif.AutoSize = true;
            checkBoxpasif.BackColor = Color.Transparent;
            checkBoxpasif.Location = new Point(1161, 163);
            checkBoxpasif.Margin = new Padding(4, 3, 4, 3);
            checkBoxpasif.Name = "checkBoxpasif";
            checkBoxpasif.Size = new Size(86, 27);
            checkBoxpasif.TabIndex = 21;
            checkBoxpasif.Text = "PASİF";
            checkBoxpasif.UseVisualStyleBackColor = false;
            checkBoxpasif.CheckedChanged += checkBoxpasif_CheckedChanged;
            // 
            // checkBoxaktif
            // 
            checkBoxaktif.AutoSize = true;
            checkBoxaktif.BackColor = Color.Transparent;
            checkBoxaktif.Location = new Point(1051, 163);
            checkBoxaktif.Margin = new Padding(4, 3, 4, 3);
            checkBoxaktif.Name = "checkBoxaktif";
            checkBoxaktif.Size = new Size(91, 27);
            checkBoxaktif.TabIndex = 20;
            checkBoxaktif.Text = "AKTİF";
            checkBoxaktif.UseVisualStyleBackColor = false;
            checkBoxaktif.CheckedChanged += checkBoxaktif_CheckedChanged;
            // 
            // FormKategoriler
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1924, 987);
            Controls.Add(checkBoxpasif);
            Controls.Add(checkBoxaktif);
            Controls.Add(panelkategoribilgi);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridViewkategori);
            Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(5, 3, 5, 3);
            Name = "FormKategoriler";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kategoriler Sayfası";
            WindowState = FormWindowState.Maximized;
            Load += FormKategoriler_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewkategori).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelkategoribilgi.ResumeLayout(false);
            panelkategoribilgi.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private DataGridView dataGridViewkategori;
        private PictureBox pictureBox1;
        private Label labelkategoriadi;
        private Label label1;
        private Button buttontemizle;
        private Button buttonguncelle;
        private Button buttonsil;
        private Button buttonekle;
        private TextBox textBoxkategoriadi;
        private TextBox textBoxkategoriid;
        private TextBox textBox1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private Panel panelkategoribilgi;
        private TextBox textBoxkategoriarama;
        private Label labelkategoribilgi;
        private TextBox textBox8;
        private Label labelkategoriarama;
        private Label labelkategoriaciklama;
        private TextBox textBoxkategoriaciklama;
        private Control labelkategoriid;
        private Label labelkategorid;
        private CheckBox checkBoxpasif;
        private CheckBox checkBoxaktif;
    }
}
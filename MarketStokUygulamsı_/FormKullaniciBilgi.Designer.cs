namespace MarketStokUygulamsı_
{
    partial class FormKullaniciBilgi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKullaniciBilgi));
            dataGridViewkullanicibilgi = new DataGridView();
            pictureBox1 = new PictureBox();
            panelkullanicibilgi = new Panel();
            maskedTextBoxtelno = new MaskedTextBox();
            labeltelno = new Label();
            pictureBox2 = new PictureBox();
            labelyetki = new Label();
            labelsifre = new Label();
            labelkullaniciadi = new Label();
            labelsoyadi = new Label();
            labeladi = new Label();
            comboBoxyetki = new ComboBox();
            textBoxsifre = new TextBox();
            textBoxkullaniciadi = new TextBox();
            textBoxsoyadi = new TextBox();
            textBoxadi = new TextBox();
            label1 = new Label();
            buttonekle = new Button();
            buttonguncelle = new Button();
            buttonsil = new Button();
            buttontemizle = new Button();
            checkBoxpasif = new CheckBox();
            checkBoxaktif = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewkullanicibilgi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelkullanicibilgi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewkullanicibilgi
            // 
            dataGridViewkullanicibilgi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dataGridViewCellStyle1.ForeColor = Color.Maroon;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionForeColor = Color.Gainsboro;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridViewkullanicibilgi.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewkullanicibilgi.GridColor = Color.Maroon;
            dataGridViewkullanicibilgi.Location = new Point(32, 202);
            dataGridViewkullanicibilgi.Margin = new Padding(5, 3, 5, 3);
            dataGridViewkullanicibilgi.Name = "dataGridViewkullanicibilgi";
            dataGridViewkullanicibilgi.RowHeadersWidth = 51;
            dataGridViewkullanicibilgi.Size = new Size(1383, 683);
            dataGridViewkullanicibilgi.TabIndex = 0;
            dataGridViewkullanicibilgi.CellClick += dataGridViewkullanicibilgi_CellClick;
            dataGridViewkullanicibilgi.CellFormatting += dataGridViewkullanicibilgi_CellFormatting;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(32, 14);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(160, 148);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panelkullanicibilgi
            // 
            panelkullanicibilgi.BackColor = Color.Transparent;
            panelkullanicibilgi.BorderStyle = BorderStyle.FixedSingle;
            panelkullanicibilgi.Controls.Add(maskedTextBoxtelno);
            panelkullanicibilgi.Controls.Add(labeltelno);
            panelkullanicibilgi.Controls.Add(pictureBox2);
            panelkullanicibilgi.Controls.Add(labelyetki);
            panelkullanicibilgi.Controls.Add(labelsifre);
            panelkullanicibilgi.Controls.Add(labelkullaniciadi);
            panelkullanicibilgi.Controls.Add(labelsoyadi);
            panelkullanicibilgi.Controls.Add(labeladi);
            panelkullanicibilgi.Controls.Add(comboBoxyetki);
            panelkullanicibilgi.Controls.Add(textBoxsifre);
            panelkullanicibilgi.Controls.Add(textBoxkullaniciadi);
            panelkullanicibilgi.Controls.Add(textBoxsoyadi);
            panelkullanicibilgi.Controls.Add(textBoxadi);
            panelkullanicibilgi.Controls.Add(label1);
            panelkullanicibilgi.Location = new Point(1480, 202);
            panelkullanicibilgi.Margin = new Padding(4, 3, 4, 3);
            panelkullanicibilgi.Name = "panelkullanicibilgi";
            panelkullanicibilgi.Size = new Size(387, 393);
            panelkullanicibilgi.TabIndex = 2;
            // 
            // maskedTextBoxtelno
            // 
            maskedTextBoxtelno.BackColor = SystemColors.ScrollBar;
            maskedTextBoxtelno.BorderStyle = BorderStyle.FixedSingle;
            maskedTextBoxtelno.Location = new Point(160, 357);
            maskedTextBoxtelno.Margin = new Padding(4, 3, 4, 3);
            maskedTextBoxtelno.Mask = "(999) 000-0000";
            maskedTextBoxtelno.Name = "maskedTextBoxtelno";
            maskedTextBoxtelno.Size = new Size(193, 30);
            maskedTextBoxtelno.TabIndex = 18;
            // 
            // labeltelno
            // 
            labeltelno.AutoSize = true;
            labeltelno.ForeColor = Color.Maroon;
            labeltelno.Location = new Point(35, 359);
            labeltelno.Margin = new Padding(4, 0, 4, 0);
            labeltelno.Name = "labeltelno";
            labeltelno.Size = new Size(109, 23);
            labeltelno.TabIndex = 17;
            labeltelno.Text = "Telefon No:";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(173, 14);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(37, 27);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // labelyetki
            // 
            labelyetki.AutoSize = true;
            labelyetki.ForeColor = Color.Maroon;
            labelyetki.Location = new Point(90, 312);
            labelyetki.Margin = new Padding(4, 0, 4, 0);
            labelyetki.Name = "labelyetki";
            labelyetki.Size = new Size(61, 23);
            labelyetki.TabIndex = 10;
            labelyetki.Text = "Yetki:";
            // 
            // labelsifre
            // 
            labelsifre.AutoSize = true;
            labelsifre.ForeColor = Color.Maroon;
            labelsifre.Location = new Point(90, 261);
            labelsifre.Margin = new Padding(4, 0, 4, 0);
            labelsifre.Name = "labelsifre";
            labelsifre.Size = new Size(58, 23);
            labelsifre.TabIndex = 9;
            labelsifre.Text = "Şifre:";
            // 
            // labelkullaniciadi
            // 
            labelkullaniciadi.AutoSize = true;
            labelkullaniciadi.ForeColor = Color.Maroon;
            labelkullaniciadi.Location = new Point(14, 207);
            labelkullaniciadi.Margin = new Padding(4, 0, 4, 0);
            labelkullaniciadi.Name = "labelkullaniciadi";
            labelkullaniciadi.Size = new Size(123, 23);
            labelkullaniciadi.TabIndex = 8;
            labelkullaniciadi.Text = "Kullanıcı Adı:";
            // 
            // labelsoyadi
            // 
            labelsoyadi.AutoSize = true;
            labelsoyadi.ForeColor = Color.Maroon;
            labelsoyadi.Location = new Point(73, 152);
            labelsoyadi.Margin = new Padding(4, 0, 4, 0);
            labelsoyadi.Name = "labelsoyadi";
            labelsoyadi.Size = new Size(73, 23);
            labelsoyadi.TabIndex = 7;
            labelsoyadi.Text = "Soyadı:";
            // 
            // labeladi
            // 
            labeladi.AutoSize = true;
            labeladi.BackColor = Color.Transparent;
            labeladi.ForeColor = Color.Maroon;
            labeladi.Location = new Point(102, 84);
            labeladi.Margin = new Padding(4, 0, 4, 0);
            labeladi.Name = "labeladi";
            labeladi.Size = new Size(46, 23);
            labeladi.TabIndex = 6;
            labeladi.Text = "Adı:";
            // 
            // comboBoxyetki
            // 
            comboBoxyetki.BackColor = SystemColors.ScrollBar;
            comboBoxyetki.FlatStyle = FlatStyle.Flat;
            comboBoxyetki.FormattingEnabled = true;
            comboBoxyetki.Items.AddRange(new object[] { "Admin", "Personel" });
            comboBoxyetki.Location = new Point(160, 309);
            comboBoxyetki.Margin = new Padding(4, 3, 4, 3);
            comboBoxyetki.Name = "comboBoxyetki";
            comboBoxyetki.Size = new Size(192, 31);
            comboBoxyetki.TabIndex = 5;
            // 
            // textBoxsifre
            // 
            textBoxsifre.BackColor = SystemColors.ScrollBar;
            textBoxsifre.BorderStyle = BorderStyle.FixedSingle;
            textBoxsifre.Location = new Point(160, 253);
            textBoxsifre.Margin = new Padding(4, 3, 4, 3);
            textBoxsifre.Name = "textBoxsifre";
            textBoxsifre.PasswordChar = '*';
            textBoxsifre.Size = new Size(193, 30);
            textBoxsifre.TabIndex = 4;
            // 
            // textBoxkullaniciadi
            // 
            textBoxkullaniciadi.BackColor = SystemColors.ScrollBar;
            textBoxkullaniciadi.BorderStyle = BorderStyle.FixedSingle;
            textBoxkullaniciadi.Location = new Point(160, 198);
            textBoxkullaniciadi.Margin = new Padding(4, 3, 4, 3);
            textBoxkullaniciadi.Name = "textBoxkullaniciadi";
            textBoxkullaniciadi.Size = new Size(193, 30);
            textBoxkullaniciadi.TabIndex = 3;
            // 
            // textBoxsoyadi
            // 
            textBoxsoyadi.BackColor = SystemColors.ScrollBar;
            textBoxsoyadi.BorderStyle = BorderStyle.FixedSingle;
            textBoxsoyadi.Location = new Point(160, 145);
            textBoxsoyadi.Margin = new Padding(4, 3, 4, 3);
            textBoxsoyadi.Name = "textBoxsoyadi";
            textBoxsoyadi.Size = new Size(193, 30);
            textBoxsoyadi.TabIndex = 2;
            // 
            // textBoxadi
            // 
            textBoxadi.BackColor = SystemColors.ScrollBar;
            textBoxadi.BorderStyle = BorderStyle.FixedSingle;
            textBoxadi.Location = new Point(160, 77);
            textBoxadi.Margin = new Padding(4, 3, 4, 3);
            textBoxadi.Name = "textBoxadi";
            textBoxadi.Size = new Size(193, 30);
            textBoxadi.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 19);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(134, 23);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Kayıt";
            // 
            // buttonekle
            // 
            buttonekle.BackColor = Color.Transparent;
            buttonekle.FlatStyle = FlatStyle.Flat;
            buttonekle.ForeColor = Color.Maroon;
            buttonekle.Location = new Point(1475, 632);
            buttonekle.Margin = new Padding(4, 3, 4, 3);
            buttonekle.Name = "buttonekle";
            buttonekle.Size = new Size(185, 37);
            buttonekle.TabIndex = 3;
            buttonekle.Text = "EKLE";
            buttonekle.UseVisualStyleBackColor = false;
            buttonekle.Click += buttonekle_Click;
            // 
            // buttonguncelle
            // 
            buttonguncelle.BackColor = Color.Transparent;
            buttonguncelle.FlatStyle = FlatStyle.Flat;
            buttonguncelle.ForeColor = Color.Maroon;
            buttonguncelle.Location = new Point(1683, 632);
            buttonguncelle.Margin = new Padding(4, 3, 4, 3);
            buttonguncelle.Name = "buttonguncelle";
            buttonguncelle.Size = new Size(184, 37);
            buttonguncelle.TabIndex = 4;
            buttonguncelle.Text = "GÜNCELLE";
            buttonguncelle.UseVisualStyleBackColor = false;
            buttonguncelle.Click += buttonguncelle_Click;
            // 
            // buttonsil
            // 
            buttonsil.BackColor = Color.Transparent;
            buttonsil.FlatStyle = FlatStyle.Flat;
            buttonsil.ForeColor = Color.Maroon;
            buttonsil.Location = new Point(1475, 694);
            buttonsil.Margin = new Padding(4, 3, 4, 3);
            buttonsil.Name = "buttonsil";
            buttonsil.Size = new Size(185, 35);
            buttonsil.TabIndex = 5;
            buttonsil.Text = "SİL";
            buttonsil.UseVisualStyleBackColor = false;
            buttonsil.Click += buttonsil_Click;
            // 
            // buttontemizle
            // 
            buttontemizle.BackColor = Color.Transparent;
            buttontemizle.FlatStyle = FlatStyle.Flat;
            buttontemizle.ForeColor = Color.Maroon;
            buttontemizle.Location = new Point(1683, 694);
            buttontemizle.Margin = new Padding(4, 3, 4, 3);
            buttontemizle.Name = "buttontemizle";
            buttontemizle.Size = new Size(184, 35);
            buttontemizle.TabIndex = 6;
            buttontemizle.Text = "TEMİZLE";
            buttontemizle.UseVisualStyleBackColor = false;
            buttontemizle.Click += buttontemizle_Click;
            // 
            // checkBoxpasif
            // 
            checkBoxpasif.AutoSize = true;
            checkBoxpasif.BackColor = Color.Transparent;
            checkBoxpasif.Location = new Point(1329, 169);
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
            checkBoxaktif.Location = new Point(1219, 169);
            checkBoxaktif.Margin = new Padding(4, 3, 4, 3);
            checkBoxaktif.Name = "checkBoxaktif";
            checkBoxaktif.Size = new Size(91, 27);
            checkBoxaktif.TabIndex = 20;
            checkBoxaktif.Text = "AKTİF";
            checkBoxaktif.UseVisualStyleBackColor = false;
            checkBoxaktif.CheckedChanged += checkBoxaktif_CheckedChanged;
            // 
            // FormKullaniciBilgi
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1924, 981);
            Controls.Add(checkBoxpasif);
            Controls.Add(checkBoxaktif);
            Controls.Add(buttontemizle);
            Controls.Add(buttonsil);
            Controls.Add(buttonguncelle);
            Controls.Add(buttonekle);
            Controls.Add(panelkullanicibilgi);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridViewkullanicibilgi);
            Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(5, 3, 5, 3);
            Name = "FormKullaniciBilgi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kullanıcı Bilgileri Sayfası";
            WindowState = FormWindowState.Maximized;
            Load += FormKullaniciBilgi_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewkullanicibilgi).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelkullanicibilgi.ResumeLayout(false);
            panelkullanicibilgi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewkullanicibilgi;
        private PictureBox pictureBox1;
        private Panel panelkullanicibilgi;
        private Label label1;
        private TextBox textBoxadi;
        private Label labelyetki;
        private Label labelsifre;
        private Label labelkullaniciadi;
        private Label labelsoyadi;
        private Label labeladi;
        private ComboBox comboBoxyetki;
        private TextBox textBoxsifre;
        private TextBox textBoxkullaniciadi;
        private TextBox textBoxsoyadi;
        private Button buttonekle;
        private Button buttonguncelle;
        private Button buttonsil;
        private Button buttontemizle;
        private PictureBox pictureBox2;
        private MaskedTextBox maskedTextBoxtelno;
        private Label labeltelno;
        private CheckBox checkBoxpasif;
        private CheckBox checkBoxaktif;
    }
}
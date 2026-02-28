namespace MarketStokUygulamsı_
{
    partial class FormAlis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlis));
            dataGridViewalis = new DataGridView();
            panelalisislem = new Panel();
            buttonsepetekle = new Button();
            labelstokhareket = new Label();
            comboBoxstokhareket = new ComboBox();
            textBoxtedarikci = new TextBox();
            labeltedarikci = new Label();
            numericUpDownmiktar = new NumericUpDown();
            textBoxalisfiyat = new TextBox();
            textBoxurunad = new TextBox();
            buttontemizle = new Button();
            labelmiktar = new Label();
            labelalisfiyat = new Label();
            labelurunad = new Label();
            labelalisislem = new Label();
            textBoxurunara = new TextBox();
            labelurunara = new Label();
            pictureBox1 = new PictureBox();
            panelalissepet = new Panel();
            buttonsepettensil = new Button();
            buttontedarikcidenal = new Button();
            labelalisepet = new Label();
            listBoxalissepet = new ListBox();
            textBoxtoplamtutar = new TextBox();
            labeltoplamtutar = new Label();
            pictureBoxurunresimi = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewalis).BeginInit();
            panelalisislem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownmiktar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelalissepet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxurunresimi).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewalis
            // 
            dataGridViewalis.BackgroundColor = SystemColors.ControlDarkDark;
            dataGridViewalis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dataGridViewCellStyle1.ForeColor = Color.Maroon;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionForeColor = Color.Gainsboro;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridViewalis.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewalis.GridColor = Color.Maroon;
            dataGridViewalis.Location = new Point(14, 167);
            dataGridViewalis.Margin = new Padding(5, 3, 5, 3);
            dataGridViewalis.Name = "dataGridViewalis";
            dataGridViewalis.RowHeadersWidth = 51;
            dataGridViewalis.Size = new Size(1852, 433);
            dataGridViewalis.TabIndex = 0;
            dataGridViewalis.CellClick += dataGridViewalis_CellClick;
            // 
            // panelalisislem
            // 
            panelalisislem.BackColor = Color.Transparent;
            panelalisislem.BorderStyle = BorderStyle.FixedSingle;
            panelalisislem.Controls.Add(buttonsepetekle);
            panelalisislem.Controls.Add(labelstokhareket);
            panelalisislem.Controls.Add(comboBoxstokhareket);
            panelalisislem.Controls.Add(textBoxtedarikci);
            panelalisislem.Controls.Add(labeltedarikci);
            panelalisislem.Controls.Add(numericUpDownmiktar);
            panelalisislem.Controls.Add(textBoxalisfiyat);
            panelalisislem.Controls.Add(textBoxurunad);
            panelalisislem.Controls.Add(buttontemizle);
            panelalisislem.Controls.Add(labelmiktar);
            panelalisislem.Controls.Add(labelalisfiyat);
            panelalisislem.Controls.Add(labelurunad);
            panelalisislem.Controls.Add(labelalisislem);
            panelalisislem.Location = new Point(73, 635);
            panelalisislem.Margin = new Padding(4, 3, 4, 3);
            panelalisislem.Name = "panelalisislem";
            panelalisislem.Size = new Size(438, 342);
            panelalisislem.TabIndex = 3;
            // 
            // buttonsepetekle
            // 
            buttonsepetekle.FlatStyle = FlatStyle.Flat;
            buttonsepetekle.ForeColor = Color.Maroon;
            buttonsepetekle.Location = new Point(24, 290);
            buttonsepetekle.Margin = new Padding(4, 3, 4, 3);
            buttonsepetekle.Name = "buttonsepetekle";
            buttonsepetekle.Size = new Size(174, 33);
            buttonsepetekle.TabIndex = 35;
            buttonsepetekle.Text = "SEPETE EKLE";
            buttonsepetekle.UseVisualStyleBackColor = true;
            buttonsepetekle.Click += buttonsepetekle_Click;
            // 
            // labelstokhareket
            // 
            labelstokhareket.AutoSize = true;
            labelstokhareket.ForeColor = Color.Maroon;
            labelstokhareket.Location = new Point(38, 187);
            labelstokhareket.Margin = new Padding(4, 0, 4, 0);
            labelstokhareket.Name = "labelstokhareket";
            labelstokhareket.Size = new Size(137, 23);
            labelstokhareket.TabIndex = 34;
            labelstokhareket.Text = "Stok Hareketi:";
            // 
            // comboBoxstokhareket
            // 
            comboBoxstokhareket.BackColor = SystemColors.ScrollBar;
            comboBoxstokhareket.FlatStyle = FlatStyle.Flat;
            comboBoxstokhareket.FormattingEnabled = true;
            comboBoxstokhareket.Items.AddRange(new object[] { "Ürün Alış", "Ürün Satış" });
            comboBoxstokhareket.Location = new Point(189, 178);
            comboBoxstokhareket.Margin = new Padding(4, 3, 4, 3);
            comboBoxstokhareket.Name = "comboBoxstokhareket";
            comboBoxstokhareket.Size = new Size(194, 31);
            comboBoxstokhareket.TabIndex = 33;
            // 
            // textBoxtedarikci
            // 
            textBoxtedarikci.BackColor = SystemColors.ScrollBar;
            textBoxtedarikci.BorderStyle = BorderStyle.FixedSingle;
            textBoxtedarikci.Location = new Point(191, 227);
            textBoxtedarikci.Margin = new Padding(4, 3, 4, 3);
            textBoxtedarikci.Name = "textBoxtedarikci";
            textBoxtedarikci.Size = new Size(193, 30);
            textBoxtedarikci.TabIndex = 32;
            // 
            // labeltedarikci
            // 
            labeltedarikci.AutoSize = true;
            labeltedarikci.ForeColor = Color.Maroon;
            labeltedarikci.Location = new Point(79, 234);
            labeltedarikci.Margin = new Padding(4, 0, 4, 0);
            labeltedarikci.Name = "labeltedarikci";
            labeltedarikci.Size = new Size(96, 23);
            labeltedarikci.TabIndex = 31;
            labeltedarikci.Text = "Tedarikçi:";
            // 
            // numericUpDownmiktar
            // 
            numericUpDownmiktar.BackColor = SystemColors.ScrollBar;
            numericUpDownmiktar.BorderStyle = BorderStyle.FixedSingle;
            numericUpDownmiktar.Location = new Point(189, 127);
            numericUpDownmiktar.Margin = new Padding(4, 3, 4, 3);
            numericUpDownmiktar.Name = "numericUpDownmiktar";
            numericUpDownmiktar.Size = new Size(194, 30);
            numericUpDownmiktar.TabIndex = 29;
            // 
            // textBoxalisfiyat
            // 
            textBoxalisfiyat.BackColor = SystemColors.ScrollBar;
            textBoxalisfiyat.BorderStyle = BorderStyle.FixedSingle;
            textBoxalisfiyat.Location = new Point(191, 81);
            textBoxalisfiyat.Margin = new Padding(4, 3, 4, 3);
            textBoxalisfiyat.Name = "textBoxalisfiyat";
            textBoxalisfiyat.Size = new Size(193, 30);
            textBoxalisfiyat.TabIndex = 27;
            // 
            // textBoxurunad
            // 
            textBoxurunad.BackColor = SystemColors.ScrollBar;
            textBoxurunad.BorderStyle = BorderStyle.FixedSingle;
            textBoxurunad.Location = new Point(189, 35);
            textBoxurunad.Margin = new Padding(4, 3, 4, 3);
            textBoxurunad.Name = "textBoxurunad";
            textBoxurunad.Size = new Size(194, 30);
            textBoxurunad.TabIndex = 26;
            // 
            // buttontemizle
            // 
            buttontemizle.FlatStyle = FlatStyle.Flat;
            buttontemizle.ForeColor = Color.Maroon;
            buttontemizle.Location = new Point(230, 290);
            buttontemizle.Margin = new Padding(4, 3, 4, 3);
            buttontemizle.Name = "buttontemizle";
            buttontemizle.Size = new Size(154, 33);
            buttontemizle.TabIndex = 23;
            buttontemizle.Text = "TEMİZLE";
            buttontemizle.UseVisualStyleBackColor = true;
            // 
            // labelmiktar
            // 
            labelmiktar.AutoSize = true;
            labelmiktar.ForeColor = Color.Maroon;
            labelmiktar.Location = new Point(101, 135);
            labelmiktar.Margin = new Padding(4, 0, 4, 0);
            labelmiktar.Name = "labelmiktar";
            labelmiktar.Size = new Size(76, 23);
            labelmiktar.TabIndex = 19;
            labelmiktar.Text = "Miktar:";
            // 
            // labelalisfiyat
            // 
            labelalisfiyat.AutoSize = true;
            labelalisfiyat.ForeColor = Color.Maroon;
            labelalisfiyat.Location = new Point(73, 89);
            labelalisfiyat.Margin = new Padding(4, 0, 4, 0);
            labelalisfiyat.Name = "labelalisfiyat";
            labelalisfiyat.Size = new Size(99, 23);
            labelalisfiyat.TabIndex = 18;
            labelalisfiyat.Text = "Alış-Fiyat:";
            // 
            // labelurunad
            // 
            labelurunad.AutoSize = true;
            labelurunad.ForeColor = Color.Maroon;
            labelurunad.Location = new Point(79, 43);
            labelurunad.Margin = new Padding(4, 0, 4, 0);
            labelurunad.Name = "labelurunad";
            labelurunad.Size = new Size(93, 23);
            labelurunad.TabIndex = 17;
            labelurunad.Text = "Ürün Adı:";
            // 
            // labelalisislem
            // 
            labelalisislem.AutoSize = true;
            labelalisislem.Location = new Point(4, 16);
            labelalisislem.Margin = new Padding(4, 0, 4, 0);
            labelalisislem.Name = "labelalisislem";
            labelalisislem.Size = new Size(120, 23);
            labelalisislem.TabIndex = 1;
            labelalisislem.Text = "Alış İşlemleri";
            // 
            // textBoxurunara
            // 
            textBoxurunara.BackColor = SystemColors.ScrollBar;
            textBoxurunara.BorderStyle = BorderStyle.FixedSingle;
            textBoxurunara.Location = new Point(176, 131);
            textBoxurunara.Margin = new Padding(4, 3, 4, 3);
            textBoxurunara.Name = "textBoxurunara";
            textBoxurunara.Size = new Size(584, 30);
            textBoxurunara.TabIndex = 25;
            textBoxurunara.TextChanged += textBoxurunara_TextChanged;
            // 
            // labelurunara
            // 
            labelurunara.AutoSize = true;
            labelurunara.BackColor = Color.Transparent;
            labelurunara.ForeColor = Color.Maroon;
            labelurunara.Location = new Point(34, 139);
            labelurunara.Margin = new Padding(4, 0, 4, 0);
            labelurunara.Name = "labelurunara";
            labelurunara.Size = new Size(121, 23);
            labelurunara.TabIndex = 16;
            labelurunara.Text = "Ürün Arama:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(14, 10);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(142, 108);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // panelalissepet
            // 
            panelalissepet.BackColor = Color.Transparent;
            panelalissepet.BorderStyle = BorderStyle.FixedSingle;
            panelalissepet.Controls.Add(buttonsepettensil);
            panelalissepet.Controls.Add(buttontedarikcidenal);
            panelalissepet.Controls.Add(labelalisepet);
            panelalissepet.Controls.Add(listBoxalissepet);
            panelalissepet.Controls.Add(textBoxtoplamtutar);
            panelalissepet.Controls.Add(labeltoplamtutar);
            panelalissepet.Location = new Point(800, 635);
            panelalissepet.Margin = new Padding(4, 3, 4, 3);
            panelalissepet.Name = "panelalissepet";
            panelalissepet.Size = new Size(615, 342);
            panelalissepet.TabIndex = 25;
            // 
            // buttonsepettensil
            // 
            buttonsepettensil.FlatStyle = FlatStyle.Flat;
            buttonsepettensil.ForeColor = Color.Maroon;
            buttonsepettensil.Location = new Point(313, 276);
            buttonsepettensil.Margin = new Padding(5, 3, 5, 3);
            buttonsepettensil.Name = "buttonsepettensil";
            buttonsepettensil.Size = new Size(258, 34);
            buttonsepettensil.TabIndex = 20;
            buttonsepettensil.Text = "SEPETTEN ÜRÜN SİL";
            buttonsepettensil.UseVisualStyleBackColor = true;
            buttonsepettensil.Click += buttonsepettensil_Click;
            // 
            // buttontedarikcidenal
            // 
            buttontedarikcidenal.FlatStyle = FlatStyle.Flat;
            buttontedarikcidenal.ForeColor = Color.Maroon;
            buttontedarikcidenal.Location = new Point(46, 276);
            buttontedarikcidenal.Margin = new Padding(5, 3, 5, 3);
            buttontedarikcidenal.Name = "buttontedarikcidenal";
            buttontedarikcidenal.Size = new Size(246, 34);
            buttontedarikcidenal.TabIndex = 19;
            buttontedarikcidenal.Text = "TEDARİKÇİDEN AL";
            buttontedarikcidenal.UseVisualStyleBackColor = true;
            buttontedarikcidenal.Click += buttontedarikcidenal_Click;
            // 
            // labelalisepet
            // 
            labelalisepet.AutoSize = true;
            labelalisepet.Location = new Point(5, 0);
            labelalisepet.Margin = new Padding(5, 0, 5, 0);
            labelalisepet.Name = "labelalisepet";
            labelalisepet.Size = new Size(97, 23);
            labelalisepet.TabIndex = 19;
            labelalisepet.Text = "Alış-Sepet";
            // 
            // listBoxalissepet
            // 
            listBoxalissepet.BackColor = SystemColors.ScrollBar;
            listBoxalissepet.BorderStyle = BorderStyle.FixedSingle;
            listBoxalissepet.FormattingEnabled = true;
            listBoxalissepet.ItemHeight = 23;
            listBoxalissepet.Location = new Point(35, 51);
            listBoxalissepet.Margin = new Padding(4, 3, 4, 3);
            listBoxalissepet.Name = "listBoxalissepet";
            listBoxalissepet.Size = new Size(536, 163);
            listBoxalissepet.TabIndex = 0;
            // 
            // textBoxtoplamtutar
            // 
            textBoxtoplamtutar.BackColor = SystemColors.ScrollBar;
            textBoxtoplamtutar.BorderStyle = BorderStyle.FixedSingle;
            textBoxtoplamtutar.Location = new Point(390, 228);
            textBoxtoplamtutar.Margin = new Padding(5, 3, 5, 3);
            textBoxtoplamtutar.Name = "textBoxtoplamtutar";
            textBoxtoplamtutar.Size = new Size(181, 30);
            textBoxtoplamtutar.TabIndex = 13;
            // 
            // labeltoplamtutar
            // 
            labeltoplamtutar.AutoSize = true;
            labeltoplamtutar.ForeColor = Color.Maroon;
            labeltoplamtutar.Location = new Point(239, 235);
            labeltoplamtutar.Margin = new Padding(5, 0, 5, 0);
            labeltoplamtutar.Name = "labeltoplamtutar";
            labeltoplamtutar.Size = new Size(129, 23);
            labeltoplamtutar.TabIndex = 5;
            labeltoplamtutar.Text = "Toplam Tutar:";
            // 
            // pictureBoxurunresimi
            // 
            pictureBoxurunresimi.BackColor = Color.Transparent;
            pictureBoxurunresimi.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxurunresimi.Location = new Point(533, 635);
            pictureBoxurunresimi.Margin = new Padding(4, 3, 4, 3);
            pictureBoxurunresimi.Name = "pictureBoxurunresimi";
            pictureBoxurunresimi.Size = new Size(157, 159);
            pictureBoxurunresimi.TabIndex = 26;
            pictureBoxurunresimi.TabStop = false;
            // 
            // FormAlis
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1924, 1055);
            Controls.Add(pictureBoxurunresimi);
            Controls.Add(panelalissepet);
            Controls.Add(pictureBox1);
            Controls.Add(panelalisislem);
            Controls.Add(dataGridViewalis);
            Controls.Add(textBoxurunara);
            Controls.Add(labelurunara);
            Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(5, 3, 5, 3);
            Name = "FormAlis";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alış İşlemleri";
            WindowState = FormWindowState.Maximized;
            Load += FormAlis_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewalis).EndInit();
            panelalisislem.ResumeLayout(false);
            panelalisislem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownmiktar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelalissepet.ResumeLayout(false);
            panelalissepet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxurunresimi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewalis;
        private Panel panelalisislem;
        private Label labelalisislem;
        private TextBox textBoxtedarikci;
        private Label labeltedarikci;
        private NumericUpDown numericUpDownmiktar;
        private TextBox textBoxalisfiyat;
        private TextBox textBoxurunad;
        private TextBox textBoxurunara;
        private Button buttontemizle;
        private Label labelmiktar;
        private Label labelalisfiyat;
        private Label labelurunad;
        private Label labelurunara;
        private PictureBox pictureBox1;
        private Panel panelalissepet;
        private Button buttonsepettensil;
        private Button buttontedarikcidenal;
        private Label labelalisepet;
        private ListBox listBoxalissepet;
        private TextBox textBoxtoplamtutar;
        private Label labeltoplamtutar;
        private Label labelstokhareket;
        private ComboBox comboBoxstokhareket;
        private PictureBox pictureBoxurunresimi;
        private Button buttonsepetekle;
    }
}
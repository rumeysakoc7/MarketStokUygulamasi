namespace MarketStokUygulamsı_
{
    partial class FormStokHareketleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStokHareketleri));
            dataGridViewstokhareket = new DataGridView();
            pictureBox1 = new PictureBox();
            labelstokhareketleri = new Label();
            textBoxurunad = new TextBox();
            labelurunad = new Label();
            dateTimePicker1 = new DateTimePicker();
            labelstokhareket = new Label();
            comboBoxstokhareket = new ComboBox();
            textBoxkullaniciad = new TextBox();
            labelkullaniciad = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewstokhareket).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewstokhareket
            // 
            dataGridViewstokhareket.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewstokhareket.Location = new Point(36, 292);
            dataGridViewstokhareket.Margin = new Padding(4, 3, 4, 3);
            dataGridViewstokhareket.Name = "dataGridViewstokhareket";
            dataGridViewstokhareket.RowHeadersWidth = 51;
            dataGridViewstokhareket.Size = new Size(1762, 586);
            dataGridViewstokhareket.TabIndex = 0;
            dataGridViewstokhareket.CellContentClick += dataGridViewstokhareket_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(14, 17);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 136);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // labelstokhareketleri
            // 
            labelstokhareketleri.AutoSize = true;
            labelstokhareketleri.BackColor = Color.Transparent;
            labelstokhareketleri.ForeColor = Color.Maroon;
            labelstokhareketleri.Location = new Point(36, 254);
            labelstokhareketleri.Margin = new Padding(4, 0, 4, 0);
            labelstokhareketleri.Name = "labelstokhareketleri";
            labelstokhareketleri.Size = new Size(212, 23);
            labelstokhareketleri.TabIndex = 11;
            labelstokhareketleri.Text = "STOK HAREKETLERİ";
            // 
            // textBoxurunad
            // 
            textBoxurunad.BackColor = SystemColors.ScrollBar;
            textBoxurunad.BorderStyle = BorderStyle.FixedSingle;
            textBoxurunad.Location = new Point(148, 202);
            textBoxurunad.Margin = new Padding(4, 3, 4, 3);
            textBoxurunad.Name = "textBoxurunad";
            textBoxurunad.Size = new Size(194, 30);
            textBoxurunad.TabIndex = 6;
            textBoxurunad.TextChanged += textBox1_TextChanged;
            // 
            // labelurunad
            // 
            labelurunad.AutoSize = true;
            labelurunad.BackColor = Color.Transparent;
            labelurunad.ForeColor = Color.Maroon;
            labelurunad.Location = new Point(36, 210);
            labelurunad.Margin = new Padding(4, 0, 4, 0);
            labelurunad.Name = "labelurunad";
            labelurunad.Size = new Size(93, 23);
            labelurunad.TabIndex = 1;
            labelurunad.Text = "Ürün Adı:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(1168, 202);
            dateTimePicker1.Margin = new Padding(4, 3, 4, 3);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(306, 30);
            dateTimePicker1.TabIndex = 16;
            // 
            // labelstokhareket
            // 
            labelstokhareket.AutoSize = true;
            labelstokhareket.BackColor = Color.Transparent;
            labelstokhareket.ForeColor = Color.Maroon;
            labelstokhareket.Location = new Point(747, 205);
            labelstokhareket.Margin = new Padding(4, 0, 4, 0);
            labelstokhareket.Name = "labelstokhareket";
            labelstokhareket.Size = new Size(137, 23);
            labelstokhareket.TabIndex = 36;
            labelstokhareket.Text = "Stok Hareketi:";
            // 
            // comboBoxstokhareket
            // 
            comboBoxstokhareket.BackColor = SystemColors.ScrollBar;
            comboBoxstokhareket.FlatStyle = FlatStyle.Flat;
            comboBoxstokhareket.FormattingEnabled = true;
            comboBoxstokhareket.Items.AddRange(new object[] { "Hepsi", "Ürün Alış", "Ürün Satış" });
            comboBoxstokhareket.Location = new Point(889, 202);
            comboBoxstokhareket.Margin = new Padding(4, 3, 4, 3);
            comboBoxstokhareket.Name = "comboBoxstokhareket";
            comboBoxstokhareket.Size = new Size(234, 31);
            comboBoxstokhareket.TabIndex = 35;
            // 
            // textBoxkullaniciad
            // 
            textBoxkullaniciad.BackColor = SystemColors.ScrollBar;
            textBoxkullaniciad.BorderStyle = BorderStyle.FixedSingle;
            textBoxkullaniciad.Location = new Point(512, 202);
            textBoxkullaniciad.Margin = new Padding(4, 3, 4, 3);
            textBoxkullaniciad.Name = "textBoxkullaniciad";
            textBoxkullaniciad.Size = new Size(194, 30);
            textBoxkullaniciad.TabIndex = 38;
            // 
            // labelkullaniciad
            // 
            labelkullaniciad.AutoSize = true;
            labelkullaniciad.BackColor = Color.Transparent;
            labelkullaniciad.ForeColor = Color.Maroon;
            labelkullaniciad.Location = new Point(374, 210);
            labelkullaniciad.Margin = new Padding(4, 0, 4, 0);
            labelkullaniciad.Name = "labelkullaniciad";
            labelkullaniciad.Size = new Size(123, 23);
            labelkullaniciad.TabIndex = 37;
            labelkullaniciad.Text = "Kullanıcı Adı:";
            // 
            // FormStokHareketleri
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1924, 965);
            Controls.Add(textBoxkullaniciad);
            Controls.Add(labelkullaniciad);
            Controls.Add(labelstokhareket);
            Controls.Add(comboBoxstokhareket);
            Controls.Add(dateTimePicker1);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridViewstokhareket);
            Controls.Add(textBoxurunad);
            Controls.Add(labelstokhareketleri);
            Controls.Add(labelurunad);
            Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(5, 3, 5, 3);
            Name = "FormStokHareketleri";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormStokHareketleri";
            WindowState = FormWindowState.Maximized;
            Load += FormStokHareketleri_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewstokhareket).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewstokhareket;
        private PictureBox pictureBox1;
        private TextBox textBoxurunad;
        private Label labelurunad;
        private Label labelstokhareketleri;
        private DateTimePicker dateTimePicker1;
        private Label labelstokhareket;
        private ComboBox comboBoxstokhareket;
        private TextBox textBoxkullaniciad;
        private Label labelkullaniciad;
    }
}
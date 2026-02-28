namespace MarketStokUygulamsı_
{
    partial class FormSatisDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSatisDetay));
            labelurunad = new Label();
            labelsatisdetay = new Label();
            textBoxurunara = new TextBox();
            dataGridViewsatisdetay = new DataGridView();
            pictureBox1 = new PictureBox();
            dateTimePicker1 = new DateTimePicker();
            textBoxmusteriara = new TextBox();
            labelmusteri = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewsatisdetay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelurunad
            // 
            labelurunad.AutoSize = true;
            labelurunad.BackColor = Color.Transparent;
            labelurunad.ForeColor = Color.Maroon;
            labelurunad.Location = new Point(78, 213);
            labelurunad.Margin = new Padding(4, 0, 4, 0);
            labelurunad.Name = "labelurunad";
            labelurunad.Size = new Size(93, 23);
            labelurunad.TabIndex = 41;
            labelurunad.Text = "Ürün Adı:";
            // 
            // labelsatisdetay
            // 
            labelsatisdetay.AutoSize = true;
            labelsatisdetay.BackColor = Color.Transparent;
            labelsatisdetay.ForeColor = Color.Maroon;
            labelsatisdetay.Location = new Point(74, 254);
            labelsatisdetay.Margin = new Padding(4, 0, 4, 0);
            labelsatisdetay.Name = "labelsatisdetay";
            labelsatisdetay.Size = new Size(182, 23);
            labelsatisdetay.TabIndex = 43;
            labelsatisdetay.Text = "SATIŞ DETAYLARI";
            // 
            // textBoxurunara
            // 
            textBoxurunara.BackColor = SystemColors.ScrollBar;
            textBoxurunara.BorderStyle = BorderStyle.FixedSingle;
            textBoxurunara.Location = new Point(190, 205);
            textBoxurunara.Margin = new Padding(4, 3, 4, 3);
            textBoxurunara.Name = "textBoxurunara";
            textBoxurunara.Size = new Size(342, 30);
            textBoxurunara.TabIndex = 42;
            textBoxurunara.TextChanged += textBoxurunara_TextChanged;
            // 
            // dataGridViewsatisdetay
            // 
            dataGridViewsatisdetay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewsatisdetay.Location = new Point(71, 289);
            dataGridViewsatisdetay.Margin = new Padding(4, 3, 4, 3);
            dataGridViewsatisdetay.Name = "dataGridViewsatisdetay";
            dataGridViewsatisdetay.RowHeadersWidth = 51;
            dataGridViewsatisdetay.Size = new Size(1744, 659);
            dataGridViewsatisdetay.TabIndex = 39;
            dataGridViewsatisdetay.CellClick += dataGridViewsatisdetay_CellClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(30, 14);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 136);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 40;
            pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(1145, 196);
            dateTimePicker1.Margin = new Padding(4, 3, 4, 3);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(306, 30);
            dateTimePicker1.TabIndex = 44;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // textBoxmusteriara
            // 
            textBoxmusteriara.BackColor = SystemColors.ScrollBar;
            textBoxmusteriara.BorderStyle = BorderStyle.FixedSingle;
            textBoxmusteriara.Location = new Point(710, 199);
            textBoxmusteriara.Margin = new Padding(4, 3, 4, 3);
            textBoxmusteriara.Name = "textBoxmusteriara";
            textBoxmusteriara.Size = new Size(361, 30);
            textBoxmusteriara.TabIndex = 49;
            textBoxmusteriara.TextChanged += textBoxmusteriara_TextChanged;
            // 
            // labelmusteri
            // 
            labelmusteri.AutoSize = true;
            labelmusteri.BackColor = Color.Transparent;
            labelmusteri.ForeColor = Color.Maroon;
            labelmusteri.Location = new Point(572, 207);
            labelmusteri.Margin = new Padding(4, 0, 4, 0);
            labelmusteri.Name = "labelmusteri";
            labelmusteri.Size = new Size(120, 23);
            labelmusteri.TabIndex = 48;
            labelmusteri.Text = "Müşteri Ara:";
            // 
            // FormSatisDetay
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1924, 1055);
            Controls.Add(textBoxmusteriara);
            Controls.Add(labelmusteri);
            Controls.Add(dateTimePicker1);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridViewsatisdetay);
            Controls.Add(textBoxurunara);
            Controls.Add(labelsatisdetay);
            Controls.Add(labelurunad);
            Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Margin = new Padding(5, 3, 5, 3);
            Name = "FormSatisDetay";
            Text = "FormSiparisDetay";
            WindowState = FormWindowState.Maximized;
            Load += FormSatisDetay_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewsatisdetay).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelurunad;
        private Label labelsatisdetay;
        private TextBox textBoxurunara;
        private DataGridView dataGridViewsatisdetay;
        private PictureBox pictureBox1;
        private DateTimePicker dateTimePicker1;
        private TextBox textBoxmusteriara;
        private Label labelmusteri;
    }
}
namespace MarketStokUygulamsı_
{
    partial class FormMusteriBilgi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMusteriBilgi));
            dataGridViewmusteri = new DataGridView();
            panelmusteribilgi = new Panel();
            pictureBoxmusteri = new PictureBox();
            buttontemizle = new Button();
            buttonguncelle = new Button();
            buttonsil = new Button();
            buttonekle = new Button();
            labelmusteritelno = new Label();
            maskedTextBoxtelno = new MaskedTextBox();
            labelmusterisoyad = new Label();
            textBoxmusterisoyad = new TextBox();
            labelmusteriad = new Label();
            textBoxmusteriad = new TextBox();
            pictureBox1 = new PictureBox();
            textBoxmusteriarama = new TextBox();
            labelmusteriarama = new Label();
            checkBoxpasif = new CheckBox();
            checkBoxaktif = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewmusteri).BeginInit();
            panelmusteribilgi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxmusteri).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewmusteri
            // 
            dataGridViewmusteri.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dataGridViewCellStyle1.ForeColor = Color.Maroon;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ScrollBar;
            dataGridViewCellStyle1.SelectionForeColor = Color.Gainsboro;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridViewmusteri.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewmusteri.Location = new Point(26, 182);
            dataGridViewmusteri.Margin = new Padding(5, 3, 5, 3);
            dataGridViewmusteri.Name = "dataGridViewmusteri";
            dataGridViewmusteri.RowHeadersWidth = 51;
            dataGridViewmusteri.Size = new Size(1142, 690);
            dataGridViewmusteri.TabIndex = 0;
            dataGridViewmusteri.CellClick += dataGridViewmusteri_CellClick;
            dataGridViewmusteri.CellContentClick += dataGridViewmusteri_CellContentClick;
            dataGridViewmusteri.CellFormatting += dataGridViewmusteri_CellFormatting;
            dataGridViewmusteri.SelectionChanged += dataGridViewmusteri_SelectionChanged;
            // 
            // panelmusteribilgi
            // 
            panelmusteribilgi.BackColor = Color.Transparent;
            panelmusteribilgi.BorderStyle = BorderStyle.FixedSingle;
            panelmusteribilgi.Controls.Add(pictureBoxmusteri);
            panelmusteribilgi.Controls.Add(buttontemizle);
            panelmusteribilgi.Controls.Add(buttonguncelle);
            panelmusteribilgi.Controls.Add(buttonsil);
            panelmusteribilgi.Controls.Add(buttonekle);
            panelmusteribilgi.Controls.Add(labelmusteritelno);
            panelmusteribilgi.Controls.Add(maskedTextBoxtelno);
            panelmusteribilgi.Controls.Add(labelmusterisoyad);
            panelmusteribilgi.Controls.Add(textBoxmusterisoyad);
            panelmusteribilgi.Controls.Add(labelmusteriad);
            panelmusteribilgi.Controls.Add(textBoxmusteriad);
            panelmusteribilgi.Location = new Point(1217, 182);
            panelmusteribilgi.Margin = new Padding(5, 3, 5, 3);
            panelmusteribilgi.Name = "panelmusteribilgi";
            panelmusteribilgi.Size = new Size(507, 514);
            panelmusteribilgi.TabIndex = 1;
            // 
            // pictureBoxmusteri
            // 
            pictureBoxmusteri.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxmusteri.Image = (Image)resources.GetObject("pictureBoxmusteri.Image");
            pictureBoxmusteri.Location = new Point(187, 36);
            pictureBoxmusteri.Margin = new Padding(4, 3, 4, 3);
            pictureBoxmusteri.Name = "pictureBoxmusteri";
            pictureBoxmusteri.Size = new Size(160, 135);
            pictureBoxmusteri.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxmusteri.TabIndex = 10;
            pictureBoxmusteri.TabStop = false;
            // 
            // buttontemizle
            // 
            buttontemizle.FlatStyle = FlatStyle.Flat;
            buttontemizle.ForeColor = Color.Maroon;
            buttontemizle.Location = new Point(267, 448);
            buttontemizle.Margin = new Padding(4, 3, 4, 3);
            buttontemizle.Name = "buttontemizle";
            buttontemizle.Size = new Size(203, 36);
            buttontemizle.TabIndex = 9;
            buttontemizle.Text = "TEMİZLE";
            buttontemizle.UseVisualStyleBackColor = true;
            buttontemizle.Click += buttontemizle_Click;
            // 
            // buttonguncelle
            // 
            buttonguncelle.FlatStyle = FlatStyle.Flat;
            buttonguncelle.ForeColor = Color.Maroon;
            buttonguncelle.Location = new Point(37, 448);
            buttonguncelle.Margin = new Padding(4, 3, 4, 3);
            buttonguncelle.Name = "buttonguncelle";
            buttonguncelle.Size = new Size(203, 36);
            buttonguncelle.TabIndex = 8;
            buttonguncelle.Text = "GÜNCELLE";
            buttonguncelle.UseVisualStyleBackColor = true;
            buttonguncelle.Click += buttonguncelle_Click;
            // 
            // buttonsil
            // 
            buttonsil.FlatStyle = FlatStyle.Flat;
            buttonsil.ForeColor = Color.Maroon;
            buttonsil.Location = new Point(267, 380);
            buttonsil.Margin = new Padding(4, 3, 4, 3);
            buttonsil.Name = "buttonsil";
            buttonsil.Size = new Size(203, 36);
            buttonsil.TabIndex = 7;
            buttonsil.Text = "SİL";
            buttonsil.UseVisualStyleBackColor = true;
            buttonsil.Click += buttonsil_Click;
            // 
            // buttonekle
            // 
            buttonekle.FlatStyle = FlatStyle.Flat;
            buttonekle.ForeColor = Color.Maroon;
            buttonekle.Location = new Point(37, 380);
            buttonekle.Margin = new Padding(4, 3, 4, 3);
            buttonekle.Name = "buttonekle";
            buttonekle.Size = new Size(203, 36);
            buttonekle.TabIndex = 6;
            buttonekle.Text = "EKLE";
            buttonekle.UseVisualStyleBackColor = true;
            buttonekle.Click += buttonekle_Click;
            // 
            // labelmusteritelno
            // 
            labelmusteritelno.AutoSize = true;
            labelmusteritelno.ForeColor = Color.Maroon;
            labelmusteritelno.Location = new Point(77, 320);
            labelmusteritelno.Margin = new Padding(4, 0, 4, 0);
            labelmusteritelno.Name = "labelmusteritelno";
            labelmusteritelno.Size = new Size(139, 23);
            labelmusteritelno.TabIndex = 5;
            labelmusteritelno.Text = "Müşteri TelNo:";
            // 
            // maskedTextBoxtelno
            // 
            maskedTextBoxtelno.BackColor = SystemColors.ScrollBar;
            maskedTextBoxtelno.BorderStyle = BorderStyle.FixedSingle;
            maskedTextBoxtelno.Location = new Point(233, 313);
            maskedTextBoxtelno.Margin = new Padding(4, 3, 4, 3);
            maskedTextBoxtelno.Mask = "(999) 000-0000";
            maskedTextBoxtelno.Name = "maskedTextBoxtelno";
            maskedTextBoxtelno.Size = new Size(216, 30);
            maskedTextBoxtelno.TabIndex = 4;
            // 
            // labelmusterisoyad
            // 
            labelmusterisoyad.AutoSize = true;
            labelmusterisoyad.ForeColor = Color.Maroon;
            labelmusterisoyad.Location = new Point(70, 262);
            labelmusterisoyad.Margin = new Padding(4, 0, 4, 0);
            labelmusterisoyad.Name = "labelmusterisoyad";
            labelmusterisoyad.Size = new Size(145, 23);
            labelmusterisoyad.TabIndex = 3;
            labelmusterisoyad.Text = "Müşteri Soyadı:";
            // 
            // textBoxmusterisoyad
            // 
            textBoxmusterisoyad.BackColor = SystemColors.ScrollBar;
            textBoxmusterisoyad.BorderStyle = BorderStyle.FixedSingle;
            textBoxmusterisoyad.Location = new Point(233, 254);
            textBoxmusterisoyad.Margin = new Padding(5, 3, 5, 3);
            textBoxmusterisoyad.Name = "textBoxmusterisoyad";
            textBoxmusterisoyad.Size = new Size(216, 30);
            textBoxmusterisoyad.TabIndex = 2;
            // 
            // labelmusteriad
            // 
            labelmusteriad.AutoSize = true;
            labelmusteriad.ForeColor = Color.Maroon;
            labelmusteriad.Location = new Point(100, 206);
            labelmusteriad.Margin = new Padding(4, 0, 4, 0);
            labelmusteriad.Name = "labelmusteriad";
            labelmusteriad.Size = new Size(117, 23);
            labelmusteriad.TabIndex = 1;
            labelmusteriad.Text = "Müşteri Adı:";
            // 
            // textBoxmusteriad
            // 
            textBoxmusteriad.BackColor = SystemColors.ScrollBar;
            textBoxmusteriad.BorderStyle = BorderStyle.FixedSingle;
            textBoxmusteriad.Location = new Point(233, 199);
            textBoxmusteriad.Margin = new Padding(5, 3, 5, 3);
            textBoxmusteriad.Name = "textBoxmusteriad";
            textBoxmusteriad.Size = new Size(216, 30);
            textBoxmusteriad.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(26, 1);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 134);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // textBoxmusteriarama
            // 
            textBoxmusteriarama.BackColor = SystemColors.ScrollBar;
            textBoxmusteriarama.BorderStyle = BorderStyle.FixedSingle;
            textBoxmusteriarama.Location = new Point(1390, 134);
            textBoxmusteriarama.Margin = new Padding(4, 3, 4, 3);
            textBoxmusteriarama.Name = "textBoxmusteriarama";
            textBoxmusteriarama.Size = new Size(248, 30);
            textBoxmusteriarama.TabIndex = 29;
            textBoxmusteriarama.TextChanged += textBoxmusteriarama_TextChanged;
            // 
            // labelmusteriarama
            // 
            labelmusteriarama.AutoSize = true;
            labelmusteriarama.BackColor = Color.Transparent;
            labelmusteriarama.ForeColor = Color.Maroon;
            labelmusteriarama.Location = new Point(1217, 141);
            labelmusteriarama.Margin = new Padding(4, 0, 4, 0);
            labelmusteriarama.Name = "labelmusteriarama";
            labelmusteriarama.Size = new Size(145, 23);
            labelmusteriarama.TabIndex = 28;
            labelmusteriarama.Text = "Müşteri Arama:";
            // 
            // checkBoxpasif
            // 
            checkBoxpasif.AutoSize = true;
            checkBoxpasif.BackColor = Color.Transparent;
            checkBoxpasif.Location = new Point(970, 148);
            checkBoxpasif.Margin = new Padding(4, 3, 4, 3);
            checkBoxpasif.Name = "checkBoxpasif";
            checkBoxpasif.Size = new Size(86, 27);
            checkBoxpasif.TabIndex = 31;
            checkBoxpasif.Text = "PASİF";
            checkBoxpasif.UseVisualStyleBackColor = false;
            checkBoxpasif.CheckedChanged += checkBoxpasif_CheckedChanged_1;
            // 
            // checkBoxaktif
            // 
            checkBoxaktif.AutoSize = true;
            checkBoxaktif.BackColor = Color.Transparent;
            checkBoxaktif.Location = new Point(859, 148);
            checkBoxaktif.Margin = new Padding(4, 3, 4, 3);
            checkBoxaktif.Name = "checkBoxaktif";
            checkBoxaktif.Size = new Size(91, 27);
            checkBoxaktif.TabIndex = 30;
            checkBoxaktif.Text = "AKTİF";
            checkBoxaktif.UseVisualStyleBackColor = false;
            checkBoxaktif.CheckedChanged += checkBoxaktif_CheckedChanged_1;
            // 
            // FormMusteriBilgi
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1924, 921);
            Controls.Add(checkBoxpasif);
            Controls.Add(checkBoxaktif);
            Controls.Add(textBoxmusteriarama);
            Controls.Add(labelmusteriarama);
            Controls.Add(pictureBox1);
            Controls.Add(panelmusteribilgi);
            Controls.Add(dataGridViewmusteri);
            Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(5, 3, 5, 3);
            Name = "FormMusteriBilgi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Müşteri Bilgileri ";
            WindowState = FormWindowState.Maximized;
            Load += FormMusteriBilgi_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewmusteri).EndInit();
            panelmusteribilgi.ResumeLayout(false);
            panelmusteribilgi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxmusteri).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewmusteri;
        private Panel panelmusteribilgi;
        private Button buttonguncelle;
        private Button buttonsil;
        private Button buttonekle;
        private Label labelmusteritelno;
        private MaskedTextBox maskedTextBoxtelno;
        private Label labelmusterisoyad;
        private TextBox textBoxmusterisoyad;
        private Label labelmusteriad;
        private TextBox textBoxmusteriad;
        private Button buttontemizle;
        private PictureBox pictureBoxmusteri;
        private PictureBox pictureBox1;
        private TextBox textBoxmusteriarama;
        private Label labelmusteriarama;
        private CheckBox checkBoxpasif;
        private CheckBox checkBoxaktif;
    }
}
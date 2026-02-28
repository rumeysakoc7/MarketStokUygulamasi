
namespace MarketStokUygulamsı_
{
    partial class Formgiris
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formgiris));
            pictureBox1 = new PictureBox();
            txtboxkullaniciAd = new TextBox();
            txtboxsifre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            linkLabelkayitol = new LinkLabel();
            linklabelsifre = new LinkLabel();
            butongiris = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(101, 24);
            pictureBox1.Margin = new Padding(5, 3, 5, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(284, 235);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtboxkullaniciAd
            // 
            txtboxkullaniciAd.BackColor = SystemColors.ScrollBar;
            txtboxkullaniciAd.BorderStyle = BorderStyle.FixedSingle;
            txtboxkullaniciAd.Location = new Point(158, 314);
            txtboxkullaniciAd.Margin = new Padding(5, 3, 5, 3);
            txtboxkullaniciAd.Name = "txtboxkullaniciAd";
            txtboxkullaniciAd.Size = new Size(225, 30);
            txtboxkullaniciAd.TabIndex = 1;
            // 
            // txtboxsifre
            // 
            txtboxsifre.BackColor = SystemColors.ScrollBar;
            txtboxsifre.BorderStyle = BorderStyle.FixedSingle;
            txtboxsifre.Location = new Point(160, 374);
            txtboxsifre.Margin = new Padding(5, 3, 5, 3);
            txtboxsifre.Name = "txtboxsifre";
            txtboxsifre.PasswordChar = '●';
            txtboxsifre.Size = new Size(225, 30);
            txtboxsifre.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label1.Location = new Point(29, 321);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(123, 23);
            label1.TabIndex = 3;
            label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label2.Location = new Point(94, 381);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(58, 23);
            label2.TabIndex = 4;
            label2.Text = "Şifre:";
            // 
            // linkLabelkayitol
            // 
            linkLabelkayitol.AutoSize = true;
            linkLabelkayitol.BackColor = Color.Transparent;
            linkLabelkayitol.LinkColor = Color.Maroon;
            linkLabelkayitol.Location = new Point(158, 421);
            linkLabelkayitol.Margin = new Padding(5, 0, 5, 0);
            linkLabelkayitol.Name = "linkLabelkayitol";
            linkLabelkayitol.Size = new Size(82, 23);
            linkLabelkayitol.TabIndex = 5;
            linkLabelkayitol.TabStop = true;
            linkLabelkayitol.Text = "Kayıt Ol";
            linkLabelkayitol.LinkClicked += linkLabeloturum_LinkClicked;
            // 
            // linklabelsifre
            // 
            linklabelsifre.AutoSize = true;
            linklabelsifre.BackColor = Color.Transparent;
            linklabelsifre.LinkColor = Color.Maroon;
            linklabelsifre.Location = new Point(260, 421);
            linklabelsifre.Margin = new Padding(5, 0, 5, 0);
            linklabelsifre.Name = "linklabelsifre";
            linklabelsifre.Size = new Size(149, 23);
            linklabelsifre.TabIndex = 6;
            linklabelsifre.TabStop = true;
            linklabelsifre.Text = "Şifremi Unuttum";
            linklabelsifre.LinkClicked += linklabelsifre_LinkClicked;
            // 
            // butongiris
            // 
            butongiris.BackColor = SystemColors.ControlDark;
            butongiris.FlatStyle = FlatStyle.Flat;
            butongiris.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            butongiris.Location = new Point(170, 473);
            butongiris.Margin = new Padding(5, 3, 5, 3);
            butongiris.Name = "butongiris";
            butongiris.Size = new Size(194, 45);
            butongiris.TabIndex = 7;
            butongiris.Text = "Giriş Yap";
            butongiris.UseVisualStyleBackColor = false;
            butongiris.Click += button1_Click;
            // 
            // Formgiris
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(495, 594);
            Controls.Add(butongiris);
            Controls.Add(linklabelsifre);
            Controls.Add(linkLabelkayitol);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtboxsifre);
            Controls.Add(txtboxkullaniciAd);
            Controls.Add(pictureBox1);
            Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(5, 3, 5, 3);
            Name = "Formgiris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kullanıcı Giriş";
            Load += Formgiris_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private PictureBox pictureBox1;
        private TextBox txtboxkullaniciAd;
        private TextBox txtboxsifre;
        private Label label1;
        private Label label2;
        private LinkLabel linkLabelkayitol;
        private LinkLabel linklabelsifre;
        private Button butongiris;
    }
}

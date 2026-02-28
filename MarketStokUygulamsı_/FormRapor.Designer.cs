namespace MarketStokUygulamsı_
{
    partial class FormRapor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRapor));
            dateTimePickerbitis = new DateTimePicker();
            dateTimePickerbaslangic = new DateTimePicker();
            pictureBox1 = new PictureBox();
            dataGridViewRapor = new DataGridView();
            labelraporsayfa = new Label();
            buttonraporhesap = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRapor).BeginInit();
            SuspendLayout();
            // 
            // dateTimePickerbitis
            // 
            dateTimePickerbitis.Location = new Point(363, 174);
            dateTimePickerbitis.Margin = new Padding(4, 3, 4, 3);
            dateTimePickerbitis.Name = "dateTimePickerbitis";
            dateTimePickerbitis.Size = new Size(306, 30);
            dateTimePickerbitis.TabIndex = 45;
            // 
            // dateTimePickerbaslangic
            // 
            dateTimePickerbaslangic.Location = new Point(36, 174);
            dateTimePickerbaslangic.Margin = new Padding(4, 3, 4, 3);
            dateTimePickerbaslangic.Name = "dateTimePickerbaslangic";
            dateTimePickerbaslangic.Size = new Size(306, 30);
            dateTimePickerbaslangic.TabIndex = 44;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(14, 14);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 136);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 40;
            pictureBox1.TabStop = false;
            // 
            // dataGridViewRapor
            // 
            dataGridViewRapor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRapor.Location = new Point(24, 267);
            dataGridViewRapor.Margin = new Padding(4, 3, 4, 3);
            dataGridViewRapor.Name = "dataGridViewRapor";
            dataGridViewRapor.RowHeadersWidth = 51;
            dataGridViewRapor.Size = new Size(1792, 623);
            dataGridViewRapor.TabIndex = 39;
            // 
            // labelraporsayfa
            // 
            labelraporsayfa.AutoSize = true;
            labelraporsayfa.BackColor = Color.Transparent;
            labelraporsayfa.ForeColor = Color.Maroon;
            labelraporsayfa.Location = new Point(24, 229);
            labelraporsayfa.Margin = new Padding(4, 0, 4, 0);
            labelraporsayfa.Name = "labelraporsayfa";
            labelraporsayfa.Size = new Size(121, 23);
            labelraporsayfa.TabIndex = 43;
            labelraporsayfa.Text = "RAPORLAR";
            // 
            // buttonraporhesap
            // 
            buttonraporhesap.BackColor = Color.Transparent;
            buttonraporhesap.FlatStyle = FlatStyle.Flat;
            buttonraporhesap.Location = new Point(704, 169);
            buttonraporhesap.Name = "buttonraporhesap";
            buttonraporhesap.Size = new Size(174, 35);
            buttonraporhesap.TabIndex = 50;
            buttonraporhesap.Text = "Hesapla";
            buttonraporhesap.UseVisualStyleBackColor = false;
            buttonraporhesap.Click += buttonraporhesap_Click;
            // 
            // FormRapor
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1924, 915);
            Controls.Add(buttonraporhesap);
            Controls.Add(dateTimePickerbitis);
            Controls.Add(dateTimePickerbaslangic);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridViewRapor);
            Controls.Add(labelraporsayfa);
            Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Margin = new Padding(5, 3, 5, 3);
            Name = "FormRapor";
            Text = "FormRapor";
            WindowState = FormWindowState.Maximized;
            Load += FormRapor_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRapor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker dateTimePickerbitis;
        private DateTimePicker dateTimePickerbaslangic;
        private PictureBox pictureBox1;
        private DataGridView dataGridViewRapor;
        private Label labelraporsayfa;
        private Button buttonraporhesap;
    }
}
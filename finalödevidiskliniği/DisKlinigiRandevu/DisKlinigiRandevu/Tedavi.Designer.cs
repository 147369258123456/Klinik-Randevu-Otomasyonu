namespace DisKlinigiRandevu
{
    partial class Tedavi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tedavi));
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ARATB = new System.Windows.Forms.TextBox();
            this.TedaviDGV = new System.Windows.Forms.DataGridView();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnDuzenle = new System.Windows.Forms.Button();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnHasta = new System.Windows.Forms.Button();
            this.BtnReceteler = new System.Windows.Forms.Button();
            this.BtnTedavi = new System.Windows.Forms.Button();
            this.BtnRandevu = new System.Windows.Forms.Button();
            this.TedaviAdiTb = new System.Windows.Forms.TextBox();
            this.TutarTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AciklamaTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TedaviDGV)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(965, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "DOLGUN DİŞ KLİNİĞİ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ARATB
            // 
            this.ARATB.Location = new System.Drawing.Point(377, 370);
            this.ARATB.Name = "ARATB";
            this.ARATB.Size = new System.Drawing.Size(200, 22);
            this.ARATB.TabIndex = 59;
            this.ARATB.TextChanged += new System.EventHandler(this.ARATB_TextChanged);
            // 
            // TedaviDGV
            // 
            this.TedaviDGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TedaviDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TedaviDGV.Location = new System.Drawing.Point(17, 416);
            this.TedaviDGV.Name = "TedaviDGV";
            this.TedaviDGV.RowHeadersWidth = 51;
            this.TedaviDGV.RowTemplate.Height = 24;
            this.TedaviDGV.Size = new System.Drawing.Size(943, 270);
            this.TedaviDGV.TabIndex = 57;
            this.TedaviDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TedaviDGV_CellClick);
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(357, 301);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(96, 35);
            this.BtnSil.TabIndex = 56;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnDuzenle
            // 
            this.BtnDuzenle.Location = new System.Drawing.Point(208, 301);
            this.BtnDuzenle.Name = "BtnDuzenle";
            this.BtnDuzenle.Size = new System.Drawing.Size(96, 35);
            this.BtnDuzenle.TabIndex = 55;
            this.BtnDuzenle.Text = "Düzenle";
            this.BtnDuzenle.UseVisualStyleBackColor = true;
            this.BtnDuzenle.Click += new System.EventHandler(this.BtnDuzenle_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Location = new System.Drawing.Point(60, 301);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(96, 35);
            this.BtnKaydet.TabIndex = 54;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(37, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 22);
            this.label3.TabIndex = 49;
            this.label3.Text = "Tedavi Adı : ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.BtnHasta);
            this.panel1.Controls.Add(this.BtnReceteler);
            this.panel1.Controls.Add(this.BtnTedavi);
            this.panel1.Controls.Add(this.BtnRandevu);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(991, 100);
            this.panel1.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(135, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 25);
            this.label7.TabIndex = 85;
            this.label7.Text = "<<<";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // BtnHasta
            // 
            this.BtnHasta.Location = new System.Drawing.Point(388, 29);
            this.BtnHasta.Name = "BtnHasta";
            this.BtnHasta.Size = new System.Drawing.Size(105, 34);
            this.BtnHasta.TabIndex = 10;
            this.BtnHasta.Text = "Hasta";
            this.BtnHasta.UseVisualStyleBackColor = true;
            // 
            // BtnReceteler
            // 
            this.BtnReceteler.Location = new System.Drawing.Point(781, 29);
            this.BtnReceteler.Name = "BtnReceteler";
            this.BtnReceteler.Size = new System.Drawing.Size(105, 34);
            this.BtnReceteler.TabIndex = 9;
            this.BtnReceteler.Text = "Reçeteler";
            this.BtnReceteler.UseVisualStyleBackColor = true;
            // 
            // BtnTedavi
            // 
            this.BtnTedavi.BackColor = System.Drawing.Color.Red;
            this.BtnTedavi.Location = new System.Drawing.Point(642, 29);
            this.BtnTedavi.Name = "BtnTedavi";
            this.BtnTedavi.Size = new System.Drawing.Size(105, 34);
            this.BtnTedavi.TabIndex = 8;
            this.BtnTedavi.Text = "Tedavi";
            this.BtnTedavi.UseVisualStyleBackColor = false;
            // 
            // BtnRandevu
            // 
            this.BtnRandevu.Location = new System.Drawing.Point(514, 29);
            this.BtnRandevu.Name = "BtnRandevu";
            this.BtnRandevu.Size = new System.Drawing.Size(105, 34);
            this.BtnRandevu.TabIndex = 7;
            this.BtnRandevu.Text = "Randevu";
            this.BtnRandevu.UseVisualStyleBackColor = true;
            // 
            // TedaviAdiTb
            // 
            this.TedaviAdiTb.Location = new System.Drawing.Point(183, 147);
            this.TedaviAdiTb.Name = "TedaviAdiTb";
            this.TedaviAdiTb.Size = new System.Drawing.Size(200, 22);
            this.TedaviAdiTb.TabIndex = 61;
            // 
            // TutarTb
            // 
            this.TutarTb.Location = new System.Drawing.Point(183, 191);
            this.TutarTb.Name = "TutarTb";
            this.TutarTb.Size = new System.Drawing.Size(200, 22);
            this.TutarTb.TabIndex = 63;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(85, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 22);
            this.label4.TabIndex = 62;
            this.label4.Text = "Tutar : ";
            // 
            // AciklamaTb
            // 
            this.AciklamaTb.Location = new System.Drawing.Point(183, 236);
            this.AciklamaTb.Name = "AciklamaTb";
            this.AciklamaTb.Size = new System.Drawing.Size(200, 22);
            this.AciklamaTb.TabIndex = 65;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(50, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 22);
            this.label5.TabIndex = 64;
            this.label5.Text = "Açıklama : ";
            // 
            // Tedavi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(991, 696);
            this.Controls.Add(this.AciklamaTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TutarTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TedaviAdiTb);
            this.Controls.Add(this.ARATB);
            this.Controls.Add(this.TedaviDGV);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnDuzenle);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tedavi";
            this.Text = "Tedavi";
            this.Load += new System.EventHandler(this.Tedavi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TedaviDGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ARATB;
        private System.Windows.Forms.DataGridView TedaviDGV;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnDuzenle;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TedaviAdiTb;
        private System.Windows.Forms.TextBox TutarTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AciklamaTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnHasta;
        private System.Windows.Forms.Button BtnReceteler;
        private System.Windows.Forms.Button BtnTedavi;
        private System.Windows.Forms.Button BtnRandevu;
        private System.Windows.Forms.Label label7;
    }
}
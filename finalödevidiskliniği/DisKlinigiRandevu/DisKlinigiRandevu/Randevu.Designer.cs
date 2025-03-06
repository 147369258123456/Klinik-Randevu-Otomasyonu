namespace DisKlinigiRandevu
{
    partial class Randevu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Randevu));
            this.araTb = new System.Windows.Forms.TextBox();
            this.RandevuDgv = new System.Windows.Forms.DataGridView();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnDuzenle = new System.Windows.Forms.Button();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.SaatCb = new System.Windows.Forms.ComboBox();
            this.Rtarih = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnHasta = new System.Windows.Forms.Button();
            this.BtnReceteler = new System.Windows.Forms.Button();
            this.BtnTedavi = new System.Windows.Forms.Button();
            this.BtnRandevu = new System.Windows.Forms.Button();
            this.RadCb = new System.Windows.Forms.ComboBox();
            this.RtedaviCb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RandevuDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // araTb
            // 
            this.araTb.Location = new System.Drawing.Point(375, 436);
            this.araTb.Name = "araTb";
            this.araTb.Size = new System.Drawing.Size(200, 22);
            this.araTb.TabIndex = 43;
            this.araTb.TextChanged += new System.EventHandler(this.araTb_TextChanged);
            // 
            // RandevuDgv
            // 
            this.RandevuDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RandevuDgv.Location = new System.Drawing.Point(12, 479);
            this.RandevuDgv.Name = "RandevuDgv";
            this.RandevuDgv.RowHeadersWidth = 51;
            this.RandevuDgv.RowTemplate.Height = 24;
            this.RandevuDgv.Size = new System.Drawing.Size(967, 252);
            this.RandevuDgv.TabIndex = 41;
            this.RandevuDgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RandevuDgv_CellClick);
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(449, 329);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(96, 35);
            this.BtnSil.TabIndex = 40;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnDuzenle
            // 
            this.BtnDuzenle.Location = new System.Drawing.Point(300, 329);
            this.BtnDuzenle.Name = "BtnDuzenle";
            this.BtnDuzenle.Size = new System.Drawing.Size(96, 35);
            this.BtnDuzenle.TabIndex = 39;
            this.BtnDuzenle.Text = "Düzenle";
            this.BtnDuzenle.UseVisualStyleBackColor = true;
            this.BtnDuzenle.Click += new System.EventHandler(this.BtnDuzenle_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Location = new System.Drawing.Point(152, 329);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(96, 35);
            this.BtnKaydet.TabIndex = 38;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // SaatCb
            // 
            this.SaatCb.FormattingEnabled = true;
            this.SaatCb.Items.AddRange(new object[] {
            "09.00-10.00",
            "10.30-11.30",
            "12.00-13.00",
            "13.30-14.30",
            "15.00-16.00"});
            this.SaatCb.Location = new System.Drawing.Point(271, 232);
            this.SaatCb.Name = "SaatCb";
            this.SaatCb.Size = new System.Drawing.Size(200, 24);
            this.SaatCb.TabIndex = 33;
            // 
            // Rtarih
            // 
            this.Rtarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Rtarih.Location = new System.Drawing.Point(271, 187);
            this.Rtarih.Name = "Rtarih";
            this.Rtarih.Size = new System.Drawing.Size(200, 22);
            this.Rtarih.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(170, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 22);
            this.label5.TabIndex = 30;
            this.label5.Text = "Tarih : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(134, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 22);
            this.label3.TabIndex = 26;
            this.label3.Text = "Ad Soyad : ";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(178, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 22);
            this.label6.TabIndex = 32;
            this.label6.Text = "Saat : ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.BtnHasta);
            this.panel1.Controls.Add(this.BtnReceteler);
            this.panel1.Controls.Add(this.BtnTedavi);
            this.panel1.Controls.Add(this.BtnRandevu);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(991, 100);
            this.panel1.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 15);
            this.label1.TabIndex = 86;
            this.label1.Text = "DOLGUN DİŞ KLİNİĞİ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(130, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 25);
            this.label7.TabIndex = 85;
            this.label7.Text = "<<<";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // BtnHasta
            // 
            this.BtnHasta.Location = new System.Drawing.Point(375, 34);
            this.BtnHasta.Name = "BtnHasta";
            this.BtnHasta.Size = new System.Drawing.Size(105, 34);
            this.BtnHasta.TabIndex = 10;
            this.BtnHasta.Text = "Hasta";
            this.BtnHasta.UseVisualStyleBackColor = true;
            // 
            // BtnReceteler
            // 
            this.BtnReceteler.Location = new System.Drawing.Point(768, 34);
            this.BtnReceteler.Name = "BtnReceteler";
            this.BtnReceteler.Size = new System.Drawing.Size(105, 34);
            this.BtnReceteler.TabIndex = 9;
            this.BtnReceteler.Text = "Reçeteler";
            this.BtnReceteler.UseVisualStyleBackColor = true;
            // 
            // BtnTedavi
            // 
            this.BtnTedavi.Location = new System.Drawing.Point(629, 34);
            this.BtnTedavi.Name = "BtnTedavi";
            this.BtnTedavi.Size = new System.Drawing.Size(105, 34);
            this.BtnTedavi.TabIndex = 8;
            this.BtnTedavi.Text = "Tedavi";
            this.BtnTedavi.UseVisualStyleBackColor = true;
            // 
            // BtnRandevu
            // 
            this.BtnRandevu.BackColor = System.Drawing.Color.Red;
            this.BtnRandevu.Location = new System.Drawing.Point(501, 34);
            this.BtnRandevu.Name = "BtnRandevu";
            this.BtnRandevu.Size = new System.Drawing.Size(105, 34);
            this.BtnRandevu.TabIndex = 7;
            this.BtnRandevu.Text = "Randevu";
            this.BtnRandevu.UseVisualStyleBackColor = false;
            // 
            // RadCb
            // 
            this.RadCb.FormattingEnabled = true;
            this.RadCb.Items.AddRange(new object[] {
            "Kadın ",
            "Erkek"});
            this.RadCb.Location = new System.Drawing.Point(271, 146);
            this.RadCb.Name = "RadCb";
            this.RadCb.Size = new System.Drawing.Size(200, 24);
            this.RadCb.TabIndex = 45;
            // 
            // RtedaviCb
            // 
            this.RtedaviCb.FormattingEnabled = true;
            this.RtedaviCb.Items.AddRange(new object[] {
            "Dolgu",
            "Diş Çekimi",
            "Kanal Tedavisi",
            "Diş Teli Tedavisi",
            "Protetik Diş Tedavisi",
            "Pedodonti"});
            this.RtedaviCb.Location = new System.Drawing.Point(271, 273);
            this.RtedaviCb.Name = "RtedaviCb";
            this.RtedaviCb.Size = new System.Drawing.Size(200, 24);
            this.RtedaviCb.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(157, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 22);
            this.label4.TabIndex = 46;
            this.label4.Text = "Tedavi : ";
            // 
            // Randevu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 743);
            this.Controls.Add(this.RtedaviCb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RadCb);
            this.Controls.Add(this.araTb);
            this.Controls.Add(this.RandevuDgv);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnDuzenle);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.SaatCb);
            this.Controls.Add(this.Rtarih);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Randevu";
            this.Text = "Randevu";
            this.Load += new System.EventHandler(this.Randevu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RandevuDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox araTb;
        private System.Windows.Forms.DataGridView RandevuDgv;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnDuzenle;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.ComboBox SaatCb;
        private System.Windows.Forms.DateTimePicker Rtarih;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox RadCb;
        private System.Windows.Forms.ComboBox RtedaviCb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnHasta;
        private System.Windows.Forms.Button BtnReceteler;
        private System.Windows.Forms.Button BtnTedavi;
        private System.Windows.Forms.Button BtnRandevu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
    }
}
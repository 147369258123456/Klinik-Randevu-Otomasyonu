namespace DisKlinigiRandevu
{
    partial class Receteler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Receteler));
            this.MiktarTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TutarTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TedaviTb = new System.Windows.Forms.TextBox();
            this.aratb = new System.Windows.Forms.TextBox();
            this.ReceteDGV = new System.Windows.Forms.DataGridView();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnHasta = new System.Windows.Forms.Button();
            this.BtnReceteler = new System.Windows.Forms.Button();
            this.BtnTedavi = new System.Windows.Forms.Button();
            this.BtnRandevu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.HastaASCb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnYazdir = new System.Windows.Forms.Button();
            this.IlaclarTb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.ReceteDGV)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MiktarTb
            // 
            this.MiktarTb.Location = new System.Drawing.Point(145, 348);
            this.MiktarTb.Name = "MiktarTb";
            this.MiktarTb.Size = new System.Drawing.Size(200, 22);
            this.MiktarTb.TabIndex = 79;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 22);
            this.label5.TabIndex = 78;
            this.label5.Text = "Miktar : ";
            // 
            // TutarTb
            // 
            this.TutarTb.Location = new System.Drawing.Point(145, 262);
            this.TutarTb.Name = "TutarTb";
            this.TutarTb.Size = new System.Drawing.Size(200, 22);
            this.TutarTb.TabIndex = 77;
            this.TutarTb.TextChanged += new System.EventHandler(this.TutarTb_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(24, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 22);
            this.label4.TabIndex = 76;
            this.label4.Text = "Tutar : ";
            // 
            // TedaviTb
            // 
            this.TedaviTb.Location = new System.Drawing.Point(145, 218);
            this.TedaviTb.Name = "TedaviTb";
            this.TedaviTb.Size = new System.Drawing.Size(200, 22);
            this.TedaviTb.TabIndex = 75;
            this.TedaviTb.TextChanged += new System.EventHandler(this.TedaviTb_TextChanged);
            // 
            // aratb
            // 
            this.aratb.Location = new System.Drawing.Point(568, 130);
            this.aratb.Name = "aratb";
            this.aratb.Size = new System.Drawing.Size(200, 22);
            this.aratb.TabIndex = 73;
            this.aratb.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // ReceteDGV
            // 
            this.ReceteDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReceteDGV.Location = new System.Drawing.Point(361, 169);
            this.ReceteDGV.Name = "ReceteDGV";
            this.ReceteDGV.RowHeadersWidth = 51;
            this.ReceteDGV.RowTemplate.Height = 24;
            this.ReceteDGV.Size = new System.Drawing.Size(618, 305);
            this.ReceteDGV.TabIndex = 71;
            this.ReceteDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ReceteDGV_CellClick);
            this.ReceteDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ReceteDGV_CellContentClick);
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(181, 439);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(96, 35);
            this.BtnSil.TabIndex = 70;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Location = new System.Drawing.Point(33, 439);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(96, 35);
            this.BtnKaydet.TabIndex = 68;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
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
            this.panel1.TabIndex = 66;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(145, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 25);
            this.label7.TabIndex = 84;
            this.label7.Text = "<<<";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // BtnHasta
            // 
            this.BtnHasta.Location = new System.Drawing.Point(361, 28);
            this.BtnHasta.Name = "BtnHasta";
            this.BtnHasta.Size = new System.Drawing.Size(105, 34);
            this.BtnHasta.TabIndex = 10;
            this.BtnHasta.Text = "Hasta";
            this.BtnHasta.UseVisualStyleBackColor = true;
            // 
            // BtnReceteler
            // 
            this.BtnReceteler.BackColor = System.Drawing.Color.Red;
            this.BtnReceteler.Location = new System.Drawing.Point(754, 28);
            this.BtnReceteler.Name = "BtnReceteler";
            this.BtnReceteler.Size = new System.Drawing.Size(105, 34);
            this.BtnReceteler.TabIndex = 9;
            this.BtnReceteler.Text = "Reçeteler";
            this.BtnReceteler.UseVisualStyleBackColor = false;
            // 
            // BtnTedavi
            // 
            this.BtnTedavi.Location = new System.Drawing.Point(615, 28);
            this.BtnTedavi.Name = "BtnTedavi";
            this.BtnTedavi.Size = new System.Drawing.Size(105, 34);
            this.BtnTedavi.TabIndex = 8;
            this.BtnTedavi.Text = "Tedavi";
            this.BtnTedavi.UseVisualStyleBackColor = true;
            // 
            // BtnRandevu
            // 
            this.BtnRandevu.Location = new System.Drawing.Point(487, 28);
            this.BtnRandevu.Name = "BtnRandevu";
            this.BtnRandevu.Size = new System.Drawing.Size(105, 34);
            this.BtnRandevu.TabIndex = 7;
            this.BtnRandevu.Text = "Randevu";
            this.BtnRandevu.UseVisualStyleBackColor = true;
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
            this.label1.Location = new System.Drawing.Point(118, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "DOLGUN DİŞ KLİNİĞİ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(-24, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 22);
            this.label3.TabIndex = 67;
            this.label3.Text = "Tedavi Adı : ";
            // 
            // HastaASCb
            // 
            this.HastaASCb.FormattingEnabled = true;
            this.HastaASCb.Items.AddRange(new object[] {
            "Kadın ",
            "Erkek"});
            this.HastaASCb.Location = new System.Drawing.Point(145, 182);
            this.HastaASCb.Name = "HastaASCb";
            this.HastaASCb.Size = new System.Drawing.Size(200, 24);
            this.HastaASCb.TabIndex = 81;
            this.HastaASCb.SelectionChangeCommitted += new System.EventHandler(this.HastaASCb_SelectionChangeCommitted);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(-13, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 22);
            this.label6.TabIndex = 80;
            this.label6.Text = "Ad Soyad : ";
            // 
            // BtnYazdir
            // 
            this.BtnYazdir.Location = new System.Drawing.Point(652, 480);
            this.BtnYazdir.Name = "BtnYazdir";
            this.BtnYazdir.Size = new System.Drawing.Size(96, 35);
            this.BtnYazdir.TabIndex = 82;
            this.BtnYazdir.Text = "Yazdır";
            this.BtnYazdir.UseVisualStyleBackColor = true;
            this.BtnYazdir.Click += new System.EventHandler(this.BtnYazdir_Click);
            // 
            // IlaclarTb
            // 
            this.IlaclarTb.Location = new System.Drawing.Point(145, 305);
            this.IlaclarTb.Name = "IlaclarTb";
            this.IlaclarTb.Size = new System.Drawing.Size(200, 22);
            this.IlaclarTb.TabIndex = 84;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(12, 305);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 22);
            this.label8.TabIndex = 83;
            this.label8.Text = "İlaçlar : ";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Text = "Baskı önizleme";
            this.printPreviewDialog1.Visible = false;
            // 
            // Receteler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(991, 526);
            this.Controls.Add(this.IlaclarTb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BtnYazdir);
            this.Controls.Add(this.HastaASCb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MiktarTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TutarTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TedaviTb);
            this.Controls.Add(this.aratb);
            this.Controls.Add(this.ReceteDGV);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Receteler";
            this.Text = "Receteler";
            this.Load += new System.EventHandler(this.Receteler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReceteDGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MiktarTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TutarTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TedaviTb;
        private System.Windows.Forms.TextBox aratb;
        private System.Windows.Forms.DataGridView ReceteDGV;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox HastaASCb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnYazdir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnHasta;
        private System.Windows.Forms.Button BtnReceteler;
        private System.Windows.Forms.Button BtnTedavi;
        private System.Windows.Forms.Button BtnRandevu;
        private System.Windows.Forms.TextBox IlaclarTb;
        private System.Windows.Forms.Label label8;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}
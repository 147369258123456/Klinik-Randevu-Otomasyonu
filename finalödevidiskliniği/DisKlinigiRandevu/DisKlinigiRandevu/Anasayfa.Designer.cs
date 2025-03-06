namespace DisKlinigiRandevu
{
    partial class Anasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anasayfa));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnHasta = new System.Windows.Forms.Button();
            this.BtnReceteler = new System.Windows.Forms.Button();
            this.BtnTedavi = new System.Windows.Forms.Button();
            this.BtnRandevu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.BtnHasta);
            this.panel1.Controls.Add(this.BtnReceteler);
            this.panel1.Controls.Add(this.BtnTedavi);
            this.panel1.Controls.Add(this.BtnRandevu);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(905, 100);
            this.panel1.TabIndex = 0;
            // 
            // BtnHasta
            // 
            this.BtnHasta.Location = new System.Drawing.Point(295, 38);
            this.BtnHasta.Name = "BtnHasta";
            this.BtnHasta.Size = new System.Drawing.Size(105, 34);
            this.BtnHasta.TabIndex = 6;
            this.BtnHasta.Text = "Hasta";
            this.BtnHasta.UseVisualStyleBackColor = true;
            this.BtnHasta.Click += new System.EventHandler(this.BtnHasta_Click);
            // 
            // BtnReceteler
            // 
            this.BtnReceteler.Location = new System.Drawing.Point(688, 38);
            this.BtnReceteler.Name = "BtnReceteler";
            this.BtnReceteler.Size = new System.Drawing.Size(105, 34);
            this.BtnReceteler.TabIndex = 5;
            this.BtnReceteler.Text = "Reçeteler";
            this.BtnReceteler.UseVisualStyleBackColor = true;
            this.BtnReceteler.Click += new System.EventHandler(this.BtnReceteler_Click);
            // 
            // BtnTedavi
            // 
            this.BtnTedavi.Location = new System.Drawing.Point(549, 38);
            this.BtnTedavi.Name = "BtnTedavi";
            this.BtnTedavi.Size = new System.Drawing.Size(105, 34);
            this.BtnTedavi.TabIndex = 4;
            this.BtnTedavi.Text = "Tedavi";
            this.BtnTedavi.UseVisualStyleBackColor = true;
            this.BtnTedavi.Click += new System.EventHandler(this.BtnTedavi_Click);
            // 
            // BtnRandevu
            // 
            this.BtnRandevu.Location = new System.Drawing.Point(421, 38);
            this.BtnRandevu.Name = "BtnRandevu";
            this.BtnRandevu.Size = new System.Drawing.Size(105, 34);
            this.BtnRandevu.TabIndex = 1;
            this.BtnRandevu.Text = "Randevu";
            this.BtnRandevu.UseVisualStyleBackColor = true;
            this.BtnRandevu.Click += new System.EventHandler(this.BtnRandevu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(365, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "DOLGUN DİŞ KLİNİĞİ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 149);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(905, 366);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 513);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Anasayfa";
            this.Text = "Anasayfa";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnReceteler;
        private System.Windows.Forms.Button BtnTedavi;
        private System.Windows.Forms.Button BtnRandevu;
        private System.Windows.Forms.Button BtnHasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
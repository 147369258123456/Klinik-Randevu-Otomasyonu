﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisKlinigiRandevu
{
    public partial class Hasta : Form
    {
       
        public Hasta()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        void uyeler()
        {
            Hastalar Hs = new Hastalar();
            string query = "select * from HastaTbl";
            DataSet ds = Hs.ShowHasta(query);
            HastaDGV.DataSource = ds.Tables[0];
        }
        void filter()
        {
            Hastalar Hs = new Hastalar();
            string query = "select * from HastaTbl where HAd like '%"+AraTb.Text+"%'";
            DataSet ds = Hs.ShowHasta(query);
            HastaDGV.DataSource = ds.Tables[0];
        }
        void Reset()
        {
            HAdSoyadTb.Text = "";
            HTelefonTb.Text = "";
            AdresTb.Text = "";
            HDogumTarih.Text = "";
            HDogumTarih.Text = "";
            HCinsiyetCb.SelectedItem = "";
            AlerjiTb.Text = "";
            pictureBox2.ImageLocation = "";
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            string query = "insert into HastaTbl values('" + HAdSoyadTb.Text + "','" + HTelefonTb.Text + "','" + AdresTb.Text + "','" + HDogumTarih.Text + "','" + HCinsiyetCb.SelectedItem.ToString() + "','" + AlerjiTb.Text + "','"+pictureBox2.ImageLocation+"')";
            Hastalar Hs =new Hastalar();
            try
            {
                Hs.HastaEkle(query);
                MessageBox.Show("Hasta Başarıyla Eklendi");
                uyeler();
                Reset();
            }catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Hasta_Load(object sender, EventArgs e)
        {
            uyeler();
            Reset();
        }

        private void HastaDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int key = 0;
        private void HastaDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HAdSoyadTb.Text = HastaDGV.SelectedRows[0].Cells[1].Value.ToString();
            HTelefonTb.Text = HastaDGV.SelectedRows[0].Cells[2].Value.ToString();
            AdresTb.Text = HastaDGV.SelectedRows[0].Cells[3].Value.ToString();
            HDogumTarih.Text = HastaDGV.SelectedRows[0].Cells[4].Value.ToString();
            HCinsiyetCb.SelectedItem = HastaDGV.SelectedRows[0].Cells[5].Value.ToString();
            AlerjiTb.Text = HastaDGV.SelectedRows[0].Cells[6].Value.ToString();
            pictureBox2.ImageLocation = HastaDGV.SelectedRows[0].Cells[7].Value.ToString();

            if (HAdSoyadTb.Text=="")
            {
                key = 0;
            }
            else 
            {
                key = Convert.ToInt32(HastaDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            Hastalar Hs = new Hastalar();
            if (key==0)
            {
                MessageBox.Show("Silinecek Hastayı Seçiniz");
            }
            else
            {
                try
                {
                    string query = "Delete  from HastaTbl where HId=" + key + "";
                    Hs.HastaSil(query);
                    MessageBox.Show("Hasta Başarıyla Silindi");
                    uyeler();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                    
                }
            }
            
        }

        private void BtnDüzenle_Click(object sender, EventArgs e)
        {
            Hastalar Hs = new Hastalar();
            if (key == 0)
            {
                MessageBox.Show("Güncellenecek Hasatayı Seçiniz");
            }
            else
            {
                try
                {
                    string query = "Update HastaTbl set HAd='"+HAdSoyadTb.Text+ "',Htelefon='"+HTelefonTb.Text+ "',HAdres='"+AdresTb.Text+ "',HDTarih='"+HDogumTarih.Text+ "', HCinsiyet='"+HCinsiyetCb.SelectedItem.ToString()+ "',HAlerji='"+AlerjiTb.Text+"',resim_url='"+pictureBox2.ImageLocation+"' where HId=" + key + "";
                    Hs.HastaSil(query);
                    MessageBox.Show("Hasta Başarıyla Güncellendi");
                    uyeler();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);

                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            Anasayfa ana = new Anasayfa();
            ana.Show();
            this.Hide();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            filter();
        }

        private void BtnFotografSec_Click(object sender, EventArgs e)
        {
          OpenFileDialog ofd = new OpenFileDialog();
            
            ofd.Filter = "Resim dosyalari |*.jpg; *.png; *.tif| Tum dosyalar |.*";
            ofd.ShowDialog();
            pictureBox2.ImageLocation = ofd.FileName;
        }

       
        
    }
    
}

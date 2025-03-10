﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisKlinigiRandevu
{
    public partial class Receteler : Form
    {
        public Receteler()
        {
            InitializeComponent();
        }
        ConnectionString MyCon = new ConnectionString();

        private void fillHasta()
        {
            SqlConnection baglanti = MyCon.GetCon();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select HAd from HastaTbl", baglanti);
            SqlDataReader rdr;
            rdr = komut.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("HAd", typeof(string));
            dt.Load(rdr);
            HastaASCb.ValueMember = "HAd";
            HastaASCb.DataSource = dt;
            baglanti.Close();
        }

        private void fillTedavi()
        {
            SqlConnection baglanti = MyCon.GetCon();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from RandevuTbl where Hasta='"+HastaASCb.SelectedValue.ToString()+"'", baglanti);
           DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(komut);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                TedaviTb.Text = dr["Tedavi"].ToString();
            }
            baglanti.Close();
        }
        private void fillTutar()
        {
            SqlConnection baglanti = MyCon.GetCon();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from TedaviTbl where TAd='" + TedaviTb.Text + "'", baglanti);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(komut);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                TutarTb.Text = dr["TUcret"].ToString();
            }
            baglanti.Close();
        }

        private void Receteler_Load(object sender, EventArgs e)
        {
            fillHasta();
            uyeler();
            Reset();
        }

        private void HastaASCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fillTedavi();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            Anasayfa ana = new Anasayfa();
            ana.Show();
            this.Hide();
        }

        private void TutarTb_TextChanged(object sender, EventArgs e)
        {
            fillTutar();
        }

        private void TedaviTb_TextChanged(object sender, EventArgs e)
        {
            fillTutar();
        }

        void uyeler()
        {
            Hastalar Hs = new Hastalar();
            string query = "select * from ReceteTbl";
            DataSet ds = Hs.ShowHasta(query);
            ReceteDGV.DataSource = ds.Tables[0];
        }
        void filter()
        {
            Hastalar Hs = new Hastalar();
            string query = "select * from ReceteTbl where HasAd like '%" + aratb.Text + "%'";
            DataSet ds = Hs.ShowHasta(query);
            ReceteDGV.DataSource = ds.Tables[0];
        }

        void Reset()
        {
            HastaASCb.SelectedItem = "";
            TutarTb.Text = "";
            IlaclarTb.Text = "";
            MiktarTb.Text = "";
            TedaviTb.Text = "";
            
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            string query = "insert into ReceteTbl values('" + HastaASCb.SelectedValue.ToString() + "','" + TedaviTb.Text + "'," + TutarTb.Text + ",'"+IlaclarTb.Text+"',"+MiktarTb.Text+")";
            Hastalar Hs = new Hastalar();
            try
            {
                Hs.HastaEkle(query);
                MessageBox.Show("Reçete Başarıyla Eklendi");
                uyeler();
                Reset();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void ReceteDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int key = 0;
        private void ReceteDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HastaASCb.Text = ReceteDGV.SelectedRows[0].Cells[1].Value.ToString();
            TedaviTb.Text = ReceteDGV.SelectedRows[0].Cells[2].Value.ToString();
            TutarTb.Text = ReceteDGV.SelectedRows[0].Cells[3].Value.ToString();
            IlaclarTb.Text = ReceteDGV.SelectedRows[0].Cells[4].Value.ToString();
            MiktarTb.Text = ReceteDGV.SelectedRows[0].Cells[5].Value.ToString();
           

            if (TedaviTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(ReceteDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            Hastalar Hs = new Hastalar();
            if (key == 0)
            {
                MessageBox.Show("Silinecek Receteyi Seçiniz");
            }
            else
            {
                try
                {
                    string query = "Delete  from ReceteTbl where RecId=" + key + "";
                    Hs.HastaSil(query);
                    MessageBox.Show("Reçete Başarıyla Silindi");
                    uyeler();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);

                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            filter();
        }
        Bitmap bitmap;
        private void BtnYazdir_Click(object sender, EventArgs e)
        {
            int height = ReceteDGV.Height;
            ReceteDGV.Height=ReceteDGV.RowCount * ReceteDGV.RowTemplate.Height * 2;
            bitmap = new Bitmap(ReceteDGV.Width, ReceteDGV.Height);
            ReceteDGV.DrawToBitmap(bitmap, new Rectangle(0,10,ReceteDGV.Width,ReceteDGV.Height));
            ReceteDGV.Height = height;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }
    }
}

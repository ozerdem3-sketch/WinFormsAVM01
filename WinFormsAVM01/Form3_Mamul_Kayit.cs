using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsAVM01
{
    public partial class Form3_Mamul_Kayit : Form
    {
        SqlConnection baglan = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DboAVM;Integrated Security=True;Trust Server Certificate=True");
        public Form3_Mamul_Kayit()
        {
            InitializeComponent();
        }

        void cinslistesi()
        {
            baglan.Open();

            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_cins order by mamul_adi asc", baglan);
            DataTable dt2 = new DataTable();
            da.Fill(dt2);
            dataGridView1.DataSource = dt2;
            baglan.Close();
        }
        void firmalistesi()
        {
            baglan.Close();
            SqlDataAdapter da3 = new SqlDataAdapter("select * from tbl_firmalar order by firma_adi asc", baglan);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            dataGridView3.DataSource = dt3;
            baglan.Close();
        }
        void guruplistesi()
        {
            baglan.Open();
            SqlDataAdapter da4 = new SqlDataAdapter("select * from tbl_gurup order by gurup_adi asc", baglan);
            DataTable dt4 = new DataTable();
            da4.Fill(dt4);
            dataGridView2.DataSource = dt4;
            baglan.Close();
        }

        private void Form3_Mamul_Kayit_Load(object sender, EventArgs e)
        {
            cinslistesi();
            firmalistesi();
            guruplistesi();
            bankaaciklama();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sec = dataGridView1.SelectedCells[0].RowIndex;
            txtIDM.Text = dataGridView1.Rows[sec].Cells[0].Value.ToString();
            txtMamul.Text = dataGridView1.Rows[sec].Cells[1].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)   //KATDET BUTONU
        {
            baglan.Open();
            SqlCommand komut1 = new SqlCommand("insert into tbl_cins (mamul_adi) values (@p1)", baglan);
            komut1.Parameters.AddWithValue("@p1", txtMamul.Text);
            komut1.ExecuteNonQuery();

            baglan.Close();
            cinslistesi();
            temizle();
            txtMamul.Focus();
        }

        private void btnSil_Click(object sender, EventArgs e)    //MAMUL SİL BUTONU 
        {
            baglan.Open();
            SqlCommand komut2 = new SqlCommand("delete tbl_cins where ID=@p1", baglan);
            komut2.Parameters.AddWithValue("@p1", txtIDM.Text);
            komut2.ExecuteNonQuery();
            baglan.Close();
            cinslistesi();
            temizle();
        }
        void temizle()
        {
            baglan.Open();
            txtIDM.Text = "";
            txtMamul.Text = "";
            txtIDF.Text = "";
            txtFirma.Text = "";
            txtGurup.Text = "";
            txtIDG.Text = "";
            baglan.Close();

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sec = dataGridView2.SelectedCells[0].RowIndex;
            txtIDG.Text = dataGridView2.Rows[sec].Cells[0].Value.ToString();
            txtGurup.Text = dataGridView2.Rows[sec].Cells[1].Value.ToString();
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sec = dataGridView3.SelectedCells[0].RowIndex;
            txtIDF.Text = dataGridView3.Rows[sec].Cells[0].Value.ToString();
            txtFirma.Text = dataGridView3.Rows[sec].Cells[1].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)//MAMUL GÜNCELLE BUTONU
        {
            baglan.Open();
            SqlCommand komut3 = new SqlCommand("update tbl_cins set mamul_adi=@p1 where ID=@p2", baglan);
            komut3.Parameters.AddWithValue("@p1", txtMamul.Text);
            komut3.Parameters.AddWithValue("@p2", txtIDM.Text);
            komut3.ExecuteNonQuery();
            baglan.Close();
            temizle();

            guruplistesi();
        }

        private void btnFirmaKaydet_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut4 = new SqlCommand("insert into tbl_firmalar (firma_adi) values (@p1)", baglan);
            komut4.Parameters.AddWithValue("@p1", txtFirma.Text);
            komut4.ExecuteNonQuery();

            baglan.Close();
            firmalistesi();
            temizle();
        }

        private void btnFirmaGuncelle_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut3 = new SqlCommand("update tbl_firmalar set firma_adi=@p1 where ID=@p2", baglan);
            komut3.Parameters.AddWithValue("@p1", txtFirma.Text);
            komut3.Parameters.AddWithValue("@p2", txtIDF.Text);
            komut3.ExecuteNonQuery();
            baglan.Close();
            temizle();

            firmalistesi();
        }

        private void btnFirmaSil_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut2 = new SqlCommand("delete tbl_firmalar where ID=@p1", baglan);
            komut2.Parameters.AddWithValue("@p1", txtIDF.Text);
            komut2.ExecuteNonQuery();
            baglan.Close();
            cinslistesi();
            firmalistesi();
            temizle();
        }

        private void btnGurupKaydet_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut4 = new SqlCommand("insert into tbl_gurup (gurup_adi) values (@p1)", baglan);
            komut4.Parameters.AddWithValue("@p1", txtGurup.Text);
            komut4.ExecuteNonQuery();

            baglan.Close();

            temizle();
            txtMamul.Focus();
        }

        private void btnGurupGuncelle_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut3 = new SqlCommand("update tbl_gurup set gurup_adi=@p1 where ID=@p2", baglan);
            komut3.Parameters.AddWithValue("@p1", txtGurup.Text);
            komut3.Parameters.AddWithValue("@p2", txtIDG.Text);
            komut3.ExecuteNonQuery();
            baglan.Close();
            temizle();


        }

        private void btnGurupSil_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut2 = new SqlCommand("delete tbl_gurup where ID=@p1", baglan);
            komut2.Parameters.AddWithValue("@p1", txtIDG.Text);
            komut2.ExecuteNonQuery();
            baglan.Close();

            temizle();
        }

        private void btnMemu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void bankaaciklama()
        {
            baglan.Open();

            SqlDataAdapter da4 = new SqlDataAdapter("select * from tbl_aciklama order by aciklama asc", baglan);
            DataTable dt4 = new DataTable();
            da4.Fill(dt4);
            dataGridView4.DataSource = dt4;
            baglan.Close();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut4 = new SqlCommand("insert into tbl_aciklama (aciklama) values (@p1)", baglan);
            komut4.Parameters.AddWithValue("@p1", txtAciklama.Text);
            komut4.ExecuteNonQuery();

            baglan.Close();

        }
    }
}

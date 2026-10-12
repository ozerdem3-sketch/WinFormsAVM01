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
    public partial class Form_Kredi_Kartlari : Form
    {
        SqlConnection baglan = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DboAVM;Integrated Security=True;Trust Server Certificate=True");
        public Form_Kredi_Kartlari()
        {
            InitializeComponent();
        }

        string banka, kart, firma;
        DateTime tarih1, tarih;

        double tutar;

        void firmalar()
        {
            baglan.Open();
            SqlCommand cmd = new SqlCommand("select * from tbl_firmalar order by firma_adi asc ", baglan);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbFirma.Items.Add(dr[1]).ToString();
            }

            baglan.Close();
        }
        void temizle()
        {
            baglan.Open();
            txtTarih.Text = "";
            cmbBanka.Text = "";
            cmbBanka.Text = "";
            cmbFirma.Text = "";
            cmbKart.Text = "";
            txtTutar.Text = "0";

            baglan.Close();
        }
        void kayitlar()
        {
            baglan.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_kredi_kart order by tarih desc", baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglan.Close();

        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglan.Open();
            // txtTarih.Text = dateTimePicker1.Text;
            banka = cmbBanka.Text;
            kart = cmbKart.Text;
            firma = cmbFirma.Text;
            tutar = Convert.ToDouble(txtTutar.Text);
            SqlCommand kom = new SqlCommand("Insert into tbl_kredi_kart  (tarih,banka,kart_adi,firma,tutar) values (@p1,@p2,@p3,@p4,@p5)", baglan);
            kom.Parameters.AddWithValue("@p1", dateTimePicker1.Value);
            kom.Parameters.AddWithValue("@p2", banka);
            kom.Parameters.AddWithValue("@p3", kart);
            kom.Parameters.AddWithValue("@p4", firma);
            kom.Parameters.AddWithValue("@P5", tutar);
            kom.ExecuteNonQuery();
            baglan.Close();
            kayitlar();
            temizle();
            dateTimePicker1.Focus();

        }

        private void Form_Kredi_Kartlari_Load(object sender, EventArgs e)
        {
            firmalar();
            kayitlar();
            txtTutar.Text = 0.ToString();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            lblID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtTarih.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            cmbBanka.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbKart.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            cmbFirma.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtTutar.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();

            dateTimePicker1.Text = txtTarih.Text;

            tutar = Convert.ToDouble(txtTutar.Text);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand kom = new SqlCommand("delete tbl_kredi_kart where ID=@p1", baglan);
            kom.Parameters.AddWithValue("@p1", lblID.Text);
            kom.ExecuteNonQuery();

            baglan.Close();
            kayitlar();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglan.Open();

            tarih = dateTimePicker1.Value.Date;
            txtTarih.Text = tarih.ToString();
            banka = cmbBanka.Text;
            kart = cmbKart.Text;
            firma = cmbFirma.Text;
            tutar = Convert.ToDouble(txtTutar.Text);
            SqlCommand kom = new SqlCommand("update tbl_kredi_kart set tarih=@p1,banka=@p2,kart_adi=@p3,firma=@p4,tutar=@p5 where ID=@p6", baglan);
            kom.Parameters.AddWithValue("@p1", tarih);
            kom.Parameters.AddWithValue("@p2", banka);
            kom.Parameters.AddWithValue("@p3", kart);
            kom.Parameters.AddWithValue("@p4", firma);
            kom.Parameters.AddWithValue("@P5", tutar);
            kom.Parameters.AddWithValue("@p6", lblID.Text);
            kom.ExecuteNonQuery();
            baglan.Close();
            kayitlar();
            temizle();
            dateTimePicker1.Focus();
        }

        private void btnAnaMenuye_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class FormListeler : Form
    {
        SqlConnection baglan = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DboAVM;Integrated Security=True;Trust Server Certificate=True");
        public FormListeler()
        {
            InitializeComponent();
        }

        DateTime tarih1, tarih2, tarih3;

        string firma1, mamul1, gurup1;
        decimal miktar, fiyat, tutar, toplamtutar;

        void firmalar()
        {
            baglan.Open();

            SqlCommand cmd = new SqlCommand("select firma_adi from tbl_firmalar order by firma_adi asc", baglan);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbFirmalar.Items.Add(dr[0]);
            }
            baglan.Close();
        }

        void mamuller()
        {
            baglan.Open();
            SqlCommand cmd = new SqlCommand("select mamul_adi from tbl_cins order by mamul_adi asc", baglan);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbMamuller.Items.Add(dr[0]);
            }
            baglan.Close();
        }

        void guruplar()
        {
            baglan.Open();
            SqlCommand cmd = new SqlCommand("select gurup_adi from tbl_gurup order by gurup_adi asc", baglan);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbGuruplar.Items.Add(dr[0]);
            }
            baglan.Close();
        }

        private void FormListeler_Load(object sender, EventArgs e)
        {
            firmalar();
            mamuller();
            guruplar();
            dateTimePicker1.Value = Convert.ToDateTime("01.01.2026");
            tarih1 = dateTimePicker1.Value;
        }

        private void btnFirma_Click(object sender, EventArgs e)
        {
            baglan.Open();
            firma1 = cmbFirmalar.Text;
            tarih1 = dateTimePicker1.Value.Date;
            tarih2 = dateTimePicker2.Value.Date;

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_alim where firma=@firma1 and tarih>=@tarih1 and tarih<=@tarih2 order by tarih", baglan);
            da.SelectCommand.Parameters.AddWithValue("@tarih1", tarih1);
            da.SelectCommand.Parameters.AddWithValue("@tarih2", tarih2);
            da.SelectCommand.Parameters.AddWithValue("@firma1", firma1);

            da.Fill(dt);
            dataGridView1.DataSource = dt;


            SqlCommand cmd = new SqlCommand("select sum(miktar),sum(tutar) from tbl_alim where firma=@firma1 and tarih>=@tarih1 and tarih<=@tarih2 ", baglan);
            cmd.Parameters.AddWithValue("@tarih1", tarih1);
            cmd.Parameters.AddWithValue("@tarih2", tarih2);
            cmd.Parameters.AddWithValue("@firma1", firma1);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lblToplamMiktar.Text = dr[0].ToString();
                lblToplamTutar.Text = dr[1].ToString();
            }

            baglan.Close();
        }

        private void btnMamul_Click(object sender, EventArgs e)
        {
            baglan.Open();
            mamul1 = cmbMamuller.Text;

            tarih2 = dateTimePicker2.Value.Date;

            tarih1 = dateTimePicker1.Value.Date;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_alim where cins like '" + @mamul1 + "%' and tarih>=@tarih1 and tarih<=@tarih2 order by tarih", baglan);
            da.SelectCommand.Parameters.AddWithValue("@tarih1", tarih1);
            da.SelectCommand.Parameters.AddWithValue("@tarih2", tarih2);
            da.SelectCommand.Parameters.AddWithValue("@mamul1", mamul1);

            da.Fill(dt);
            dataGridView1.DataSource = dt;


            SqlCommand cmd = new SqlCommand("select sum(miktar),sum(tutar) from tbl_alim where cins like '" + mamul1 + "%'  and tarih>=@tarih1 and tarih<=@tarih2 ", baglan);
            cmd.Parameters.AddWithValue("@tarih1", tarih1);
            cmd.Parameters.AddWithValue("@tarih2", tarih2);
            cmd.Parameters.AddWithValue("@mamul1", mamul1);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lblToplamMiktar.Text = dr[0].ToString();
                lblToplamTutar.Text = dr[1].ToString();
            }
            baglan.Close();
        }

        private void btnGurup_Click(object sender, EventArgs e)
        {
            baglan.Open();
            gurup1 = cmbGuruplar.Text;
            tarih1 = dateTimePicker1.Value.Date;
            tarih2 = dateTimePicker2.Value.Date;

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_alim where grup_adi=@gurup1 and tarih>=@tarih1 and tarih<=@tarih2 order by tarih", baglan);
            da.SelectCommand.Parameters.AddWithValue("@tarih1", tarih1);
            da.SelectCommand.Parameters.AddWithValue("@tarih2", tarih2);
            da.SelectCommand.Parameters.AddWithValue("@gurup1", gurup1);

            da.Fill(dt);
            dataGridView1.DataSource = dt;


            SqlCommand cmd = new SqlCommand("select sum(miktar),sum(tutar) from tbl_alim where grup_adi=@gurup1 and tarih>=@tarih1 and tarih<=@tarih2 ", baglan);
            cmd.Parameters.AddWithValue("@tarih1", tarih1);
            cmd.Parameters.AddWithValue("@tarih2", tarih2);
            cmd.Parameters.AddWithValue("@gurup1", gurup1);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lblToplamMiktar.Text = dr[0].ToString();
                lblToplamTutar.Text = dr[1].ToString();
            }
            baglan.Close();
        }

        private void btnFirmaMamul_Click(object sender, EventArgs e)
        {
            baglan.Open();
            firma1 = cmbFirmalar.Text;
            mamul1 = cmbMamuller.Text;
            tarih1 = dateTimePicker1.Value;
            tarih2 = dateTimePicker2.Value.Date;

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_alim where firma=@firma1 and cins Like '" + mamul1 + "%' and tarih>=@tarih1 and tarih<=@tarih2 order by tarih", baglan);
            da.SelectCommand.Parameters.AddWithValue("@tarih1", tarih1);
            da.SelectCommand.Parameters.AddWithValue("@tarih2", tarih2);
            da.SelectCommand.Parameters.AddWithValue("@firma1", firma1);
            da.SelectCommand.Parameters.AddWithValue("@mamul1", mamul1);
            da.Fill(dt);
            dataGridView1.DataSource = dt;


            SqlCommand cmd = new SqlCommand("select sum(miktar),sum(tutar) from tbl_alim where firma=@firma1 and tarih>=@tarih1 and tarih<=@tarih2 ", baglan);
            cmd.Parameters.AddWithValue("@tarih1", tarih1);
            cmd.Parameters.AddWithValue("@tarih2", tarih2);
            cmd.Parameters.AddWithValue("@firma1", firma1);
            cmd.Parameters.AddWithValue("@mamul1", mamul1);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lblToplamMiktar.Text = dr[0].ToString();
                lblToplamTutar.Text = dr[1].ToString();
            }
            baglan.Close();

        }

        private void btnFirmaGurup_Click(object sender, EventArgs e)
        {
            baglan.Open();
            firma1 = cmbFirmalar.Text;
            gurup1 = cmbGuruplar.Text;
            tarih1 = dateTimePicker1.Value;
            tarih2 = dateTimePicker2.Value.Date;

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_alim where firma=@firma1 and grup_adi=@gurup1 and tarih>=@tarih1 and tarih<=@tarih2 order by tarih", baglan);
            da.SelectCommand.Parameters.AddWithValue("@tarih1", tarih1);
            da.SelectCommand.Parameters.AddWithValue("@tarih2", tarih2);
            da.SelectCommand.Parameters.AddWithValue("@firma1", firma1);
            da.SelectCommand.Parameters.AddWithValue("@gurup1", gurup1);
            da.Fill(dt);
            dataGridView1.DataSource = dt;


            SqlCommand cmd = new SqlCommand("select sum(miktar),sum(tutar) from tbl_alim where firma=@firma1 and tarih>=@tarih1 and tarih<=@tarih2 ", baglan);
            cmd.Parameters.AddWithValue("@tarih1", tarih1);
            cmd.Parameters.AddWithValue("@tarih2", tarih2);
            cmd.Parameters.AddWithValue("@firma1", firma1);
            cmd.Parameters.AddWithValue("@gurup1", gurup1);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lblToplamMiktar.Text = dr[0].ToString();
                lblToplamTutar.Text = dr[1].ToString();
            }
            baglan.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbFirmalar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            lblID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtTarih.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            cmbFirmalar.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbMamuller.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            cmbGuruplar.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtMiktar.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtFiyat.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            txtTutar.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();

            tarih3 = Convert.ToDateTime(txtTarih.Text);
            miktar = Convert.ToDecimal(txtMiktar.Text);
            fiyat = Convert.ToDecimal(txtFiyat.Text);

            tutar = Convert.ToDecimal(txtTutar.Text);
            txtTarih.Text = tarih3.ToString("dd.MM.yyyy");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //private void btnGuncelle_Click(object sender, EventArgs e)
        //{
        //    
        //}

        private void btnTariheGore_Click(object sender, EventArgs e)
        {
            baglan.Open();

            tarih1 = dateTimePicker1.Value.Date;
            tarih2 = dateTimePicker2.Value.Date;

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_alim where  tarih>=@tarih1 and tarih<=@tarih2 order by tarih", baglan);
            da.SelectCommand.Parameters.AddWithValue("@tarih1", tarih1);
            da.SelectCommand.Parameters.AddWithValue("@tarih2", tarih2);


            da.Fill(dt);
            dataGridView1.DataSource = dt;


            SqlCommand cmd = new SqlCommand("select sum(miktar),sum(tutar) from tbl_alim where tarih>=@tarih1 and tarih<=@tarih2 ", baglan);
            cmd.Parameters.AddWithValue("@tarih1", tarih1);
            cmd.Parameters.AddWithValue("@tarih2", tarih2);


            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lblToplamMiktar.Text = dr[0].ToString();
                lblToplamTutar.Text = dr[1].ToString();
            }

            baglan.Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglan.Open();
            tarih3 = Convert.ToDateTime(txtTarih.Text);
            miktar = Convert.ToDecimal(txtMiktar.Text);
            fiyat = Convert.ToDecimal(txtFiyat.Text);
            tutar = Convert.ToDecimal(txtTutar.Text);

            if (miktar == 0 && fiyat != 0 && tutar != 0)
            {
                miktar = tutar / fiyat;
                txtMiktar.Text = miktar.ToString();
            }
            if (miktar != 0 && fiyat == 0 && tutar != 0)
            {
                fiyat = tutar / miktar;
                txtFiyat.Text = fiyat.ToString();
            }
            if (miktar != 0 && fiyat != 0 && tutar == 0)
            {
                tutar = miktar * fiyat;
                txtTutar.Text = tutar.ToString();
            }


            Microsoft.Data.SqlClient.SqlCommand cmd = new Microsoft.Data.SqlClient.SqlCommand("update tbl_alim set tarih=@p1,firma=@p2,cins=@p3,grup_adi=@p4,miktar=@p5,fiyat=@p6,tutar=@p7 where ID=@p8", baglan);
            cmd.Parameters.AddWithValue("@p1", tarih3);
            cmd.Parameters.AddWithValue("@p2", cmbFirmalar.Text);
            cmd.Parameters.AddWithValue("@p3", cmbMamuller.Text);
            cmd.Parameters.AddWithValue("@p4", cmbGuruplar.Text);
            cmd.Parameters.AddWithValue("@p5", miktar);
            cmd.Parameters.AddWithValue("@p6", fiyat);
            cmd.Parameters.AddWithValue("@p7", tutar);
            cmd.Parameters.AddWithValue("@p8", lblID.Text);
            cmd.ExecuteNonQuery();

            baglan.Close();
        }
    }
}
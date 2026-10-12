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
    public partial class Form2 : Form
    {
        Microsoft.Data.SqlClient.SqlConnection baglan = new Microsoft.Data.SqlClient.SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DboAVM;Integrated Security=True;Trust Server Certificate=True");

        public Form2()
        {
            InitializeComponent();
        }

        DateTime tarih;
        decimal miktar, fiyat, tutar;
        string firma, mamul, gurup;

        void firmalistesi()
        {
            baglan.Open();
            Microsoft.Data.SqlClient.SqlCommand komut1 = new Microsoft.Data.SqlClient.SqlCommand("select firma_adi from tbl_firmalar order by firma_adi", baglan);
            Microsoft.Data.SqlClient.SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                firma = cmbFirma.Items.Add(dr1[0]).ToString();

            }
            cmbFirma.Text = firma;
            baglan.Close();
        }

        void cinslistesi()
        {
            baglan.Open();
            Microsoft.Data.SqlClient.SqlCommand komut2 = new Microsoft.Data.SqlClient.SqlCommand("select mamul_adi from tbl_cins order by mamul_adi", baglan);
            Microsoft.Data.SqlClient.SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                mamul = cmbMamul.Items.Add(dr2[0]).ToString();

            }
            cmbMamul.Text = mamul;

            baglan.Close();
        }

        void guruplistesi()
        {
            baglan.Open();
            Microsoft.Data.SqlClient.SqlCommand komut3 = new Microsoft.Data.SqlClient.SqlCommand("select gurup_adi from tbl_gurup order by gurup_adi", baglan);
            Microsoft.Data.SqlClient.SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                gurup = cmbGurup.Items.Add(dr3[0]).ToString();

            }
            cmbGurup.Text = gurup;

            baglan.Close();

        }

        void girislistesi()
        {
            baglan.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select *  from tbl_alim  order by tarih desc", baglan);

            da.Fill(dt);
            dataGridView1.DataSource = dt;

            baglan.Close();
        }

        void temizle()
        {
            baglan.Open();
            txtFiyat.Text = "0";
            txtMiktar.Text = "0";
            txtTutar.Text = "0";
            cmbMamul.Text = "";
            cmbMamul.Focus();
            baglan.Close();
        }

        void temizletam()
        {
            baglan.Open();
            txtTarih.Text = "";
            cmbFirma.Text = "";
            cmbGurup.Text = "";
            txtFiyat.Text = "0";
            txtMiktar.Text = "0";
            txtTutar.Text = "0";
            cmbMamul.Text = "";
            baglan.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cmbMamul.Text = "";
            cmbGurup.Text = "";
            cmbFirma.Text = "";
            firmalistesi();
            cinslistesi();
            guruplistesi();
            girislistesi();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            tarih = dateTimePicker1.Value.Date;
            firma = cmbFirma.Text;
            mamul = cmbMamul.Text;
            gurup = cmbGurup.Text;
            miktar = Convert.ToDecimal(txtMiktar.Text);
            fiyat = Convert.ToDecimal(txtFiyat.Text);
            tutar = Convert.ToDecimal(txtTutar.Text);

            if (fiyat == 0 && miktar > 0 && tutar > 0) fiyat = tutar / miktar;

            if (fiyat > 0 && tutar > 0 && miktar == 0) miktar = tutar / fiyat;

            if (fiyat > 0 && miktar > 0 && tutar == 0) tutar = miktar * fiyat;

            baglan.Open();
            Microsoft.Data.SqlClient.SqlCommand cmd = new Microsoft.Data.SqlClient.SqlCommand("insert into tbl_alim (tarih,firma,cins,grup_adi,miktar,fiyat,tutar) values" +
                "(@p1,@p2,@p3,@p4,@p5,@p6,@p7)", baglan);
            cmd.Parameters.AddWithValue("@p1", dateTimePicker1.Value.Date);
            cmd.Parameters.AddWithValue("@p2", firma);
            cmd.Parameters.AddWithValue("@p3", mamul);
            cmd.Parameters.AddWithValue("@p4", gurup);
            cmd.Parameters.AddWithValue("@p5", miktar);
            cmd.Parameters.AddWithValue("@p6", fiyat);
            cmd.Parameters.AddWithValue("@p7", tutar);

            cmd.ExecuteNonQuery();

            baglan.Close();
            girislistesi();
            temizle();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglan.Open();
            Microsoft.Data.SqlClient.SqlCommand komut1 = new Microsoft.Data.SqlClient.SqlCommand("delete tbl_Alim where ID=@p1", baglan);
            komut1.Parameters.AddWithValue("@p1", lblID.Text);

            komut1.ExecuteNonQuery();
            baglan.Close();
            girislistesi();
            temizletam();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            lblID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtTarih.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            cmbFirma.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbMamul.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            cmbGurup.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtMiktar.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtFiyat.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            txtTutar.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();


        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            tarih = Convert.ToDateTime(txtTarih.Text);
            firma = cmbFirma.Text;
            mamul = cmbMamul.Text;
            gurup = cmbGurup.Text;
            miktar = Convert.ToDecimal(txtMiktar.Text);
            fiyat = Convert.ToDecimal(txtFiyat.Text);
            tutar = Convert.ToDecimal(txtTutar.Text);

            if (fiyat == 0 && miktar > 0 && tutar > 0) fiyat = tutar / miktar;

            if (fiyat > 0 && tutar > 0 && miktar == 0) miktar = tutar / fiyat;

            if (fiyat > 0 && miktar > 0 && tutar == 0) tutar = miktar * fiyat;

            baglan.Open();
            Microsoft.Data.SqlClient.SqlCommand cmd1 = new Microsoft.Data.SqlClient.SqlCommand("update tbl_alim set tarih=@p1,firma=@p2,cins=@p3,grup_adi=@p4," +
                "miktar=@p5,fiyat=@p6,tutar=@p7 where ID=@p8", baglan);
            cmd1.Parameters.AddWithValue("@p1", tarih);
            cmd1.Parameters.AddWithValue("@p2", firma);
            cmd1.Parameters.AddWithValue("@p3", mamul);
            cmd1.Parameters.AddWithValue("@p4", gurup);
            cmd1.Parameters.AddWithValue("@p5", miktar);
            cmd1.Parameters.AddWithValue("@p6", fiyat);
            cmd1.Parameters.AddWithValue("@p7", tutar);
            cmd1.Parameters.AddWithValue("@p8", lblID.Text);

            cmd1.ExecuteNonQuery();

            baglan.Close();

            girislistesi();
            temizletam();
        }

        private void btnFirma_Click(object sender, EventArgs e)
        {

            baglan.Open();
            SqlCommand kom1 = new SqlCommand("insert into tbl_firmalar (firma_adi) values (@p1)", baglan);
            kom1.Parameters.AddWithValue("@p1", cmbFirma.Text);
            kom1.ExecuteNonQuery();

            baglan.Close();
            cmbMamul.Focus();
        }

        private void btnCins_Click(object sender, EventArgs e)
        {

            baglan.Open();
            SqlCommand kom2 = new SqlCommand("insert into tbl_cins (mamul_adi) values (@p1)", baglan);
            kom2.Parameters.AddWithValue("@p1", cmbMamul.Text);
            kom2.ExecuteNonQuery();

            baglan.Close();
            cmbGurup.Focus();
        }

        private void btnGurup_Click(object sender, EventArgs e)
        {

            baglan.Open();
            SqlCommand kom3 = new SqlCommand("insert into tbl_gurup (gurup_adi) values (@p1)", baglan);
            kom3.Parameters.AddWithValue("@p1", cmbGurup.Text);
            kom3.ExecuteNonQuery();

            baglan.Close();
            txtMiktar.Focus();
        }
    }
}

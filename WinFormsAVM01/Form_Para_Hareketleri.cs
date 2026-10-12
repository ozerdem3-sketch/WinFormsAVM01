using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Policy;
using System.Text;
using System.Windows.Forms;

namespace WinFormsAVM01
{
    public partial class Form_Para_Hareketleri : Form
    {
        SqlConnection baglan = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DboAVM;Integrated Security=True;Trust Server Certificate=True");
        public Form_Para_Hareketleri()
        {
            InitializeComponent();
        }

        string firma, aciklama, gurup;
        decimal girentl, cikantl, girendolar, cikandolar, gireneuro, cikaneuro, giren24k, cikan24k, giren22k, cikan22k;
        decimal girentam, cikantam, girenyarim, cikanyarim, girenceyrek, cikanceyrek, fonyp4giren, fonyp4cikan, fonyp4fiyat;
        DateTime tarih1;

        void aciklamalistesia()
        {
            baglan.Open();
            SqlCommand cmd = new SqlCommand("select aciklama from tbl_aciklama order by aciklama asc", baglan);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                cmbAciklama.Items.Add(rdr[0]).ToString();
            }
            baglan.Close();

        }

        void kayitlar()
        {
            baglan.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_para_hareketleri order by tarih desc", baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglan.Close();

        }

        private void btnAciklamaKaydet_Click(object sender, EventArgs e)
        {
            baglan.Open();
            string aciklama1 = cmbAciklama.Text;
            SqlCommand cmd = new SqlCommand("insert into tbl_aciklama (aciklama) values (@p1)", baglan);
            cmd.Parameters.AddWithValue("@p1", aciklama1);
            cmd.ExecuteNonQuery();
            baglan.Close();
            aciklamalistesia();
            cmbGrup.Focus();
        }

        void temizle()
        {
            baglan.Open();
            txtID.Text = "";
            cmbBanka.Text = "";
            txtTarih.Text = "";
            cmbAciklama.Text = "";
            cmbGrup.Text = "";
            txtGirenTL.Text = "";
            txtCikanTL.Text = "";
            txtGirenDolar.Text = "";
            txtCikanDolar.Text = "";
            txtGirenEuro.Text = "";
            txtCikanEuro.Text = "";
            txtGiren24K.Text = "";
            txtCikan24K.Text = "";
            txtGiren22K.Text = "";
            txtCikan22K.Text = "";
            txtGirenCeyrek.Text = "";
            txtCikanCeyrek.Text = "";
            txtGirenYarim.Text = "";
            txtCikanYarim.Text = "";
            txtGirenTam.Text = "";
            txtCikanTam.Text = "";
            txtGirFonYP4.Text = "";
            txtCikFonYP4.Text = "";
            txtFiyatYP4.Text = "";

            baglan.Close();
        }

        void giristemizle()
        {
            baglan.Open();
            cmbAciklama.Text = "";
            cmbBanka.Text = "";
            cmbGrup.Text = "";
            txtID.Text = "";
            cmbBanka.Text = "";
            txtTarih.Text = "";
            cmbAciklama.Text = "";
            cmbGrup.Text = "";
            txtGirenTL.Text = "0";
            txtCikanTL.Text = "0";

            txtGirenDolar.Text = "0";
            txtCikanDolar.Text = "0";
            txtGirenEuro.Text = "0";
            txtCikanEuro.Text = "0";
            txtGiren24K.Text = "0";
            txtCikan24K.Text = "0";
            txtGiren22K.Text = "0";
            txtCikan22K.Text = "0";
            txtGirenCeyrek.Text = "0";
            txtCikanCeyrek.Text = "0";
            txtGirenYarim.Text = "0";
            txtCikanYarim.Text = "0";
            txtGirenTam.Text = "0";
            txtCikanTam.Text = "0";
            txtGirFonYP4.Text = "0";
            txtCikFonYP4.Text = "0";
            txtFiyatYP4.Text = "0";

            baglan.Close();
        }

        private void Form_Para_Hareketleri_Load(object sender, EventArgs e)
        {
            aciklamalistesia();
            kayitlar();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglan.Open();
            firma = cmbBanka.Text;
            tarih1 = dateTimePicker1.Value.Date;
            aciklama = cmbAciklama.Text;
            gurup = cmbGrup.Text;
            girentl = Convert.ToDecimal(txtGirenTL.Text);
            cikantl = Convert.ToDecimal(txtCikanTL.Text);
            girendolar = Convert.ToDecimal(txtGirenDolar.Text);
            cikandolar = Convert.ToDecimal(txtCikanDolar.Text);
            gireneuro = Convert.ToDecimal(txtGirenEuro.Text);
            cikaneuro = Convert.ToDecimal(txtCikanEuro.Text);
            giren22k = Convert.ToDecimal(txtGiren22K.Text);
            cikan22k = Convert.ToDecimal(txtGiren22K.Text);
            giren24k = Convert.ToDecimal(txtGiren24K.Text);
            cikan24k = Convert.ToDecimal(txtCikan24K.Text);
            girentam = Convert.ToDecimal(txtGirenTam.Text);
            cikantam = Convert.ToDecimal(txtCikanTam.Text);
            girenyarim = Convert.ToDecimal(txtGirenYarim.Text);
            cikanyarim = Convert.ToDecimal(txtCikanYarim.Text);
            girenceyrek = Convert.ToDecimal(txtGirenCeyrek.Text);
            cikanceyrek = Convert.ToDecimal(txtCikanCeyrek.Text);
            fonyp4giren = Convert.ToDecimal(txtGirFonYP4.Text);
            fonyp4cikan = Convert.ToDecimal(txtCikFonYP4.Text);
            fonyp4fiyat = Convert.ToDecimal(txtFiyatYP4.Text);

            SqlCommand komut1 = new SqlCommand("insert into tbl_Para_Hareketleri (firma,tarih,aciklama,gurup,TL_yatan,TL_cekilen,dol_yatan,dol_cekilen,euro_yatan,euro_cekilen,k24_gr_yatan,k24_gr_cekilen,k22_gr_yatan,k22_gr_cekilen,ceyrek_yatan,ceyrek_cekilen,yarim_yatan,yarim_cekilen,tam_yatan,tam_cekilen,fon_yp4_yatan,fon_yp4_cekilen,fon_yp4_Fiyat_dolar) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14,@p15,@p16,@p17,@p18,@p19,@p20,@p21,@p22,@p23)", baglan);
            komut1.Parameters.AddWithValue("@p1", firma);
            komut1.Parameters.AddWithValue("@p2", tarih1);
            komut1.Parameters.AddWithValue("@p3", aciklama);
            komut1.Parameters.AddWithValue("@p4", gurup);
            komut1.Parameters.AddWithValue("@p5", girentl);
            komut1.Parameters.AddWithValue("@p6", cikantl);
            komut1.Parameters.AddWithValue("@p7", girendolar);
            komut1.Parameters.AddWithValue("@p8", cikandolar);
            komut1.Parameters.AddWithValue("@p9", gireneuro);
            komut1.Parameters.AddWithValue("@p10", cikaneuro);
            komut1.Parameters.AddWithValue("@p11", giren24k);
            komut1.Parameters.AddWithValue("@p12", cikan24k);
            komut1.Parameters.AddWithValue("@p13", giren22k);
            komut1.Parameters.AddWithValue("@p14", cikan22k);
            komut1.Parameters.AddWithValue("@p15", girenceyrek);
            komut1.Parameters.AddWithValue("@p16", cikanceyrek);
            komut1.Parameters.AddWithValue("@p17", girenyarim);
            komut1.Parameters.AddWithValue("@p18", cikanyarim);
            komut1.Parameters.AddWithValue("@p19", girentam);
            komut1.Parameters.AddWithValue("@p20", cikantam);
            komut1.Parameters.AddWithValue("@p21", fonyp4giren);
            komut1.Parameters.AddWithValue("@p22", fonyp4cikan);
            komut1.Parameters.AddWithValue("@p23", fonyp4fiyat);


            komut1.ExecuteNonQuery();


            baglan.Close();
            aciklamalistesia();
            kayitlar();
            giristemizle();
            cmbBanka.Focus();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            baglan.Open();
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            cmbBanka.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            tarih1 = Convert.ToDateTime(dataGridView1.Rows[secilen].Cells[2].Value.ToString());
            cmbAciklama.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            cmbGrup.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtGirenTL.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtCikanTL.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            txtGirenDolar.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            txtCikanDolar.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            txtGirenEuro.Text = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
            txtCikanEuro.Text = dataGridView1.Rows[secilen].Cells[10].Value.ToString();
            txtGiren24K.Text = dataGridView1.Rows[secilen].Cells[11].Value.ToString();
            txtCikan24K.Text = dataGridView1.Rows[secilen].Cells[12].Value.ToString();
            txtGiren22K.Text = dataGridView1.Rows[secilen].Cells[13].Value.ToString();
            txtCikan22K.Text = dataGridView1.Rows[secilen].Cells[14].Value.ToString();
            txtGirenCeyrek.Text = dataGridView1.Rows[secilen].Cells[15].Value.ToString();
            txtCikanCeyrek.Text = dataGridView1.Rows[secilen].Cells[16].Value.ToString();
            txtGirenYarim.Text = dataGridView1.Rows[secilen].Cells[17].Value.ToString();
            txtCikanYarim.Text = dataGridView1.Rows[secilen].Cells[18].Value.ToString();
            txtGirenTam.Text = dataGridView1.Rows[secilen].Cells[19].Value.ToString();
            txtCikanTam.Text = dataGridView1.Rows[secilen].Cells[20].Value.ToString();
            txtGirFonYP4.Text = dataGridView1.Rows[secilen].Cells[21].Value.ToString();
            txtCikFonYP4.Text = dataGridView1.Rows[secilen].Cells[22].Value.ToString();
            txtFiyatYP4.Text = dataGridView1.Rows[secilen].Cells[23].Value.ToString();

            baglan.Close();
            //tarih1 = Convert.ToDateTime(txtTarih.Text);
            dateTimePicker1.Value = tarih1;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand kom = new SqlCommand("delete  from tbl_para_hareketleri where ID=@p1", baglan);
            kom.Parameters.AddWithValue("@p1", txtID.Text);

            kom.ExecuteNonQuery();
            baglan.Close();
            kayitlar();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglan.Open();
            girentl = Convert.ToDecimal(txtGirenTL.Text);
            cikantl = Convert.ToDecimal(txtCikanTL.Text);
            girendolar = Convert.ToDecimal(txtGirenDolar.Text);
            cikandolar = Convert.ToDecimal(txtCikanDolar.Text);
            gireneuro = Convert.ToDecimal(txtGirenEuro.Text);
            cikaneuro = Convert.ToDecimal(txtCikanEuro.Text);
            giren24k = Convert.ToDecimal(txtGiren24K.Text);
            cikan24k = Convert.ToDecimal(txtCikan24K.Text);
            giren22k = Convert.ToDecimal(txtGiren22K.Text);
            cikan22k = Convert.ToDecimal(txtCikan22K.Text);
            girenceyrek = Convert.ToDecimal(txtGirenCeyrek.Text);
            cikanceyrek = Convert.ToDecimal(txtCikanCeyrek.Text);
            girenyarim = Convert.ToDecimal(txtGirenYarim.Text);
            cikanyarim = Convert.ToDecimal(txtCikanYarim.Text);
            girentam = Convert.ToDecimal(txtGirenTam.Text);
            cikantam = Convert.ToDecimal(txtCikanTam.Text);
            fonyp4giren = Convert.ToDecimal(txtGirFonYP4.Text);
            fonyp4cikan = Convert.ToDecimal(txtCikFonYP4.Text);
            fonyp4fiyat = Convert.ToDecimal(txtFiyatYP4.Text);

            SqlCommand komut1 = new SqlCommand("update tbl_para_hareketleri set firma=@p1,tarih=@p2,aciklama=@p3,gurup=@p4,tl_yatan=@p5,tl_cekilen=@p6,dol_yatan=@p7,dol_cekilen=@p8,euro_yatan=@p9,euro_cekilen=@p10,k24_gr_yatan=@p11,k24_gr_cekilen=@p12,k22_gr_yatan=@p13,k22_gr_cekilen=@p14,ceyrek_yatan=@p15,ceyrek_cekilen=@p16,Yarim_yatan=@p17,yarim_cekilen=@p18,tam_yatan=@p19,tam_cekilen=@p20,fon_yp4_yatan=@p21,fon_yp4_cekilen=@p22,fon_yp4_fiyat_dolar=@p23 where ID=@p24", baglan);

            komut1.Parameters.AddWithValue("@p1", cmbBanka.Text);
            komut1.Parameters.AddWithValue("@p2", dateTimePicker1.Value.Date);
            komut1.Parameters.AddWithValue("@p3", cmbAciklama.Text);
            komut1.Parameters.AddWithValue("@p4", cmbGrup.Text);
            komut1.Parameters.AddWithValue("@p5", girentl);
            komut1.Parameters.AddWithValue("@p6", cikantl);
            komut1.Parameters.AddWithValue("@p7", girendolar);
            komut1.Parameters.AddWithValue("@p8", cikandolar);
            komut1.Parameters.AddWithValue("@p9", gireneuro);
            komut1.Parameters.AddWithValue("@p10", cikaneuro);
            komut1.Parameters.AddWithValue("@p11", giren24k);
            komut1.Parameters.AddWithValue("@p12", cikan24k);
            komut1.Parameters.AddWithValue("@p13", giren22k);
            komut1.Parameters.AddWithValue("@p14", cikan22k);
            komut1.Parameters.AddWithValue("@p15", girenceyrek);
            komut1.Parameters.AddWithValue("@p16", cikanceyrek);
            komut1.Parameters.AddWithValue("@p17", girenyarim);
            komut1.Parameters.AddWithValue("@p18", cikanyarim);
            komut1.Parameters.AddWithValue("@p19", girentam);
            komut1.Parameters.AddWithValue("@p20", cikantam);
            komut1.Parameters.AddWithValue("@p21", fonyp4giren);
            komut1.Parameters.AddWithValue("@p22", fonyp4cikan);
            komut1.Parameters.AddWithValue("@p23", fonyp4fiyat);
            komut1.Parameters.AddWithValue("@p24", txtID.Text);

            komut1.ExecuteNonQuery();

            baglan.Close();
            kayitlar();
            giristemizle();
            cmbBanka.Focus();

        }

        private void btnMemuye_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

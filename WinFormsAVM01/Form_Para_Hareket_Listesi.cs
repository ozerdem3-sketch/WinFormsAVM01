using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;


namespace WinFormsAVM01
{
    public partial class Form_Para_Hareket_Listesi : Form
    {
        Microsoft.Data.SqlClient.SqlConnection baglanti = new Microsoft.Data.SqlClient.SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DboAVM;Integrated Security=True;Trust Server Certificate=True");

        public Form_Para_Hareket_Listesi()
        {
            InitializeComponent();
        }

        DateTime tarih1, tarih2;
        string banka, aciklama, gurup;
        decimal tlyatan, tlcekilen, dolaryatan, dolarcekilen, euroyatan, eurocekilen, k24yatan, k24cekilen, k22yatan, k22cekilen;
        decimal tlgiren, tlcikan, dolargiren, dolarcikan, eurogiren, eurocikan, k24giren, k24cikan, k22giren, k22cikan;






        void aciklamalistesi()
        {
            baglanti.Open();
            SqlCommand cmd1 = new SqlCommand("select * from tbl_Aciklama order by aciklama asc", baglanti);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                cmbAciklama.Items.Add(dr1[1]).ToString();
            }
            baglanti.Close();
        }

        void hareketlistesi()
        {
            baglanti.Open();

            DataTable dt = new DataTable();
            Microsoft.Data.SqlClient.SqlDataAdapter da = new Microsoft.Data.SqlClient.SqlDataAdapter("select * from tbl_Para_Hareketleri order by tarih desc", baglanti);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            baglanti.Close();

        }

        void bakiyelistesi()
        {

        }


        private void Form_Para_Hareket_Listesi_Load(object sender, EventArgs e)
        {
            aciklamalistesi();
            // hareketlistesi();
        }

        private void btnBankaTarih_Click(object sender, EventArgs e)        //&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&
        {
            tarih1 = (dateTimePicker1.Value);
            tarih2 = (dateTimePicker2.Value);
            banka = cmbBanka.Text;
            baglanti.Open();
            DataTable dt = new DataTable();
            Microsoft.Data.SqlClient.SqlDataAdapter da = new Microsoft.Data.SqlClient.SqlDataAdapter("select * from tbl_Para_Hareketleri where tarih>=@tarih1 and tarih<=@tarih2 and firma=@p3", baglanti);
            da.SelectCommand.Parameters.AddWithValue("@tarih1", tarih1);
            da.SelectCommand.Parameters.AddWithValue("@tarih2", tarih2);
            da.SelectCommand.Parameters.AddWithValue("@p3", banka);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            baglanti.Close();





        }

        private void btnAciklamaTarih_Click(object sender, EventArgs e)     //&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&
        {
            tarih1 = (dateTimePicker1.Value);
            tarih2 = (dateTimePicker2.Value);
            aciklama = cmbAciklama.Text;
            baglanti.Open();
            DataTable dt2 = new DataTable();
            Microsoft.Data.SqlClient.SqlDataAdapter da2 = new Microsoft.Data.SqlClient.SqlDataAdapter("select * from tbl_Para_Hareketleri where tarih>= @tarih1 and tarih<= @tarih2 and aciklama like '" + aciklama + "%' ", baglanti);
            da2.SelectCommand.Parameters.AddWithValue("@tarih1", tarih1);
            da2.SelectCommand.Parameters.AddWithValue("@tarih2", tarih2);

            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;

            baglanti.Close();



            baglanti.Open();
            Microsoft.Data.SqlClient.SqlCommand kom11 = new Microsoft.Data.SqlClient.SqlCommand("select sum(tl_yatan), sum(tl_cekilen), sum(dol_yatan), sum(dol_cekilen), sum(euro_yatan), sum(euro_cekilen), sum(k24_gr_yatan), sum(k24_gr_cekilen), sum(k22_gr_yatan), sum(k22_gr_cekilen) from tbl_Para_Hareketleri where aciklama like '" + aciklama + "%'" +
                "and tarih>= @tarih1 and tarih<= @tarih2", baglanti);
            kom11.Parameters.AddWithValue("@tarih1", tarih1);
            kom11.Parameters.AddWithValue("@tarih2", tarih2);

            Microsoft.Data.SqlClient.SqlDataReader dr11 = kom11.ExecuteReader();

            while (dr11.Read())
            {
                tlgiren = dr11[0] == DBNull.Value ? 0m : Convert.ToDecimal(dr11[0]);
                tlcikan = dr11[1] == DBNull.Value ? 0m : Convert.ToDecimal(dr11[1]);
                dolargiren = dr11[2] == DBNull.Value ? 0m : Convert.ToDecimal(dr11[2]);
                dolarcikan = dr11[3] == DBNull.Value ? 0m : Convert.ToDecimal(dr11[3]);
                eurogiren = dr11[4] == DBNull.Value ? 0m : Convert.ToDecimal(dr11[4]);
                eurocikan = dr11[5] == DBNull.Value ? 0m : Convert.ToDecimal(dr11[5]);
                k24giren = dr11[6] == DBNull.Value ? 0m : Convert.ToDecimal(dr11[6]);
                k24cikan = dr11[7] == DBNull.Value ? 0m : Convert.ToDecimal(dr11[7]);
                k22giren = dr11[8] == DBNull.Value ? 0m : Convert.ToDecimal(dr11[8]);
                k22cikan = dr11[9] == DBNull.Value ? 0m : Convert.ToDecimal(dr11[9]);
            }
            lblGirenEuro.Text = eurogiren.ToString("#,##0.00") + " €";
            lblCikanDol.Text = dolarcikan.ToString("#,##0.00") + " $";
            lblCikanTL.Text = tlcikan.ToString("#,##0.00") + " ₺";
            lblGirenDol.Text = dolargiren.ToString("#,##0.00") + " $";
            lblGirenTL.Text = tlgiren.ToString("#,##0.00") + " ₺";
            lblCikan24KGr.Text = k24cikan.ToString("#,##0.00") + " gr";
            lblGiren22KGr.Text = k22giren.ToString("#,##0.00") + " gr";
            lblCikan22KGr.Text = k22cikan.ToString("#,##0.00") + " gr";
            lblGiren24KGr.Text = k24giren.ToString("#,##0.00") + " gr";
            lblCikanEuro.Text = eurocikan.ToString("#,##0.00") + " €";
            baglanti.Close();
        }

        private void cmbGurupTarih_Click(object sender, EventArgs e)
        {
            tarih1 = (dateTimePicker1.Value);
            tarih2 = (dateTimePicker2.Value);
            gurup = cmbGurup.Text;
            baglanti.Open();
            DataTable dt2 = new DataTable();
            Microsoft.Data.SqlClient.SqlDataAdapter da2 = new Microsoft.Data.SqlClient.SqlDataAdapter("select * from tbl_Para_Hareketleri where tarih>= @tarih1 and tarih<= @tarih2 and gurup like '" + gurup + "%'", baglanti);
            da2.SelectCommand.Parameters.AddWithValue("@tarih1", tarih1);
            da2.SelectCommand.Parameters.AddWithValue("@tarih2", tarih2);

            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;

            baglanti.Close();

            baglanti.Open();
            Microsoft.Data.SqlClient.SqlCommand kom11 = new Microsoft.Data.SqlClient.SqlCommand("select sum(tl_yatan), sum(tl_cekilen), sum(dol_yatan), sum(dol_cekilen), sum(euro_yatan), sum(euro_cekilen), sum(k24_gr_yatan), sum(k24_gr_cekilen), sum(k22_gr_yatan), sum(k22_gr_cekilen) from tbl_Para_Hareketleri where gurup like '" + gurup + "%'", baglanti);

            Microsoft.Data.SqlClient.SqlDataReader dr11 = kom11.ExecuteReader();
            while (dr11.Read())
            {
                tlgiren = dr11[0] == DBNull.Value ? 0m : Convert.ToDecimal(dr11[0]);
                tlcikan = dr11[1] == DBNull.Value ? 0m : Convert.ToDecimal(dr11[1]);
                dolargiren = dr11[2] == DBNull.Value ? 0m : Convert.ToDecimal(dr11[2]);
                dolarcikan = dr11[3] == DBNull.Value ? 0m : Convert.ToDecimal(dr11[3]);
                eurogiren = dr11[4] == DBNull.Value ? 0m : Convert.ToDecimal(dr11[4]);
                eurocikan = dr11[5] == DBNull.Value ? 0m : Convert.ToDecimal(dr11[5]);
                k24giren = dr11[6] == DBNull.Value ? 0m : Convert.ToDecimal(dr11[6]);
                k24cikan = dr11[7] == DBNull.Value ? 0m : Convert.ToDecimal(dr11[7]);
                k22giren = dr11[8] == DBNull.Value ? 0m : Convert.ToDecimal(dr11[8]);
                k22cikan = dr11[9] == DBNull.Value ? 0m : Convert.ToDecimal(dr11[9]);
            }

            lblGirenEuro.Text = eurogiren.ToString("#,##0.00") + " €";
            lblCikanDol.Text = dolarcikan.ToString("#,##0.00") + " $";
            lblCikanTL.Text = tlcikan.ToString("#,##0.00") + " ₺";
            lblGirenDol.Text = dolargiren.ToString("#,##0.00") + " $";
            lblGirenTL.Text = tlgiren.ToString("#,##0.00") + " ₺";
            lblCikan24KGr.Text = k24cikan.ToString("#,##0.00") + " gr";
            lblGiren22KGr.Text = k22giren.ToString("#,##0.00") + " gr";
            lblCikan22KGr.Text = k22cikan.ToString("#,##0.00") + " gr";
            lblGiren24KGr.Text = k24giren.ToString("#,##0.00") + " gr";
            lblCikanEuro.Text = eurocikan.ToString("#,##0.00") + " €";
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form = new Form1();
            form.Show();

        }

    }
}
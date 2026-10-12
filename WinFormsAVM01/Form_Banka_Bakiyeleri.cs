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
    public partial class Form_Banka_Bakiyeleri : Form
    {
        SqlConnection baglan = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DboAVM;Integrated Security=True;Trust Server Certificate=True");
        public Form_Banka_Bakiyeleri()
        {
            InitializeComponent();
        }
        string banka;
        decimal tlyatan, tlcekilen, dolyatan, dolcekilen, euroyatan, eurocekilen, k24yatan, k24cekilen, k22yatan, k22cekilen, ceyrekyatan, ceyrekcekilen, yarimyatan, yarimcekilen, tamyatan, tamcekilen, fonyp4yatan, fonyp4cekilen;
        void temizle()
        {
            //  baglan.Open();
            cmbBanka.Text = "";
            lblTL.Text = "0";
            lblDolar.Text = "0";
            lblEuro.Text = "0";
            lblK24.Text = "0";
            lblFonAdet.Text = "0";
            lblFonFiyat.Text = "0";
            lblK22.Text = "0";
            lblTam.Text = "0";
            lblYarim.Text = "0";
            lblCeyrek.Text = "0";
            lblFonTutar.Text = "0";

            //  baglan.Close();
        }


        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglan.Open();

            // temizle();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select *  from tbl_para_hareketleri where firma=@p1 order by tarih desc", baglan);
            da.SelectCommand.Parameters.AddWithValue("@p1", cmbBanka.Text);

            da.Fill(dt);
            dataGridView1.DataSource = dt;

            SqlCommand kom = new SqlCommand("select sum(tl_yatan),sum(tl_cekilen),sum(dol_yatan),sum(dol_cekilen),sum(euro_yatan),sum(euro_cekilen),sum(k24_gr_yatan),sum(k24_gr_cekilen),sum(k22_gr_yatan),sum(k22_gr_cekilen),sum(ceyrek_yatan),sum(ceyrek_cekilen),sum(yarim_yatan),sum(yarim_cekilen),sum(tam_yatan),sum(tam_cekilen),sum(fon_yp4_yatan),sum(fon_yp4_cekilen) from tbl_para_hareketleri where firma=@p2", baglan);
            kom.Parameters.AddWithValue("@p2", cmbBanka.Text);

            SqlDataReader dr = kom.ExecuteReader();
            while (dr.Read())
            {
                tlyatan = Convert.ToDecimal(dr[0].ToString());
                tlcekilen = Convert.ToDecimal(dr[1].ToString());
                dolyatan = Convert.ToDecimal(dr[2].ToString());
                dolcekilen = Convert.ToDecimal(dr[3].ToString());
                euroyatan = Convert.ToDecimal(dr[4].ToString());
                eurocekilen = Convert.ToDecimal(dr[5].ToString());
                k24yatan = Convert.ToDecimal(dr[6].ToString());
                k24cekilen = Convert.ToDecimal(dr[7].ToString());
                k22yatan = Convert.ToDecimal(dr[8].ToString());
                k22cekilen = Convert.ToDecimal(dr[9].ToString());
                ceyrekyatan = Convert.ToDecimal(dr[10].ToString());
                ceyrekcekilen = Convert.ToDecimal(dr[11].ToString());
                yarimyatan = Convert.ToDecimal(dr[12].ToString());
                yarimcekilen = Convert.ToDecimal(dr[13].ToString());
                tamyatan = Convert.ToDecimal(dr[14].ToString());
                tamcekilen = Convert.ToDecimal(dr[15].ToString());
                fonyp4yatan = Convert.ToDecimal(dr[16].ToString());
                fonyp4cekilen = Convert.ToDecimal(dr[17].ToString());

            }

            lblTL.Text = (tlyatan - tlcekilen).ToString();
            lblDolar.Text = (dolyatan - dolcekilen).ToString();
            lblEuro.Text = (euroyatan - eurocekilen).ToString();
            lblK24.Text = (k24yatan - k24cekilen).ToString();
            lblK22.Text = (k22yatan - k22cekilen).ToString();
            lblCeyrek.Text = (ceyrekyatan - ceyrekcekilen).ToString();
            lblYarim.Text = (yarimyatan - yarimcekilen).ToString();
            lblTam.Text = (tamyatan - tamcekilen).ToString();
            lblFonAdet.Text = (fonyp4yatan - fonyp4cekilen).ToString();


            baglan.Close();


        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

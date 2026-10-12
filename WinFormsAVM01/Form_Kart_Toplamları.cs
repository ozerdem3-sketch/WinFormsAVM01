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
    public partial class Form_Kart_Toplamları : Form
    {
        SqlConnection baglan = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DboAVM;Integrated Security=True;Trust Server Certificate=True");
        public Form_Kart_Toplamları()
        {
            InitializeComponent();
        }
        DateTime tarih1, tarih2;
        string banka, kart;
        decimal tutar, goldtoplam, tematoplam, visatoplam, opettoplam, worldtoplam, enptoplam, ykbtoplam, geneltoplam, isbtoplam;

        private void btnKartToplami_Click(object sender, EventArgs e)
        {
            baglan.Open();
            tarih1 = dateTimePicker1.Value.Date;
            tarih2 = dateTimePicker2.Value.Date;
            banka = cmbBankaAdi.Text;
            kart = cmbKartAdi.Text;


            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select tarih,kart_adi,firma,tutar from tbl_kredi_kart where tarih>=@tarih1 and tarih<=@tarih2  and kart_adi=@p2 order by tarih ", baglan);
            da.SelectCommand.Parameters.AddWithValue("@tarih1", tarih1);
            da.SelectCommand.Parameters.AddWithValue("@tarih2", tarih2);

            da.SelectCommand.Parameters.AddWithValue("@p2", kart);

            da.Fill(dt);
            dataGridView1.DataSource = dt;

            SqlCommand kom = new SqlCommand("select sum(tutar) from tbl_kredi_kart where tarih>=@tarih1 and tarih<=@tarih2 and kart_adi=@p2", baglan);
            kom.Parameters.AddWithValue("@tarih1", tarih1);
            kom.Parameters.AddWithValue("@tarih2", tarih2);
            kom.Parameters.AddWithValue("@p2", kart);
            SqlDataReader dr = kom.ExecuteReader();
            while (dr.Read())
            {
                lblKartToplami.Text = dr[0].ToString();
            }
            baglan.Close();

        }

        private void btnBankaToplami_Click(object sender, EventArgs e)
        {
            baglan.Open();
            tarih1 = dateTimePicker1.Value.Date;
            tarih2 = dateTimePicker2.Value.Date;
            banka = cmbBankaAdi.Text;
            kart = cmbKartAdi.Text;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select tarih,banka,kart_adi,tutar from tbl_kredi_kart where tarih>=@tarih1 and tarih<=@tarih2 order by tarih ", baglan);
            da.SelectCommand.Parameters.AddWithValue("@tarih1", tarih1);
            da.SelectCommand.Parameters.AddWithValue("@tarih2", tarih2);


            da.Fill(dt);
            dataGridView1.DataSource = dt;

            kart = "GOLD";
            if (kart == "GOLD")
            {
                SqlCommand kom = new SqlCommand("select sum(tutar) from tbl_kredi_kart where tarih>=@tarih1 and tarih<=@tarih2 and kart_adi=@p2", baglan);
                kom.Parameters.AddWithValue("@tarih1", tarih1);
                kom.Parameters.AddWithValue("@tarih2", tarih2);
                kom.Parameters.AddWithValue("@p2", kart);
                SqlDataReader dr = kom.ExecuteReader();
                while (dr.Read())
                {
                    lblGold.Text = dr[0].ToString();
                }
            }
            if (lblGold.Text != "")
            {
                goldtoplam = Convert.ToDecimal(lblGold.Text);
            }
            lblGold.Text = goldtoplam.ToString();

            baglan.Close();

            baglan.Open();

            kart = "TEMA";
            if (kart == "TEMA")
            {
                SqlCommand kom = new SqlCommand("select sum(tutar) from tbl_kredi_kart where tarih>=@tarih1 and tarih<=@tarih2 and kart_adi=@p2 ", baglan);
                kom.Parameters.AddWithValue("@tarih1", tarih1);
                kom.Parameters.AddWithValue("@tarih2", tarih2);
                kom.Parameters.AddWithValue("@p2", kart);
                SqlDataReader dr = kom.ExecuteReader();
                while (dr.Read())
                {
                    (lblTema.Text) = dr[0].ToString();
                }
            }
            if (lblTema.Text != "")
            {
                tematoplam = Convert.ToDecimal(lblTema.Text);
            }
            lblTema.Text = tematoplam.ToString();


            baglan.Close();

            baglan.Open();
            kart = "VİSA";
            if (kart == "VİSA")
            {
                SqlCommand kom = new SqlCommand("select sum(tutar) from tbl_kredi_kart where tarih>=@tarih1 and tarih<=@tarih2 and kart_adi=@p2 ", baglan);
                kom.Parameters.AddWithValue("@tarih1", tarih1);
                kom.Parameters.AddWithValue("@tarih2", tarih2);
                kom.Parameters.AddWithValue("@p2", kart);
                SqlDataReader dr = kom.ExecuteReader();
                while (dr.Read())
                {
                    lblVisa.Text = dr[0].ToString();
                }
            }

            if (lblVisa.Text != "")
            {
                visatoplam = Convert.ToDecimal(lblVisa.Text);
            }
            lblVisa.Text = visatoplam.ToString();

            isbtoplam = goldtoplam + tematoplam + visatoplam;
            lblISB.Text = isbtoplam.ToString();

            baglan.Close();

            baglan.Open();

            kart = "OPET";
            if (kart == "OPET")
            {
                SqlCommand kom = new SqlCommand("select sum(tutar) from tbl_kredi_kart where tarih>=@tarih1 and tarih<=@tarih2 and kart_adi=@p2", baglan);
                kom.Parameters.AddWithValue("@tarih1", tarih1);
                kom.Parameters.AddWithValue("@tarih2", tarih2);
                kom.Parameters.AddWithValue("@p2", kart);
                SqlDataReader dr = kom.ExecuteReader();
                while (dr.Read())
                {
                    lblOpet.Text = dr[0].ToString();
                }
            }

            if (lblOpet.Text != "")
            {
                opettoplam = Convert.ToDecimal(lblOpet.Text);
            }
            lblOpet.Text = opettoplam.ToString();




            baglan.Close();

            baglan.Open();
            kart = "WORLD";
            if (kart == "WORLD")
            {
                SqlCommand kom = new SqlCommand("select sum(tutar) from tbl_kredi_kart where tarih>=@tarih1 and tarih<=@tarih2 and kart_adi=@p2", baglan);
                kom.Parameters.AddWithValue("@tarih1", tarih1);
                kom.Parameters.AddWithValue("@tarih2", tarih2);
                kom.Parameters.AddWithValue("@p2", kart);
                SqlDataReader dr = kom.ExecuteReader();
                while (dr.Read())
                {
                    lblWorld.Text = dr[0].ToString();
                }
            }

            if (lblWorld.Text != "")
            {
                worldtoplam = Convert.ToDecimal(lblWorld.Text);
            }

            lblWorld.Text = worldtoplam.ToString();


            ykbtoplam = opettoplam + worldtoplam;
            lblYKB.Text = ykbtoplam.ToString();

            baglan.Close();

            baglan.Open();
            kart = "ENPARA";
            if (kart == "ENPARA")
            {
                SqlCommand kom = new SqlCommand("select sum(tutar) from tbl_kredi_kart where tarih>=@tarih1 and tarih<=@tarih2 and kart_adi=@p2", baglan);
                kom.Parameters.AddWithValue("@tarih1", tarih1);
                kom.Parameters.AddWithValue("@tarih2", tarih2);
                kom.Parameters.AddWithValue("@p2", kart);
                SqlDataReader dr = kom.ExecuteReader();
                while (dr.Read())
                {
                    lblENP.Text = dr[0].ToString();
                }
            }
            if (lblENP.Text != "")
            {
                enptoplam = Convert.ToDecimal(lblENP.Text);
            }

            lblENP.Text = enptoplam.ToString();
            geneltoplam = isbtoplam + ykbtoplam + enptoplam;
            lblToplam.Text = geneltoplam.ToString();


            baglan.Close();
        }

        private void Form_Kart_Toplamları_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = Convert.ToDateTime("01.01.2026");
            tarih1 = dateTimePicker1.Value.Date;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class Fiyat_Farki : Form
    {
        Microsoft.Data.SqlClient.SqlConnection baglan = new Microsoft.Data.SqlClient.SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DboAVM;Integrated Security=True;Trust Server Certificate=True");

        public Fiyat_Farki()
        {
            InitializeComponent();
        }
        DateTime ilktarih, sontarih, tarih1, tarih2, tarih3, tarih4, tarih5, tarih6;
        string firma1, firma2, firma3, mamul;
        double fiyat1, fiyat2, fiyat3, fiyat4, fiyat5, fiyat6, fark1, fark2, fark3;


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

        void firmalistesi1()
        {
            baglan.Open();
            Microsoft.Data.SqlClient.SqlCommand komut1 = new Microsoft.Data.SqlClient.SqlCommand("select firma_adi from tbl_firmalar order by firma_adi", baglan);
            Microsoft.Data.SqlClient.SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                firma1 = cmbFirma1.Items.Add(dr1[0]).ToString();

            }
            cmbFirma1.Text = firma1;
            baglan.Close();
        }

        void firmalistesi2()
        {
            baglan.Open();
            Microsoft.Data.SqlClient.SqlCommand komut1 = new Microsoft.Data.SqlClient.SqlCommand("select firma_adi from tbl_firmalar order by firma_adi", baglan);
            Microsoft.Data.SqlClient.SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                firma2 = cmbFirma2.Items.Add(dr1[0]).ToString();

            }
            cmbFirma2.Text = firma2;
            baglan.Close();
        }

        void firmalistesi3()
        {
            baglan.Open();
            Microsoft.Data.SqlClient.SqlCommand komut1 = new Microsoft.Data.SqlClient.SqlCommand("select firma_adi from tbl_firmalar order by firma_adi", baglan);
            Microsoft.Data.SqlClient.SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                firma3 = cmbFirma3.Items.Add(dr1[0]).ToString();

            }
            cmbFirma3.Text = firma3;
            baglan.Close();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)  //çalıştır butonu
        {
            firma1 = cmbFirma1.Text;
            firma2 = cmbFirma2.Text;
            firma3 = cmbFirma3.Text;
            mamul = cmbMamul.Text;

            baglan.Open();


            Microsoft.Data.SqlClient.SqlCommand komut1 = new Microsoft.Data.SqlClient.SqlCommand("select tarih,firma,cins,fiyat from tbl_alim where firma=@p1 and cins=@p2 and tarih>=@p3 order by tarih desc", baglan);
            komut1.Parameters.AddWithValue("@p1", firma1);
            komut1.Parameters.AddWithValue("@p2", mamul);
            komut1.Parameters.AddWithValue("@p3", dateTimePicker1.Value.Date);
            Microsoft.Data.SqlClient.SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                tarih1 = Convert.ToDateTime(dr1[0].ToString());
                fiyat1 = Convert.ToDouble(dr1[3].ToString());
            }
            mskTarih1.Text = tarih1.ToString();
            lblFiyat1.Text = fiyat1.ToString("#,##0.00");

            baglan.Close();
        }

        private void Fiyat_Farki_Load(object sender, EventArgs e)
        {
            cinslistesi();
            firmalistesi1();
            firmalistesi2();
            firmalistesi3();
        }
    }
}

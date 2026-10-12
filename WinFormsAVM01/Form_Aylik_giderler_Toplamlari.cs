using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace WinFormsAVM01
{
    public partial class Form_Aylik_giderler_Toplamlari : Form
    {
        SqlConnection baglan = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DboAVM;Integrated Security=True;Trust Server Certificate=True");

        public Form_Aylik_giderler_Toplamlari()
        {
            InitializeComponent();
        }

        DateTime tr1, tr2, tr3;
        decimal tutar, goldtoplam, tematoplam, visatoplam, opettoplam, worldtoplam, enptoplam, ykbtoplam, geneltoplam, isbtoplam;
        decimal tlyatan, tlcekilen, tlkalan, tlkalanisb, tlkalanykb, tlkalanenp, skaidat, skyakit, datcaaidat, osman, kur, doli, dolg, tlihtiyac;
        string kart, banka;

        void isbank()
        {

        }



        private void btnKartHesapla_Click(object sender, EventArgs e)
        {
            tr1 = dateTimePicker1.Value.Date;
            tr2 = dateTimePicker2.Value.Date;
            skaidat = Convert.ToDecimal(txtSKAidat.Text);
            skyakit = Convert.ToDecimal(txtSKYakit.Text);
            datcaaidat = Convert.ToDecimal(txtDatcaAidat.Text);
            osman = Convert.ToDecimal(txtOsmanOzerdem.Text);
            kur = Convert.ToDecimal(txtDolKuru.Text);


            baglan.Open();


            kart = "GOLD";
            if (kart == "GOLD")
            {
                SqlCommand kom0 = new SqlCommand("select sum(tutar) from tbl_kredi_kart where tarih>=@tarih1 and tarih<=@tarih2 and kart_adi=@p2", baglan);
                kom0.Parameters.AddWithValue("@tarih1", tr1);
                kom0.Parameters.AddWithValue("@tarih2", tr2);
                kom0.Parameters.AddWithValue("@p2", kart);
                SqlDataReader dr0 = kom0.ExecuteReader();
                while (dr0.Read())
                {
                    lblKkGold.Text = dr0[0].ToString();
                }
            }
            if (lblKkGold.Text != "")
            {
                goldtoplam = Convert.ToDecimal(lblKkGold.Text);
            }
            lblKkGold.Text = goldtoplam.ToString();

            baglan.Close();

            baglan.Open();

            kart = "TEMA";
            if (kart == "TEMA")
            {
                SqlCommand kom1 = new SqlCommand("select sum(tutar) from tbl_kredi_kart where tarih>=@tarih1 and tarih<=@tarih2 and kart_adi=@p2 ", baglan);
                kom1.Parameters.AddWithValue("@tarih1", tr1);
                kom1.Parameters.AddWithValue("@tarih2", tr2);
                kom1.Parameters.AddWithValue("@p2", kart);
                SqlDataReader dr1 = kom1.ExecuteReader();
                while (dr1.Read())
                {
                    (lblKkTema.Text) = dr1[0].ToString();
                }
            }
            if (lblKkTema.Text != "")
            {
                tematoplam = Convert.ToDecimal(lblKkTema.Text);
            }
            lblKkTema.Text = tematoplam.ToString();


            baglan.Close();

            baglan.Open();
            kart = "VİSA";
            if (kart == "VİSA")
            {
                SqlCommand kom2 = new SqlCommand("select sum(tutar) from tbl_kredi_kart where tarih>=@tarih1 and tarih<=@tarih2 and kart_adi=@p2 ", baglan);
                kom2.Parameters.AddWithValue("@tarih1", tr1);
                kom2.Parameters.AddWithValue("@tarih2", tr2);
                kom2.Parameters.AddWithValue("@p2", kart);
                SqlDataReader dr2 = kom2.ExecuteReader();
                while (dr2.Read())
                {
                    lblKkVisa.Text = dr2[0].ToString();
                }
            }

            if (lblKkVisa.Text != "")
            {
                visatoplam = Convert.ToDecimal(lblKkVisa.Text);
            }
            lblKkVisa.Text = visatoplam.ToString();

            isbtoplam = goldtoplam + tematoplam + visatoplam;
            lblKkISB.Text = isbtoplam.ToString();

            baglan.Close();

            baglan.Open();

            kart = "OPET";
            if (kart == "OPET")
            {
                SqlCommand kom3 = new SqlCommand("select sum(tutar) from tbl_kredi_kart where tarih>=@tarih1 and tarih<=@tarih2 and kart_adi=@p2", baglan);
                kom3.Parameters.AddWithValue("@tarih1", tr1);
                kom3.Parameters.AddWithValue("@tarih2", tr2);
                kom3.Parameters.AddWithValue("@p2", kart);
                SqlDataReader dr3 = kom3.ExecuteReader();
                while (dr3.Read())
                {
                    lblKkOpet.Text = dr3[0].ToString();
                }
            }

            if (lblKkOpet.Text != "")
            {
                opettoplam = Convert.ToDecimal(lblKkOpet.Text);
            }
            lblKkOpet.Text = opettoplam.ToString();




            baglan.Close();

            baglan.Open();
            kart = "WORLD";
            if (kart == "WORLD")
            {
                SqlCommand kom4 = new SqlCommand("select sum(tutar) from tbl_kredi_kart where tarih>=@tarih1 and tarih<=@tarih2 and kart_adi=@p2", baglan);
                kom4.Parameters.AddWithValue("@tarih1", tr1);
                kom4.Parameters.AddWithValue("@tarih2", tr2);
                kom4.Parameters.AddWithValue("@p2", kart);
                SqlDataReader dr4 = kom4.ExecuteReader();
                while (dr4.Read())
                {
                    lblKkWorld.Text = dr4[0].ToString();
                }
            }

            if (lblKkWorld.Text != "")
            {
                worldtoplam = Convert.ToDecimal(lblKkWorld.Text);
            }

            lblKkWorld.Text = worldtoplam.ToString();


            ykbtoplam = opettoplam + worldtoplam;
            lblKkYKB.Text = ykbtoplam.ToString();

            baglan.Close();

            baglan.Open();
            kart = "ENPARA";
            if (kart == "ENPARA")
            {
                SqlCommand kom5 = new SqlCommand("select sum(tutar) from tbl_kredi_kart where tarih>=@tarih1 and tarih<=@tarih2 and kart_adi=@p2", baglan);
                kom5.Parameters.AddWithValue("@tarih1", tr1);
                kom5.Parameters.AddWithValue("@tarih2", tr2);
                kom5.Parameters.AddWithValue("@p2", kart);
                SqlDataReader dr5 = kom5.ExecuteReader();
                while (dr5.Read())
                {
                    lblKkENP.Text = dr5[0].ToString();
                }
            }
            if (lblKkENP.Text != "")
            {
                enptoplam = Convert.ToDecimal(lblKkENP.Text);
            }

            lblKkEnpara.Text = enptoplam.ToString();
            lblKkENP.Text = enptoplam.ToString();
            geneltoplam = isbtoplam + ykbtoplam + enptoplam;
            //lblToplam.Text = geneltoplam.ToString();


            baglan.Close();

            baglan.Open();
            SqlCommand komut1 = new SqlCommand("select sum(tl_yatan),sum(tl_cekilen) from tbl_para_hareketleri where firma=@p2", baglan);
            komut1.Parameters.AddWithValue("@p2", "ISB");

            SqlDataReader dr01 = komut1.ExecuteReader();
            while (dr01.Read())
            {
                tlyatan = Convert.ToDecimal(dr01[0].ToString());
                tlcekilen = Convert.ToDecimal(dr01[1].ToString());


            }
            tlkalanisb = tlyatan - tlcekilen;

            lblISBTL.Text = tlkalanisb.ToString();

            baglan.Close();

            baglan.Close();

            baglan.Open();
            SqlCommand komut2 = new SqlCommand("select sum(tl_yatan),sum(tl_cekilen) from tbl_para_hareketleri where firma=@p2", baglan);
            komut2.Parameters.AddWithValue("@p2", "YKB");

            SqlDataReader dr02 = komut2.ExecuteReader();
            while (dr02.Read())
            {
                tlyatan = Convert.ToDecimal(dr02[0].ToString());
                tlcekilen = Convert.ToDecimal(dr02[1].ToString());


            }
            tlkalanykb = tlyatan - tlcekilen;

            lblYKBTL.Text = tlkalanykb.ToString();

            baglan.Close();

            baglan.Close();

            baglan.Open();
            SqlCommand komut3 = new SqlCommand("select sum(tl_yatan),sum(tl_cekilen) from tbl_para_hareketleri where firma=@p2", baglan);
            komut3.Parameters.AddWithValue("@p2", "ENP");

            SqlDataReader dr03 = komut3.ExecuteReader();
            while (dr03.Read())
            {
                tlyatan = Convert.ToDecimal(dr03[0].ToString());
                tlcekilen = Convert.ToDecimal(dr03[1].ToString());


            }
            tlkalanenp = tlyatan - tlcekilen;

            lblENPTL.Text = tlkalanenp.ToString();// INPUT VALIDASYONU EKLEYIN - satır 42'den sonra:
if (kur == 0)
{
    MessageBox.Show("Dolar kuru 0 olamaz!");
    return;
}

// VEYA tüm input değerlerinin geçerliğini kontrol edin:
if (string.IsNullOrWhiteSpace(txtDolKuru.Text) || !decimal.TryParse(txtDolKuru.Text, out kur) || kur <= 0)
{
    MessageBox.Show("Geçerli bir dolar kuru giriniz!");
    return;
}

            lblISBihtiyac.Text = (isbtoplam - tlkalanisb).ToString("#,##0.00");
            lblYKBihtiyac.Text = (ykbtoplam - tlkalanykb).ToString("#,##0.00");
            lblENPihtiyac.Text = (enptoplam - tlkalanenp).ToString("#,##0.00");

            tlihtiyac = (isbtoplam + ykbtoplam + enptoplam) - (tlkalanisb + tlkalanykb + tlkalanenp) + skaidat + skyakit + datcaaidat + osman;
            lblTLihtiyac.Text = tlihtiyac.ToString("₺ #,##0.00");
            doli = tlihtiyac / kur;
            lblDolIhtiyac.Text = doli.ToString("$ #,##0.00");
            baglan.Close();


        }

        private void Form_Aylik_giderler_Toplamlari_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblYKBTL_Click(object sender, EventArgs e)
        {

        }
    }
}
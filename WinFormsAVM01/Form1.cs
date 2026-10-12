using WinFormsAVM01.obj;

namespace WinFormsAVM01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMalGiris_Click(object sender, EventArgs e)
        {
            Form2 frm1 = new Form2();
            frm1.ShowDialog();
        }

        private void btnMamulKayit_Click(object sender, EventArgs e)
        {
            Form3_Mamul_Kayit frm3 = new Form3_Mamul_Kayit();
            frm3.ShowDialog();

        }

        private void btnFirmaKayit_Click(object sender, EventArgs e)
        {
            FormListeler frm4 = new FormListeler();
            frm4.ShowDialog();

        }

        private void btnParaHareketleri_Click(object sender, EventArgs e)
        {
            Form_Para_Hareketleri frm5 = new Form_Para_Hareketleri();
            frm5.ShowDialog();

        }

        private void btnAltinHareketleri_Click(object sender, EventArgs e)
        {
            Form_Banka_Bakiyeleri frm6 = new Form_Banka_Bakiyeleri();
            frm6.ShowDialog();

        }

        private void btnKartlar_Click(object sender, EventArgs e)
        {
            Form_Kredi_Kartlari frm7 = new Form_Kredi_Kartlari();
            frm7.ShowDialog();

        }

        private void btnKartListesi_Click(object sender, EventArgs e)
        {
            Form_Kart_Toplamları frm8 = new Form_Kart_Toplamları();
            frm8.ShowDialog();

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Para_Hareket_Listesi frm9 = new Form_Para_Hareket_Listesi();
            frm9.ShowDialog();
        }

        private void btnFiyatFarkı_Click(object sender, EventArgs e)
        {
            Fiyat_Farki frm10 = new Fiyat_Farki();
            frm10.ShowDialog();

        }

        private void btnHarcamalar_Click(object sender, EventArgs e)
        {
            Harcamalar harcamalar = new Harcamalar();
            harcamalar.ShowDialog();
        }

        private void btnKartHarcamalari_Click(object sender, EventArgs e)
        {
            Form_Aylik_giderler_Toplamlari frm20 = new Form_Aylik_giderler_Toplamlari();
            frm20.ShowDialog();

        }
    }
}

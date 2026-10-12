namespace WinFormsAVM01
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnMalGiris = new Button();
            btnMamulKayit = new Button();
            btnFirmaKayit = new Button();
            btnParaHareketleri = new Button();
            btnAltinHareketleri = new Button();
            btnKartlar = new Button();
            btnKartListesi = new Button();
            btnKapat = new Button();
            button1 = new Button();
            btnFiyatFarkı = new Button();
            btnHarcamalar = new Button();
            btnKartHarcamalari = new Button();
            SuspendLayout();
            // 
            // btnMalGiris
            // 
            btnMalGiris.BackColor = Color.Cyan;
            btnMalGiris.Location = new Point(729, 148);
            btnMalGiris.Name = "btnMalGiris";
            btnMalGiris.Size = new Size(148, 62);
            btnMalGiris.TabIndex = 1;
            btnMalGiris.Text = "FATURA GİRİŞ";
            btnMalGiris.UseVisualStyleBackColor = false;
            btnMalGiris.Click += btnMalGiris_Click;
            // 
            // btnMamulKayit
            // 
            btnMamulKayit.BackColor = Color.Cyan;
            btnMamulKayit.Location = new Point(729, 392);
            btnMamulKayit.Name = "btnMamulKayit";
            btnMamulKayit.Size = new Size(148, 62);
            btnMamulKayit.TabIndex = 2;
            btnMamulKayit.Text = "YENİ MAMUL KAYIT";
            btnMamulKayit.UseVisualStyleBackColor = false;
            btnMamulKayit.Click += btnMamulKayit_Click;
            // 
            // btnFirmaKayit
            // 
            btnFirmaKayit.BackColor = Color.Cyan;
            btnFirmaKayit.Location = new Point(893, 148);
            btnFirmaKayit.Name = "btnFirmaKayit";
            btnFirmaKayit.Size = new Size(148, 62);
            btnFirmaKayit.TabIndex = 3;
            btnFirmaKayit.Text = "GİRİŞ LİSTELERİ";
            btnFirmaKayit.UseVisualStyleBackColor = false;
            btnFirmaKayit.Click += btnFirmaKayit_Click;
            // 
            // btnParaHareketleri
            // 
            btnParaHareketleri.BackColor = Color.Cyan;
            btnParaHareketleri.Location = new Point(729, 314);
            btnParaHareketleri.Name = "btnParaHareketleri";
            btnParaHareketleri.Size = new Size(148, 62);
            btnParaHareketleri.TabIndex = 4;
            btnParaHareketleri.Text = "PARA HAREKETLERİ";
            btnParaHareketleri.UseVisualStyleBackColor = false;
            btnParaHareketleri.Click += btnParaHareketleri_Click;
            // 
            // btnAltinHareketleri
            // 
            btnAltinHareketleri.BackColor = Color.Cyan;
            btnAltinHareketleri.Location = new Point(893, 314);
            btnAltinHareketleri.Name = "btnAltinHareketleri";
            btnAltinHareketleri.Size = new Size(148, 62);
            btnAltinHareketleri.TabIndex = 5;
            btnAltinHareketleri.Text = "BANKA BAKİYELERİ";
            btnAltinHareketleri.UseVisualStyleBackColor = false;
            btnAltinHareketleri.Click += btnAltinHareketleri_Click;
            // 
            // btnKartlar
            // 
            btnKartlar.BackColor = Color.Cyan;
            btnKartlar.Location = new Point(729, 235);
            btnKartlar.Name = "btnKartlar";
            btnKartlar.Size = new Size(148, 62);
            btnKartlar.TabIndex = 6;
            btnKartlar.Text = "K.KART GİRİŞLERİ";
            btnKartlar.UseVisualStyleBackColor = false;
            btnKartlar.Click += btnKartlar_Click;
            // 
            // btnKartListesi
            // 
            btnKartListesi.BackColor = Color.Cyan;
            btnKartListesi.Location = new Point(893, 236);
            btnKartListesi.Name = "btnKartListesi";
            btnKartListesi.Size = new Size(148, 62);
            btnKartListesi.TabIndex = 7;
            btnKartListesi.Text = "KART GİRİŞ LİSTESİ";
            btnKartListesi.UseVisualStyleBackColor = false;
            btnKartListesi.Click += btnKartListesi_Click;
            // 
            // btnKapat
            // 
            btnKapat.BackColor = Color.RosyBrown;
            btnKapat.Location = new Point(754, 518);
            btnKapat.Name = "btnKapat";
            btnKapat.Size = new Size(257, 65);
            btnKapat.TabIndex = 8;
            btnKapat.Text = "PROGRAMDAN ÇIKIŞ";
            btnKapat.UseVisualStyleBackColor = false;
            btnKapat.Click += btnKapat_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Cyan;
            button1.Location = new Point(893, 392);
            button1.Name = "button1";
            button1.Size = new Size(148, 62);
            button1.TabIndex = 9;
            button1.Text = "HAREKET LİSTELERİ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnFiyatFarkı
            // 
            btnFiyatFarkı.BackColor = Color.Cyan;
            btnFiyatFarkı.Location = new Point(1064, 148);
            btnFiyatFarkı.Name = "btnFiyatFarkı";
            btnFiyatFarkı.Size = new Size(148, 62);
            btnFiyatFarkı.TabIndex = 10;
            btnFiyatFarkı.Text = "FİYAT FARKI HESAPLAMA";
            btnFiyatFarkı.UseVisualStyleBackColor = false;
            btnFiyatFarkı.Click += btnFiyatFarkı_Click;
            // 
            // btnHarcamalar
            // 
            btnHarcamalar.BackColor = Color.Cyan;
            btnHarcamalar.Location = new Point(1064, 234);
            btnHarcamalar.Name = "btnHarcamalar";
            btnHarcamalar.Size = new Size(148, 63);
            btnHarcamalar.TabIndex = 11;
            btnHarcamalar.Text = "HARCAMALAR";
            btnHarcamalar.UseVisualStyleBackColor = false;
            btnHarcamalar.Click += btnHarcamalar_Click;
            // 
            // btnKartHarcamalari
            // 
            btnKartHarcamalari.Location = new Point(1064, 314);
            btnKartHarcamalari.Name = "btnKartHarcamalari";
            btnKartHarcamalari.Size = new Size(148, 62);
            btnKartHarcamalari.TabIndex = 12;
            btnKartHarcamalari.Text = "KART BORCU HESAPLAMA";
            btnKartHarcamalari.UseVisualStyleBackColor = true;
            btnKartHarcamalari.Click += btnKartHarcamalari_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(1892, 853);
            Controls.Add(btnKartHarcamalari);
            Controls.Add(btnHarcamalar);
            Controls.Add(btnFiyatFarkı);
            Controls.Add(button1);
            Controls.Add(btnKapat);
            Controls.Add(btnKartListesi);
            Controls.Add(btnKartlar);
            Controls.Add(btnAltinHareketleri);
            Controls.Add(btnParaHareketleri);
            Controls.Add(btnFirmaKayit);
            Controls.Add(btnMamulKayit);
            Controls.Add(btnMalGiris);
            Font = new Font("Cascadia Code", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
        }

        #endregion

        private Button btnMalGiris;
        private Button btnMamulKayit;
        private Button btnFirmaKayit;
        private Button btnParaHareketleri;
        private Button btnAltinHareketleri;
        private Button btnKartlar;
        private Button btnKartListesi;
        private Button btnKapat;
        private Button button1;
        private Button btnFiyatFarkı;
        private Button btnHarcamalar;
        private Button btnKartHarcamalari;
    }
}

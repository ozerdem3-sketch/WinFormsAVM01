namespace WinFormsAVM01
{
    partial class Form_Banka_Bakiyeleri
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnKaydet = new Button();
            cmbBanka = new ComboBox();
            label10 = new Label();
            label6 = new Label();
            label5 = new Label();
            label2 = new Label();
            label11 = new Label();
            label12 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            label17 = new Label();
            lblTL = new Label();
            lblDolar = new Label();
            lblEuro = new Label();
            lblK24 = new Label();
            lblK22 = new Label();
            lblTam = new Label();
            lblYarim = new Label();
            lblCeyrek = new Label();
            label1 = new Label();
            label3 = new Label();
            lblFonAdet = new Label();
            lblFonFiyat = new Label();
            lblFonTutar = new Label();
            btnMenu = new Button();
            label4 = new Label();
            label7 = new Label();
            label8 = new Label();
            lblTL_Vadeli = new Label();
            lblDolarVadeli = new Label();
            lblEuroVadeli = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.Lime;
            btnKaydet.Location = new Point(169, 85);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(182, 40);
            btnKaydet.TabIndex = 37;
            btnKaydet.Text = "HESABI GÖSTER";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // cmbBanka
            // 
            cmbBanka.FormattingEnabled = true;
            cmbBanka.Items.AddRange(new object[] { "ISB", "ENP", "ENPV", "YKB", "ZB", "KASA" });
            cmbBanka.Location = new Point(133, 24);
            cmbBanka.Name = "cmbBanka";
            cmbBanka.Size = new Size(155, 32);
            cmbBanka.TabIndex = 35;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(1120, 149);
            label10.Name = "label10";
            label10.Size = new Size(142, 24);
            label10.TabIndex = 26;
            label10.Text = "ÇEYREK ADEDİ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(398, 51);
            label6.Name = "label6";
            label6.Size = new Size(164, 24);
            label6.TabIndex = 22;
            label6.Text = "DOLAR VADESİZ ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(442, 20);
            label5.Name = "label5";
            label5.Size = new Size(120, 24);
            label5.TabIndex = 21;
            label5.Text = "TL VADESİZ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 32);
            label2.Name = "label2";
            label2.Size = new Size(76, 24);
            label2.TabIndex = 18;
            label2.Text = "Firma:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(420, 83);
            label11.Name = "label11";
            label11.Size = new Size(142, 24);
            label11.TabIndex = 21;
            label11.Text = "EURO VADESİZ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(1170, 17);
            label12.Name = "label12";
            label12.Size = new Size(98, 24);
            label12.TabIndex = 22;
            label12.Text = "24K GRAM";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(781, 17);
            label14.Name = "label14";
            label14.Size = new Size(98, 24);
            label14.TabIndex = 24;
            label14.Text = "FON ADET";
            label14.Click += label14_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(1131, 117);
            label15.Name = "label15";
            label15.Size = new Size(131, 24);
            label15.TabIndex = 25;
            label15.Text = "YARIM ADEDİ";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(1153, 85);
            label16.Name = "label16";
            label16.Size = new Size(109, 24);
            label16.TabIndex = 26;
            label16.Text = "TAM ADEDİ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(12, 205);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1512, 433);
            groupBox1.TabIndex = 41;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 24);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1506, 406);
            dataGridView1.TabIndex = 0;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(1164, 54);
            label17.Name = "label17";
            label17.Size = new Size(98, 24);
            label17.TabIndex = 20;
            label17.Text = "22K GRAM";
            // 
            // lblTL
            // 
            lblTL.BackColor = Color.Bisque;
            lblTL.Location = new Point(596, 20);
            lblTL.Name = "lblTL";
            lblTL.Size = new Size(150, 24);
            lblTL.TabIndex = 46;
            lblTL.Text = "0";
            lblTL.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDolar
            // 
            lblDolar.BackColor = Color.Bisque;
            lblDolar.Location = new Point(596, 51);
            lblDolar.Name = "lblDolar";
            lblDolar.Size = new Size(150, 24);
            lblDolar.TabIndex = 46;
            lblDolar.Text = "0";
            lblDolar.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblEuro
            // 
            lblEuro.BackColor = Color.Bisque;
            lblEuro.Location = new Point(596, 83);
            lblEuro.Name = "lblEuro";
            lblEuro.Size = new Size(150, 24);
            lblEuro.TabIndex = 46;
            lblEuro.Text = "0";
            lblEuro.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblK24
            // 
            lblK24.BackColor = Color.Bisque;
            lblK24.Location = new Point(1302, 17);
            lblK24.Name = "lblK24";
            lblK24.Size = new Size(150, 24);
            lblK24.TabIndex = 46;
            lblK24.Text = "0";
            lblK24.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblK22
            // 
            lblK22.BackColor = Color.Bisque;
            lblK22.Location = new Point(1302, 54);
            lblK22.Name = "lblK22";
            lblK22.Size = new Size(150, 24);
            lblK22.TabIndex = 46;
            lblK22.Text = "0";
            lblK22.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTam
            // 
            lblTam.BackColor = Color.Bisque;
            lblTam.Location = new Point(1302, 85);
            lblTam.Name = "lblTam";
            lblTam.Size = new Size(150, 24);
            lblTam.TabIndex = 46;
            lblTam.Text = "0";
            lblTam.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblYarim
            // 
            lblYarim.BackColor = Color.Bisque;
            lblYarim.Location = new Point(1302, 117);
            lblYarim.Name = "lblYarim";
            lblYarim.Size = new Size(150, 24);
            lblYarim.TabIndex = 46;
            lblYarim.Text = "0";
            lblYarim.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCeyrek
            // 
            lblCeyrek.BackColor = Color.Bisque;
            lblCeyrek.Location = new Point(1302, 149);
            lblCeyrek.Name = "lblCeyrek";
            lblCeyrek.Size = new Size(150, 24);
            lblCeyrek.TabIndex = 46;
            lblCeyrek.Text = "0";
            lblCeyrek.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(764, 51);
            label1.Name = "label1";
            label1.Size = new Size(109, 24);
            label1.TabIndex = 24;
            label1.Text = "FON FİYAT";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 145);
            label3.Name = "label3";
            label3.Size = new Size(109, 24);
            label3.TabIndex = 24;
            label3.Text = "FON TUTAR";
            // 
            // lblFonAdet
            // 
            lblFonAdet.BackColor = Color.Bisque;
            lblFonAdet.Location = new Point(913, 17);
            lblFonAdet.Name = "lblFonAdet";
            lblFonAdet.Size = new Size(150, 24);
            lblFonAdet.TabIndex = 46;
            lblFonAdet.Text = "0";
            lblFonAdet.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblFonFiyat
            // 
            lblFonFiyat.BackColor = Color.Bisque;
            lblFonFiyat.Location = new Point(166, 145);
            lblFonFiyat.Name = "lblFonFiyat";
            lblFonFiyat.Size = new Size(150, 24);
            lblFonFiyat.TabIndex = 46;
            lblFonFiyat.Text = "0";
            lblFonFiyat.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblFonTutar
            // 
            lblFonTutar.BackColor = Color.Bisque;
            lblFonTutar.Location = new Point(913, 51);
            lblFonTutar.Name = "lblFonTutar";
            lblFonTutar.Size = new Size(150, 24);
            lblFonTutar.TabIndex = 46;
            lblFonTutar.Text = "0";
            lblFonTutar.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.Magenta;
            btnMenu.Location = new Point(33, 85);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(94, 40);
            btnMenu.TabIndex = 47;
            btnMenu.Text = "MENÜYE";
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(442, 115);
            label4.Name = "label4";
            label4.Size = new Size(109, 24);
            label4.TabIndex = 21;
            label4.Text = "TL VADELİ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(398, 146);
            label7.Name = "label7";
            label7.Size = new Size(142, 24);
            label7.TabIndex = 22;
            label7.Text = "DOLAR VADELİ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(420, 178);
            label8.Name = "label8";
            label8.Size = new Size(131, 24);
            label8.TabIndex = 21;
            label8.Text = "EURO VADELİ";
            // 
            // lblTL_Vadeli
            // 
            lblTL_Vadeli.BackColor = Color.Bisque;
            lblTL_Vadeli.Location = new Point(596, 115);
            lblTL_Vadeli.Name = "lblTL_Vadeli";
            lblTL_Vadeli.Size = new Size(150, 24);
            lblTL_Vadeli.TabIndex = 46;
            lblTL_Vadeli.Text = "0";
            lblTL_Vadeli.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDolarVadeli
            // 
            lblDolarVadeli.BackColor = Color.Bisque;
            lblDolarVadeli.Location = new Point(596, 146);
            lblDolarVadeli.Name = "lblDolarVadeli";
            lblDolarVadeli.Size = new Size(150, 24);
            lblDolarVadeli.TabIndex = 46;
            lblDolarVadeli.Text = "0";
            lblDolarVadeli.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblEuroVadeli
            // 
            lblEuroVadeli.BackColor = Color.Bisque;
            lblEuroVadeli.Location = new Point(596, 178);
            lblEuroVadeli.Name = "lblEuroVadeli";
            lblEuroVadeli.Size = new Size(150, 24);
            lblEuroVadeli.TabIndex = 46;
            lblEuroVadeli.Text = "0";
            lblEuroVadeli.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Form_Banka_Bakiyeleri
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(1540, 650);
            Controls.Add(btnMenu);
            Controls.Add(lblCeyrek);
            Controls.Add(lblFonTutar);
            Controls.Add(lblFonFiyat);
            Controls.Add(lblK24);
            Controls.Add(lblYarim);
            Controls.Add(lblFonAdet);
            Controls.Add(lblTam);
            Controls.Add(lblEuroVadeli);
            Controls.Add(lblEuro);
            Controls.Add(lblDolarVadeli);
            Controls.Add(lblK22);
            Controls.Add(lblTL_Vadeli);
            Controls.Add(lblDolar);
            Controls.Add(lblTL);
            Controls.Add(groupBox1);
            Controls.Add(btnKaydet);
            Controls.Add(cmbBanka);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label10);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label14);
            Controls.Add(label8);
            Controls.Add(label12);
            Controls.Add(label7);
            Controls.Add(label11);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label17);
            Controls.Add(label2);
            Font = new Font("Cascadia Code", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "Form_Banka_Bakiyeleri";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form_Altin_Hareketleri";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnKaydet;
        private ComboBox cmbBanka;
        private Label label10;
        private Label label6;
        private Label label5;
        private Label label2;
        private Label label11;
        private Label label12;
        private Label label14;
        private Label label15;
        private Label label16;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private Label label17;
        private Label lblTL;
        private Label lblDolar;
        private Label lblEuro;
        private Label lblK24;
        private Label lblK22;
        private Label lblTam;
        private Label lblYarim;
        private Label lblCeyrek;
        private Label label1;
        private Label label3;
        private Label lblFonAdet;
        private Label lblFonFiyat;
        private Label lblFonTutar;
        private Button btnMenu;
        private Label label4;
        private Label label7;
        private Label label8;
        private Label lblTL_Vadeli;
        private Label lblDolarVadeli;
        private Label lblEuroVadeli;
    }
}
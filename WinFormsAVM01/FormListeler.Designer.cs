namespace WinFormsAVM01
{
    partial class FormListeler
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
            label1 = new Label();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            btnFirma = new Button();
            btnMamul = new Button();
            btnFirmaMamul = new Button();
            btnGurup = new Button();
            btnFirmaGurup = new Button();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            lblToplamMiktar = new Label();
            label5 = new Label();
            lblToplamTutar = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            cmbFirmalar = new ComboBox();
            cmbMamuller = new ComboBox();
            cmbGuruplar = new ComboBox();
            button1 = new Button();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtMiktar = new TextBox();
            txtFiyat = new TextBox();
            txtTutar = new TextBox();
            lblID = new Label();
            txtTarih = new TextBox();
            label11 = new Label();
            label12 = new Label();
            btnTariheGore = new Button();
            btnGuncelle = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 33);
            label1.Name = "label1";
            label1.Size = new Size(120, 24);
            label1.TabIndex = 0;
            label1.Text = "İlk Tarih:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 74);
            label2.Name = "label2";
            label2.Size = new Size(120, 24);
            label2.TabIndex = 0;
            label2.Text = "Son Tarih:";
            label2.Click += label2_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(175, 33);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(169, 28);
            dateTimePicker1.TabIndex = 1;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(175, 74);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(169, 28);
            dateTimePicker2.TabIndex = 2;
            // 
            // btnFirma
            // 
            btnFirma.BackColor = Color.Chartreuse;
            btnFirma.Location = new Point(1078, 9);
            btnFirma.Name = "btnFirma";
            btnFirma.Size = new Size(144, 52);
            btnFirma.TabIndex = 33;
            btnFirma.Text = "FİRMA";
            btnFirma.UseVisualStyleBackColor = false;
            btnFirma.Click += btnFirma_Click;
            // 
            // btnMamul
            // 
            btnMamul.BackColor = Color.Chartreuse;
            btnMamul.Location = new Point(1078, 77);
            btnMamul.Name = "btnMamul";
            btnMamul.Size = new Size(144, 52);
            btnMamul.TabIndex = 34;
            btnMamul.Text = "MAMUL";
            btnMamul.UseVisualStyleBackColor = false;
            btnMamul.Click += btnMamul_Click;
            // 
            // btnFirmaMamul
            // 
            btnFirmaMamul.BackColor = Color.Chartreuse;
            btnFirmaMamul.Location = new Point(1246, 10);
            btnFirmaMamul.Name = "btnFirmaMamul";
            btnFirmaMamul.Size = new Size(144, 52);
            btnFirmaMamul.TabIndex = 35;
            btnFirmaMamul.Text = "FİRMA+MAMUL";
            btnFirmaMamul.UseVisualStyleBackColor = false;
            btnFirmaMamul.Click += btnFirmaMamul_Click;
            // 
            // btnGurup
            // 
            btnGurup.BackColor = Color.Chartreuse;
            btnGurup.Location = new Point(1246, 77);
            btnGurup.Name = "btnGurup";
            btnGurup.Size = new Size(144, 52);
            btnGurup.TabIndex = 66;
            btnGurup.Text = "GURUP";
            btnGurup.UseVisualStyleBackColor = false;
            btnGurup.Click += btnGurup_Click;
            // 
            // btnFirmaGurup
            // 
            btnFirmaGurup.BackColor = Color.Chartreuse;
            btnFirmaGurup.Location = new Point(1405, 10);
            btnFirmaGurup.Name = "btnFirmaGurup";
            btnFirmaGurup.Size = new Size(144, 52);
            btnFirmaGurup.TabIndex = 37;
            btnFirmaGurup.Text = "FİRMA+GURUP";
            btnFirmaGurup.UseVisualStyleBackColor = false;
            btnFirmaGurup.Click += btnFirmaGurup_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(40, 135);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1660, 581);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 24);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1654, 554);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(352, 719);
            label3.Name = "label3";
            label3.Size = new Size(164, 24);
            label3.TabIndex = 5;
            label3.Text = "Toplam Miktar:";
            // 
            // lblToplamMiktar
            // 
            lblToplamMiktar.AutoSize = true;
            lblToplamMiktar.Location = new Point(544, 719);
            lblToplamMiktar.Name = "lblToplamMiktar";
            lblToplamMiktar.Size = new Size(76, 24);
            lblToplamMiktar.TabIndex = 5;
            lblToplamMiktar.Text = "label3";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(705, 719);
            label5.Name = "label5";
            label5.Size = new Size(142, 24);
            label5.TabIndex = 5;
            label5.Text = "Toğlam tutar";
            // 
            // lblToplamTutar
            // 
            lblToplamTutar.AutoSize = true;
            lblToplamTutar.Location = new Point(914, 719);
            lblToplamTutar.Name = "lblToplamTutar";
            lblToplamTutar.Size = new Size(76, 24);
            lblToplamTutar.TabIndex = 5;
            lblToplamTutar.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(375, 24);
            label4.Name = "label4";
            label4.Size = new Size(98, 24);
            label4.TabIndex = 6;
            label4.Text = "FİRMALAR";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(375, 62);
            label6.Name = "label6";
            label6.Size = new Size(98, 24);
            label6.TabIndex = 6;
            label6.Text = "MAMULLER";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(375, 100);
            label7.Name = "label7";
            label7.Size = new Size(98, 24);
            label7.TabIndex = 6;
            label7.Text = "GURUPLAR";
            // 
            // cmbFirmalar
            // 
            cmbFirmalar.FormattingEnabled = true;
            cmbFirmalar.Location = new Point(499, 16);
            cmbFirmalar.Name = "cmbFirmalar";
            cmbFirmalar.Size = new Size(246, 32);
            cmbFirmalar.TabIndex = 3;
            cmbFirmalar.SelectedIndexChanged += cmbFirmalar_SelectedIndexChanged;
            // 
            // cmbMamuller
            // 
            cmbMamuller.FormattingEnabled = true;
            cmbMamuller.Location = new Point(499, 54);
            cmbMamuller.Name = "cmbMamuller";
            cmbMamuller.Size = new Size(246, 32);
            cmbMamuller.TabIndex = 4;
            // 
            // cmbGuruplar
            // 
            cmbGuruplar.FormattingEnabled = true;
            cmbGuruplar.Location = new Point(499, 92);
            cmbGuruplar.Name = "cmbGuruplar";
            cmbGuruplar.Size = new Size(246, 32);
            cmbGuruplar.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.Yellow;
            button1.Location = new Point(1567, 10);
            button1.Name = "button1";
            button1.Size = new Size(144, 52);
            button1.TabIndex = 88;
            button1.Text = "MENÜYE GİT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(751, 19);
            label8.Name = "label8";
            label8.Size = new Size(76, 24);
            label8.TabIndex = 6;
            label8.Text = "MİKTAR";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(751, 57);
            label9.Name = "label9";
            label9.Size = new Size(65, 24);
            label9.TabIndex = 6;
            label9.Text = "FİYAT";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(751, 95);
            label10.Name = "label10";
            label10.Size = new Size(65, 24);
            label10.TabIndex = 6;
            label10.Text = "TUTAR";
            // 
            // txtMiktar
            // 
            txtMiktar.Location = new Point(865, 15);
            txtMiktar.Name = "txtMiktar";
            txtMiktar.Size = new Size(178, 28);
            txtMiktar.TabIndex = 6;
            // 
            // txtFiyat
            // 
            txtFiyat.Location = new Point(865, 54);
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Size = new Size(178, 28);
            txtFiyat.TabIndex = 7;
            // 
            // txtTutar
            // 
            txtTutar.Location = new Point(865, 92);
            txtTutar.Name = "txtTutar";
            txtTutar.Size = new Size(178, 28);
            txtTutar.TabIndex = 8;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(52, 9);
            lblID.Name = "lblID";
            lblID.Size = new Size(21, 24);
            lblID.TabIndex = 11;
            lblID.Text = "0";
            // 
            // txtTarih
            // 
            txtTarih.Location = new Point(175, 108);
            txtTarih.Name = "txtTarih";
            txtTarih.Size = new Size(169, 28);
            txtTarih.TabIndex = 10;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(-638, 25);
            label11.Name = "label11";
            label11.Size = new Size(21, 24);
            label11.TabIndex = 11;
            label11.Text = "0";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(40, 108);
            label12.Name = "label12";
            label12.Size = new Size(87, 24);
            label12.TabIndex = 0;
            label12.Text = " Tarih:";
            label12.Click += label2_Click;
            // 
            // btnTariheGore
            // 
            btnTariheGore.Location = new Point(1405, 77);
            btnTariheGore.Name = "btnTariheGore";
            btnTariheGore.Size = new Size(144, 59);
            btnTariheGore.TabIndex = 89;
            btnTariheGore.Text = "TARİH ARALIĞI";
            btnTariheGore.UseVisualStyleBackColor = true;
            btnTariheGore.Click += btnTariheGore_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.Wheat;
            btnGuncelle.Location = new Point(1567, 77);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(144, 59);
            btnGuncelle.TabIndex = 90;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // FormListeler
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(1739, 751);
            Controls.Add(btnGuncelle);
            Controls.Add(btnTariheGore);
            Controls.Add(label11);
            Controls.Add(lblID);
            Controls.Add(txtTarih);
            Controls.Add(txtTutar);
            Controls.Add(txtFiyat);
            Controls.Add(txtMiktar);
            Controls.Add(button1);
            Controls.Add(cmbGuruplar);
            Controls.Add(cmbMamuller);
            Controls.Add(cmbFirmalar);
            Controls.Add(label10);
            Controls.Add(label7);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(lblToplamTutar);
            Controls.Add(label5);
            Controls.Add(lblToplamMiktar);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Controls.Add(btnFirmaGurup);
            Controls.Add(btnGurup);
            Controls.Add(btnFirmaMamul);
            Controls.Add(btnMamul);
            Controls.Add(btnFirma);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label12);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Cascadia Code", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "FormListeler";
            Text = "FormListeler";
            Load += FormListeler_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Button btnFirma;
        private Button btnMamul;
        private Button btnFirmaMamul;
        private Button btnGurup;
        private Button btnFirmaGurup;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private Label label3;
        private Label lblToplamMiktar;
        private Label label5;
        private Label lblToplamTutar;
        private Label label4;
        private Label label6;
        private Label label7;
        private ComboBox cmbFirmalar;
        private ComboBox cmbMamuller;
        private ComboBox cmbGuruplar;
        private Button button1;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtMiktar;
        private TextBox txtFiyat;
        private TextBox txtTutar;
        private Label lblID;
        private TextBox txtTarih;
        private Label label11;
        private Label label12;
        private Button btnTariheGore;
        private Button btnGuncelle;
    }
}
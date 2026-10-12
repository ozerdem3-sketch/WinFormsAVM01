namespace WinFormsAVM01
{
    partial class Form2
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
            groupBox1 = new GroupBox();
            btnGurup = new Button();
            btnCins = new Button();
            btnFirma = new Button();
            btnMenu = new Button();
            btnKaydet = new Button();
            btnSil = new Button();
            btnGuncelle = new Button();
            dateTimePicker1 = new DateTimePicker();
            txtTutar = new TextBox();
            txtFiyat = new TextBox();
            txtTarih = new TextBox();
            txtMiktar = new TextBox();
            cmbGurup = new ComboBox();
            cmbMamul = new ComboBox();
            cmbFirma = new ComboBox();
            label9 = new Label();
            lblID = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.PaleGoldenrod;
            groupBox1.Controls.Add(btnGurup);
            groupBox1.Controls.Add(btnCins);
            groupBox1.Controls.Add(btnFirma);
            groupBox1.Controls.Add(btnMenu);
            groupBox1.Controls.Add(btnKaydet);
            groupBox1.Controls.Add(btnSil);
            groupBox1.Controls.Add(btnGuncelle);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(txtTutar);
            groupBox1.Controls.Add(txtFiyat);
            groupBox1.Controls.Add(txtTarih);
            groupBox1.Controls.Add(txtMiktar);
            groupBox1.Controls.Add(cmbGurup);
            groupBox1.Controls.Add(cmbMamul);
            groupBox1.Controls.Add(cmbFirma);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(lblID);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(29, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1722, 167);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // btnGurup
            // 
            btnGurup.Location = new Point(762, 97);
            btnGurup.Name = "btnGurup";
            btnGurup.Size = new Size(131, 35);
            btnGurup.TabIndex = 101;
            btnGurup.Text = "GURUP";
            btnGurup.UseVisualStyleBackColor = true;
            btnGurup.Click += btnGurup_Click;
            // 
            // btnCins
            // 
            btnCins.Location = new Point(762, 55);
            btnCins.Name = "btnCins";
            btnCins.Size = new Size(131, 35);
            btnCins.TabIndex = 101;
            btnCins.Text = "AÇIKLAMA";
            btnCins.UseVisualStyleBackColor = true;
            btnCins.Click += btnCins_Click;
            // 
            // btnFirma
            // 
            btnFirma.Location = new Point(762, 8);
            btnFirma.Name = "btnFirma";
            btnFirma.Size = new Size(131, 35);
            btnFirma.TabIndex = 101;
            btnFirma.Text = "FİRMA";
            btnFirma.UseVisualStyleBackColor = true;
            btnFirma.Click += btnFirma_Click;
            // 
            // btnMenu
            // 
            btnMenu.Location = new Point(1503, 77);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(130, 61);
            btnMenu.TabIndex = 9;
            btnMenu.Text = "ANA MENÜ";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(1334, 77);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(130, 61);
            btnKaydet.TabIndex = 8;
            btnKaydet.Text = "KAYDET";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(1503, 11);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(130, 61);
            btnSil.TabIndex = 11;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(1334, 11);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(130, 61);
            btnGuncelle.TabIndex = 10;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(50, 105);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(138, 28);
            dateTimePicker1.TabIndex = 1;
            // 
            // txtTutar
            // 
            txtTutar.Location = new Point(1059, 110);
            txtTutar.Name = "txtTutar";
            txtTutar.Size = new Size(201, 28);
            txtTutar.TabIndex = 7;
            txtTutar.Text = "0";
            txtTutar.TextAlign = HorizontalAlignment.Right;
            // 
            // txtFiyat
            // 
            txtFiyat.Location = new Point(1059, 55);
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Size = new Size(201, 28);
            txtFiyat.TabIndex = 6;
            txtFiyat.Text = "0";
            txtFiyat.TextAlign = HorizontalAlignment.Right;
            // 
            // txtTarih
            // 
            txtTarih.Location = new Point(99, 62);
            txtTarih.Name = "txtTarih";
            txtTarih.Size = new Size(89, 28);
            txtTarih.TabIndex = 100;
            // 
            // txtMiktar
            // 
            txtMiktar.Location = new Point(1059, 12);
            txtMiktar.Name = "txtMiktar";
            txtMiktar.Size = new Size(201, 28);
            txtMiktar.TabIndex = 5;
            txtMiktar.Text = "0";
            txtMiktar.TextAlign = HorizontalAlignment.Right;
            // 
            // cmbGurup
            // 
            cmbGurup.FormattingEnabled = true;
            cmbGurup.Location = new Point(332, 97);
            cmbGurup.Name = "cmbGurup";
            cmbGurup.Size = new Size(404, 29);
            cmbGurup.TabIndex = 4;
            // 
            // cmbMamul
            // 
            cmbMamul.FormattingEnabled = true;
            cmbMamul.Location = new Point(332, 54);
            cmbMamul.Name = "cmbMamul";
            cmbMamul.Size = new Size(404, 29);
            cmbMamul.TabIndex = 3;
            // 
            // cmbFirma
            // 
            cmbFirma.FormattingEnabled = true;
            cmbFirma.Location = new Point(332, 11);
            cmbFirma.Name = "cmbFirma";
            cmbFirma.Size = new Size(404, 29);
            cmbFirma.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(35, 15);
            label9.Name = "label9";
            label9.Size = new Size(32, 21);
            label9.TabIndex = 8;
            label9.Text = "ID:";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(90, 15);
            lblID.Name = "lblID";
            lblID.Size = new Size(20, 21);
            lblID.TabIndex = 7;
            lblID.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(962, 105);
            label7.Name = "label7";
            label7.Size = new Size(75, 21);
            label7.TabIndex = 6;
            label7.Text = "TUTAR:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(976, 62);
            label6.Name = "label6";
            label6.Size = new Size(61, 21);
            label6.TabIndex = 5;
            label6.Text = "FİYAT:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(956, 19);
            label5.Name = "label5";
            label5.Size = new Size(81, 21);
            label5.TabIndex = 4;
            label5.Text = "MİKTAR:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(240, 105);
            label4.Name = "label4";
            label4.Size = new Size(80, 21);
            label4.TabIndex = 3;
            label4.Text = "GURUP:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(218, 62);
            label3.Name = "label3";
            label3.Size = new Size(102, 21);
            label3.TabIndex = 2;
            label3.Text = "AÇIKLAMA:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(251, 19);
            label2.Name = "label2";
            label2.Size = new Size(69, 21);
            label2.TabIndex = 1;
            label2.Text = "FİRMA:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 69);
            label1.Name = "label1";
            label1.Size = new Size(67, 21);
            label1.TabIndex = 0;
            label1.Text = "TARİH:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(36, 219);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1714, 465);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 24);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1708, 438);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(1765, 720);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form2";
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label9;
        private Label lblID;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cmbGurup;
        private ComboBox cmbMamul;
        private ComboBox cmbFirma;
        private DateTimePicker dateTimePicker1;
        private TextBox txtTutar;
        private TextBox txtFiyat;
        private TextBox txtTarih;
        private TextBox txtMiktar;
        private Button btnMenu;
        private Button btnKaydet;
        private Button btnSil;
        private Button btnGuncelle;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private Button btnGurup;
        private Button btnCins;
        private Button btnFirma;
    }
}
namespace WinFormsAVM01
{
    partial class Form_Kredi_Kartlari
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
            label3 = new Label();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            cmbKart = new ComboBox();
            cmbFirma = new ComboBox();
            txtTutar = new TextBox();
            btnKaydet = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            btnAnaMenuye = new Button();
            label5 = new Label();
            cmbBanka = new ComboBox();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            label6 = new Label();
            lblID = new Label();
            txtTarih = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.LightGoldenrodYellow;
            label1.Location = new Point(27, 47);
            label1.Name = "label1";
            label1.Size = new Size(150, 28);
            label1.TabIndex = 0;
            label1.Text = "TARİH";
            // 
            // label2
            // 
            label2.BackColor = Color.LightGoldenrodYellow;
            label2.Location = new Point(27, 126);
            label2.Name = "label2";
            label2.Size = new Size(150, 28);
            label2.TabIndex = 0;
            label2.Text = "KART ADİ";
            // 
            // label3
            // 
            label3.BackColor = Color.LightGoldenrodYellow;
            label3.Location = new Point(27, 163);
            label3.Name = "label3";
            label3.Size = new Size(150, 28);
            label3.TabIndex = 0;
            label3.Text = "FİRMA ADI";
            // 
            // label4
            // 
            label4.BackColor = Color.LightGoldenrodYellow;
            label4.Location = new Point(27, 199);
            label4.Name = "label4";
            label4.Size = new Size(150, 28);
            label4.TabIndex = 0;
            label4.Text = "ÖDEME TUTARI";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(211, 47);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(322, 28);
            dateTimePicker1.TabIndex = 1;
            // 
            // cmbKart
            // 
            cmbKart.FormattingEnabled = true;
            cmbKart.Items.AddRange(new object[] { "GOLD", "TEMA", "VİSA", "OPET", "WORLD", "ENPARA" });
            cmbKart.Location = new Point(211, 122);
            cmbKart.Name = "cmbKart";
            cmbKart.Size = new Size(324, 32);
            cmbKart.TabIndex = 3;
            // 
            // cmbFirma
            // 
            cmbFirma.FormattingEnabled = true;
            cmbFirma.Location = new Point(211, 159);
            cmbFirma.Name = "cmbFirma";
            cmbFirma.Size = new Size(324, 32);
            cmbFirma.TabIndex = 4;
            // 
            // txtTutar
            // 
            txtTutar.Location = new Point(213, 199);
            txtTutar.Name = "txtTutar";
            txtTutar.Size = new Size(322, 28);
            txtTutar.TabIndex = 5;
            txtTutar.TextAlign = HorizontalAlignment.Right;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.Turquoise;
            btnKaydet.Location = new Point(572, 171);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(129, 56);
            btnKaydet.TabIndex = 6;
            btnKaydet.Text = "KAYDET";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.Yellow;
            btnGuncelle.Location = new Point(725, 171);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(129, 56);
            btnGuncelle.TabIndex = 7;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.OrangeRed;
            btnSil.Location = new Point(707, 98);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(129, 56);
            btnSil.TabIndex = 9;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnAnaMenuye
            // 
            btnAnaMenuye.BackColor = Color.MediumSpringGreen;
            btnAnaMenuye.Location = new Point(572, 98);
            btnAnaMenuye.Name = "btnAnaMenuye";
            btnAnaMenuye.Size = new Size(129, 56);
            btnAnaMenuye.TabIndex = 8;
            btnAnaMenuye.Text = "MENÜYE";
            btnAnaMenuye.UseVisualStyleBackColor = false;
            btnAnaMenuye.Click += btnAnaMenuye_Click;
            // 
            // label5
            // 
            label5.BackColor = Color.LightGoldenrodYellow;
            label5.Location = new Point(27, 87);
            label5.Name = "label5";
            label5.Size = new Size(150, 28);
            label5.TabIndex = 0;
            label5.Text = "BANKA";
            // 
            // cmbBanka
            // 
            cmbBanka.FormattingEnabled = true;
            cmbBanka.Items.AddRange(new object[] { "ISB", "ENP", "YKB", "QNB", "\t" });
            cmbBanka.Location = new Point(213, 83);
            cmbBanka.Name = "cmbBanka";
            cmbBanka.Size = new Size(324, 32);
            cmbBanka.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(12, 259);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(845, 433);
            groupBox1.TabIndex = 55;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 24);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(839, 406);
            dataGridView1.StandardTab = true;
            dataGridView1.TabIndex = 10;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(40, 9);
            label6.Name = "label6";
            label6.Size = new Size(32, 24);
            label6.TabIndex = 6;
            label6.Text = "ID";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(157, 9);
            lblID.Name = "lblID";
            lblID.Size = new Size(21, 24);
            lblID.TabIndex = 0;
            lblID.Text = "0";
            lblID.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtTarih
            // 
            txtTarih.BackColor = SystemColors.ControlLightLight;
            txtTarih.BorderStyle = BorderStyle.None;
            txtTarih.Location = new Point(281, 9);
            txtTarih.Name = "txtTarih";
            txtTarih.Size = new Size(159, 21);
            txtTarih.TabIndex = 59;
            // 
            // Form_Kredi_Kartlari
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(869, 685);
            Controls.Add(txtTarih);
            Controls.Add(lblID);
            Controls.Add(label6);
            Controls.Add(groupBox1);
            Controls.Add(btnAnaMenuye);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnKaydet);
            Controls.Add(txtTutar);
            Controls.Add(cmbFirma);
            Controls.Add(cmbBanka);
            Controls.Add(cmbKart);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Cascadia Code", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "Form_Kredi_Kartlari";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_Kredi_Kartlari";
            Load += Form_Kredi_Kartlari_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private ComboBox cmbKart;
        private ComboBox cmbFirma;
        private TextBox txtTutar;
        private Button btnKaydet;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnAnaMenuye;
        private Label label5;
        private ComboBox cmbBanka;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private Label label6;
        private Label lblID;
        private TextBox txtTarih;
    }
}
namespace WinFormsAVM01
{
    partial class Form_Para_Hareket_Listesi
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
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            cmbBanka = new ComboBox();
            cmbAciklama = new ComboBox();
            cmbGurup = new ComboBox();
            btnBankaTarih = new Button();
            btnAciklamaTarih = new Button();
            cmbGurupTarih = new Button();
            cmbBankaAciklama = new Button();
            cmbBankaGurup = new Button();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox3 = new GroupBox();
            lblCikanTL = new Label();
            lblCikanEuro = new Label();
            lblGirenDol = new Label();
            lblGiren22KGr = new Label();
            lblCikan22KGr = new Label();
            lblGiren24KGr = new Label();
            lblCikan24KGr = new Label();
            lblCikanDol = new Label();
            lblGirenEuro = new Label();
            lblGirenTL = new Label();
            label12 = new Label();
            label25 = new Label();
            label11 = new Label();
            label29 = new Label();
            label28 = new Label();
            label27 = new Label();
            label24 = new Label();
            label23 = new Label();
            label22 = new Label();
            label21 = new Label();
            button1 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 28);
            label1.Name = "label1";
            label1.Size = new Size(93, 21);
            label1.TabIndex = 20;
            label1.Text = "İLK TARİH";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 69);
            label2.Name = "label2";
            label2.Size = new Size(106, 21);
            label2.TabIndex = 2;
            label2.Text = "SON TARİH";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(333, 28);
            label3.Name = "label3";
            label3.Size = new Size(69, 21);
            label3.TabIndex = 2;
            label3.Text = "BANKA";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(305, 69);
            label4.Name = "label4";
            label4.Size = new Size(97, 21);
            label4.TabIndex = 3;
            label4.Text = "AÇIKLAMA";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(327, 111);
            label5.Name = "label5";
            label5.Size = new Size(75, 21);
            label5.TabIndex = 4;
            label5.Text = "GURUP";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1058, 28);
            label6.Name = "label6";
            label6.Size = new Size(175, 21);
            label6.TabIndex = 20;
            label6.Text = "BANKA + AÇIKLAMA";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1058, 69);
            label7.Name = "label7";
            label7.Size = new Size(154, 21);
            label7.TabIndex = 20;
            label7.Text = "BANKA + GURUP";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(714, 28);
            label8.Name = "label8";
            label8.Size = new Size(125, 21);
            label8.TabIndex = 20;
            label8.Text = "BANKA TARİH";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(714, 69);
            label9.Name = "label9";
            label9.Size = new Size(153, 21);
            label9.TabIndex = 20;
            label9.Text = "AÇIKLAMA TARİH";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(714, 111);
            label10.Name = "label10";
            label10.Size = new Size(132, 21);
            label10.TabIndex = 20;
            label10.Text = "GURUP TARİH";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(121, 21);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(149, 28);
            dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(121, 62);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(149, 28);
            dateTimePicker2.TabIndex = 1;
            // 
            // cmbBanka
            // 
            cmbBanka.FormattingEnabled = true;
            cmbBanka.Items.AddRange(new object[] { "ISB", "ENP", "YKB", "ZB", "KASA", "ENPV", "", "" });
            cmbBanka.Location = new Point(413, 20);
            cmbBanka.Name = "cmbBanka";
            cmbBanka.Size = new Size(280, 29);
            cmbBanka.TabIndex = 2;
            // 
            // cmbAciklama
            // 
            cmbAciklama.FormattingEnabled = true;
            cmbAciklama.Location = new Point(413, 61);
            cmbAciklama.Name = "cmbAciklama";
            cmbAciklama.Size = new Size(280, 29);
            cmbAciklama.TabIndex = 3;
            // 
            // cmbGurup
            // 
            cmbGurup.FormattingEnabled = true;
            cmbGurup.Items.AddRange(new object[] { "GELİR", "GİDER", "DİĞER" });
            cmbGurup.Location = new Point(413, 103);
            cmbGurup.Name = "cmbGurup";
            cmbGurup.Size = new Size(280, 29);
            cmbGurup.TabIndex = 4;
            // 
            // btnBankaTarih
            // 
            btnBankaTarih.Location = new Point(871, 10);
            btnBankaTarih.Name = "btnBankaTarih";
            btnBankaTarih.Size = new Size(180, 39);
            btnBankaTarih.TabIndex = 5;
            btnBankaTarih.Text = "BANKA";
            btnBankaTarih.UseVisualStyleBackColor = true;
            btnBankaTarih.Click += btnBankaTarih_Click;
            // 
            // btnAciklamaTarih
            // 
            btnAciklamaTarih.Location = new Point(871, 51);
            btnAciklamaTarih.Name = "btnAciklamaTarih";
            btnAciklamaTarih.Size = new Size(180, 39);
            btnAciklamaTarih.TabIndex = 6;
            btnAciklamaTarih.Text = "AÇIKLAMA";
            btnAciklamaTarih.UseVisualStyleBackColor = true;
            btnAciklamaTarih.Click += btnAciklamaTarih_Click;
            // 
            // cmbGurupTarih
            // 
            cmbGurupTarih.Location = new Point(871, 93);
            cmbGurupTarih.Name = "cmbGurupTarih";
            cmbGurupTarih.Size = new Size(180, 39);
            cmbGurupTarih.TabIndex = 7;
            cmbGurupTarih.Text = "GURUP";
            cmbGurupTarih.UseVisualStyleBackColor = true;
            cmbGurupTarih.Click += cmbGurupTarih_Click;
            // 
            // cmbBankaAciklama
            // 
            cmbBankaAciklama.Location = new Point(1260, 10);
            cmbBankaAciklama.Name = "cmbBankaAciklama";
            cmbBankaAciklama.Size = new Size(180, 39);
            cmbBankaAciklama.TabIndex = 8;
            cmbBankaAciklama.Text = "BANKA AÇIKLAMA";
            cmbBankaAciklama.UseVisualStyleBackColor = true;
            // 
            // cmbBankaGurup
            // 
            cmbBankaGurup.Location = new Point(1260, 51);
            cmbBankaGurup.Name = "cmbBankaGurup";
            cmbBankaGurup.Size = new Size(180, 39);
            cmbBankaGurup.TabIndex = 9;
            cmbBankaGurup.Text = "BANKA GURUP";
            cmbBankaGurup.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(11, 232);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1780, 457);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 24);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1774, 430);
            dataGridView1.TabIndex = 19;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.GradientActiveCaption;
            groupBox3.Controls.Add(lblCikanTL);
            groupBox3.Controls.Add(lblCikanEuro);
            groupBox3.Controls.Add(lblGirenDol);
            groupBox3.Controls.Add(lblGiren22KGr);
            groupBox3.Controls.Add(lblCikan22KGr);
            groupBox3.Controls.Add(lblGiren24KGr);
            groupBox3.Controls.Add(lblCikan24KGr);
            groupBox3.Controls.Add(lblCikanDol);
            groupBox3.Controls.Add(lblGirenEuro);
            groupBox3.Controls.Add(lblGirenTL);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label25);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label29);
            groupBox3.Controls.Add(label28);
            groupBox3.Controls.Add(label27);
            groupBox3.Controls.Add(label24);
            groupBox3.Controls.Add(label23);
            groupBox3.Controls.Add(label22);
            groupBox3.Controls.Add(label21);
            groupBox3.Location = new Point(22, 135);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1752, 95);
            groupBox3.TabIndex = 33;
            groupBox3.TabStop = false;
            // 
            // lblCikanTL
            // 
            lblCikanTL.BackColor = Color.Yellow;
            lblCikanTL.Location = new Point(176, 60);
            lblCikanTL.Name = "lblCikanTL";
            lblCikanTL.Size = new Size(125, 21);
            lblCikanTL.TabIndex = 7;
            lblCikanTL.Text = "0";
            lblCikanTL.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCikanEuro
            // 
            lblCikanEuro.BackColor = Color.Yellow;
            lblCikanEuro.Location = new Point(927, 60);
            lblCikanEuro.Name = "lblCikanEuro";
            lblCikanEuro.Size = new Size(125, 21);
            lblCikanEuro.TabIndex = 6;
            lblCikanEuro.Text = "0";
            lblCikanEuro.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblGirenDol
            // 
            lblGirenDol.BackColor = Color.Yellow;
            lblGirenDol.Location = new Point(401, 60);
            lblGirenDol.Name = "lblGirenDol";
            lblGirenDol.Size = new Size(125, 21);
            lblGirenDol.TabIndex = 6;
            lblGirenDol.Text = "0";
            lblGirenDol.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblGiren22KGr
            // 
            lblGiren22KGr.BackColor = Color.Yellow;
            lblGiren22KGr.Location = new Point(1416, 60);
            lblGiren22KGr.Name = "lblGiren22KGr";
            lblGiren22KGr.Size = new Size(125, 21);
            lblGiren22KGr.TabIndex = 6;
            lblGiren22KGr.Text = "0";
            lblGiren22KGr.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCikan22KGr
            // 
            lblCikan22KGr.BackColor = Color.Yellow;
            lblCikan22KGr.Location = new Point(1581, 60);
            lblCikan22KGr.Name = "lblCikan22KGr";
            lblCikan22KGr.Size = new Size(125, 21);
            lblCikan22KGr.TabIndex = 6;
            lblCikan22KGr.Text = "0";
            lblCikan22KGr.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblGiren24KGr
            // 
            lblGiren24KGr.BackColor = Color.Yellow;
            lblGiren24KGr.Location = new Point(1098, 60);
            lblGiren24KGr.Name = "lblGiren24KGr";
            lblGiren24KGr.Size = new Size(125, 21);
            lblGiren24KGr.TabIndex = 6;
            lblGiren24KGr.Text = "0";
            lblGiren24KGr.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCikan24KGr
            // 
            lblCikan24KGr.BackColor = Color.Yellow;
            lblCikan24KGr.Location = new Point(1263, 60);
            lblCikan24KGr.Name = "lblCikan24KGr";
            lblCikan24KGr.Size = new Size(125, 21);
            lblCikan24KGr.TabIndex = 6;
            lblCikan24KGr.Text = "0";
            lblCikan24KGr.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCikanDol
            // 
            lblCikanDol.BackColor = Color.Yellow;
            lblCikanDol.Location = new Point(572, 60);
            lblCikanDol.Name = "lblCikanDol";
            lblCikanDol.Size = new Size(125, 21);
            lblCikanDol.TabIndex = 6;
            lblCikanDol.Text = "0";
            lblCikanDol.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblGirenEuro
            // 
            lblGirenEuro.BackColor = Color.Yellow;
            lblGirenEuro.Location = new Point(772, 60);
            lblGirenEuro.Name = "lblGirenEuro";
            lblGirenEuro.Size = new Size(125, 21);
            lblGirenEuro.TabIndex = 6;
            lblGirenEuro.Text = "0";
            lblGirenEuro.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblGirenTL
            // 
            lblGirenTL.BackColor = Color.Yellow;
            lblGirenTL.Location = new Point(19, 60);
            lblGirenTL.Name = "lblGirenTL";
            lblGirenTL.Size = new Size(125, 21);
            lblGirenTL.TabIndex = 5;
            lblGirenTL.Text = "0";
            lblGirenTL.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            label12.BackColor = Color.Yellow;
            label12.Location = new Point(1581, 24);
            label12.Name = "label12";
            label12.Size = new Size(125, 21);
            label12.TabIndex = 3;
            label12.Text = "ÇIK.22K GR";
            // 
            // label25
            // 
            label25.BackColor = Color.Yellow;
            label25.Location = new Point(772, 24);
            label25.Name = "label25";
            label25.Size = new Size(125, 21);
            label25.TabIndex = 4;
            label25.Text = "GİREN €";
            // 
            // label11
            // 
            label11.BackColor = Color.Yellow;
            label11.Location = new Point(1416, 24);
            label11.Name = "label11";
            label11.Size = new Size(125, 21);
            label11.TabIndex = 2;
            label11.Text = "GİR.22K GR";
            // 
            // label29
            // 
            label29.BackColor = Color.Yellow;
            label29.Location = new Point(1263, 24);
            label29.Name = "label29";
            label29.Size = new Size(125, 21);
            label29.TabIndex = 3;
            label29.Text = "ÇIK.24K GR";
            // 
            // label28
            // 
            label28.BackColor = Color.Yellow;
            label28.Location = new Point(1098, 24);
            label28.Name = "label28";
            label28.Size = new Size(125, 21);
            label28.TabIndex = 2;
            label28.Text = "GİR.24K GR";
            // 
            // label27
            // 
            label27.BackColor = Color.Yellow;
            label27.Location = new Point(927, 24);
            label27.Name = "label27";
            label27.Size = new Size(125, 21);
            label27.TabIndex = 3;
            label27.Text = "ÇIKAN €";
            // 
            // label24
            // 
            label24.BackColor = Color.Yellow;
            label24.Location = new Point(572, 24);
            label24.Name = "label24";
            label24.Size = new Size(125, 21);
            label24.TabIndex = 3;
            label24.Text = "ÇIKAN $";
            // 
            // label23
            // 
            label23.BackColor = Color.Yellow;
            label23.Location = new Point(401, 24);
            label23.Name = "label23";
            label23.Size = new Size(125, 21);
            label23.TabIndex = 2;
            label23.Text = "GİREN $";
            // 
            // label22
            // 
            label22.BackColor = Color.Yellow;
            label22.Location = new Point(176, 24);
            label22.Name = "label22";
            label22.Size = new Size(125, 21);
            label22.TabIndex = 1;
            label22.Text = "ÇIKAN TL";
            // 
            // label21
            // 
            label21.BackColor = Color.Yellow;
            label21.Location = new Point(19, 24);
            label21.Name = "label21";
            label21.Size = new Size(125, 21);
            label21.TabIndex = 0;
            label21.Text = "GİREN TL";
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Location = new Point(1535, 21);
            button1.Name = "button1";
            button1.Size = new Size(123, 83);
            button1.TabIndex = 34;
            button1.Text = "ANA MENÜYE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form_Para_Hareket_Listesi
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(1787, 703);
            Controls.Add(button1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(cmbBankaGurup);
            Controls.Add(cmbBankaAciklama);
            Controls.Add(cmbGurupTarih);
            Controls.Add(btnAciklamaTarih);
            Controls.Add(btnBankaTarih);
            Controls.Add(cmbGurup);
            Controls.Add(cmbAciklama);
            Controls.Add(cmbBanka);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label10);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form_Para_Hareket_Listesi";
            Text = "Form_Para_Hareket_Listesi";
            Load += Form_Para_Hareket_Listesi_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private ComboBox cmbBanka;
        private ComboBox cmbAciklama;
        private ComboBox cmbGurup;
        private Button btnBankaTarih;
        private Button btnAciklamaTarih;
        private Button cmbGurupTarih;
        private Button cmbBankaAciklama;
        private Button cmbBankaGurup;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private GroupBox groupBox3;
        private Label lblCikanTL;
        private Label lblGirenEuro;
        private Label lblGirenTL;
        private Label label25;
        private Label label24;
        private Label label23;
        private Label label22;
        private Label label21;
        private Label lblGirenDol;
        private Label lblCikanDol;
        private Label label29;
        private Label label28;
        private Label label27;
        private Label lblCikanEuro;
        private Label lblGiren24KGr;
        private Label lblCikan24KGr;
        private Label lblGiren22KGr;
        private Label lblCikan22KGr;
        private Label label12;
        private Label label11;
        private Button button1;
    }
}
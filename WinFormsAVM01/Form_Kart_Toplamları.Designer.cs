namespace WinFormsAVM01
{
    partial class Form_Kart_Toplamları
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
            cmbKartAdi = new ComboBox();
            cmbBankaAdi = new ComboBox();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            btnKartToplami = new Button();
            btnBankaToplami = new Button();
            lblKartToplami = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            lblGold = new Label();
            lblTema = new Label();
            lblVisa = new Label();
            lblISB = new Label();
            lblOpet = new Label();
            lblWorld = new Label();
            lblYKB = new Label();
            lblENP = new Label();
            lblToplam = new Label();
            comboBox1 = new ComboBox();
            label12 = new Label();
            label13 = new Label();
            button1 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(186, 24);
            label1.TabIndex = 0;
            label1.Text = "BAŞLANGIÇ TARİHİ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 51);
            label2.Name = "label2";
            label2.Size = new Size(109, 24);
            label2.TabIndex = 0;
            label2.Text = "SON TARİH";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(201, 8);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(172, 28);
            dateTimePicker1.TabIndex = 1;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(201, 47);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(172, 28);
            dateTimePicker2.TabIndex = 2;
            // 
            // cmbKartAdi
            // 
            cmbKartAdi.FormattingEnabled = true;
            cmbKartAdi.Items.AddRange(new object[] { "GOLD", "TEMA", "VİSA", "OPET", "WORLD", "ENPARA" });
            cmbKartAdi.Location = new Point(505, 6);
            cmbKartAdi.Name = "cmbKartAdi";
            cmbKartAdi.Size = new Size(118, 32);
            cmbKartAdi.TabIndex = 3;
            // 
            // cmbBankaAdi
            // 
            cmbBankaAdi.FormattingEnabled = true;
            cmbBankaAdi.Items.AddRange(new object[] { "ISB", "YKB", "ENP" });
            cmbBankaAdi.Location = new Point(505, 45);
            cmbBankaAdi.Name = "cmbBankaAdi";
            cmbBankaAdi.Size = new Size(118, 32);
            cmbBankaAdi.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(25, 176);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(610, 416);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 24);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(604, 389);
            dataGridView1.TabIndex = 50;
            // 
            // btnKartToplami
            // 
            btnKartToplami.BackColor = Color.Crimson;
            btnKartToplami.Location = new Point(22, 111);
            btnKartToplami.Name = "btnKartToplami";
            btnKartToplami.Size = new Size(173, 39);
            btnKartToplami.TabIndex = 5;
            btnKartToplami.Text = "KART TOPLAMI";
            btnKartToplami.UseVisualStyleBackColor = false;
            btnKartToplami.Click += btnKartToplami_Click;
            // 
            // btnBankaToplami
            // 
            btnBankaToplami.BackColor = Color.Crimson;
            btnBankaToplami.Location = new Point(676, 130);
            btnBankaToplami.Name = "btnBankaToplami";
            btnBankaToplami.Size = new Size(176, 39);
            btnBankaToplami.TabIndex = 5;
            btnBankaToplami.Text = "BANKA TOPLAMI";
            btnBankaToplami.UseVisualStyleBackColor = false;
            btnBankaToplami.Click += btnBankaToplami_Click;
            // 
            // lblKartToplami
            // 
            lblKartToplami.BackColor = Color.MintCream;
            lblKartToplami.Location = new Point(201, 114);
            lblKartToplami.Name = "lblKartToplami";
            lblKartToplami.Size = new Size(191, 32);
            lblKartToplami.TabIndex = 6;
            lblKartToplami.Text = "0";
            lblKartToplami.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.BackColor = Color.Crimson;
            label3.Location = new Point(658, 200);
            label3.Name = "label3";
            label3.Size = new Size(70, 32);
            label3.TabIndex = 7;
            label3.Text = "GOLD";
            // 
            // label4
            // 
            label4.BackColor = Color.Crimson;
            label4.Location = new Point(658, 240);
            label4.Name = "label4";
            label4.Size = new Size(70, 32);
            label4.TabIndex = 7;
            label4.Text = "TEMA";
            // 
            // label5
            // 
            label5.BackColor = Color.Crimson;
            label5.Location = new Point(658, 276);
            label5.Name = "label5";
            label5.Size = new Size(70, 32);
            label5.TabIndex = 7;
            label5.Text = "VİSA";
            // 
            // label6
            // 
            label6.BackColor = Color.Crimson;
            label6.Location = new Point(658, 315);
            label6.Name = "label6";
            label6.Size = new Size(70, 32);
            label6.TabIndex = 7;
            label6.Text = "ISB";
            // 
            // label7
            // 
            label7.BackColor = Color.Crimson;
            label7.Location = new Point(658, 355);
            label7.Name = "label7";
            label7.Size = new Size(70, 32);
            label7.TabIndex = 7;
            label7.Text = "OPET";
            // 
            // label8
            // 
            label8.BackColor = Color.Crimson;
            label8.Location = new Point(658, 392);
            label8.Name = "label8";
            label8.Size = new Size(70, 32);
            label8.TabIndex = 7;
            label8.Text = "WORLD";
            // 
            // label9
            // 
            label9.BackColor = Color.Crimson;
            label9.Location = new Point(658, 430);
            label9.Name = "label9";
            label9.Size = new Size(70, 32);
            label9.TabIndex = 7;
            label9.Text = "YKB";
            // 
            // label10
            // 
            label10.BackColor = Color.Crimson;
            label10.Location = new Point(658, 467);
            label10.Name = "label10";
            label10.Size = new Size(70, 32);
            label10.TabIndex = 7;
            label10.Text = "ENP";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(641, 523);
            label11.Name = "label11";
            label11.Size = new Size(87, 24);
            label11.TabIndex = 7;
            label11.Text = " TOPLAM";
            // 
            // lblGold
            // 
            lblGold.BackColor = Color.MintCream;
            lblGold.Location = new Point(751, 200);
            lblGold.Name = "lblGold";
            lblGold.Size = new Size(150, 32);
            lblGold.TabIndex = 7;
            lblGold.Text = "0";
            lblGold.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTema
            // 
            lblTema.BackColor = Color.MintCream;
            lblTema.Location = new Point(751, 237);
            lblTema.Name = "lblTema";
            lblTema.Size = new Size(150, 32);
            lblTema.TabIndex = 7;
            lblTema.Text = "0";
            lblTema.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblVisa
            // 
            lblVisa.BackColor = Color.MintCream;
            lblVisa.Location = new Point(751, 276);
            lblVisa.Name = "lblVisa";
            lblVisa.Size = new Size(150, 32);
            lblVisa.TabIndex = 7;
            lblVisa.Text = "0";
            lblVisa.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblISB
            // 
            lblISB.BackColor = Color.MintCream;
            lblISB.Location = new Point(751, 315);
            lblISB.Name = "lblISB";
            lblISB.Size = new Size(150, 32);
            lblISB.TabIndex = 7;
            lblISB.Text = "0";
            lblISB.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblOpet
            // 
            lblOpet.BackColor = Color.MintCream;
            lblOpet.Location = new Point(751, 355);
            lblOpet.Name = "lblOpet";
            lblOpet.Size = new Size(150, 32);
            lblOpet.TabIndex = 7;
            lblOpet.Text = "0";
            lblOpet.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblWorld
            // 
            lblWorld.BackColor = Color.MintCream;
            lblWorld.Location = new Point(751, 392);
            lblWorld.Name = "lblWorld";
            lblWorld.Size = new Size(150, 32);
            lblWorld.TabIndex = 7;
            lblWorld.Text = "0";
            lblWorld.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblYKB
            // 
            lblYKB.BackColor = Color.MintCream;
            lblYKB.Location = new Point(751, 430);
            lblYKB.Name = "lblYKB";
            lblYKB.Size = new Size(150, 32);
            lblYKB.TabIndex = 7;
            lblYKB.Text = "0";
            lblYKB.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblENP
            // 
            lblENP.BackColor = Color.MintCream;
            lblENP.Location = new Point(751, 467);
            lblENP.Name = "lblENP";
            lblENP.Size = new Size(150, 32);
            lblENP.TabIndex = 7;
            lblENP.Text = "0";
            lblENP.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblToplam
            // 
            lblToplam.BackColor = Color.MintCream;
            lblToplam.Location = new Point(751, 515);
            lblToplam.Name = "lblToplam";
            lblToplam.Size = new Size(150, 32);
            lblToplam.TabIndex = 7;
            lblToplam.Text = "0";
            lblToplam.TextAlign = ContentAlignment.MiddleRight;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "ISB", "YKB", "ENP" });
            comboBox1.Location = new Point(505, 45);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(118, 32);
            comboBox1.TabIndex = 3;
            // 
            // label12
            // 
            label12.BackColor = Color.Crimson;
            label12.Location = new Point(394, 8);
            label12.Name = "label12";
            label12.Size = new Size(105, 32);
            label12.TabIndex = 7;
            label12.Text = "KARTLAR";
            label12.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            label13.BackColor = Color.Crimson;
            label13.Location = new Point(394, 47);
            label13.Name = "label13";
            label13.Size = new Size(105, 32);
            label13.TabIndex = 7;
            label13.Text = "BANKALAR";
            label13.TextAlign = ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            button1.BackColor = Color.Yellow;
            button1.Location = new Point(693, 12);
            button1.Name = "button1";
            button1.Size = new Size(139, 60);
            button1.TabIndex = 8;
            button1.Text = "MENÜYE GİT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form_Kart_Toplamları
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumAquamarine;
            ClientSize = new Size(907, 604);
            Controls.Add(button1);
            Controls.Add(label11);
            Controls.Add(lblToplam);
            Controls.Add(lblENP);
            Controls.Add(label10);
            Controls.Add(lblYKB);
            Controls.Add(label9);
            Controls.Add(lblWorld);
            Controls.Add(label8);
            Controls.Add(lblOpet);
            Controls.Add(lblISB);
            Controls.Add(label7);
            Controls.Add(lblVisa);
            Controls.Add(label6);
            Controls.Add(lblTema);
            Controls.Add(label5);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(lblGold);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblKartToplami);
            Controls.Add(btnBankaToplami);
            Controls.Add(btnKartToplami);
            Controls.Add(groupBox1);
            Controls.Add(comboBox1);
            Controls.Add(cmbBankaAdi);
            Controls.Add(cmbKartAdi);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Cascadia Code", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "Form_Kart_Toplamları";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_Kart_Toplamlarıcs";
            Load += Form_Kart_Toplamları_Load;
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
        private ComboBox cmbKartAdi;
        private ComboBox cmbBankaAdi;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private Button btnKartToplami;
        private Button btnBankaToplami;
        private Label lblKartToplami;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label lblGold;
        private Label lblTema;
        private Label lblVisa;
        private Label lblISB;
        private Label lblOpet;
        private Label lblWorld;
        private Label lblYKB;
        private Label lblENP;
        private Label lblToplam;
        private ComboBox comboBox1;
        private Label label12;
        private Label label13;
        private Button button1;
    }
}
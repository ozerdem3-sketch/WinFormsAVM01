namespace WinFormsAVM01
{
    partial class Form3_Mamul_Kayit
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
            txtIDM = new TextBox();
            txtMamul = new TextBox();
            button1 = new Button();
            btnSil = new Button();
            btnGuncelle = new Button();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            txtIDG = new TextBox();
            txtGurup = new TextBox();
            groupBox2 = new GroupBox();
            dataGridView2 = new DataGridView();
            groupBox3 = new GroupBox();
            btnMemu = new Button();
            btnGurupSil = new Button();
            btnGurupGuncelle = new Button();
            btnGurupKaydet = new Button();
            groupBox4 = new GroupBox();
            btnFirmaSil = new Button();
            btnFirmaGuncelle = new Button();
            btnFirmaKaydet = new Button();
            groupBox5 = new GroupBox();
            dataGridView3 = new DataGridView();
            label5 = new Label();
            label6 = new Label();
            txtIDF = new TextBox();
            txtFirma = new TextBox();
            groupBox6 = new GroupBox();
            groupBox7 = new GroupBox();
            groupBox8 = new GroupBox();
            label7 = new Label();
            lblID = new Label();
            label9 = new Label();
            txtAciklama = new TextBox();
            btnKaydet = new Button();
            dataGridView4 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            groupBox6.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 33);
            label1.Name = "label1";
            label1.Size = new Size(32, 24);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 81);
            label2.Name = "label2";
            label2.Size = new Size(120, 24);
            label2.TabIndex = 0;
            label2.Text = "Mamul adı:";
            // 
            // txtIDM
            // 
            txtIDM.Location = new Point(140, 33);
            txtIDM.Name = "txtIDM";
            txtIDM.Size = new Size(125, 28);
            txtIDM.TabIndex = 1;
            // 
            // txtMamul
            // 
            txtMamul.Location = new Point(140, 78);
            txtMamul.Name = "txtMamul";
            txtMamul.Size = new Size(296, 28);
            txtMamul.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(47, 116);
            button1.Name = "button1";
            button1.Size = new Size(106, 58);
            button1.TabIndex = 2;
            button1.Text = "MAMUL KAYDET";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(323, 116);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(106, 58);
            btnSil.TabIndex = 2;
            btnSil.Text = "MAMUL SİL";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(194, 116);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(106, 58);
            btnGuncelle.TabIndex = 2;
            btnGuncelle.Text = "MAMUL GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(13, 180);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(419, 476);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 24);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(413, 449);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 17);
            label3.Name = "label3";
            label3.Size = new Size(32, 24);
            label3.TabIndex = 0;
            label3.Text = "ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 79);
            label4.Name = "label4";
            label4.Size = new Size(120, 24);
            label4.TabIndex = 0;
            label4.Text = "Gurup Adı:";
            // 
            // txtIDG
            // 
            txtIDG.Location = new Point(140, 17);
            txtIDG.Name = "txtIDG";
            txtIDG.Size = new Size(125, 28);
            txtIDG.TabIndex = 1;
            // 
            // txtGurup
            // 
            txtGurup.Location = new Point(140, 79);
            txtGurup.Name = "txtGurup";
            txtGurup.Size = new Size(296, 28);
            txtGurup.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView2);
            groupBox2.Location = new Point(9, 191);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(419, 457);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(3, 24);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(413, 430);
            dataGridView2.TabIndex = 0;
            dataGridView2.CellClick += dataGridView2_CellClick;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.LightSkyBlue;
            groupBox3.Controls.Add(btnMemu);
            groupBox3.Controls.Add(btnGurupSil);
            groupBox3.Controls.Add(btnGurupGuncelle);
            groupBox3.Controls.Add(btnGurupKaydet);
            groupBox3.Controls.Add(groupBox2);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(txtIDG);
            groupBox3.Controls.Add(txtGurup);
            groupBox3.Location = new Point(923, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(441, 660);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            // 
            // btnMemu
            // 
            btnMemu.BackColor = Color.Yellow;
            btnMemu.Location = new Point(306, 11);
            btnMemu.Name = "btnMemu";
            btnMemu.Size = new Size(109, 57);
            btnMemu.TabIndex = 7;
            btnMemu.Text = "MENÜYE GİT";
            btnMemu.UseVisualStyleBackColor = false;
            btnMemu.Click += btnMemu_Click;
            // 
            // btnGurupSil
            // 
            btnGurupSil.Location = new Point(245, 119);
            btnGurupSil.Name = "btnGurupSil";
            btnGurupSil.Size = new Size(112, 66);
            btnGurupSil.TabIndex = 6;
            btnGurupSil.Text = "GURUP SİL";
            btnGurupSil.UseVisualStyleBackColor = true;
            btnGurupSil.Click += btnGurupSil_Click;
            // 
            // btnGurupGuncelle
            // 
            btnGurupGuncelle.Location = new Point(127, 119);
            btnGurupGuncelle.Name = "btnGurupGuncelle";
            btnGurupGuncelle.Size = new Size(112, 66);
            btnGurupGuncelle.TabIndex = 5;
            btnGurupGuncelle.Text = "GURUP GÜNCELLE";
            btnGurupGuncelle.UseVisualStyleBackColor = true;
            btnGurupGuncelle.Click += btnGurupGuncelle_Click;
            // 
            // btnGurupKaydet
            // 
            btnGurupKaydet.Location = new Point(9, 119);
            btnGurupKaydet.Name = "btnGurupKaydet";
            btnGurupKaydet.Size = new Size(112, 66);
            btnGurupKaydet.TabIndex = 4;
            btnGurupKaydet.Text = "GURUP KAYDET";
            btnGurupKaydet.UseVisualStyleBackColor = true;
            btnGurupKaydet.Click += btnGurupKaydet_Click;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.Yellow;
            groupBox4.Controls.Add(btnFirmaSil);
            groupBox4.Controls.Add(btnFirmaGuncelle);
            groupBox4.Controls.Add(btnFirmaKaydet);
            groupBox4.Controls.Add(groupBox5);
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(txtIDF);
            groupBox4.Controls.Add(txtFirma);
            groupBox4.Location = new Point(476, 10);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(441, 662);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            // 
            // btnFirmaSil
            // 
            btnFirmaSil.Location = new Point(307, 116);
            btnFirmaSil.Name = "btnFirmaSil";
            btnFirmaSil.Size = new Size(109, 58);
            btnFirmaSil.TabIndex = 6;
            btnFirmaSil.Text = "FİRMA SİL";
            btnFirmaSil.UseVisualStyleBackColor = true;
            btnFirmaSil.Click += btnFirmaSil_Click;
            // 
            // btnFirmaGuncelle
            // 
            btnFirmaGuncelle.Location = new Point(171, 116);
            btnFirmaGuncelle.Name = "btnFirmaGuncelle";
            btnFirmaGuncelle.Size = new Size(109, 58);
            btnFirmaGuncelle.TabIndex = 5;
            btnFirmaGuncelle.Text = "FİRMA GÜNCELLE";
            btnFirmaGuncelle.UseVisualStyleBackColor = true;
            btnFirmaGuncelle.Click += btnFirmaGuncelle_Click;
            // 
            // btnFirmaKaydet
            // 
            btnFirmaKaydet.Location = new Point(32, 116);
            btnFirmaKaydet.Name = "btnFirmaKaydet";
            btnFirmaKaydet.Size = new Size(133, 58);
            btnFirmaKaydet.TabIndex = 4;
            btnFirmaKaydet.Text = "FİRMA KAYDET";
            btnFirmaKaydet.UseVisualStyleBackColor = true;
            btnFirmaKaydet.Click += btnFirmaKaydet_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(dataGridView3);
            groupBox5.Location = new Point(9, 191);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(419, 462);
            groupBox5.TabIndex = 3;
            groupBox5.TabStop = false;
            // 
            // dataGridView3
            // 
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Dock = DockStyle.Fill;
            dataGridView3.Location = new Point(3, 24);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.Size = new Size(413, 435);
            dataGridView3.TabIndex = 0;
            dataGridView3.CellClick += dataGridView3_CellClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 17);
            label5.Name = "label5";
            label5.Size = new Size(32, 24);
            label5.TabIndex = 0;
            label5.Text = "ID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 60);
            label6.Name = "label6";
            label6.Size = new Size(120, 24);
            label6.TabIndex = 0;
            label6.Text = "Firma Adı:";
            // 
            // txtIDF
            // 
            txtIDF.Location = new Point(140, 13);
            txtIDF.Name = "txtIDF";
            txtIDF.Size = new Size(125, 28);
            txtIDF.TabIndex = 1;
            // 
            // txtFirma
            // 
            txtFirma.Location = new Point(140, 60);
            txtFirma.Name = "txtFirma";
            txtFirma.Size = new Size(296, 28);
            txtFirma.TabIndex = 1;
            // 
            // groupBox6
            // 
            groupBox6.BackColor = Color.LightGreen;
            groupBox6.Controls.Add(btnGuncelle);
            groupBox6.Controls.Add(btnSil);
            groupBox6.Controls.Add(txtMamul);
            groupBox6.Controls.Add(groupBox1);
            groupBox6.Controls.Add(txtIDM);
            groupBox6.Controls.Add(button1);
            groupBox6.Controls.Add(label1);
            groupBox6.Controls.Add(label2);
            groupBox6.Location = new Point(12, 10);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(442, 662);
            groupBox6.TabIndex = 5;
            groupBox6.TabStop = false;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(btnKaydet);
            groupBox7.Controls.Add(txtAciklama);
            groupBox7.Controls.Add(label9);
            groupBox7.Controls.Add(lblID);
            groupBox7.Controls.Add(label7);
            groupBox7.Controls.Add(groupBox8);
            groupBox7.Location = new Point(1371, 17);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(346, 657);
            groupBox7.TabIndex = 6;
            groupBox7.TabStop = false;
            groupBox7.Text = "groupBox7";
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(dataGridView4);
            groupBox8.Location = new Point(14, 210);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(321, 439);
            groupBox8.TabIndex = 0;
            groupBox8.TabStop = false;
            groupBox8.Text = "groupBox8";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(65, 39);
            label7.Name = "label7";
            label7.Size = new Size(43, 24);
            label7.TabIndex = 1;
            label7.Text = "ID:";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(14, 78);
            lblID.Name = "lblID";
            lblID.Size = new Size(175, 24);
            lblID.TabIndex = 2;
            lblID.Text = "...............";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(14, 126);
            label9.Name = "label9";
            label9.Size = new Size(197, 24);
            label9.TabIndex = 3;
            label9.Text = "BANKALAR AÇIKLAMA";
            // 
            // txtAciklama
            // 
            txtAciklama.Location = new Point(6, 173);
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(329, 28);
            txtAciklama.TabIndex = 4;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(207, 39);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(111, 64);
            btnKaydet.TabIndex = 5;
            btnKaydet.Text = "KAYDET";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // dataGridView4
            // 
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Dock = DockStyle.Fill;
            dataGridView4.Location = new Point(3, 24);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowHeadersWidth = 51;
            dataGridView4.Size = new Size(315, 412);
            dataGridView4.TabIndex = 0;
            // 
            // Form3_Mamul_Kayit
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1741, 684);
            Controls.Add(groupBox7);
            Controls.Add(groupBox6);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Font = new Font("Cascadia Code", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "Form3_Mamul_Kayit";
            Text = "Form3_Mamul_Kayit";
            Load += Form3_Mamul_Kayit_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtIDM;
        private TextBox txtMamul;
        private Button button1;
        private Button btnSil;
        private Button btnGuncelle;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private Label label3;
        private Label label4;
        private TextBox txtIDG;
        private TextBox txtGurup;
        private GroupBox groupBox2;
        private DataGridView dataGridView2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private DataGridView dataGridView3;
        private Label label5;
        private Label label6;
        private TextBox txtIDF;
        private TextBox txtFirma;
        private GroupBox groupBox6;
        private Button btnGurupGuncelle;
        private Button btnGurupKaydet;
        private Button btnFirmaSil;
        private Button btnFirmaGuncelle;
        private Button btnFirmaKaydet;
        private Button btnGurupSil;
        private Button btnMemu;
        private GroupBox groupBox7;
        private Label label9;
        private Label lblID;
        private Label label7;
        private GroupBox groupBox8;
        private Button btnKaydet;
        private TextBox txtAciklama;
        private DataGridView dataGridView4;
    }
}
namespace aracKiralama
{
    partial class FrmGirisAyarlari
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblKullaniciAdi = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblKullaniciTuru = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbTuru = new System.Windows.Forms.ComboBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtKullaniciAd = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnKullaniciSil = new System.Windows.Forms.Button();
            this.btnKullaniciEkle = new System.Windows.Forms.Button();
            this.btnSifreyiDegistir = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblKullaniciAdi,
            this.toolStripStatusLabel3,
            this.lblKullaniciTuru});
            this.statusStrip1.Location = new System.Drawing.Point(0, 571);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1042, 33);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(143, 28);
            this.toolStripStatusLabel1.Text = "Kullanıcı Adı :";
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(199, 28);
            this.lblKullaniciAdi.Text = "toolStripStatusLabel2";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(154, 28);
            this.toolStripStatusLabel3.Text = "Kullanıcı Türü :";
            // 
            // lblKullaniciTuru
            // 
            this.lblKullaniciTuru.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblKullaniciTuru.Name = "lblKullaniciTuru";
            this.lblKullaniciTuru.Size = new System.Drawing.Size(199, 28);
            this.lblKullaniciTuru.Text = "toolStripStatusLabel4";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(487, 479);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 514);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcılar";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbTuru);
            this.groupBox2.Controls.Add(this.txtSifre);
            this.groupBox2.Controls.Add(this.txtKullaniciAd);
            this.groupBox2.Controls.Add(this.txtID);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(511, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(510, 240);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kullanıcı Bilgileri";
            // 
            // cmbTuru
            // 
            this.cmbTuru.BackColor = System.Drawing.SystemColors.Window;
            this.cmbTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTuru.FormattingEnabled = true;
            this.cmbTuru.Items.AddRange(new object[] {
            "Seçiniz",
            "Yönetici",
            "Kullanıcı"});
            this.cmbTuru.Location = new System.Drawing.Point(260, 161);
            this.cmbTuru.Name = "cmbTuru";
            this.cmbTuru.Size = new System.Drawing.Size(205, 37);
            this.cmbTuru.TabIndex = 2;
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.Color.White;
            this.txtSifre.Location = new System.Drawing.Point(260, 119);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(205, 36);
            this.txtSifre.TabIndex = 1;
            // 
            // txtKullaniciAd
            // 
            this.txtKullaniciAd.BackColor = System.Drawing.Color.White;
            this.txtKullaniciAd.Location = new System.Drawing.Point(260, 77);
            this.txtKullaniciAd.Name = "txtKullaniciAd";
            this.txtKullaniciAd.Size = new System.Drawing.Size(205, 36);
            this.txtKullaniciAd.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(260, 35);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(205, 36);
            this.txtID.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(224, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 29);
            this.label8.TabIndex = 0;
            this.label8.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Türü";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(224, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 29);
            this.label7.TabIndex = 0;
            this.label7.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Şifre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(224, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 29);
            this.label6.TabIndex = 0;
            this.label6.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kullanıcı Ad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(224, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = ":";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "İD";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnKullaniciSil);
            this.groupBox3.Controls.Add(this.btnKullaniciEkle);
            this.groupBox3.Controls.Add(this.btnSifreyiDegistir);
            this.groupBox3.Location = new System.Drawing.Point(511, 303);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(510, 240);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "İşlemler";
            // 
            // btnKullaniciSil
            // 
            this.btnKullaniciSil.Location = new System.Drawing.Point(138, 152);
            this.btnKullaniciSil.Name = "btnKullaniciSil";
            this.btnKullaniciSil.Size = new System.Drawing.Size(222, 42);
            this.btnKullaniciSil.TabIndex = 0;
            this.btnKullaniciSil.Text = "Kullanıcı Sil";
            this.btnKullaniciSil.UseVisualStyleBackColor = true;
            this.btnKullaniciSil.Click += new System.EventHandler(this.btnKullaniciSil_Click);
            // 
            // btnKullaniciEkle
            // 
            this.btnKullaniciEkle.Location = new System.Drawing.Point(138, 104);
            this.btnKullaniciEkle.Name = "btnKullaniciEkle";
            this.btnKullaniciEkle.Size = new System.Drawing.Size(222, 42);
            this.btnKullaniciEkle.TabIndex = 0;
            this.btnKullaniciEkle.Text = "Kullanıcı Ekle";
            this.btnKullaniciEkle.UseVisualStyleBackColor = true;
            this.btnKullaniciEkle.Click += new System.EventHandler(this.btnKullaniciEkle_Click);
            // 
            // btnSifreyiDegistir
            // 
            this.btnSifreyiDegistir.Location = new System.Drawing.Point(138, 56);
            this.btnSifreyiDegistir.Name = "btnSifreyiDegistir";
            this.btnSifreyiDegistir.Size = new System.Drawing.Size(222, 42);
            this.btnSifreyiDegistir.TabIndex = 0;
            this.btnSifreyiDegistir.Text = "Şifreyi Değiştir";
            this.btnSifreyiDegistir.UseVisualStyleBackColor = true;
            this.btnSifreyiDegistir.Click += new System.EventHandler(this.btnSifreyiDegistir_Click);
            // 
            // FrmGirisAyarlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1042, 604);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGirisAyarlari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Giriş Ayarları";
            this.Load += new System.EventHandler(this.FrmGirisAyarlari_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblKullaniciAdi;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel lblKullaniciTuru;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbTuru;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtKullaniciAd;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnKullaniciSil;
        private System.Windows.Forms.Button btnKullaniciEkle;
        private System.Windows.Forms.Button btnSifreyiDegistir;
    }
}
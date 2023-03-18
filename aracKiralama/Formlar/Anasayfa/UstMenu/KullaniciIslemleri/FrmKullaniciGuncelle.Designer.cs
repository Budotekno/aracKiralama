namespace aracKiralama
{
    partial class FrmKullaniciGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKullaniciGuncelle));
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbKullaniciTuru = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtKullaniciAd = new System.Windows.Forms.TextBox();
            this.lblYildizTc = new System.Windows.Forms.Label();
            this.lblYildizKullaniciTuru = new System.Windows.Forms.Label();
            this.lblYildizSifre = new System.Windows.Forms.Label();
            this.lblYildizKullaniciAd = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.ptbKullanici = new System.Windows.Forms.PictureBox();
            this.btnResimSec = new System.Windows.Forms.Button();
            this.lblYildizFoto = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbKullanici)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(418, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(308, 39);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kullanıcı Güncelle";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cmbKullaniciTuru);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtTc);
            this.panel1.Controls.Add(this.txtSifre);
            this.panel1.Controls.Add(this.txtKullaniciAd);
            this.panel1.Controls.Add(this.lblYildizTc);
            this.panel1.Controls.Add(this.lblYildizKullaniciTuru);
            this.panel1.Controls.Add(this.lblYildizSifre);
            this.panel1.Controls.Add(this.lblYildizKullaniciAd);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(321, 169);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(481, 246);
            this.panel1.TabIndex = 7;
            // 
            // cmbKullaniciTuru
            // 
            this.cmbKullaniciTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKullaniciTuru.FormattingEnabled = true;
            this.cmbKullaniciTuru.Items.AddRange(new object[] {
            "Seçiniz",
            "Yönetici",
            "Kullanıcı"});
            this.cmbKullaniciTuru.Location = new System.Drawing.Point(242, 198);
            this.cmbKullaniciTuru.Name = "cmbKullaniciTuru";
            this.cmbKullaniciTuru.Size = new System.Drawing.Size(182, 37);
            this.cmbKullaniciTuru.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(31, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "İD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(202, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 29);
            this.label5.TabIndex = 2;
            this.label5.Text = ":";
            // 
            // txtTc
            // 
            this.txtTc.Enabled = false;
            this.txtTc.Location = new System.Drawing.Point(242, 65);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(182, 36);
            this.txtTc.TabIndex = 1;
            this.txtTc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(242, 155);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(182, 36);
            this.txtSifre.TabIndex = 2;
            this.txtSifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtKullaniciAd
            // 
            this.txtKullaniciAd.Location = new System.Drawing.Point(242, 113);
            this.txtKullaniciAd.Name = "txtKullaniciAd";
            this.txtKullaniciAd.Size = new System.Drawing.Size(182, 36);
            this.txtKullaniciAd.TabIndex = 1;
            this.txtKullaniciAd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblYildizTc
            // 
            this.lblYildizTc.AutoSize = true;
            this.lblYildizTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYildizTc.ForeColor = System.Drawing.Color.Red;
            this.lblYildizTc.Location = new System.Drawing.Point(430, 65);
            this.lblYildizTc.Name = "lblYildizTc";
            this.lblYildizTc.Size = new System.Drawing.Size(31, 39);
            this.lblYildizTc.TabIndex = 2;
            this.lblYildizTc.Text = "*";
            this.lblYildizTc.Visible = false;
            // 
            // lblYildizKullaniciTuru
            // 
            this.lblYildizKullaniciTuru.AutoSize = true;
            this.lblYildizKullaniciTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYildizKullaniciTuru.ForeColor = System.Drawing.Color.Red;
            this.lblYildizKullaniciTuru.Location = new System.Drawing.Point(430, 195);
            this.lblYildizKullaniciTuru.Name = "lblYildizKullaniciTuru";
            this.lblYildizKullaniciTuru.Size = new System.Drawing.Size(31, 39);
            this.lblYildizKullaniciTuru.TabIndex = 2;
            this.lblYildizKullaniciTuru.Text = "*";
            this.lblYildizKullaniciTuru.Visible = false;
            // 
            // lblYildizSifre
            // 
            this.lblYildizSifre.AutoSize = true;
            this.lblYildizSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYildizSifre.ForeColor = System.Drawing.Color.Red;
            this.lblYildizSifre.Location = new System.Drawing.Point(430, 155);
            this.lblYildizSifre.Name = "lblYildizSifre";
            this.lblYildizSifre.Size = new System.Drawing.Size(31, 39);
            this.lblYildizSifre.TabIndex = 2;
            this.lblYildizSifre.Text = "*";
            this.lblYildizSifre.Visible = false;
            // 
            // lblYildizKullaniciAd
            // 
            this.lblYildizKullaniciAd.AutoSize = true;
            this.lblYildizKullaniciAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYildizKullaniciAd.ForeColor = System.Drawing.Color.Red;
            this.lblYildizKullaniciAd.Location = new System.Drawing.Point(430, 113);
            this.lblYildizKullaniciAd.Name = "lblYildizKullaniciAd";
            this.lblYildizKullaniciAd.Size = new System.Drawing.Size(31, 39);
            this.lblYildizKullaniciAd.TabIndex = 2;
            this.lblYildizKullaniciAd.Text = "*";
            this.lblYildizKullaniciAd.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(31, 195);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(181, 29);
            this.label11.TabIndex = 2;
            this.label11.Text = "Kullanıcı Türü";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(31, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 29);
            this.label7.TabIndex = 2;
            this.label7.Text = "Şifre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(31, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kullanıcı Adı";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(31, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 29);
            this.label9.TabIndex = 2;
            this.label9.Text = "T.C No";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(202, 198);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 29);
            this.label10.TabIndex = 2;
            this.label10.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(202, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 29);
            this.label8.TabIndex = 2;
            this.label8.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(202, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = ":";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(242, 18);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(182, 36);
            this.txtId.TabIndex = 3;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(202, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 29);
            this.label6.TabIndex = 2;
            this.label6.Text = ":";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(475, 421);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(190, 47);
            this.btnGuncelle.TabIndex = 0;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // ptbKullanici
            // 
            this.ptbKullanici.Location = new System.Drawing.Point(26, 106);
            this.ptbKullanici.Name = "ptbKullanici";
            this.ptbKullanici.Size = new System.Drawing.Size(278, 331);
            this.ptbKullanici.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbKullanici.TabIndex = 8;
            this.ptbKullanici.TabStop = false;
            // 
            // btnResimSec
            // 
            this.btnResimSec.Location = new System.Drawing.Point(70, 443);
            this.btnResimSec.Name = "btnResimSec";
            this.btnResimSec.Size = new System.Drawing.Size(174, 35);
            this.btnResimSec.TabIndex = 9;
            this.btnResimSec.Text = "Resim Seç";
            this.btnResimSec.UseVisualStyleBackColor = true;
            this.btnResimSec.Visible = false;
            this.btnResimSec.Click += new System.EventHandler(this.btnResimSec_Click);
            // 
            // lblYildizFoto
            // 
            this.lblYildizFoto.AutoSize = true;
            this.lblYildizFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYildizFoto.ForeColor = System.Drawing.Color.Red;
            this.lblYildizFoto.Location = new System.Drawing.Point(250, 451);
            this.lblYildizFoto.Name = "lblYildizFoto";
            this.lblYildizFoto.Size = new System.Drawing.Size(31, 39);
            this.lblYildizFoto.TabIndex = 2;
            this.lblYildizFoto.Text = "*";
            this.lblYildizFoto.Visible = false;
            // 
            // FrmKullaniciGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 480);
            this.Controls.Add(this.btnResimSec);
            this.Controls.Add(this.ptbKullanici);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblYildizFoto);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmKullaniciGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kullanıcı Güncelleme ";
            this.Load += new System.EventHandler(this.FrmKullaniciGuncelle_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbKullanici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtSifre;
        public System.Windows.Forms.TextBox txtKullaniciAd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label lblYildizSifre;
        private System.Windows.Forms.Label lblYildizKullaniciAd;
        private System.Windows.Forms.PictureBox ptbKullanici;
        private System.Windows.Forms.Button btnResimSec;
        private System.Windows.Forms.Label lblYildizFoto;
        public System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.Label lblYildizTc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblYildizKullaniciTuru;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.ComboBox cmbKullaniciTuru;
    }
}
namespace aracKiralama
{
    partial class FrmGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGiris));
            this.lblCikis = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKullaniciAd = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ptbSifreAcKapat = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSifreAcKapat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCikis
            // 
            this.lblCikis.AutoSize = true;
            this.lblCikis.BackColor = System.Drawing.Color.Goldenrod;
            this.lblCikis.Font = new System.Drawing.Font("Buxton Sketch", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCikis.Location = new System.Drawing.Point(451, 171);
            this.lblCikis.Name = "lblCikis";
            this.lblCikis.Size = new System.Drawing.Size(18, 21);
            this.lblCikis.TabIndex = 1;
            this.lblCikis.Text = "X";
            this.lblCikis.Click += new System.EventHandler(this.lblCikis_Click);
            this.lblCikis.MouseLeave += new System.EventHandler(this.lblCikis_MouseLeave);
            this.lblCikis.MouseHover += new System.EventHandler(this.lblCikis_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Goldenrod;
            this.label2.Font = new System.Drawing.Font("Buxton Sketch", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(202, 531);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kullanıcı Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Goldenrod;
            this.label3.Font = new System.Drawing.Font("Buxton Sketch", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(329, 531);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 31);
            this.label3.TabIndex = 1;
            this.label3.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Goldenrod;
            this.label4.Font = new System.Drawing.Font("Buxton Sketch", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(254, 570);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 31);
            this.label4.TabIndex = 1;
            this.label4.Text = "Şifre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Goldenrod;
            this.label5.Font = new System.Drawing.Font("Buxton Sketch", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(329, 573);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 31);
            this.label5.TabIndex = 1;
            this.label5.Text = ":";
            // 
            // txtKullaniciAd
            // 
            this.txtKullaniciAd.BackColor = System.Drawing.Color.Goldenrod;
            this.txtKullaniciAd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKullaniciAd.Font = new System.Drawing.Font("Buxton Sketch", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciAd.Location = new System.Drawing.Point(355, 523);
            this.txtKullaniciAd.Multiline = true;
            this.txtKullaniciAd.Name = "txtKullaniciAd";
            this.txtKullaniciAd.Size = new System.Drawing.Size(195, 32);
            this.txtKullaniciAd.TabIndex = 1;
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.Color.Goldenrod;
            this.txtSifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSifre.Font = new System.Drawing.Font("Buxton Sketch", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.Location = new System.Drawing.Point(355, 566);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(131, 35);
            this.txtSifre.TabIndex = 2;
            this.txtSifre.TextChanged += new System.EventHandler(this.txtSifre_TextChanged);
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.BackColor = System.Drawing.Color.Goldenrod;
            this.btnGirisYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGirisYap.Font = new System.Drawing.Font("Buxton Sketch", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGirisYap.Location = new System.Drawing.Point(289, 446);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(182, 34);
            this.btnGirisYap.TabIndex = 0;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.UseVisualStyleBackColor = false;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            this.btnGirisYap.MouseLeave += new System.EventHandler(this.btnGirisYap_MouseLeave);
            this.btnGirisYap.MouseHover += new System.EventHandler(this.btnGirisYap_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(355, 555);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 1);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(356, 594);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(130, 1);
            this.panel2.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Goldenrod;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 700);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(763, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // ptbSifreAcKapat
            // 
            this.ptbSifreAcKapat.BackColor = System.Drawing.Color.Goldenrod;
            this.ptbSifreAcKapat.Image = global::aracKiralama.Properties.Resources.göz;
            this.ptbSifreAcKapat.Location = new System.Drawing.Point(489, 563);
            this.ptbSifreAcKapat.Name = "ptbSifreAcKapat";
            this.ptbSifreAcKapat.Size = new System.Drawing.Size(28, 28);
            this.ptbSifreAcKapat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbSifreAcKapat.TabIndex = 6;
            this.ptbSifreAcKapat.TabStop = false;
            this.ptbSifreAcKapat.Visible = false;
            this.ptbSifreAcKapat.Click += new System.EventHandler(this.ptbSifreAcKapat_Click);
            this.ptbSifreAcKapat.MouseLeave += new System.EventHandler(this.ptbSifreAcKapat_MouseLeave);
            this.ptbSifreAcKapat.MouseHover += new System.EventHandler(this.ptbSifreAcKapat_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gray;
            this.pictureBox1.Image = global::aracKiralama.Properties.Resources.giris1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(763, 694);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 691);
            this.Controls.Add(this.ptbSifreAcKapat);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciAd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCikis);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FrmGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGiris";
            this.TransparencyKey = System.Drawing.Color.Gray;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSifreAcKapat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCikis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKullaniciAd;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox ptbSifreAcKapat;
    }
}
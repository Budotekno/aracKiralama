namespace aracKiralama
{
    partial class FrmKullaniciIslemleri
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKullaniciIslemleri));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnKullanicilariListele = new System.Windows.Forms.ToolStripButton();
            this.btnKullaniciEkle = new System.Windows.Forms.ToolStripButton();
            this.btnKullaniciSil = new System.Windows.Forms.ToolStripButton();
            this.btnGuncelle = new System.Windows.Forms.ToolStripButton();
            this.ptbKullanici = new System.Windows.Forms.PictureBox();
            this.txtAraKullaniciAd = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kullanıcıListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbKullanici)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(293, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(677, 341);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnKullanicilariListele,
            this.btnKullaniciEkle,
            this.btnKullaniciSil,
            this.btnGuncelle});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(970, 88);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnKullanicilariListele
            // 
            this.btnKullanicilariListele.Font = new System.Drawing.Font("Buxton Sketch", 15F);
            this.btnKullanicilariListele.Image = global::aracKiralama.Properties.Resources.listele;
            this.btnKullanicilariListele.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKullanicilariListele.Name = "btnKullanicilariListele";
            this.btnKullanicilariListele.Size = new System.Drawing.Size(183, 85);
            this.btnKullanicilariListele.Text = "Kullanıcıları Listele";
            this.btnKullanicilariListele.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnKullanicilariListele.Click += new System.EventHandler(this.btnKullanicilariListele_Click);
            // 
            // btnKullaniciEkle
            // 
            this.btnKullaniciEkle.Font = new System.Drawing.Font("Buxton Sketch", 15F);
            this.btnKullaniciEkle.Image = global::aracKiralama.Properties.Resources.ekle;
            this.btnKullaniciEkle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKullaniciEkle.Name = "btnKullaniciEkle";
            this.btnKullaniciEkle.Size = new System.Drawing.Size(133, 85);
            this.btnKullaniciEkle.Text = "Kullanıcı Ekle";
            this.btnKullaniciEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnKullaniciEkle.Click += new System.EventHandler(this.btnKullaniciEkle_Click);
            // 
            // btnKullaniciSil
            // 
            this.btnKullaniciSil.Font = new System.Drawing.Font("Buxton Sketch", 15F);
            this.btnKullaniciSil.Image = global::aracKiralama.Properties.Resources.icons8_denied_40px;
            this.btnKullaniciSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKullaniciSil.Name = "btnKullaniciSil";
            this.btnKullaniciSil.Size = new System.Drawing.Size(121, 85);
            this.btnKullaniciSil.Text = "Kullanıcı Sil";
            this.btnKullaniciSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnKullaniciSil.Click += new System.EventHandler(this.btnKullaniciSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Buxton Sketch", 15F);
            this.btnGuncelle.Image = global::aracKiralama.Properties.Resources.guncelle;
            this.btnGuncelle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(168, 85);
            this.btnGuncelle.Text = "Kullanıcı Güncelle";
            this.btnGuncelle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // ptbKullanici
            // 
            this.ptbKullanici.Location = new System.Drawing.Point(9, 165);
            this.ptbKullanici.Name = "ptbKullanici";
            this.ptbKullanici.Size = new System.Drawing.Size(276, 301);
            this.ptbKullanici.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbKullanici.TabIndex = 2;
            this.ptbKullanici.TabStop = false;
            // 
            // txtAraKullaniciAd
            // 
            this.txtAraKullaniciAd.Font = new System.Drawing.Font("Buxton Sketch", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAraKullaniciAd.ForeColor = System.Drawing.Color.Silver;
            this.txtAraKullaniciAd.Location = new System.Drawing.Point(685, 100);
            this.txtAraKullaniciAd.Name = "txtAraKullaniciAd";
            this.txtAraKullaniciAd.Size = new System.Drawing.Size(275, 38);
            this.txtAraKullaniciAd.TabIndex = 3;
            this.txtAraKullaniciAd.Text = "Kullanıcı ada göre arama";
            this.txtAraKullaniciAd.Click += new System.EventHandler(this.txtAraKullaniciAd_Click);
            this.txtAraKullaniciAd.TextChanged += new System.EventHandler(this.txtAraKullaniciAd_TextChanged);
            this.txtAraKullaniciAd.Leave += new System.EventHandler(this.txtAraKullaniciAd_Leave);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullanıcıListeleToolStripMenuItem,
            this.kullanıcıEkleToolStripMenuItem,
            this.kullanıcıSilToolStripMenuItem,
            this.kullanıcıGüncelleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(196, 100);
            // 
            // kullanıcıListeleToolStripMenuItem
            // 
            this.kullanıcıListeleToolStripMenuItem.Image = global::aracKiralama.Properties.Resources.listele;
            this.kullanıcıListeleToolStripMenuItem.Name = "kullanıcıListeleToolStripMenuItem";
            this.kullanıcıListeleToolStripMenuItem.Size = new System.Drawing.Size(195, 24);
            this.kullanıcıListeleToolStripMenuItem.Text = "Kullanıcı Listele";
            this.kullanıcıListeleToolStripMenuItem.Click += new System.EventHandler(this.btnKullanicilariListele_Click);
            // 
            // kullanıcıEkleToolStripMenuItem
            // 
            this.kullanıcıEkleToolStripMenuItem.Image = global::aracKiralama.Properties.Resources.ekle;
            this.kullanıcıEkleToolStripMenuItem.Name = "kullanıcıEkleToolStripMenuItem";
            this.kullanıcıEkleToolStripMenuItem.Size = new System.Drawing.Size(195, 24);
            this.kullanıcıEkleToolStripMenuItem.Text = "Kullanıcı Ekle";
            this.kullanıcıEkleToolStripMenuItem.Click += new System.EventHandler(this.btnKullaniciEkle_Click);
            // 
            // kullanıcıSilToolStripMenuItem
            // 
            this.kullanıcıSilToolStripMenuItem.Image = global::aracKiralama.Properties.Resources.icons8_denied_40px;
            this.kullanıcıSilToolStripMenuItem.Name = "kullanıcıSilToolStripMenuItem";
            this.kullanıcıSilToolStripMenuItem.Size = new System.Drawing.Size(195, 24);
            this.kullanıcıSilToolStripMenuItem.Text = "Kullanıcı Sil";
            this.kullanıcıSilToolStripMenuItem.Click += new System.EventHandler(this.btnKullaniciSil_Click);
            // 
            // kullanıcıGüncelleToolStripMenuItem
            // 
            this.kullanıcıGüncelleToolStripMenuItem.Image = global::aracKiralama.Properties.Resources.guncelle;
            this.kullanıcıGüncelleToolStripMenuItem.Name = "kullanıcıGüncelleToolStripMenuItem";
            this.kullanıcıGüncelleToolStripMenuItem.Size = new System.Drawing.Size(195, 24);
            this.kullanıcıGüncelleToolStripMenuItem.Text = "Kullanıcı Güncelle";
            this.kullanıcıGüncelleToolStripMenuItem.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // FrmKullaniciIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(970, 508);
            this.Controls.Add(this.txtAraKullaniciAd);
            this.Controls.Add(this.ptbKullanici);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmKullaniciIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kullanıcı İşlemleri";
            this.Activated += new System.EventHandler(this.FrmKullaniciIslemleri_Activated);
            this.Load += new System.EventHandler(this.FrmKullaniciIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbKullanici)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnKullanicilariListele;
        private System.Windows.Forms.ToolStripButton btnKullaniciEkle;
        private System.Windows.Forms.ToolStripButton btnKullaniciSil;
        private System.Windows.Forms.ToolStripButton btnGuncelle;
        private System.Windows.Forms.PictureBox ptbKullanici;
        private System.Windows.Forms.TextBox txtAraKullaniciAd;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıGüncelleToolStripMenuItem;
    }
}
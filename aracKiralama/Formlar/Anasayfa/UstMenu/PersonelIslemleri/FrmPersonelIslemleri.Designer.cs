namespace aracKiralama
{
    partial class FrmPersonelIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonelIslemleri));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnPersonelleriListele = new System.Windows.Forms.ToolStripButton();
            this.btnPersonelEkle = new System.Windows.Forms.ToolStripButton();
            this.btnPersonelSil = new System.Windows.Forms.ToolStripButton();
            this.btnPersonelGuncelle = new System.Windows.Forms.ToolStripButton();
            this.ptbPersonel = new System.Windows.Forms.PictureBox();
            this.txtAraAd = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.personelListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPersonel)).BeginInit();
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
            this.dataGridView1.Location = new System.Drawing.Point(265, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(786, 337);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPersonelleriListele,
            this.btnPersonelEkle,
            this.btnPersonelSil,
            this.btnPersonelGuncelle});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1051, 88);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnPersonelleriListele
            // 
            this.btnPersonelleriListele.Font = new System.Drawing.Font("Buxton Sketch", 15F);
            this.btnPersonelleriListele.Image = global::aracKiralama.Properties.Resources.listele;
            this.btnPersonelleriListele.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPersonelleriListele.Name = "btnPersonelleriListele";
            this.btnPersonelleriListele.Size = new System.Drawing.Size(186, 85);
            this.btnPersonelleriListele.Text = "Personelleri Listele";
            this.btnPersonelleriListele.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPersonelleriListele.Click += new System.EventHandler(this.btnPersonelleriListele_Click);
            // 
            // btnPersonelEkle
            // 
            this.btnPersonelEkle.Font = new System.Drawing.Font("Buxton Sketch", 15F);
            this.btnPersonelEkle.Image = global::aracKiralama.Properties.Resources.ekle;
            this.btnPersonelEkle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPersonelEkle.Name = "btnPersonelEkle";
            this.btnPersonelEkle.Size = new System.Drawing.Size(136, 85);
            this.btnPersonelEkle.Text = "Personel Ekle";
            this.btnPersonelEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPersonelEkle.Click += new System.EventHandler(this.btnPersonelEkle_Click);
            // 
            // btnPersonelSil
            // 
            this.btnPersonelSil.Font = new System.Drawing.Font("Buxton Sketch", 15F);
            this.btnPersonelSil.Image = global::aracKiralama.Properties.Resources.icons8_denied_40px;
            this.btnPersonelSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPersonelSil.Name = "btnPersonelSil";
            this.btnPersonelSil.Size = new System.Drawing.Size(124, 85);
            this.btnPersonelSil.Text = "Personel Sil";
            this.btnPersonelSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPersonelSil.Click += new System.EventHandler(this.btnPersonelSil_Click);
            // 
            // btnPersonelGuncelle
            // 
            this.btnPersonelGuncelle.Font = new System.Drawing.Font("Buxton Sketch", 15F);
            this.btnPersonelGuncelle.Image = global::aracKiralama.Properties.Resources.guncelle;
            this.btnPersonelGuncelle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPersonelGuncelle.Name = "btnPersonelGuncelle";
            this.btnPersonelGuncelle.Size = new System.Drawing.Size(171, 85);
            this.btnPersonelGuncelle.Text = "Personel Güncelle";
            this.btnPersonelGuncelle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPersonelGuncelle.Click += new System.EventHandler(this.btnPersonelGuncelle_Click);
            // 
            // ptbPersonel
            // 
            this.ptbPersonel.Location = new System.Drawing.Point(11, 159);
            this.ptbPersonel.Name = "ptbPersonel";
            this.ptbPersonel.Size = new System.Drawing.Size(247, 296);
            this.ptbPersonel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbPersonel.TabIndex = 3;
            this.ptbPersonel.TabStop = false;
            // 
            // txtAraAd
            // 
            this.txtAraAd.Font = new System.Drawing.Font("Buxton Sketch", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAraAd.ForeColor = System.Drawing.Color.Silver;
            this.txtAraAd.Location = new System.Drawing.Point(858, 99);
            this.txtAraAd.Name = "txtAraAd";
            this.txtAraAd.Size = new System.Drawing.Size(184, 38);
            this.txtAraAd.TabIndex = 4;
            this.txtAraAd.Text = "Ada göre arama";
            this.txtAraAd.Click += new System.EventHandler(this.txtAraAd_Click);
            this.txtAraAd.TextChanged += new System.EventHandler(this.txtAraAd_TextChanged);
            this.txtAraAd.Leave += new System.EventHandler(this.txtAraAd_Leave);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelListeleToolStripMenuItem,
            this.personelEkleToolStripMenuItem,
            this.personelSilToolStripMenuItem,
            this.personelGüncelleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(195, 122);
            // 
            // personelListeleToolStripMenuItem
            // 
            this.personelListeleToolStripMenuItem.Image = global::aracKiralama.Properties.Resources.listele;
            this.personelListeleToolStripMenuItem.Name = "personelListeleToolStripMenuItem";
            this.personelListeleToolStripMenuItem.Size = new System.Drawing.Size(194, 24);
            this.personelListeleToolStripMenuItem.Text = "Personel Listele";
            this.personelListeleToolStripMenuItem.Click += new System.EventHandler(this.btnPersonelleriListele_Click);
            // 
            // personelEkleToolStripMenuItem
            // 
            this.personelEkleToolStripMenuItem.Image = global::aracKiralama.Properties.Resources.ekle;
            this.personelEkleToolStripMenuItem.Name = "personelEkleToolStripMenuItem";
            this.personelEkleToolStripMenuItem.Size = new System.Drawing.Size(194, 24);
            this.personelEkleToolStripMenuItem.Text = "Personel Ekle";
            this.personelEkleToolStripMenuItem.Click += new System.EventHandler(this.btnPersonelEkle_Click);
            // 
            // personelSilToolStripMenuItem
            // 
            this.personelSilToolStripMenuItem.Image = global::aracKiralama.Properties.Resources.icons8_denied_40px;
            this.personelSilToolStripMenuItem.Name = "personelSilToolStripMenuItem";
            this.personelSilToolStripMenuItem.Size = new System.Drawing.Size(194, 24);
            this.personelSilToolStripMenuItem.Text = "Personel Sil";
            this.personelSilToolStripMenuItem.Click += new System.EventHandler(this.btnPersonelSil_Click);
            // 
            // personelGüncelleToolStripMenuItem
            // 
            this.personelGüncelleToolStripMenuItem.Image = global::aracKiralama.Properties.Resources.guncelle;
            this.personelGüncelleToolStripMenuItem.Name = "personelGüncelleToolStripMenuItem";
            this.personelGüncelleToolStripMenuItem.Size = new System.Drawing.Size(194, 24);
            this.personelGüncelleToolStripMenuItem.Text = "Personel Güncelle";
            this.personelGüncelleToolStripMenuItem.Click += new System.EventHandler(this.btnPersonelGuncelle_Click);
            // 
            // FrmPersonelIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1051, 484);
            this.Controls.Add(this.txtAraAd);
            this.Controls.Add(this.ptbPersonel);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPersonelIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Personel İşlemleri";
            this.Activated += new System.EventHandler(this.FrmPersonelIslemleri_Activated);
            this.Load += new System.EventHandler(this.FrmPersonelIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPersonel)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnPersonelleriListele;
        private System.Windows.Forms.ToolStripButton btnPersonelEkle;
        private System.Windows.Forms.ToolStripButton btnPersonelSil;
        private System.Windows.Forms.ToolStripButton btnPersonelGuncelle;
        private System.Windows.Forms.PictureBox ptbPersonel;
        private System.Windows.Forms.TextBox txtAraAd;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem personelListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelGüncelleToolStripMenuItem;
    }
}
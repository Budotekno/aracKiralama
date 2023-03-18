namespace aracKiralama
{
    partial class FrmMusteriIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMusteriIslemleri));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnMusterileriListele = new System.Windows.Forms.ToolStripButton();
            this.btnMusteriEkle = new System.Windows.Forms.ToolStripButton();
            this.btnMusteriSil = new System.Windows.Forms.ToolStripButton();
            this.btnMusteriGuncelle = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ptbMusteri = new System.Windows.Forms.PictureBox();
            this.txtAraAd = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.müşteriListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMusteri)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMusterileriListele,
            this.btnMusteriEkle,
            this.btnMusteriSil,
            this.btnMusteriGuncelle});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1175, 88);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnMusterileriListele
            // 
            this.btnMusterileriListele.Font = new System.Drawing.Font("Buxton Sketch", 15F);
            this.btnMusterileriListele.Image = global::aracKiralama.Properties.Resources.listele;
            this.btnMusterileriListele.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMusterileriListele.Name = "btnMusterileriListele";
            this.btnMusterileriListele.Size = new System.Drawing.Size(179, 85);
            this.btnMusterileriListele.Text = "Müşterileri Listele";
            this.btnMusterileriListele.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMusterileriListele.Click += new System.EventHandler(this.btnMusterileriListele_Click);
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.Font = new System.Drawing.Font("Buxton Sketch", 15F);
            this.btnMusteriEkle.Image = global::aracKiralama.Properties.Resources.ekle;
            this.btnMusteriEkle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(129, 85);
            this.btnMusteriEkle.Text = "Müşteri Ekle";
            this.btnMusteriEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMusteriEkle.Click += new System.EventHandler(this.btnMusteriEkle_Click);
            // 
            // btnMusteriSil
            // 
            this.btnMusteriSil.Font = new System.Drawing.Font("Buxton Sketch", 15F);
            this.btnMusteriSil.Image = global::aracKiralama.Properties.Resources.icons8_denied_40px;
            this.btnMusteriSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMusteriSil.Name = "btnMusteriSil";
            this.btnMusteriSil.Size = new System.Drawing.Size(117, 85);
            this.btnMusteriSil.Text = "Müşteri Sil";
            this.btnMusteriSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMusteriSil.Click += new System.EventHandler(this.btnMusteriSil_Click);
            // 
            // btnMusteriGuncelle
            // 
            this.btnMusteriGuncelle.Font = new System.Drawing.Font("Buxton Sketch", 15F);
            this.btnMusteriGuncelle.Image = global::aracKiralama.Properties.Resources.guncelle;
            this.btnMusteriGuncelle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMusteriGuncelle.Name = "btnMusteriGuncelle";
            this.btnMusteriGuncelle.Size = new System.Drawing.Size(164, 85);
            this.btnMusteriGuncelle.Text = "Müşteri Güncelle";
            this.btnMusteriGuncelle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMusteriGuncelle.Click += new System.EventHandler(this.btnMusteriGuncelle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(253, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(922, 369);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // ptbMusteri
            // 
            this.ptbMusteri.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptbMusteri.Location = new System.Drawing.Point(12, 180);
            this.ptbMusteri.Name = "ptbMusteri";
            this.ptbMusteri.Size = new System.Drawing.Size(235, 307);
            this.ptbMusteri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbMusteri.TabIndex = 2;
            this.ptbMusteri.TabStop = false;
            // 
            // txtAraAd
            // 
            this.txtAraAd.Font = new System.Drawing.Font("Buxton Sketch", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAraAd.ForeColor = System.Drawing.Color.Silver;
            this.txtAraAd.Location = new System.Drawing.Point(971, 104);
            this.txtAraAd.Name = "txtAraAd";
            this.txtAraAd.Size = new System.Drawing.Size(197, 38);
            this.txtAraAd.TabIndex = 3;
            this.txtAraAd.Text = "Ada göre arama";
            this.txtAraAd.Click += new System.EventHandler(this.txtAraAd_Click);
            this.txtAraAd.TextChanged += new System.EventHandler(this.txtAraAd_TextChanged);
            this.txtAraAd.Leave += new System.EventHandler(this.txtAraAd_Leave);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriListeleToolStripMenuItem,
            this.müşteriEkleToolStripMenuItem,
            this.müşteriSilToolStripMenuItem,
            this.müşteriGüncelleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(189, 100);
            // 
            // müşteriListeleToolStripMenuItem
            // 
            this.müşteriListeleToolStripMenuItem.Image = global::aracKiralama.Properties.Resources.listele;
            this.müşteriListeleToolStripMenuItem.Name = "müşteriListeleToolStripMenuItem";
            this.müşteriListeleToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.müşteriListeleToolStripMenuItem.Text = "Müşteri Listele";
            this.müşteriListeleToolStripMenuItem.Click += new System.EventHandler(this.btnMusterileriListele_Click);
            // 
            // müşteriEkleToolStripMenuItem
            // 
            this.müşteriEkleToolStripMenuItem.Image = global::aracKiralama.Properties.Resources.ekle;
            this.müşteriEkleToolStripMenuItem.Name = "müşteriEkleToolStripMenuItem";
            this.müşteriEkleToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.müşteriEkleToolStripMenuItem.Text = "Müşteri Ekle";
            this.müşteriEkleToolStripMenuItem.Click += new System.EventHandler(this.btnMusteriEkle_Click);
            // 
            // müşteriSilToolStripMenuItem
            // 
            this.müşteriSilToolStripMenuItem.Image = global::aracKiralama.Properties.Resources.icons8_denied_40px;
            this.müşteriSilToolStripMenuItem.Name = "müşteriSilToolStripMenuItem";
            this.müşteriSilToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.müşteriSilToolStripMenuItem.Text = "Müşteri Sil";
            this.müşteriSilToolStripMenuItem.Click += new System.EventHandler(this.btnMusteriSil_Click);
            // 
            // müşteriGüncelleToolStripMenuItem
            // 
            this.müşteriGüncelleToolStripMenuItem.Image = global::aracKiralama.Properties.Resources.guncelle;
            this.müşteriGüncelleToolStripMenuItem.Name = "müşteriGüncelleToolStripMenuItem";
            this.müşteriGüncelleToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.müşteriGüncelleToolStripMenuItem.Text = "Müşteri Güncelle";
            this.müşteriGüncelleToolStripMenuItem.Click += new System.EventHandler(this.btnMusteriGuncelle_Click);
            // 
            // FrmMusteriIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1175, 525);
            this.Controls.Add(this.txtAraAd);
            this.Controls.Add(this.ptbMusteri);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMusteriIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Müşteri İşlemleri";
            this.Activated += new System.EventHandler(this.FrmMusteriIslemleri_Activated);
            this.Load += new System.EventHandler(this.FrmMusteriIslemleri_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMusteri)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnMusterileriListele;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripButton btnMusteriEkle;
        private System.Windows.Forms.ToolStripButton btnMusteriSil;
        private System.Windows.Forms.ToolStripButton btnMusteriGuncelle;
        private System.Windows.Forms.PictureBox ptbMusteri;
        private System.Windows.Forms.TextBox txtAraAd;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem müşteriListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriGüncelleToolStripMenuItem;
    }
}
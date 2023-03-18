namespace aracKiralama
{
    partial class FrmAracIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAracIslemleri));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAraclariListele = new System.Windows.Forms.ToolStripButton();
            this.btnKiralikAraclar = new System.Windows.Forms.ToolStripButton();
            this.btnKiralananAraclar = new System.Windows.Forms.ToolStripButton();
            this.btnYeniAracEkle = new System.Windows.Forms.ToolStripButton();
            this.btnAracSil = new System.Windows.Forms.ToolStripButton();
            this.btnAracGuncelle = new System.Windows.Forms.ToolStripButton();
            this.lblBasllik = new System.Windows.Forms.Label();
            this.ptbArac = new System.Windows.Forms.PictureBox();
            this.txtAraMarka = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbArac)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(255, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(939, 364);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAraclariListele,
            this.btnKiralikAraclar,
            this.btnKiralananAraclar,
            this.btnYeniAracEkle,
            this.btnAracSil,
            this.btnAracGuncelle});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1194, 88);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAraclariListele
            // 
            this.btnAraclariListele.Font = new System.Drawing.Font("Buxton Sketch", 15F);
            this.btnAraclariListele.Image = global::aracKiralama.Properties.Resources.tumAraclar;
            this.btnAraclariListele.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAraclariListele.Name = "btnAraclariListele";
            this.btnAraclariListele.Size = new System.Drawing.Size(148, 85);
            this.btnAraclariListele.Text = "Araçları Listele";
            this.btnAraclariListele.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAraclariListele.Click += new System.EventHandler(this.btnAraclariListele_Click);
            // 
            // btnKiralikAraclar
            // 
            this.btnKiralikAraclar.Font = new System.Drawing.Font("Buxton Sketch", 15F);
            this.btnKiralikAraclar.Image = global::aracKiralama.Properties.Resources.icons8_traffic_jam_80px;
            this.btnKiralikAraclar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKiralikAraclar.Name = "btnKiralikAraclar";
            this.btnKiralikAraclar.Size = new System.Drawing.Size(144, 85);
            this.btnKiralikAraclar.Text = "Kiralık Araçlar";
            this.btnKiralikAraclar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnKiralikAraclar.Click += new System.EventHandler(this.btnKiralikAraclar_Click);
            // 
            // btnKiralananAraclar
            // 
            this.btnKiralananAraclar.Font = new System.Drawing.Font("Buxton Sketch", 15F);
            this.btnKiralananAraclar.Image = global::aracKiralama.Properties.Resources.icons8_car_rental_48px;
            this.btnKiralananAraclar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKiralananAraclar.Name = "btnKiralananAraclar";
            this.btnKiralananAraclar.Size = new System.Drawing.Size(166, 85);
            this.btnKiralananAraclar.Text = "Kiralanan Araçlar";
            this.btnKiralananAraclar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnKiralananAraclar.Click += new System.EventHandler(this.btnKiralananAraclar_Click);
            // 
            // btnYeniAracEkle
            // 
            this.btnYeniAracEkle.Font = new System.Drawing.Font("Buxton Sketch", 15F);
            this.btnYeniAracEkle.Image = global::aracKiralama.Properties.Resources.aracEkle;
            this.btnYeniAracEkle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnYeniAracEkle.Name = "btnYeniAracEkle";
            this.btnYeniAracEkle.Size = new System.Drawing.Size(98, 85);
            this.btnYeniAracEkle.Text = "Araç Ekle";
            this.btnYeniAracEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnYeniAracEkle.Click += new System.EventHandler(this.btnYeniAracEkle_Click);
            // 
            // btnAracSil
            // 
            this.btnAracSil.Enabled = false;
            this.btnAracSil.Font = new System.Drawing.Font("Buxton Sketch", 15F);
            this.btnAracSil.Image = global::aracKiralama.Properties.Resources.aracSil;
            this.btnAracSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAracSil.Name = "btnAracSil";
            this.btnAracSil.Size = new System.Drawing.Size(86, 85);
            this.btnAracSil.Text = "Araç Sil";
            this.btnAracSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAracSil.Click += new System.EventHandler(this.btnAracSil_Click);
            // 
            // btnAracGuncelle
            // 
            this.btnAracGuncelle.Font = new System.Drawing.Font("Buxton Sketch", 15F);
            this.btnAracGuncelle.Image = global::aracKiralama.Properties.Resources.aracGuncelle;
            this.btnAracGuncelle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAracGuncelle.Name = "btnAracGuncelle";
            this.btnAracGuncelle.Size = new System.Drawing.Size(133, 85);
            this.btnAracGuncelle.Text = "Araç Güncelle";
            this.btnAracGuncelle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAracGuncelle.Click += new System.EventHandler(this.btnAracGuncelle_Click);
            // 
            // lblBasllik
            // 
            this.lblBasllik.AutoSize = true;
            this.lblBasllik.Font = new System.Drawing.Font("Buxton Sketch", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBasllik.Location = new System.Drawing.Point(1, 99);
            this.lblBasllik.Name = "lblBasllik";
            this.lblBasllik.Size = new System.Drawing.Size(220, 42);
            this.lblBasllik.TabIndex = 4;
            this.lblBasllik.Text = "Tüm Araç Listesi";
            // 
            // ptbArac
            // 
            this.ptbArac.Location = new System.Drawing.Point(6, 168);
            this.ptbArac.Name = "ptbArac";
            this.ptbArac.Size = new System.Drawing.Size(240, 330);
            this.ptbArac.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbArac.TabIndex = 3;
            this.ptbArac.TabStop = false;
            // 
            // txtAraMarka
            // 
            this.txtAraMarka.Font = new System.Drawing.Font("Buxton Sketch", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAraMarka.ForeColor = System.Drawing.Color.Silver;
            this.txtAraMarka.Location = new System.Drawing.Point(963, 99);
            this.txtAraMarka.Name = "txtAraMarka";
            this.txtAraMarka.Size = new System.Drawing.Size(219, 38);
            this.txtAraMarka.TabIndex = 5;
            this.txtAraMarka.Text = "Markaya göre arama";
            this.txtAraMarka.Click += new System.EventHandler(this.txtAraMarka_Click);
            this.txtAraMarka.TextChanged += new System.EventHandler(this.txtAraMarka_TextChanged);
            this.txtAraMarka.Leave += new System.EventHandler(this.txtAraMarka_Leave);
            // 
            // FrmAracIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1194, 542);
            this.Controls.Add(this.txtAraMarka);
            this.Controls.Add(this.lblBasllik);
            this.Controls.Add(this.ptbArac);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAracIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Araç İşlemleri";
            this.Activated += new System.EventHandler(this.FrmAracIslemleri_Activated);
            this.Load += new System.EventHandler(this.FrmAracIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbArac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAraclariListele;
        private System.Windows.Forms.ToolStripButton btnYeniAracEkle;
        private System.Windows.Forms.ToolStripButton btnAracSil;
        private System.Windows.Forms.ToolStripButton btnKiralikAraclar;
        private System.Windows.Forms.ToolStripButton btnKiralananAraclar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripButton btnAracGuncelle;
        private System.Windows.Forms.PictureBox ptbArac;
        private System.Windows.Forms.Label lblBasllik;
        private System.Windows.Forms.TextBox txtAraMarka;
    }
}
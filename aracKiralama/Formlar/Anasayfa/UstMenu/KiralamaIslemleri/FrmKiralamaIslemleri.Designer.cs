namespace aracKiralama
{
    partial class FrmKiralamaIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKiralamaIslemleri));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnListele = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAracKirala = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAracGuncelle = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAracTeslim = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtAraPlaka = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.listeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araçKiralaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araçGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araçTeslimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnListele,
            this.toolStripSeparator1,
            this.btnAracKirala,
            this.toolStripSeparator2,
            this.btnAracGuncelle,
            this.toolStripSeparator3,
            this.btnAracTeslim});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(878, 88);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnListele
            // 
            this.btnListele.Font = new System.Drawing.Font("Buxton Sketch", 15F);
            this.btnListele.Image = global::aracKiralama.Properties.Resources.araclistle;
            this.btnListele.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(76, 85);
            this.btnListele.Text = "Listele";
            this.btnListele.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 88);
            // 
            // btnAracKirala
            // 
            this.btnAracKirala.Font = new System.Drawing.Font("Buxton Sketch", 15F);
            this.btnAracKirala.Image = global::aracKiralama.Properties.Resources.araçkirala;
            this.btnAracKirala.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAracKirala.Name = "btnAracKirala";
            this.btnAracKirala.Size = new System.Drawing.Size(114, 85);
            this.btnAracKirala.Text = "Araç Kirala";
            this.btnAracKirala.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAracKirala.Click += new System.EventHandler(this.btnAracKirala_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 88);
            // 
            // btnAracGuncelle
            // 
            this.btnAracGuncelle.Font = new System.Drawing.Font("Buxton Sketch", 15F);
            this.btnAracGuncelle.Image = global::aracKiralama.Properties.Resources.araçgüncelle;
            this.btnAracGuncelle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAracGuncelle.Name = "btnAracGuncelle";
            this.btnAracGuncelle.Size = new System.Drawing.Size(133, 85);
            this.btnAracGuncelle.Text = "Araç Güncelle";
            this.btnAracGuncelle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAracGuncelle.Click += new System.EventHandler(this.btnAracGuncelle_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 88);
            // 
            // btnAracTeslim
            // 
            this.btnAracTeslim.Font = new System.Drawing.Font("Buxton Sketch", 15F);
            this.btnAracTeslim.Image = global::aracKiralama.Properties.Resources.aracteslim;
            this.btnAracTeslim.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAracTeslim.Name = "btnAracTeslim";
            this.btnAracTeslim.Size = new System.Drawing.Size(120, 85);
            this.btnAracTeslim.Text = "Araç Teslim";
            this.btnAracTeslim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAracTeslim.Click += new System.EventHandler(this.btnAracTeslim_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(878, 418);
            this.dataGridView1.TabIndex = 1;
            // 
            // txtAraPlaka
            // 
            this.txtAraPlaka.Font = new System.Drawing.Font("Buxton Sketch", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAraPlaka.ForeColor = System.Drawing.Color.Silver;
            this.txtAraPlaka.Location = new System.Drawing.Point(655, 92);
            this.txtAraPlaka.Name = "txtAraPlaka";
            this.txtAraPlaka.Size = new System.Drawing.Size(208, 38);
            this.txtAraPlaka.TabIndex = 2;
            this.txtAraPlaka.Text = "Plakaya göre arama";
            this.txtAraPlaka.Click += new System.EventHandler(this.txtAraPlaka_Click);
            this.txtAraPlaka.TextChanged += new System.EventHandler(this.txtAraPlaka_TextChanged);
            this.txtAraPlaka.Leave += new System.EventHandler(this.txtAraPlaka_Leave);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeleToolStripMenuItem,
            this.araçKiralaToolStripMenuItem,
            this.araçGüncelleToolStripMenuItem,
            this.araçTeslimToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(170, 100);
            // 
            // listeleToolStripMenuItem
            // 
            this.listeleToolStripMenuItem.Image = global::aracKiralama.Properties.Resources.araclistle;
            this.listeleToolStripMenuItem.Name = "listeleToolStripMenuItem";
            this.listeleToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.listeleToolStripMenuItem.Text = "Listele";
            this.listeleToolStripMenuItem.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // araçKiralaToolStripMenuItem
            // 
            this.araçKiralaToolStripMenuItem.Image = global::aracKiralama.Properties.Resources.araçkirala;
            this.araçKiralaToolStripMenuItem.Name = "araçKiralaToolStripMenuItem";
            this.araçKiralaToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.araçKiralaToolStripMenuItem.Text = "Araç Kirala";
            this.araçKiralaToolStripMenuItem.Click += new System.EventHandler(this.btnAracKirala_Click);
            // 
            // araçGüncelleToolStripMenuItem
            // 
            this.araçGüncelleToolStripMenuItem.Image = global::aracKiralama.Properties.Resources.araçgüncelle;
            this.araçGüncelleToolStripMenuItem.Name = "araçGüncelleToolStripMenuItem";
            this.araçGüncelleToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.araçGüncelleToolStripMenuItem.Text = "Araç Güncelle";
            this.araçGüncelleToolStripMenuItem.Click += new System.EventHandler(this.btnAracGuncelle_Click);
            // 
            // araçTeslimToolStripMenuItem
            // 
            this.araçTeslimToolStripMenuItem.Image = global::aracKiralama.Properties.Resources.aracteslim;
            this.araçTeslimToolStripMenuItem.Name = "araçTeslimToolStripMenuItem";
            this.araçTeslimToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.araçTeslimToolStripMenuItem.Text = "Araç Teslim";
            this.araçTeslimToolStripMenuItem.Click += new System.EventHandler(this.btnAracTeslim_Click);
            // 
            // FrmKiralamaIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(878, 557);
            this.Controls.Add(this.txtAraPlaka);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmKiralamaIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kiralama İşlemleri";
            this.Activated += new System.EventHandler(this.FrmKiralamaIslemleri_Activated);
            this.Load += new System.EventHandler(this.FrmKiralamaIslemleri_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnListele;
        private System.Windows.Forms.ToolStripButton btnAracKirala;
        private System.Windows.Forms.ToolStripButton btnAracGuncelle;
        private System.Windows.Forms.ToolStripButton btnAracTeslim;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtAraPlaka;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem listeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem araçKiralaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem araçGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem araçTeslimToolStripMenuItem;
    }
}
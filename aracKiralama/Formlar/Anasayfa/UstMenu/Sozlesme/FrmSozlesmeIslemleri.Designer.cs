namespace aracKiralama
{
    partial class FrmSozlesmeIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSozlesmeIslemleri));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnListele = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSozlesmeEkle = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnGuncelle = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnIptal = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtAraTc = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.listleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sözleşmeİmzalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sözleşmeGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sözleşmeİptalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.btnSozlesmeEkle,
            this.toolStripSeparator2,
            this.btnGuncelle,
            this.toolStripSeparator3,
            this.btnIptal});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(965, 88);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnListele
            // 
            this.btnListele.Font = new System.Drawing.Font("Buxton Sketch", 15F);
            this.btnListele.Image = global::aracKiralama.Properties.Resources.sözleşmeListele;
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
            // btnSozlesmeEkle
            // 
            this.btnSozlesmeEkle.Font = new System.Drawing.Font("Buxton Sketch", 15F);
            this.btnSozlesmeEkle.Image = global::aracKiralama.Properties.Resources.sözleşmeEkle;
            this.btnSozlesmeEkle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSozlesmeEkle.Name = "btnSozlesmeEkle";
            this.btnSozlesmeEkle.Size = new System.Drawing.Size(161, 85);
            this.btnSozlesmeEkle.Text = "Sözleşme İmzala";
            this.btnSozlesmeEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSozlesmeEkle.Click += new System.EventHandler(this.btnSozlesmeEkle_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 88);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Buxton Sketch", 15F);
            this.btnGuncelle.Image = global::aracKiralama.Properties.Resources.sözleşmeGuncelle;
            this.btnGuncelle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(179, 85);
            this.btnGuncelle.Text = "Sözleşme Güncelle";
            this.btnGuncelle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 88);
            // 
            // btnIptal
            // 
            this.btnIptal.Font = new System.Drawing.Font("Buxton Sketch", 15F);
            this.btnIptal.Image = global::aracKiralama.Properties.Resources.sözleşmeiptal;
            this.btnIptal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(148, 85);
            this.btnIptal.Text = "Sözleşme İptal";
            this.btnIptal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 141);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(965, 437);
            this.dataGridView1.TabIndex = 1;
            // 
            // txtAraTc
            // 
            this.txtAraTc.Font = new System.Drawing.Font("Buxton Sketch", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAraTc.ForeColor = System.Drawing.Color.Silver;
            this.txtAraTc.Location = new System.Drawing.Point(726, 97);
            this.txtAraTc.Name = "txtAraTc";
            this.txtAraTc.Size = new System.Drawing.Size(216, 38);
            this.txtAraTc.TabIndex = 2;
            this.txtAraTc.Text = "Tc\'ye göre arama";
            this.txtAraTc.Click += new System.EventHandler(this.txtAraTc_Click);
            this.txtAraTc.TextChanged += new System.EventHandler(this.txtAraTc_TextChanged);
            this.txtAraTc.Leave += new System.EventHandler(this.txtAraTc_Leave);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listleToolStripMenuItem,
            this.sözleşmeİmzalaToolStripMenuItem,
            this.sözleşmeGüncelleToolStripMenuItem,
            this.sözleşmeİptalToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(203, 100);
            // 
            // listleToolStripMenuItem
            // 
            this.listleToolStripMenuItem.Image = global::aracKiralama.Properties.Resources.sözleşmeListele;
            this.listleToolStripMenuItem.Name = "listleToolStripMenuItem";
            this.listleToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.listleToolStripMenuItem.Text = "Listele";
            this.listleToolStripMenuItem.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // sözleşmeİmzalaToolStripMenuItem
            // 
            this.sözleşmeİmzalaToolStripMenuItem.Image = global::aracKiralama.Properties.Resources.sözleşmeEkle;
            this.sözleşmeİmzalaToolStripMenuItem.Name = "sözleşmeİmzalaToolStripMenuItem";
            this.sözleşmeİmzalaToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.sözleşmeİmzalaToolStripMenuItem.Text = "Sözleşme İmzala";
            this.sözleşmeİmzalaToolStripMenuItem.Click += new System.EventHandler(this.btnSozlesmeEkle_Click);
            // 
            // sözleşmeGüncelleToolStripMenuItem
            // 
            this.sözleşmeGüncelleToolStripMenuItem.Image = global::aracKiralama.Properties.Resources.sözleşmeGuncelle;
            this.sözleşmeGüncelleToolStripMenuItem.Name = "sözleşmeGüncelleToolStripMenuItem";
            this.sözleşmeGüncelleToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.sözleşmeGüncelleToolStripMenuItem.Text = "Sözleşme Güncelle";
            this.sözleşmeGüncelleToolStripMenuItem.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // sözleşmeİptalToolStripMenuItem
            // 
            this.sözleşmeİptalToolStripMenuItem.Image = global::aracKiralama.Properties.Resources.sözleşmeiptal;
            this.sözleşmeİptalToolStripMenuItem.Name = "sözleşmeİptalToolStripMenuItem";
            this.sözleşmeİptalToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.sözleşmeİptalToolStripMenuItem.Text = "Sözleşme İptal";
            this.sözleşmeİptalToolStripMenuItem.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // FrmSozlesmeIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(965, 590);
            this.Controls.Add(this.txtAraTc);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSozlesmeIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sözleşme İşlemleri";
            this.Load += new System.EventHandler(this.FrmSozlesmeIslemleri_Load);
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
        private System.Windows.Forms.ToolStripButton btnSozlesmeEkle;
        private System.Windows.Forms.ToolStripButton btnGuncelle;
        private System.Windows.Forms.ToolStripButton btnIptal;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtAraTc;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem listleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sözleşmeİmzalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sözleşmeGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sözleşmeİptalToolStripMenuItem;
    }
}
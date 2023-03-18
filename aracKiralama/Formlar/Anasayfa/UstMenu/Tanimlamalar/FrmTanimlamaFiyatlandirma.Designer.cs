namespace aracKiralama
{
    partial class FrmTanimlamaFiyatlandirma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTanimlamaFiyatlandirma));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFiyat = new System.Windows.Forms.Button();
            this.mTxtFiyat = new System.Windows.Forms.MaskedTextBox();
            this.cmbAracTuru = new System.Windows.Forms.ComboBox();
            this.lblİkiNokta = new System.Windows.Forms.Label();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFiyat);
            this.groupBox1.Controls.Add(this.mTxtFiyat);
            this.groupBox1.Controls.Add(this.cmbAracTuru);
            this.groupBox1.Controls.Add(this.lblİkiNokta);
            this.groupBox1.Controls.Add(this.lblFiyat);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(37, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 231);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Araç Fiyatları";
            // 
            // btnFiyat
            // 
            this.btnFiyat.Location = new System.Drawing.Point(225, 159);
            this.btnFiyat.Name = "btnFiyat";
            this.btnFiyat.Size = new System.Drawing.Size(191, 36);
            this.btnFiyat.TabIndex = 3;
            this.btnFiyat.Text = "Fiyatlandır";
            this.btnFiyat.UseVisualStyleBackColor = true;
            this.btnFiyat.Visible = false;
            this.btnFiyat.Click += new System.EventHandler(this.btnFiyat_Click);
            // 
            // mTxtFiyat
            // 
            this.mTxtFiyat.Location = new System.Drawing.Point(225, 107);
            this.mTxtFiyat.Mask = "0000";
            this.mTxtFiyat.Name = "mTxtFiyat";
            this.mTxtFiyat.Size = new System.Drawing.Size(191, 36);
            this.mTxtFiyat.TabIndex = 2;
            this.mTxtFiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mTxtFiyat.Visible = false;
            // 
            // cmbAracTuru
            // 
            this.cmbAracTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAracTuru.FormattingEnabled = true;
            this.cmbAracTuru.Items.AddRange(new object[] {
            "Seçiniz",
            "Üst Sınıf",
            "Orta Sınıf",
            "Düşük Sınıf"});
            this.cmbAracTuru.Location = new System.Drawing.Point(225, 61);
            this.cmbAracTuru.Name = "cmbAracTuru";
            this.cmbAracTuru.Size = new System.Drawing.Size(191, 37);
            this.cmbAracTuru.TabIndex = 1;
            this.cmbAracTuru.SelectedIndexChanged += new System.EventHandler(this.cmbAracTuru_SelectedIndexChanged);
            // 
            // lblİkiNokta
            // 
            this.lblİkiNokta.AutoSize = true;
            this.lblİkiNokta.Location = new System.Drawing.Point(173, 104);
            this.lblİkiNokta.Name = "lblİkiNokta";
            this.lblİkiNokta.Size = new System.Drawing.Size(20, 29);
            this.lblİkiNokta.TabIndex = 0;
            this.lblİkiNokta.Text = ":";
            this.lblİkiNokta.Visible = false;
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Location = new System.Drawing.Point(17, 104);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(68, 29);
            this.lblFiyat.TabIndex = 0;
            this.lblFiyat.Text = "Fiyat";
            this.lblFiyat.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(173, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = ":";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Araç Türü";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(99, 289);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(308, 112);
            this.dataGridView1.TabIndex = 1;
            // 
            // FrmTanimlamaFiyatlandirma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(498, 448);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTanimlamaFiyatlandirma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fiyatlandırma";
            this.Load += new System.EventHandler(this.FrmTanimlamaFiyatlandirma_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFiyat;
        private System.Windows.Forms.MaskedTextBox mTxtFiyat;
        private System.Windows.Forms.ComboBox cmbAracTuru;
        private System.Windows.Forms.Label lblİkiNokta;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
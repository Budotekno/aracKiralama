namespace aracKiralama
{
    partial class FrmAramaYapma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAramaYapma));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBirebirAra = new System.Windows.Forms.Button();
            this.chbCoklu1 = new System.Windows.Forms.CheckBox();
            this.txtCoklu2 = new System.Windows.Forms.TextBox();
            this.cmbCokluBaslik = new System.Windows.Forms.ComboBox();
            this.txtCoklu1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chbCoklu2 = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtYaziniz = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbAramaTuru = new System.Windows.Forms.ComboBox();
            this.cmbAlan = new System.Windows.Forms.ComboBox();
            this.cmbBaslik = new System.Windows.Forms.ComboBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 365);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(926, 252);
            this.dataGridView1.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(904, 307);
            this.tabControl1.TabIndex = 6;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(896, 265);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Birebir Arama";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBirebirAra);
            this.groupBox1.Controls.Add(this.chbCoklu1);
            this.groupBox1.Controls.Add(this.txtCoklu2);
            this.groupBox1.Controls.Add(this.cmbCokluBaslik);
            this.groupBox1.Controls.Add(this.txtCoklu1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.chbCoklu2);
            this.groupBox1.Location = new System.Drawing.Point(256, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 236);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Birebir Arama";
            // 
            // btnBirebirAra
            // 
            this.btnBirebirAra.Location = new System.Drawing.Point(211, 182);
            this.btnBirebirAra.Name = "btnBirebirAra";
            this.btnBirebirAra.Size = new System.Drawing.Size(191, 36);
            this.btnBirebirAra.TabIndex = 6;
            this.btnBirebirAra.Text = "Ara";
            this.btnBirebirAra.UseVisualStyleBackColor = true;
            this.btnBirebirAra.Visible = false;
            this.btnBirebirAra.Click += new System.EventHandler(this.btnBirebirAra_Click);
            // 
            // chbCoklu1
            // 
            this.chbCoklu1.AutoSize = true;
            this.chbCoklu1.Location = new System.Drawing.Point(35, 92);
            this.chbCoklu1.Name = "chbCoklu1";
            this.chbCoklu1.Size = new System.Drawing.Size(159, 33);
            this.chbCoklu1.TabIndex = 4;
            this.chbCoklu1.Text = "checkBox1";
            this.chbCoklu1.UseVisualStyleBackColor = true;
            this.chbCoklu1.Visible = false;
            this.chbCoklu1.CheckedChanged += new System.EventHandler(this.chbCoklu1_CheckedChanged);
            // 
            // txtCoklu2
            // 
            this.txtCoklu2.Enabled = false;
            this.txtCoklu2.Location = new System.Drawing.Point(211, 131);
            this.txtCoklu2.Name = "txtCoklu2";
            this.txtCoklu2.Size = new System.Drawing.Size(191, 36);
            this.txtCoklu2.TabIndex = 5;
            this.txtCoklu2.Visible = false;
            // 
            // cmbCokluBaslik
            // 
            this.cmbCokluBaslik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCokluBaslik.FormattingEnabled = true;
            this.cmbCokluBaslik.Items.AddRange(new object[] {
            "Seçiniz",
            "Kullanıcı",
            "Müşteri",
            "Kiralama",
            "Personel",
            "Tüm Araç",
            "Kiralık Araç",
            "Kiralanan Araç",
            "Sözleşme"});
            this.cmbCokluBaslik.Location = new System.Drawing.Point(211, 48);
            this.cmbCokluBaslik.Name = "cmbCokluBaslik";
            this.cmbCokluBaslik.Size = new System.Drawing.Size(191, 37);
            this.cmbCokluBaslik.TabIndex = 3;
            this.cmbCokluBaslik.SelectedIndexChanged += new System.EventHandler(this.cmbCokluBaslik_SelectedIndexChanged);
            // 
            // txtCoklu1
            // 
            this.txtCoklu1.Enabled = false;
            this.txtCoklu1.Location = new System.Drawing.Point(211, 90);
            this.txtCoklu1.Name = "txtCoklu1";
            this.txtCoklu1.Size = new System.Drawing.Size(191, 36);
            this.txtCoklu1.TabIndex = 5;
            this.txtCoklu1.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tablo Adı";
            // 
            // chbCoklu2
            // 
            this.chbCoklu2.AutoSize = true;
            this.chbCoklu2.Location = new System.Drawing.Point(34, 133);
            this.chbCoklu2.Name = "chbCoklu2";
            this.chbCoklu2.Size = new System.Drawing.Size(159, 33);
            this.chbCoklu2.TabIndex = 4;
            this.chbCoklu2.Text = "checkBox1";
            this.chbCoklu2.UseVisualStyleBackColor = true;
            this.chbCoklu2.Visible = false;
            this.chbCoklu2.CheckedChanged += new System.EventHandler(this.chbCoklu2_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(896, 265);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "İçeren Arama";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtYaziniz);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cmbAramaTuru);
            this.groupBox2.Controls.Add(this.cmbAlan);
            this.groupBox2.Controls.Add(this.cmbBaslik);
            this.groupBox2.Location = new System.Drawing.Point(246, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(443, 250);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İçeren Arama";
            // 
            // txtYaziniz
            // 
            this.txtYaziniz.ForeColor = System.Drawing.Color.Black;
            this.txtYaziniz.Location = new System.Drawing.Point(38, 193);
            this.txtYaziniz.Name = "txtYaziniz";
            this.txtYaziniz.Size = new System.Drawing.Size(342, 36);
            this.txtYaziniz.TabIndex = 16;
            this.txtYaziniz.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtYaziniz.Visible = false;
            this.txtYaziniz.TextChanged += new System.EventHandler(this.txtYaziniz_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Alan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Arama Türü";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tablo Adı";
            // 
            // cmbAramaTuru
            // 
            this.cmbAramaTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAramaTuru.FormattingEnabled = true;
            this.cmbAramaTuru.Items.AddRange(new object[] {
            "Seçiniz",
            "İle Başlayan",
            "İle Biten",
            "İçeren"});
            this.cmbAramaTuru.Location = new System.Drawing.Point(214, 137);
            this.cmbAramaTuru.Name = "cmbAramaTuru";
            this.cmbAramaTuru.Size = new System.Drawing.Size(166, 37);
            this.cmbAramaTuru.TabIndex = 15;
            this.cmbAramaTuru.SelectedIndexChanged += new System.EventHandler(this.cmbAramaTuru_SelectedIndexChanged);
            // 
            // cmbAlan
            // 
            this.cmbAlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlan.Enabled = false;
            this.cmbAlan.FormattingEnabled = true;
            this.cmbAlan.Items.AddRange(new object[] {
            "Seçiniz"});
            this.cmbAlan.Location = new System.Drawing.Point(214, 89);
            this.cmbAlan.Name = "cmbAlan";
            this.cmbAlan.Size = new System.Drawing.Size(166, 37);
            this.cmbAlan.TabIndex = 14;
            this.cmbAlan.SelectedIndexChanged += new System.EventHandler(this.cmbAlan_SelectedIndexChanged);
            // 
            // cmbBaslik
            // 
            this.cmbBaslik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBaslik.FormattingEnabled = true;
            this.cmbBaslik.Items.AddRange(new object[] {
            "Seçiniz",
            "Kullanıcı",
            "Müşteri",
            "Kiralama",
            "Personel",
            "Tüm Araç",
            "Kiralık Araç",
            "Kiralanan Araç",
            "Sözleşme"});
            this.cmbBaslik.Location = new System.Drawing.Point(214, 43);
            this.cmbBaslik.Name = "cmbBaslik";
            this.cmbBaslik.Size = new System.Drawing.Size(166, 37);
            this.cmbBaslik.TabIndex = 13;
            this.cmbBaslik.SelectedIndexChanged += new System.EventHandler(this.cmbBaslik_SelectedIndexChanged);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(263, 325);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(191, 34);
            this.btnGuncelle.TabIndex = 7;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Visible = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(471, 325);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(191, 34);
            this.btnSil.TabIndex = 8;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Visible = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // FrmAramaYapma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(926, 617);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAramaYapma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Arama Yapma";
            this.Load += new System.EventHandler(this.FrmAramaYapma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtCoklu2;
        private System.Windows.Forms.TextBox txtCoklu1;
        private System.Windows.Forms.CheckBox chbCoklu1;
        private System.Windows.Forms.CheckBox chbCoklu2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCokluBaslik;
        private System.Windows.Forms.Button btnBirebirAra;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtYaziniz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbAramaTuru;
        private System.Windows.Forms.ComboBox cmbAlan;
        private System.Windows.Forms.ComboBox cmbBaslik;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
    }
}
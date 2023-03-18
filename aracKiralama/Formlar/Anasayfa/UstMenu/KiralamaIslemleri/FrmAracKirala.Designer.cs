namespace aracKiralama
{
    partial class FrmAracKirala
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAracKirala));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbTc = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtMeslek = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txtMusteriID = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.lblYildizTc = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbPlaka = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAracTuru = new System.Windows.Forms.TextBox();
            this.txtKasaTipi = new System.Windows.Forms.TextBox();
            this.lblYildizPlaka = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtAracID = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.mtxtToplamTutar = new System.Windows.Forms.MaskedTextBox();
            this.mtxtEkTutar = new System.Windows.Forms.MaskedTextBox();
            this.mtxtTutar = new System.Windows.Forms.MaskedTextBox();
            this.rbtnNakit = new System.Windows.Forms.RadioButton();
            this.rbtnKredi = new System.Windows.Forms.RadioButton();
            this.btnKirala = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dtpTeslim = new System.Windows.Forms.DateTimePicker();
            this.dtpVerilis = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbTc);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtTel);
            this.groupBox1.Controls.Add(this.txtMeslek);
            this.groupBox1.Controls.Add(this.txtSoyad);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.txtMusteriID);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.lblYildizTc);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(43, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 409);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Bilgisi";
            // 
            // cmbTc
            // 
            this.cmbTc.DropDownHeight = 150;
            this.cmbTc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTc.FormattingEnabled = true;
            this.cmbTc.IntegralHeight = false;
            this.cmbTc.Items.AddRange(new object[] {
            "Seçiniz"});
            this.cmbTc.Location = new System.Drawing.Point(142, 58);
            this.cmbTc.Name = "cmbTc";
            this.cmbTc.Size = new System.Drawing.Size(194, 37);
            this.cmbTc.TabIndex = 1;
            this.cmbTc.SelectedIndexChanged += new System.EventHandler(this.cmbTc_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 29);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tc";
            // 
            // txtTel
            // 
            this.txtTel.Enabled = false;
            this.txtTel.Location = new System.Drawing.Point(142, 324);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(194, 36);
            this.txtTel.TabIndex = 2;
            this.txtTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMeslek
            // 
            this.txtMeslek.Enabled = false;
            this.txtMeslek.Location = new System.Drawing.Point(142, 271);
            this.txtMeslek.Name = "txtMeslek";
            this.txtMeslek.Size = new System.Drawing.Size(194, 36);
            this.txtMeslek.TabIndex = 2;
            this.txtMeslek.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Enabled = false;
            this.txtSoyad.Location = new System.Drawing.Point(142, 220);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(194, 36);
            this.txtSoyad.TabIndex = 2;
            this.txtSoyad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(19, 278);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(94, 29);
            this.label18.TabIndex = 0;
            this.label18.Text = "Meslek";
            // 
            // txtAd
            // 
            this.txtAd.Enabled = false;
            this.txtAd.Location = new System.Drawing.Point(142, 164);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(194, 36);
            this.txtAd.TabIndex = 2;
            this.txtAd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(19, 227);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(85, 29);
            this.label17.TabIndex = 0;
            this.label17.Text = "Soyad";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(19, 331);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(97, 29);
            this.label24.TabIndex = 0;
            this.label24.Text = "Telefon";
            // 
            // txtMusteriID
            // 
            this.txtMusteriID.Enabled = false;
            this.txtMusteriID.Location = new System.Drawing.Point(142, 112);
            this.txtMusteriID.Name = "txtMusteriID";
            this.txtMusteriID.Size = new System.Drawing.Size(194, 36);
            this.txtMusteriID.TabIndex = 2;
            this.txtMusteriID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(19, 171);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 29);
            this.label16.TabIndex = 0;
            this.label16.Text = "Ad";
            // 
            // lblYildizTc
            // 
            this.lblYildizTc.AutoSize = true;
            this.lblYildizTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYildizTc.ForeColor = System.Drawing.Color.Red;
            this.lblYildizTc.Location = new System.Drawing.Point(344, 66);
            this.lblYildizTc.Name = "lblYildizTc";
            this.lblYildizTc.Size = new System.Drawing.Size(30, 39);
            this.lblYildizTc.TabIndex = 0;
            this.lblYildizTc.Text = "*";
            this.lblYildizTc.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 29);
            this.label9.TabIndex = 0;
            this.label9.Text = "İD";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbPlaka);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtAracTuru);
            this.groupBox2.Controls.Add(this.txtKasaTipi);
            this.groupBox2.Controls.Add(this.lblYildizPlaka);
            this.groupBox2.Controls.Add(this.txtModel);
            this.groupBox2.Controls.Add(this.txtMarka);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.txtAracID);
            this.groupBox2.Location = new System.Drawing.Point(456, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(388, 409);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Araç Bilgisi";
            // 
            // cmbPlaka
            // 
            this.cmbPlaka.DropDownHeight = 150;
            this.cmbPlaka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlaka.FormattingEnabled = true;
            this.cmbPlaka.IntegralHeight = false;
            this.cmbPlaka.Items.AddRange(new object[] {
            "Seçiniz"});
            this.cmbPlaka.Location = new System.Drawing.Point(153, 58);
            this.cmbPlaka.Name = "cmbPlaka";
            this.cmbPlaka.Size = new System.Drawing.Size(191, 37);
            this.cmbPlaka.TabIndex = 2;
            this.cmbPlaka.SelectedIndexChanged += new System.EventHandler(this.cmbPlaka_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 29);
            this.label6.TabIndex = 0;
            this.label6.Text = "Plaka";
            // 
            // txtAracTuru
            // 
            this.txtAracTuru.Enabled = false;
            this.txtAracTuru.Location = new System.Drawing.Point(153, 320);
            this.txtAracTuru.Name = "txtAracTuru";
            this.txtAracTuru.Size = new System.Drawing.Size(194, 36);
            this.txtAracTuru.TabIndex = 2;
            this.txtAracTuru.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtKasaTipi
            // 
            this.txtKasaTipi.Enabled = false;
            this.txtKasaTipi.Location = new System.Drawing.Point(153, 271);
            this.txtKasaTipi.Name = "txtKasaTipi";
            this.txtKasaTipi.Size = new System.Drawing.Size(194, 36);
            this.txtKasaTipi.TabIndex = 2;
            this.txtKasaTipi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblYildizPlaka
            // 
            this.lblYildizPlaka.AutoSize = true;
            this.lblYildizPlaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYildizPlaka.ForeColor = System.Drawing.Color.Red;
            this.lblYildizPlaka.Location = new System.Drawing.Point(351, 63);
            this.lblYildizPlaka.Name = "lblYildizPlaka";
            this.lblYildizPlaka.Size = new System.Drawing.Size(30, 39);
            this.lblYildizPlaka.TabIndex = 0;
            this.lblYildizPlaka.Text = "*";
            this.lblYildizPlaka.Visible = false;
            // 
            // txtModel
            // 
            this.txtModel.Enabled = false;
            this.txtModel.Location = new System.Drawing.Point(153, 220);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(194, 36);
            this.txtModel.TabIndex = 2;
            this.txtModel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMarka
            // 
            this.txtMarka.Enabled = false;
            this.txtMarka.Location = new System.Drawing.Point(153, 164);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(194, 36);
            this.txtMarka.TabIndex = 2;
            this.txtMarka.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(30, 327);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(123, 29);
            this.label23.TabIndex = 0;
            this.label23.Text = "Araç Türü";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(30, 278);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(119, 29);
            this.label22.TabIndex = 0;
            this.label22.Text = "Kasa Tipi";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(30, 119);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(37, 29);
            this.label19.TabIndex = 0;
            this.label19.Text = "İD";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(30, 171);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(83, 29);
            this.label20.TabIndex = 0;
            this.label20.Text = "Marka";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(30, 227);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(82, 29);
            this.label21.TabIndex = 0;
            this.label21.Text = "Model";
            // 
            // txtAracID
            // 
            this.txtAracID.Enabled = false;
            this.txtAracID.Location = new System.Drawing.Point(153, 112);
            this.txtAracID.Name = "txtAracID";
            this.txtAracID.Size = new System.Drawing.Size(194, 36);
            this.txtAracID.TabIndex = 2;
            this.txtAracID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.mtxtToplamTutar);
            this.groupBox3.Controls.Add(this.mtxtEkTutar);
            this.groupBox3.Controls.Add(this.mtxtTutar);
            this.groupBox3.Controls.Add(this.rbtnNakit);
            this.groupBox3.Controls.Add(this.rbtnKredi);
            this.groupBox3.Controls.Add(this.btnKirala);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.dtpTeslim);
            this.groupBox3.Controls.Add(this.dtpVerilis);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(874, 48);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(447, 409);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kiralama";
            // 
            // mtxtToplamTutar
            // 
            this.mtxtToplamTutar.BackColor = System.Drawing.Color.LightGray;
            this.mtxtToplamTutar.Enabled = false;
            this.mtxtToplamTutar.Location = new System.Drawing.Point(230, 230);
            this.mtxtToplamTutar.Mask = "0000";
            this.mtxtToplamTutar.Name = "mtxtToplamTutar";
            this.mtxtToplamTutar.Size = new System.Drawing.Size(200, 36);
            this.mtxtToplamTutar.TabIndex = 1;
            this.mtxtToplamTutar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mtxtEkTutar
            // 
            this.mtxtEkTutar.BackColor = System.Drawing.Color.White;
            this.mtxtEkTutar.Location = new System.Drawing.Point(230, 189);
            this.mtxtEkTutar.Mask = "0000";
            this.mtxtEkTutar.Name = "mtxtEkTutar";
            this.mtxtEkTutar.Size = new System.Drawing.Size(200, 36);
            this.mtxtEkTutar.TabIndex = 5;
            this.mtxtEkTutar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxtEkTutar.TextChanged += new System.EventHandler(this.mtxtEkTutar_TextChanged);
            // 
            // mtxtTutar
            // 
            this.mtxtTutar.BackColor = System.Drawing.Color.LightGray;
            this.mtxtTutar.Enabled = false;
            this.mtxtTutar.Location = new System.Drawing.Point(230, 147);
            this.mtxtTutar.Mask = "0000";
            this.mtxtTutar.Name = "mtxtTutar";
            this.mtxtTutar.Size = new System.Drawing.Size(200, 36);
            this.mtxtTutar.TabIndex = 1;
            this.mtxtTutar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxtTutar.TextChanged += new System.EventHandler(this.mtxtEkTutar_TextChanged);
            // 
            // rbtnNakit
            // 
            this.rbtnNakit.AutoSize = true;
            this.rbtnNakit.Location = new System.Drawing.Point(234, 272);
            this.rbtnNakit.Name = "rbtnNakit";
            this.rbtnNakit.Size = new System.Drawing.Size(92, 33);
            this.rbtnNakit.TabIndex = 6;
            this.rbtnNakit.Text = "Nakit";
            this.rbtnNakit.UseVisualStyleBackColor = true;
            // 
            // rbtnKredi
            // 
            this.rbtnKredi.AutoSize = true;
            this.rbtnKredi.Location = new System.Drawing.Point(310, 272);
            this.rbtnKredi.Name = "rbtnKredi";
            this.rbtnKredi.Size = new System.Drawing.Size(152, 33);
            this.rbtnKredi.TabIndex = 7;
            this.rbtnKredi.Text = "Kredi Kartı";
            this.rbtnKredi.UseVisualStyleBackColor = true;
            // 
            // btnKirala
            // 
            this.btnKirala.Location = new System.Drawing.Point(60, 322);
            this.btnKirala.Name = "btnKirala";
            this.btnKirala.Size = new System.Drawing.Size(319, 38);
            this.btnKirala.TabIndex = 0;
            this.btnKirala.Text = "Kirala";
            this.btnKirala.UseVisualStyleBackColor = true;
            this.btnKirala.Click += new System.EventHandler(this.btnKirala_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(192, 271);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(20, 29);
            this.label15.TabIndex = 0;
            this.label15.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 29);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ödeme Şekli";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(192, 191);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(20, 29);
            this.label14.TabIndex = 0;
            this.label14.Text = ":";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(192, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 29);
            this.label10.TabIndex = 0;
            this.label10.Text = ":";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(192, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 29);
            this.label11.TabIndex = 0;
            this.label11.Text = ":";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(192, 151);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 29);
            this.label12.TabIndex = 0;
            this.label12.Text = ":";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(192, 231);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 29);
            this.label13.TabIndex = 0;
            this.label13.Text = ":";
            // 
            // dtpTeslim
            // 
            this.dtpTeslim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTeslim.Location = new System.Drawing.Point(230, 105);
            this.dtpTeslim.Name = "dtpTeslim";
            this.dtpTeslim.Size = new System.Drawing.Size(200, 36);
            this.dtpTeslim.TabIndex = 4;
            this.dtpTeslim.ValueChanged += new System.EventHandler(this.dtpTeslim_ValueChanged);
            // 
            // dtpVerilis
            // 
            this.dtpVerilis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVerilis.Location = new System.Drawing.Point(230, 64);
            this.dtpVerilis.Name = "dtpVerilis";
            this.dtpVerilis.Size = new System.Drawing.Size(200, 36);
            this.dtpVerilis.TabIndex = 3;
            this.dtpVerilis.ValueChanged += new System.EventHandler(this.dtpVerilis_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ek Tutar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Toplam Tutar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tutar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Teslim Tarihi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Veriliş Tarihi ";
            // 
            // FrmAracKirala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 517);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAracKirala";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Araç Kirala";
            this.Load += new System.EventHandler(this.FrmAracKirala_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKirala;
        private System.Windows.Forms.DateTimePicker dtpTeslim;
        private System.Windows.Forms.DateTimePicker dtpVerilis;
        private System.Windows.Forms.ComboBox cmbTc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbPlaka;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMusteriID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton rbtnNakit;
        private System.Windows.Forms.RadioButton rbtnKredi;
        private System.Windows.Forms.MaskedTextBox mtxtToplamTutar;
        private System.Windows.Forms.MaskedTextBox mtxtEkTutar;
        private System.Windows.Forms.MaskedTextBox mtxtTutar;
        private System.Windows.Forms.Label lblYildizTc;
        private System.Windows.Forms.Label lblYildizPlaka;
        private System.Windows.Forms.TextBox txtMeslek;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtKasaTipi;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtAracID;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtAracTuru;
        private System.Windows.Forms.Label label23;
    }
}
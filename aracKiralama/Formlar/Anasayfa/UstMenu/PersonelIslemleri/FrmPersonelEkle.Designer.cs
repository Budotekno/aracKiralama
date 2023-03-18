namespace aracKiralama
{
    partial class FrmPersonelEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonelEkle));
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.cmbDogumYeri = new System.Windows.Forms.ComboBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtKullaniciAd = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.MaskedTextBox();
            this.txtMaas = new System.Windows.Forms.MaskedTextBox();
            this.txtTcNo = new System.Windows.Forms.MaskedTextBox();
            this.lblYildizSifre = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblYildizKullaniciAd = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.lblYildizAdres = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblYildizTel = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lblYildizMedeniDurumu = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lblYildizMaas = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lblYildizDogumYeri = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblYildizSoyad = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblYildizCinsiyet = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblYildizAd = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblYildizTcNo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKayitEkle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbKullaniciTuru = new System.Windows.Forms.ComboBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.lblYildizKullaniciTuru = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbGorev = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radBekar = new System.Windows.Forms.RadioButton();
            this.radEvli = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radK = new System.Windows.Forms.RadioButton();
            this.radE = new System.Windows.Forms.RadioButton();
            this.label28 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblYildizGorev = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ptbPersonel = new System.Windows.Forms.PictureBox();
            this.btnResimSec = new System.Windows.Forms.Button();
            this.lblYildizFoto = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPersonel)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "T.C No";
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDogumTarihi.Location = new System.Drawing.Point(302, 275);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(205, 36);
            this.dtpDogumTarihi.TabIndex = 8;
            // 
            // cmbDogumYeri
            // 
            this.cmbDogumYeri.DropDownHeight = 150;
            this.cmbDogumYeri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDogumYeri.FormattingEnabled = true;
            this.cmbDogumYeri.IntegralHeight = false;
            this.cmbDogumYeri.Items.AddRange(new object[] {
            "Seçiniz",
            "Adana",
            "Adıyaman",
            "Afyonkarahisar",
            "Ağrı",
            "Aksaray",
            "Amasya",
            "Ankara",
            "Antalya",
            "Ardahan",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bartın",
            "Batman",
            "Bayburt",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Düzce",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkâri",
            "Hatay",
            "Iğdır",
            "Isparta",
            "İstanbul",
            "İzmir",
            "Kahramanmaraş",
            "Karabük",
            "Karaman",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kilis",
            "Kırıkkale",
            "Kırklareli",
            "Kırşehir",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "Mardin",
            "Mersin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Osmaniye",
            "Rize",
            "Sakarya",
            "Samsun",
            "Şanlıurfa",
            "Siirt",
            "Sinop",
            "Sivas",
            "Şırnak",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Uşak",
            "Van",
            "Yalova",
            "Yozgat",
            "Zonguldak"});
            this.cmbDogumYeri.Location = new System.Drawing.Point(303, 88);
            this.cmbDogumYeri.Name = "cmbDogumYeri";
            this.cmbDogumYeri.Size = new System.Drawing.Size(205, 37);
            this.cmbDogumYeri.TabIndex = 16;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(302, 87);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(205, 36);
            this.txtSifre.TabIndex = 12;
            this.txtSifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtKullaniciAd
            // 
            this.txtKullaniciAd.Location = new System.Drawing.Point(302, 43);
            this.txtKullaniciAd.Name = "txtKullaniciAd";
            this.txtKullaniciAd.Size = new System.Drawing.Size(205, 36);
            this.txtKullaniciAd.TabIndex = 11;
            this.txtKullaniciAd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(303, 133);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAdres.Size = new System.Drawing.Size(205, 114);
            this.txtAdres.TabIndex = 17;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(302, 137);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(205, 36);
            this.txtSoyad.TabIndex = 3;
            this.txtSoyad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(302, 93);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(205, 36);
            this.txtAd.TabIndex = 2;
            this.txtAd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(303, 40);
            this.txtTel.Mask = "(999) 000 00 00";
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(205, 36);
            this.txtTel.TabIndex = 15;
            this.txtTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMaas
            // 
            this.txtMaas.Location = new System.Drawing.Point(302, 317);
            this.txtMaas.Mask = "00,000";
            this.txtMaas.Name = "txtMaas";
            this.txtMaas.Size = new System.Drawing.Size(205, 36);
            this.txtMaas.TabIndex = 9;
            this.txtMaas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTcNo
            // 
            this.txtTcNo.Location = new System.Drawing.Point(302, 49);
            this.txtTcNo.Mask = "00000000000";
            this.txtTcNo.Name = "txtTcNo";
            this.txtTcNo.Size = new System.Drawing.Size(205, 36);
            this.txtTcNo.TabIndex = 1;
            this.txtTcNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblYildizSifre
            // 
            this.lblYildizSifre.AutoSize = true;
            this.lblYildizSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYildizSifre.ForeColor = System.Drawing.Color.Red;
            this.lblYildizSifre.Location = new System.Drawing.Point(521, 99);
            this.lblYildizSifre.Name = "lblYildizSifre";
            this.lblYildizSifre.Size = new System.Drawing.Size(30, 39);
            this.lblYildizSifre.TabIndex = 0;
            this.lblYildizSifre.Text = "*";
            this.lblYildizSifre.Visible = false;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(262, 88);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(20, 29);
            this.label26.TabIndex = 0;
            this.label26.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 29);
            this.label6.TabIndex = 0;
            this.label6.Text = "Medeni Durumu";
            // 
            // lblYildizKullaniciAd
            // 
            this.lblYildizKullaniciAd.AutoSize = true;
            this.lblYildizKullaniciAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYildizKullaniciAd.ForeColor = System.Drawing.Color.Red;
            this.lblYildizKullaniciAd.Location = new System.Drawing.Point(521, 51);
            this.lblYildizKullaniciAd.Name = "lblYildizKullaniciAd";
            this.lblYildizKullaniciAd.Size = new System.Drawing.Size(30, 39);
            this.lblYildizKullaniciAd.TabIndex = 0;
            this.lblYildizKullaniciAd.Text = "*";
            this.lblYildizKullaniciAd.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(46, 95);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 29);
            this.label13.TabIndex = 0;
            this.label13.Text = "Şifre";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(262, 44);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(20, 29);
            this.label25.TabIndex = 0;
            this.label25.Text = ":";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(46, 50);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(153, 29);
            this.label12.TabIndex = 0;
            this.label12.Text = "Kullanıcı Adı";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(262, 277);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(20, 29);
            this.label24.TabIndex = 0;
            this.label24.Text = ":";
            // 
            // lblYildizAdres
            // 
            this.lblYildizAdres.AutoSize = true;
            this.lblYildizAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYildizAdres.ForeColor = System.Drawing.Color.Red;
            this.lblYildizAdres.Location = new System.Drawing.Point(522, 137);
            this.lblYildizAdres.Name = "lblYildizAdres";
            this.lblYildizAdres.Size = new System.Drawing.Size(30, 39);
            this.lblYildizAdres.TabIndex = 0;
            this.lblYildizAdres.Text = "*";
            this.lblYildizAdres.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(46, 280);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 29);
            this.label9.TabIndex = 0;
            this.label9.Text = "Doğum Tarihi";
            // 
            // lblYildizTel
            // 
            this.lblYildizTel.AutoSize = true;
            this.lblYildizTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYildizTel.ForeColor = System.Drawing.Color.Red;
            this.lblYildizTel.Location = new System.Drawing.Point(522, 40);
            this.lblYildizTel.Name = "lblYildizTel";
            this.lblYildizTel.Size = new System.Drawing.Size(30, 39);
            this.lblYildizTel.TabIndex = 0;
            this.lblYildizTel.Text = "*";
            this.lblYildizTel.Visible = false;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(263, 134);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(20, 29);
            this.label23.TabIndex = 0;
            this.label23.Text = ":";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(263, 42);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(20, 29);
            this.label22.TabIndex = 0;
            this.label22.Text = ":";
            // 
            // lblYildizMedeniDurumu
            // 
            this.lblYildizMedeniDurumu.AutoSize = true;
            this.lblYildizMedeniDurumu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYildizMedeniDurumu.ForeColor = System.Drawing.Color.Red;
            this.lblYildizMedeniDurumu.Location = new System.Drawing.Point(521, 230);
            this.lblYildizMedeniDurumu.Name = "lblYildizMedeniDurumu";
            this.lblYildizMedeniDurumu.Size = new System.Drawing.Size(30, 39);
            this.lblYildizMedeniDurumu.TabIndex = 0;
            this.lblYildizMedeniDurumu.Text = "*";
            this.lblYildizMedeniDurumu.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(47, 139);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 29);
            this.label11.TabIndex = 0;
            this.label11.Text = "Adres";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(262, 231);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(20, 29);
            this.label21.TabIndex = 0;
            this.label21.Text = ":";
            // 
            // lblYildizMaas
            // 
            this.lblYildizMaas.AutoSize = true;
            this.lblYildizMaas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYildizMaas.ForeColor = System.Drawing.Color.Red;
            this.lblYildizMaas.Location = new System.Drawing.Point(521, 321);
            this.lblYildizMaas.Name = "lblYildizMaas";
            this.lblYildizMaas.Size = new System.Drawing.Size(30, 39);
            this.lblYildizMaas.TabIndex = 0;
            this.lblYildizMaas.Text = "*";
            this.lblYildizMaas.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 29);
            this.label8.TabIndex = 0;
            this.label8.Text = "Telefon";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(262, 320);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(20, 29);
            this.label20.TabIndex = 0;
            this.label20.Text = ":";
            // 
            // lblYildizDogumYeri
            // 
            this.lblYildizDogumYeri.AutoSize = true;
            this.lblYildizDogumYeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYildizDogumYeri.ForeColor = System.Drawing.Color.Red;
            this.lblYildizDogumYeri.Location = new System.Drawing.Point(522, 89);
            this.lblYildizDogumYeri.Name = "lblYildizDogumYeri";
            this.lblYildizDogumYeri.Size = new System.Drawing.Size(30, 39);
            this.lblYildizDogumYeri.TabIndex = 0;
            this.lblYildizDogumYeri.Text = "*";
            this.lblYildizDogumYeri.Visible = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(263, 90);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(20, 29);
            this.label19.TabIndex = 0;
            this.label19.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "Maaş";
            // 
            // lblYildizSoyad
            // 
            this.lblYildizSoyad.AutoSize = true;
            this.lblYildizSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYildizSoyad.ForeColor = System.Drawing.Color.Red;
            this.lblYildizSoyad.Location = new System.Drawing.Point(521, 138);
            this.lblYildizSoyad.Name = "lblYildizSoyad";
            this.lblYildizSoyad.Size = new System.Drawing.Size(30, 39);
            this.lblYildizSoyad.TabIndex = 0;
            this.lblYildizSoyad.Text = "*";
            this.lblYildizSoyad.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(47, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 29);
            this.label10.TabIndex = 0;
            this.label10.Text = "Doğum Yeri";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(262, 141);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(20, 29);
            this.label17.TabIndex = 0;
            this.label17.Text = ":";
            // 
            // lblYildizCinsiyet
            // 
            this.lblYildizCinsiyet.AutoSize = true;
            this.lblYildizCinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYildizCinsiyet.ForeColor = System.Drawing.Color.Red;
            this.lblYildizCinsiyet.Location = new System.Drawing.Point(521, 183);
            this.lblYildizCinsiyet.Name = "lblYildizCinsiyet";
            this.lblYildizCinsiyet.Size = new System.Drawing.Size(30, 39);
            this.lblYildizCinsiyet.TabIndex = 0;
            this.lblYildizCinsiyet.Text = "*";
            this.lblYildizCinsiyet.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(262, 185);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(20, 29);
            this.label16.TabIndex = 0;
            this.label16.Text = ":";
            // 
            // lblYildizAd
            // 
            this.lblYildizAd.AutoSize = true;
            this.lblYildizAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYildizAd.ForeColor = System.Drawing.Color.Red;
            this.lblYildizAd.Location = new System.Drawing.Point(521, 97);
            this.lblYildizAd.Name = "lblYildizAd";
            this.lblYildizAd.Size = new System.Drawing.Size(30, 39);
            this.lblYildizAd.TabIndex = 0;
            this.lblYildizAd.Text = "*";
            this.lblYildizAd.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Soyad";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(262, 97);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(20, 29);
            this.label15.TabIndex = 0;
            this.label15.Text = ":";
            // 
            // lblYildizTcNo
            // 
            this.lblYildizTcNo.AutoSize = true;
            this.lblYildizTcNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYildizTcNo.ForeColor = System.Drawing.Color.Red;
            this.lblYildizTcNo.Location = new System.Drawing.Point(521, 49);
            this.lblYildizTcNo.Name = "lblYildizTcNo";
            this.lblYildizTcNo.Size = new System.Drawing.Size(30, 39);
            this.lblYildizTcNo.TabIndex = 0;
            this.lblYildizTcNo.Text = "*";
            this.lblYildizTcNo.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cinsiyet";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(262, 53);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(20, 29);
            this.label14.TabIndex = 0;
            this.label14.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ad";
            // 
            // btnKayitEkle
            // 
            this.btnKayitEkle.Location = new System.Drawing.Point(761, 699);
            this.btnKayitEkle.Name = "btnKayitEkle";
            this.btnKayitEkle.Size = new System.Drawing.Size(360, 36);
            this.btnKayitEkle.TabIndex = 0;
            this.btnKayitEkle.Text = "Kayıt Ekle";
            this.btnKayitEkle.UseVisualStyleBackColor = true;
            this.btnKayitEkle.Click += new System.EventHandler(this.btnKayitEkle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbKullaniciTuru);
            this.groupBox1.Controls.Add(this.label32);
            this.groupBox1.Controls.Add(this.label31);
            this.groupBox1.Controls.Add(this.lblYildizKullaniciTuru);
            this.groupBox1.Controls.Add(this.txtSifre);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.lblYildizKullaniciAd);
            this.groupBox1.Controls.Add(this.txtKullaniciAd);
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Controls.Add(this.lblYildizSifre);
            this.groupBox1.Location = new System.Drawing.Point(28, 487);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(623, 201);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı Bilgileri";
            // 
            // cmbKullaniciTuru
            // 
            this.cmbKullaniciTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKullaniciTuru.FormattingEnabled = true;
            this.cmbKullaniciTuru.Items.AddRange(new object[] {
            "Seçiniz",
            "Yönetici",
            "Kullanıcı"});
            this.cmbKullaniciTuru.Location = new System.Drawing.Point(302, 132);
            this.cmbKullaniciTuru.Name = "cmbKullaniciTuru";
            this.cmbKullaniciTuru.Size = new System.Drawing.Size(205, 37);
            this.cmbKullaniciTuru.TabIndex = 13;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(46, 135);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(167, 29);
            this.label32.TabIndex = 22;
            this.label32.Text = "Kullanıcı Türü";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(262, 135);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(20, 29);
            this.label31.TabIndex = 23;
            this.label31.Text = ":";
            // 
            // lblYildizKullaniciTuru
            // 
            this.lblYildizKullaniciTuru.AutoSize = true;
            this.lblYildizKullaniciTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYildizKullaniciTuru.ForeColor = System.Drawing.Color.Red;
            this.lblYildizKullaniciTuru.Location = new System.Drawing.Point(521, 137);
            this.lblYildizKullaniciTuru.Name = "lblYildizKullaniciTuru";
            this.lblYildizKullaniciTuru.Size = new System.Drawing.Size(30, 39);
            this.lblYildizKullaniciTuru.TabIndex = 24;
            this.lblYildizKullaniciTuru.Text = "*";
            this.lblYildizKullaniciTuru.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbDogumYeri);
            this.groupBox2.Controls.Add(this.txtAdres);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtTel);
            this.groupBox2.Controls.Add(this.lblYildizAdres);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.lblYildizDogumYeri);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.lblYildizTel);
            this.groupBox2.Location = new System.Drawing.Point(657, 373);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(586, 315);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İletişim Bilgileri";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbGorev);
            this.groupBox3.Controls.Add(this.panel2);
            this.groupBox3.Controls.Add(this.dtpDogumTarihi);
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Controls.Add(this.label28);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.txtSoyad);
            this.groupBox3.Controls.Add(this.lblYildizGorev);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtAd);
            this.groupBox3.Controls.Add(this.lblYildizTcNo);
            this.groupBox3.Controls.Add(this.txtMaas);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.txtTcNo);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.lblYildizAd);
            this.groupBox3.Controls.Add(this.lblYildizMedeniDurumu);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.lblYildizCinsiyet);
            this.groupBox3.Controls.Add(this.lblYildizMaas);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.lblYildizSoyad);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(28, 69);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(623, 412);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kişisel Bilgiler";
            // 
            // cmbGorev
            // 
            this.cmbGorev.DropDownHeight = 150;
            this.cmbGorev.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGorev.FormattingEnabled = true;
            this.cmbGorev.IntegralHeight = false;
            this.cmbGorev.Items.AddRange(new object[] {
            "Seçiniz",
            "Temizlikçi",
            "Yıkamacı",
            "Muhasebeci",
            "Çaycı"});
            this.cmbGorev.Location = new System.Drawing.Point(302, 365);
            this.cmbGorev.Name = "cmbGorev";
            this.cmbGorev.Size = new System.Drawing.Size(205, 37);
            this.cmbGorev.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radBekar);
            this.panel2.Controls.Add(this.radEvli);
            this.panel2.Location = new System.Drawing.Point(327, 226);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(189, 43);
            this.panel2.TabIndex = 14;
            // 
            // radBekar
            // 
            this.radBekar.AutoSize = true;
            this.radBekar.Location = new System.Drawing.Point(85, 3);
            this.radBekar.Name = "radBekar";
            this.radBekar.Size = new System.Drawing.Size(100, 33);
            this.radBekar.TabIndex = 7;
            this.radBekar.TabStop = true;
            this.radBekar.Text = "Bekar";
            this.radBekar.UseVisualStyleBackColor = true;
            // 
            // radEvli
            // 
            this.radEvli.AutoSize = true;
            this.radEvli.Location = new System.Drawing.Point(3, 3);
            this.radEvli.Name = "radEvli";
            this.radEvli.Size = new System.Drawing.Size(76, 33);
            this.radEvli.TabIndex = 6;
            this.radEvli.TabStop = true;
            this.radEvli.Text = "Evli";
            this.radEvli.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radK);
            this.panel1.Controls.Add(this.radE);
            this.panel1.Location = new System.Drawing.Point(327, 179);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 43);
            this.panel1.TabIndex = 14;
            // 
            // radK
            // 
            this.radK.AutoSize = true;
            this.radK.Location = new System.Drawing.Point(85, 3);
            this.radK.Name = "radK";
            this.radK.Size = new System.Drawing.Size(51, 33);
            this.radK.TabIndex = 5;
            this.radK.TabStop = true;
            this.radK.Text = "K";
            this.radK.UseVisualStyleBackColor = true;
            // 
            // radE
            // 
            this.radE.AutoSize = true;
            this.radE.Location = new System.Drawing.Point(3, 3);
            this.radE.Name = "radE";
            this.radE.Size = new System.Drawing.Size(51, 33);
            this.radE.TabIndex = 4;
            this.radE.TabStop = true;
            this.radE.Text = "E";
            this.radE.UseVisualStyleBackColor = true;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(46, 371);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(87, 29);
            this.label28.TabIndex = 0;
            this.label28.Text = "Görevi";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(262, 367);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(20, 29);
            this.label18.TabIndex = 0;
            this.label18.Text = ":";
            // 
            // lblYildizGorev
            // 
            this.lblYildizGorev.AutoSize = true;
            this.lblYildizGorev.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYildizGorev.ForeColor = System.Drawing.Color.Red;
            this.lblYildizGorev.Location = new System.Drawing.Point(521, 366);
            this.lblYildizGorev.Name = "lblYildizGorev";
            this.lblYildizGorev.Size = new System.Drawing.Size(30, 39);
            this.lblYildizGorev.TabIndex = 0;
            this.lblYildizGorev.Text = "*";
            this.lblYildizGorev.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(501, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(241, 39);
            this.label7.TabIndex = 12;
            this.label7.Text = "Personel Ekle";
            // 
            // ptbPersonel
            // 
            this.ptbPersonel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbPersonel.Location = new System.Drawing.Point(721, 83);
            this.ptbPersonel.Name = "ptbPersonel";
            this.ptbPersonel.Size = new System.Drawing.Size(235, 284);
            this.ptbPersonel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbPersonel.TabIndex = 13;
            this.ptbPersonel.TabStop = false;
            // 
            // btnResimSec
            // 
            this.btnResimSec.Location = new System.Drawing.Point(962, 198);
            this.btnResimSec.Name = "btnResimSec";
            this.btnResimSec.Size = new System.Drawing.Size(159, 41);
            this.btnResimSec.TabIndex = 14;
            this.btnResimSec.Text = "Resim Seç";
            this.btnResimSec.UseVisualStyleBackColor = true;
            this.btnResimSec.Click += new System.EventHandler(this.btnResimSec_Click);
            // 
            // lblYildizFoto
            // 
            this.lblYildizFoto.AutoSize = true;
            this.lblYildizFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYildizFoto.ForeColor = System.Drawing.Color.Red;
            this.lblYildizFoto.Location = new System.Drawing.Point(1129, 204);
            this.lblYildizFoto.Name = "lblYildizFoto";
            this.lblYildizFoto.Size = new System.Drawing.Size(30, 39);
            this.lblYildizFoto.TabIndex = 0;
            this.lblYildizFoto.Text = "*";
            this.lblYildizFoto.Visible = false;
            // 
            // FrmPersonelEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 748);
            this.Controls.Add(this.btnResimSec);
            this.Controls.Add(this.ptbPersonel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnKayitEkle);
            this.Controls.Add(this.lblYildizFoto);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPersonelEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Personel Ekle";
            this.Load += new System.EventHandler(this.FrmPersonelEkle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPersonel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDogumTarihi;
        private System.Windows.Forms.ComboBox cmbDogumYeri;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtKullaniciAd;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.MaskedTextBox txtTel;
        private System.Windows.Forms.MaskedTextBox txtMaas;
        private System.Windows.Forms.MaskedTextBox txtTcNo;
        private System.Windows.Forms.Label lblYildizSifre;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblYildizKullaniciAd;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lblYildizAdres;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblYildizTel;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lblYildizMedeniDurumu;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblYildizMaas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblYildizDogumYeri;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblYildizSoyad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblYildizCinsiyet;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblYildizAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblYildizTcNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKayitEkle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radE;
        private System.Windows.Forms.RadioButton radK;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radBekar;
        private System.Windows.Forms.RadioButton radEvli;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbGorev;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblYildizGorev;
        private System.Windows.Forms.PictureBox ptbPersonel;
        private System.Windows.Forms.Button btnResimSec;
        private System.Windows.Forms.Label lblYildizFoto;
        public System.Windows.Forms.ComboBox cmbKullaniciTuru;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label lblYildizKullaniciTuru;
    }
}
namespace Proje_Sinema
{
    partial class FrmBiletOlustur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBiletOlustur));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnCikis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtBiletNo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtAdSoyad = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TxtTelNo = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbFilmAdi = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbTarih = new System.Windows.Forms.ComboBox();
            this.LblYonetmenAra = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lblSeansBilgisi = new System.Windows.Forms.Label();
            this.panelFilmSaati = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.cbSalonAdi = new System.Windows.Forms.ComboBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.cbBiletTuru = new System.Windows.Forms.ComboBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.TxtSecilenKoltuklar = new System.Windows.Forms.TextBox();
            this.lblGelenKoltuk = new System.Windows.Forms.Label();
            this.BtnOlustur = new System.Windows.Forms.Button();
            this.lblSalon = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.KoltukPaneli = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listeGelenKoltuk = new System.Windows.Forms.ListBox();
            this.listBelirlenenKoltuklar = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(107)))), ((int)(((byte)(131)))));
            this.panel1.Controls.Add(this.BtnCikis);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 42);
            this.panel1.TabIndex = 3;
            // 
            // BtnCikis
            // 
            this.BtnCikis.BackColor = System.Drawing.Color.Red;
            this.BtnCikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCikis.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnCikis.ForeColor = System.Drawing.Color.White;
            this.BtnCikis.Location = new System.Drawing.Point(955, 0);
            this.BtnCikis.Name = "BtnCikis";
            this.BtnCikis.Size = new System.Drawing.Size(45, 42);
            this.BtnCikis.TabIndex = 4;
            this.BtnCikis.Text = "X";
            this.BtnCikis.UseVisualStyleBackColor = false;
            this.BtnCikis.Click += new System.EventHandler(this.BtnCikis_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bilet Oluşturma Ekranı";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtBiletNo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 64);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bilet Numarası";
            // 
            // TxtBiletNo
            // 
            this.TxtBiletNo.BackColor = System.Drawing.Color.White;
            this.TxtBiletNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBiletNo.Enabled = false;
            this.TxtBiletNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtBiletNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(107)))), ((int)(((byte)(131)))));
            this.TxtBiletNo.Location = new System.Drawing.Point(16, 29);
            this.TxtBiletNo.Name = "TxtBiletNo";
            this.TxtBiletNo.Size = new System.Drawing.Size(306, 21);
            this.TxtBiletNo.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtAdSoyad);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(12, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 64);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ad-Soyad";
            // 
            // TxtAdSoyad
            // 
            this.TxtAdSoyad.BackColor = System.Drawing.Color.White;
            this.TxtAdSoyad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAdSoyad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(107)))), ((int)(((byte)(131)))));
            this.TxtAdSoyad.Location = new System.Drawing.Point(16, 29);
            this.TxtAdSoyad.Name = "TxtAdSoyad";
            this.TxtAdSoyad.Size = new System.Drawing.Size(306, 21);
            this.TxtAdSoyad.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TxtTelNo);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(12, 191);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(328, 64);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Telefon Numarası";
            // 
            // TxtTelNo
            // 
            this.TxtTelNo.BackColor = System.Drawing.Color.White;
            this.TxtTelNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtTelNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtTelNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(107)))), ((int)(((byte)(131)))));
            this.TxtTelNo.Location = new System.Drawing.Point(16, 29);
            this.TxtTelNo.Name = "TxtTelNo";
            this.TxtTelNo.Size = new System.Drawing.Size(306, 21);
            this.TxtTelNo.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbFilmAdi);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(12, 261);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(328, 64);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Film Adı";
            // 
            // cbFilmAdi
            // 
            this.cbFilmAdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilmAdi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFilmAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(107)))), ((int)(((byte)(131)))));
            this.cbFilmAdi.FormattingEnabled = true;
            this.cbFilmAdi.Location = new System.Drawing.Point(16, 28);
            this.cbFilmAdi.Name = "cbFilmAdi";
            this.cbFilmAdi.Size = new System.Drawing.Size(298, 30);
            this.cbFilmAdi.TabIndex = 8;
            this.cbFilmAdi.SelectedIndexChanged += new System.EventHandler(this.cbFilmAdi_SelectedIndexChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbTarih);
            this.groupBox5.Controls.Add(this.LblYonetmenAra);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox5.Location = new System.Drawing.Point(12, 331);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(328, 64);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tarih";
            // 
            // cbTarih
            // 
            this.cbTarih.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTarih.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTarih.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(107)))), ((int)(((byte)(131)))));
            this.cbTarih.FormattingEnabled = true;
            this.cbTarih.Location = new System.Drawing.Point(16, 27);
            this.cbTarih.Name = "cbTarih";
            this.cbTarih.Size = new System.Drawing.Size(298, 30);
            this.cbTarih.TabIndex = 9;
            this.cbTarih.SelectedIndexChanged += new System.EventHandler(this.cbTarih_SelectedIndexChanged);
            // 
            // LblYonetmenAra
            // 
            this.LblYonetmenAra.AutoSize = true;
            this.LblYonetmenAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblYonetmenAra.ForeColor = System.Drawing.Color.Gold;
            this.LblYonetmenAra.Location = new System.Drawing.Point(228, 0);
            this.LblYonetmenAra.Name = "LblYonetmenAra";
            this.LblYonetmenAra.Size = new System.Drawing.Size(86, 18);
            this.LblYonetmenAra.TabIndex = 11;
            this.LblYonetmenAra.Text = "gg/aa/yyyy";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lblSeansBilgisi);
            this.groupBox6.Controls.Add(this.panelFilmSaati);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox6.Location = new System.Drawing.Point(12, 401);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(328, 73);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Film Saati";
            // 
            // lblSeansBilgisi
            // 
            this.lblSeansBilgisi.AutoSize = true;
            this.lblSeansBilgisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSeansBilgisi.ForeColor = System.Drawing.Color.Gold;
            this.lblSeansBilgisi.Location = new System.Drawing.Point(236, -3);
            this.lblSeansBilgisi.Name = "lblSeansBilgisi";
            this.lblSeansBilgisi.Size = new System.Drawing.Size(40, 18);
            this.lblSeansBilgisi.TabIndex = 12;
            this.lblSeansBilgisi.Text = "saat";
            this.lblSeansBilgisi.Visible = false;
            // 
            // panelFilmSaati
            // 
            this.panelFilmSaati.AutoScroll = true;
            this.panelFilmSaati.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFilmSaati.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panelFilmSaati.Location = new System.Drawing.Point(3, 24);
            this.panelFilmSaati.Name = "panelFilmSaati";
            this.panelFilmSaati.Size = new System.Drawing.Size(322, 46);
            this.panelFilmSaati.TabIndex = 11;
            this.panelFilmSaati.WrapContents = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.cbSalonAdi);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox7.Location = new System.Drawing.Point(12, 478);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(328, 64);
            this.groupBox7.TabIndex = 9;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Salon Numarası";
            // 
            // cbSalonAdi
            // 
            this.cbSalonAdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSalonAdi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSalonAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(107)))), ((int)(((byte)(131)))));
            this.cbSalonAdi.FormattingEnabled = true;
            this.cbSalonAdi.Location = new System.Drawing.Point(16, 28);
            this.cbSalonAdi.Name = "cbSalonAdi";
            this.cbSalonAdi.Size = new System.Drawing.Size(298, 30);
            this.cbSalonAdi.TabIndex = 8;
            this.cbSalonAdi.SelectedIndexChanged += new System.EventHandler(this.cbSalonAdi_SelectedIndexChanged);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.cbBiletTuru);
            this.groupBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox8.Location = new System.Drawing.Point(12, 548);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(328, 64);
            this.groupBox8.TabIndex = 9;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Bilet Türü";
            // 
            // cbBiletTuru
            // 
            this.cbBiletTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBiletTuru.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbBiletTuru.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(107)))), ((int)(((byte)(131)))));
            this.cbBiletTuru.FormattingEnabled = true;
            this.cbBiletTuru.Items.AddRange(new object[] {
            "Yetişkin",
            "Öğrenci"});
            this.cbBiletTuru.Location = new System.Drawing.Point(16, 28);
            this.cbBiletTuru.Name = "cbBiletTuru";
            this.cbBiletTuru.Size = new System.Drawing.Size(298, 30);
            this.cbBiletTuru.TabIndex = 8;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.TxtSecilenKoltuklar);
            this.groupBox9.Controls.Add(this.lblGelenKoltuk);
            this.groupBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox9.Location = new System.Drawing.Point(12, 623);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(328, 64);
            this.groupBox9.TabIndex = 5;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Seçilen Koltuk(lar)";
            // 
            // TxtSecilenKoltuklar
            // 
            this.TxtSecilenKoltuklar.BackColor = System.Drawing.Color.White;
            this.TxtSecilenKoltuklar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtSecilenKoltuklar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSecilenKoltuklar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(107)))), ((int)(((byte)(131)))));
            this.TxtSecilenKoltuklar.Location = new System.Drawing.Point(16, 29);
            this.TxtSecilenKoltuklar.Name = "TxtSecilenKoltuklar";
            this.TxtSecilenKoltuklar.Size = new System.Drawing.Size(306, 21);
            this.TxtSecilenKoltuklar.TabIndex = 1;
            // 
            // lblGelenKoltuk
            // 
            this.lblGelenKoltuk.AutoSize = true;
            this.lblGelenKoltuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGelenKoltuk.ForeColor = System.Drawing.Color.Gold;
            this.lblGelenKoltuk.Location = new System.Drawing.Point(260, 0);
            this.lblGelenKoltuk.Name = "lblGelenKoltuk";
            this.lblGelenKoltuk.Size = new System.Drawing.Size(54, 18);
            this.lblGelenKoltuk.TabIndex = 23;
            this.lblGelenKoltuk.Text = "koltuk";
            // 
            // BtnOlustur
            // 
            this.BtnOlustur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(107)))), ((int)(((byte)(131)))));
            this.BtnOlustur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnOlustur.FlatAppearance.BorderSize = 0;
            this.BtnOlustur.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnOlustur.ForeColor = System.Drawing.Color.White;
            this.BtnOlustur.Location = new System.Drawing.Point(12, 695);
            this.BtnOlustur.Name = "BtnOlustur";
            this.BtnOlustur.Size = new System.Drawing.Size(328, 42);
            this.BtnOlustur.TabIndex = 10;
            this.BtnOlustur.Text = "Bilet Oluştur";
            this.BtnOlustur.UseVisualStyleBackColor = false;
            this.BtnOlustur.Click += new System.EventHandler(this.BtnOlustur_Click);
            // 
            // lblSalon
            // 
            this.lblSalon.AutoSize = true;
            this.lblSalon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSalon.ForeColor = System.Drawing.Color.Gold;
            this.lblSalon.Location = new System.Drawing.Point(251, 474);
            this.lblSalon.Name = "lblSalon";
            this.lblSalon.Size = new System.Drawing.Size(49, 18);
            this.lblSalon.TabIndex = 13;
            this.lblSalon.Text = "salon";
            this.lblSalon.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(346, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(642, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // KoltukPaneli
            // 
            this.KoltukPaneli.AutoScroll = true;
            this.KoltukPaneli.Location = new System.Drawing.Point(346, 121);
            this.KoltukPaneli.Name = "KoltukPaneli";
            this.KoltukPaneli.Size = new System.Drawing.Size(642, 520);
            this.KoltukPaneli.TabIndex = 15;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Proje_Sinema.Properties.Resources.sari_koltuk;
            this.pictureBox2.Location = new System.Drawing.Point(453, 652);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(97, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Proje_Sinema.Properties.Resources.mavi_koltuk;
            this.pictureBox3.Location = new System.Drawing.Point(622, 652);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(97, 63);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Proje_Sinema.Properties.Resources.kirmizi_koltuk;
            this.pictureBox4.Location = new System.Drawing.Point(796, 652);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(97, 63);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 18;
            this.pictureBox4.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(439, 718);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 22);
            this.label2.TabIndex = 19;
            this.label2.Text = "Seçilen Koltuk";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(622, 718);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 22);
            this.label3.TabIndex = 20;
            this.label3.Text = "Boş Koltuk";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(792, 718);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 22);
            this.label4.TabIndex = 21;
            this.label4.Text = "Dolu Koltuk";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(600, 69);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(5);
            this.label5.Size = new System.Drawing.Size(125, 32);
            this.label5.TabIndex = 22;
            this.label5.Text = "PERDE";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listeGelenKoltuk
            // 
            this.listeGelenKoltuk.FormattingEnabled = true;
            this.listeGelenKoltuk.ItemHeight = 22;
            this.listeGelenKoltuk.Location = new System.Drawing.Point(384, 542);
            this.listeGelenKoltuk.Name = "listeGelenKoltuk";
            this.listeGelenKoltuk.Size = new System.Drawing.Size(141, 92);
            this.listeGelenKoltuk.TabIndex = 24;
            // 
            // listBelirlenenKoltuklar
            // 
            this.listBelirlenenKoltuklar.FormattingEnabled = true;
            this.listBelirlenenKoltuklar.ItemHeight = 22;
            this.listBelirlenenKoltuklar.Location = new System.Drawing.Point(548, 542);
            this.listBelirlenenKoltuklar.Name = "listBelirlenenKoltuklar";
            this.listBelirlenenKoltuklar.Size = new System.Drawing.Size(141, 92);
            this.listBelirlenenKoltuklar.TabIndex = 25;
            // 
            // FrmBiletOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 750);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.KoltukPaneli);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblSalon);
            this.Controls.Add(this.BtnOlustur);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBelirlenenKoltuklar);
            this.Controls.Add(this.listeGelenKoltuk);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(370, 70);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmBiletOlustur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FrmBiletOluştur";
            this.Load += new System.EventHandler(this.FrmBiletOlustur_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnCikis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtBiletNo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtAdSoyad;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TxtTelNo;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cbFilmAdi;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ComboBox cbSalonAdi;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.ComboBox cbBiletTuru;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox TxtSecilenKoltuklar;
        private System.Windows.Forms.Button BtnOlustur;
        private System.Windows.Forms.Label LblYonetmenAra;
        private System.Windows.Forms.ComboBox cbTarih;
        private System.Windows.Forms.FlowLayoutPanel panelFilmSaati;
        private System.Windows.Forms.Label lblSeansBilgisi;
        private System.Windows.Forms.Label lblSalon;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel KoltukPaneli;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblGelenKoltuk;
        private System.Windows.Forms.ListBox listeGelenKoltuk;
        private System.Windows.Forms.ListBox listBelirlenenKoltuklar;
    }
}
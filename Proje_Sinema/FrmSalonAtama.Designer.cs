namespace Proje_Sinema
{
    partial class FrmSalonAtama
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbFilmAdi = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.LblYonetmenAra = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.panelFilmSaati = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.BtnOlustur = new System.Windows.Forms.Button();
            this.NmrcYil = new System.Windows.Forms.NumericUpDown();
            this.NmrcAy = new System.Windows.Forms.NumericUpDown();
            this.NmrcGun = new System.Windows.Forms.NumericUpDown();
            this.cbSalonAdi = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbDoluSaatler = new System.Windows.Forms.ComboBox();
            this.lblSecilenSaat = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NmrcYil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NmrcAy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NmrcGun)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(107)))), ((int)(((byte)(131)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(706, 51);
            this.panel1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(661, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 51);
            this.button1.TabIndex = 6;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 50);
            this.label1.TabIndex = 5;
            this.label1.Text = "Salon Atama Ekranı";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbFilmAdi);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(12, 67);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(328, 64);
            this.groupBox4.TabIndex = 8;
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
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.NmrcYil);
            this.groupBox5.Controls.Add(this.LblYonetmenAra);
            this.groupBox5.Controls.Add(this.NmrcAy);
            this.groupBox5.Controls.Add(this.NmrcGun);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox5.Location = new System.Drawing.Point(12, 220);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(328, 64);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tarih";
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
            this.groupBox6.Controls.Add(this.panelFilmSaati);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox6.Location = new System.Drawing.Point(355, 67);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(344, 279);
            this.groupBox6.TabIndex = 10;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Film Saati";
            // 
            // panelFilmSaati
            // 
            this.panelFilmSaati.AutoScroll = true;
            this.panelFilmSaati.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFilmSaati.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panelFilmSaati.Location = new System.Drawing.Point(3, 24);
            this.panelFilmSaati.Name = "panelFilmSaati";
            this.panelFilmSaati.Size = new System.Drawing.Size(338, 252);
            this.panelFilmSaati.TabIndex = 11;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.cbSalonAdi);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox7.Location = new System.Drawing.Point(12, 147);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(328, 64);
            this.groupBox7.TabIndex = 11;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Salon Numarası";
            // 
            // BtnOlustur
            // 
            this.BtnOlustur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(107)))), ((int)(((byte)(131)))));
            this.BtnOlustur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnOlustur.FlatAppearance.BorderSize = 0;
            this.BtnOlustur.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnOlustur.ForeColor = System.Drawing.Color.White;
            this.BtnOlustur.Location = new System.Drawing.Point(12, 301);
            this.BtnOlustur.Name = "BtnOlustur";
            this.BtnOlustur.Size = new System.Drawing.Size(328, 42);
            this.BtnOlustur.TabIndex = 12;
            this.BtnOlustur.Text = "Tamamla";
            this.BtnOlustur.UseVisualStyleBackColor = false;
            this.BtnOlustur.Click += new System.EventHandler(this.BtnOlustur_Click);
            // 
            // NmrcYil
            // 
            this.NmrcYil.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NmrcYil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NmrcYil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(107)))), ((int)(((byte)(131)))));
            this.NmrcYil.Location = new System.Drawing.Point(242, 32);
            this.NmrcYil.Maximum = new decimal(new int[] {
            2025,
            0,
            0,
            0});
            this.NmrcYil.Minimum = new decimal(new int[] {
            2025,
            0,
            0,
            0});
            this.NmrcYil.Name = "NmrcYil";
            this.NmrcYil.Size = new System.Drawing.Size(76, 26);
            this.NmrcYil.TabIndex = 11;
            this.NmrcYil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NmrcYil.Value = new decimal(new int[] {
            2025,
            0,
            0,
            0});
            // 
            // NmrcAy
            // 
            this.NmrcAy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NmrcAy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NmrcAy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(107)))), ((int)(((byte)(131)))));
            this.NmrcAy.Location = new System.Drawing.Point(129, 32);
            this.NmrcAy.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.NmrcAy.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NmrcAy.Name = "NmrcAy";
            this.NmrcAy.Size = new System.Drawing.Size(76, 26);
            this.NmrcAy.TabIndex = 10;
            this.NmrcAy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NmrcAy.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NmrcGun
            // 
            this.NmrcGun.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NmrcGun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NmrcGun.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(107)))), ((int)(((byte)(131)))));
            this.NmrcGun.Location = new System.Drawing.Point(19, 32);
            this.NmrcGun.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.NmrcGun.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NmrcGun.Name = "NmrcGun";
            this.NmrcGun.Size = new System.Drawing.Size(76, 26);
            this.NmrcGun.TabIndex = 9;
            this.NmrcGun.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NmrcGun.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbSalonAdi
            // 
            this.cbSalonAdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSalonAdi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSalonAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(107)))), ((int)(((byte)(131)))));
            this.cbSalonAdi.FormattingEnabled = true;
            this.cbSalonAdi.Location = new System.Drawing.Point(16, 27);
            this.cbSalonAdi.Name = "cbSalonAdi";
            this.cbSalonAdi.Size = new System.Drawing.Size(298, 30);
            this.cbSalonAdi.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbDoluSaatler);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(28, 378);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 64);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dolu Saatler";
            this.groupBox1.Visible = false;
            // 
            // cbDoluSaatler
            // 
            this.cbDoluSaatler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDoluSaatler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbDoluSaatler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(107)))), ((int)(((byte)(131)))));
            this.cbDoluSaatler.FormattingEnabled = true;
            this.cbDoluSaatler.Location = new System.Drawing.Point(16, 27);
            this.cbDoluSaatler.Name = "cbDoluSaatler";
            this.cbDoluSaatler.Size = new System.Drawing.Size(298, 30);
            this.cbDoluSaatler.TabIndex = 9;
            // 
            // lblSecilenSaat
            // 
            this.lblSecilenSaat.AutoSize = true;
            this.lblSecilenSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSecilenSaat.ForeColor = System.Drawing.Color.Gold;
            this.lblSecilenSaat.Location = new System.Drawing.Point(391, 405);
            this.lblSecilenSaat.Name = "lblSecilenSaat";
            this.lblSecilenSaat.Size = new System.Drawing.Size(86, 18);
            this.lblSecilenSaat.TabIndex = 12;
            this.lblSecilenSaat.Text = "gg/aa/yyyy";
            this.lblSecilenSaat.Visible = false;
            // 
            // FrmSalonAtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(706, 353);
            this.Controls.Add(this.lblSecilenSaat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnOlustur);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(500, 250);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmSalonAtama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FrmSalonAtama";
            this.Load += new System.EventHandler(this.FrmSalonAtama_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NmrcYil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NmrcAy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NmrcGun)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cbFilmAdi;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label LblYonetmenAra;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.FlowLayoutPanel panelFilmSaati;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button BtnOlustur;
        private System.Windows.Forms.NumericUpDown NmrcYil;
        private System.Windows.Forms.NumericUpDown NmrcAy;
        private System.Windows.Forms.NumericUpDown NmrcGun;
        private System.Windows.Forms.ComboBox cbSalonAdi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbDoluSaatler;
        private System.Windows.Forms.Label lblSecilenSaat;
    }
}
namespace Proje_Sinema
{
    partial class OyuncuListesi
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OyuncuListesi));
            this.BtnSil = new System.Windows.Forms.Button();
            this.LblCinsiyet = new System.Windows.Forms.Label();
            this.LblId = new System.Windows.Forms.Label();
            this.pctrResim = new System.Windows.Forms.PictureBox();
            this.pctrCinsiyet = new System.Windows.Forms.PictureBox();
            this.BtnDetay = new System.Windows.Forms.Button();
            this.LblAdSoyad = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pctrResim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrCinsiyet)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSil
            // 
            this.BtnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(107)))), ((int)(((byte)(131)))));
            this.BtnSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSil.FlatAppearance.BorderSize = 0;
            this.BtnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSil.ForeColor = System.Drawing.Color.White;
            this.BtnSil.Location = new System.Drawing.Point(689, 48);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(135, 41);
            this.BtnSil.TabIndex = 24;
            this.BtnSil.Text = "SİL";
            this.BtnSil.UseVisualStyleBackColor = false;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // LblCinsiyet
            // 
            this.LblCinsiyet.AutoSize = true;
            this.LblCinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblCinsiyet.Location = new System.Drawing.Point(317, 12);
            this.LblCinsiyet.Name = "LblCinsiyet";
            this.LblCinsiyet.Size = new System.Drawing.Size(90, 25);
            this.LblCinsiyet.TabIndex = 23;
            this.LblCinsiyet.Text = "Cinsiyet";
            this.LblCinsiyet.UseWaitCursor = true;
            this.LblCinsiyet.Visible = false;
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblId.Location = new System.Drawing.Point(191, 48);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(29, 25);
            this.LblId.TabIndex = 22;
            this.LblId.Text = "id";
            this.LblId.Visible = false;
            // 
            // pctrResim
            // 
            this.pctrResim.ErrorImage = null;
            this.pctrResim.Image = ((System.Drawing.Image)(resources.GetObject("pctrResim.Image")));
            this.pctrResim.Location = new System.Drawing.Point(14, 3);
            this.pctrResim.Name = "pctrResim";
            this.pctrResim.Size = new System.Drawing.Size(109, 96);
            this.pctrResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrResim.TabIndex = 21;
            this.pctrResim.TabStop = false;
            // 
            // pctrCinsiyet
            // 
            this.pctrCinsiyet.Image = ((System.Drawing.Image)(resources.GetObject("pctrCinsiyet.Image")));
            this.pctrCinsiyet.Location = new System.Drawing.Point(129, 3);
            this.pctrCinsiyet.Name = "pctrCinsiyet";
            this.pctrCinsiyet.Size = new System.Drawing.Size(30, 34);
            this.pctrCinsiyet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctrCinsiyet.TabIndex = 20;
            this.pctrCinsiyet.TabStop = false;
            // 
            // BtnDetay
            // 
            this.BtnDetay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(107)))), ((int)(((byte)(131)))));
            this.BtnDetay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDetay.FlatAppearance.BorderSize = 0;
            this.BtnDetay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDetay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnDetay.ForeColor = System.Drawing.Color.White;
            this.BtnDetay.Location = new System.Drawing.Point(535, 48);
            this.BtnDetay.Name = "BtnDetay";
            this.BtnDetay.Size = new System.Drawing.Size(135, 41);
            this.BtnDetay.TabIndex = 19;
            this.BtnDetay.Text = "DETAY";
            this.BtnDetay.UseVisualStyleBackColor = false;
            this.BtnDetay.Click += new System.EventHandler(this.BtnDetay_Click);
            // 
            // LblAdSoyad
            // 
            this.LblAdSoyad.AutoSize = true;
            this.LblAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblAdSoyad.Location = new System.Drawing.Point(191, 12);
            this.LblAdSoyad.Name = "LblAdSoyad";
            this.LblAdSoyad.Size = new System.Drawing.Size(97, 25);
            this.LblAdSoyad.TabIndex = 18;
            this.LblAdSoyad.Text = "Adsoyad";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Navy;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(5, 102);
            this.flowLayoutPanel1.TabIndex = 17;
            // 
            // OyuncuListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.LblCinsiyet);
            this.Controls.Add(this.LblId);
            this.Controls.Add(this.pctrResim);
            this.Controls.Add(this.pctrCinsiyet);
            this.Controls.Add(this.BtnDetay);
            this.Controls.Add(this.LblAdSoyad);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "OyuncuListesi";
            this.Size = new System.Drawing.Size(856, 102);
            this.Load += new System.EventHandler(this.OyuncuListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctrResim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrCinsiyet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSil;
        public System.Windows.Forms.Label LblCinsiyet;
        public System.Windows.Forms.Label LblId;
        public System.Windows.Forms.PictureBox pctrResim;
        private System.Windows.Forms.PictureBox pctrCinsiyet;
        private System.Windows.Forms.Button BtnDetay;
        public System.Windows.Forms.Label LblAdSoyad;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

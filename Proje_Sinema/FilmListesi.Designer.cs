namespace Proje_Sinema
{
    partial class FilmListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilmListesi));
            this.grbFilmAfisi = new System.Windows.Forms.GroupBox();
            this.lblNo = new System.Windows.Forms.Label();
            this.lblFilmAdi = new System.Windows.Forms.Label();
            this.PcResim = new System.Windows.Forms.PictureBox();
            this.BtnResim = new System.Windows.Forms.Button();
            this.grbFilmAfisi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcResim)).BeginInit();
            this.SuspendLayout();
            // 
            // grbFilmAfisi
            // 
            this.grbFilmAfisi.Controls.Add(this.lblNo);
            this.grbFilmAfisi.Controls.Add(this.lblFilmAdi);
            this.grbFilmAfisi.Controls.Add(this.PcResim);
            this.grbFilmAfisi.Controls.Add(this.BtnResim);
            this.grbFilmAfisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grbFilmAfisi.Location = new System.Drawing.Point(3, 3);
            this.grbFilmAfisi.Name = "grbFilmAfisi";
            this.grbFilmAfisi.Size = new System.Drawing.Size(397, 361);
            this.grbFilmAfisi.TabIndex = 8;
            this.grbFilmAfisi.TabStop = false;
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Location = new System.Drawing.Point(312, 323);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(70, 25);
            this.lblNo.TabIndex = 11;
            this.lblNo.Text = "label1";
            this.lblNo.Visible = false;
            // 
            // lblFilmAdi
            // 
            this.lblFilmAdi.AutoSize = true;
            this.lblFilmAdi.Location = new System.Drawing.Point(7, 1);
            this.lblFilmAdi.Name = "lblFilmAdi";
            this.lblFilmAdi.Size = new System.Drawing.Size(70, 25);
            this.lblFilmAdi.TabIndex = 10;
            this.lblFilmAdi.Text = "label1";
            // 
            // PcResim
            // 
            this.PcResim.ErrorImage = null;
            this.PcResim.Image = ((System.Drawing.Image)(resources.GetObject("PcResim.Image")));
            this.PcResim.Location = new System.Drawing.Point(12, 29);
            this.PcResim.Name = "PcResim";
            this.PcResim.Size = new System.Drawing.Size(379, 275);
            this.PcResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcResim.TabIndex = 6;
            this.PcResim.TabStop = false;
            // 
            // BtnResim
            // 
            this.BtnResim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(107)))), ((int)(((byte)(131)))));
            this.BtnResim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnResim.FlatAppearance.BorderSize = 0;
            this.BtnResim.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnResim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnResim.ForeColor = System.Drawing.Color.White;
            this.BtnResim.Location = new System.Drawing.Point(116, 313);
            this.BtnResim.Name = "BtnResim";
            this.BtnResim.Size = new System.Drawing.Size(181, 44);
            this.BtnResim.TabIndex = 9;
            this.BtnResim.Text = "DETAY";
            this.BtnResim.UseVisualStyleBackColor = false;
            this.BtnResim.Click += new System.EventHandler(this.BtnResim_Click);
            // 
            // FilmListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grbFilmAfisi);
            this.Name = "FilmListesi";
            this.Size = new System.Drawing.Size(406, 370);
            this.grbFilmAfisi.ResumeLayout(false);
            this.grbFilmAfisi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcResim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbFilmAfisi;
        public System.Windows.Forms.Label lblFilmAdi;
        public System.Windows.Forms.Button BtnResim;
        public System.Windows.Forms.PictureBox PcResim;
        public System.Windows.Forms.Label lblNo;
    }
}

namespace Proje_Sinema
{
    partial class SalonListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalonListesi));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblKoltukSayisi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(6, 114);
            this.panel1.TabIndex = 0;
            this.panel1.MouseLeave += new System.EventHandler(this.ayril);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gel);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseLeave += new System.EventHandler(this.ayril);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gel);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(150, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            this.label1.MouseLeave += new System.EventHandler(this.ayril);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gel);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(141, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Koltuk Sayısı:";
            this.label2.MouseLeave += new System.EventHandler(this.ayril);
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gel);
            // 
            // LblKoltukSayisi
            // 
            this.LblKoltukSayisi.AutoSize = true;
            this.LblKoltukSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblKoltukSayisi.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.LblKoltukSayisi.Location = new System.Drawing.Point(279, 69);
            this.LblKoltukSayisi.Name = "LblKoltukSayisi";
            this.LblKoltukSayisi.Size = new System.Drawing.Size(64, 22);
            this.LblKoltukSayisi.TabIndex = 4;
            this.LblKoltukSayisi.Text = "label3";
            this.LblKoltukSayisi.MouseLeave += new System.EventHandler(this.ayril);
            this.LblKoltukSayisi.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gel);
            // 
            // SalonListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LblKoltukSayisi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "SalonListesi";
            this.Size = new System.Drawing.Size(375, 114);
            this.MouseLeave += new System.EventHandler(this.ayril);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gel);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label LblKoltukSayisi;
    }
}

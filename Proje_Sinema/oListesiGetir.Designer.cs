namespace Proje_Sinema
{
    partial class oListesiGetir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(oListesiGetir));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblOyuncuAdi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LblOyuncuAdi
            // 
            this.LblOyuncuAdi.AutoSize = true;
            this.LblOyuncuAdi.BackColor = System.Drawing.Color.White;
            this.LblOyuncuAdi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblOyuncuAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblOyuncuAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(107)))), ((int)(((byte)(131)))));
            this.LblOyuncuAdi.Location = new System.Drawing.Point(43, 6);
            this.LblOyuncuAdi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblOyuncuAdi.Name = "LblOyuncuAdi";
            this.LblOyuncuAdi.Size = new System.Drawing.Size(59, 20);
            this.LblOyuncuAdi.TabIndex = 1;
            this.LblOyuncuAdi.Text = "label1";
            this.LblOyuncuAdi.Click += new System.EventHandler(this.LblOyuncuAdi_Click);
            this.LblOyuncuAdi.MouseLeave += new System.EventHandler(this.LblOyuncuAdi_MouseLeave);
            this.LblOyuncuAdi.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LblOyuncuAdi_MouseMove);
            // 
            // oListesiGetir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LblOyuncuAdi);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "oListesiGetir";
            this.Size = new System.Drawing.Size(194, 32);
            this.Load += new System.EventHandler(this.oListesiGetir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label LblOyuncuAdi;
    }
}

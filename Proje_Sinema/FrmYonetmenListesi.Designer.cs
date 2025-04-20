namespace Proje_Sinema
{
    partial class FrmYonetmenListesi
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
            this.BtnCikis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ListePaneli = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TxtAramaYap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(107)))), ((int)(((byte)(131)))));
            this.panel1.Controls.Add(this.BtnCikis);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(856, 51);
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
            this.BtnCikis.Location = new System.Drawing.Point(811, 0);
            this.BtnCikis.Name = "BtnCikis";
            this.BtnCikis.Size = new System.Drawing.Size(45, 51);
            this.BtnCikis.TabIndex = 4;
            this.BtnCikis.Text = "X";
            this.BtnCikis.UseVisualStyleBackColor = false;
            this.BtnCikis.Click += new System.EventHandler(this.BtnCikis_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Yönetmen Liste Ekranı";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.ListePaneli);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(0, 102);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(856, 611);
            this.panel3.TabIndex = 5;
            // 
            // ListePaneli
            // 
            this.ListePaneli.AutoScroll = true;
            this.ListePaneli.BackColor = System.Drawing.Color.Silver;
            this.ListePaneli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListePaneli.Location = new System.Drawing.Point(0, 0);
            this.ListePaneli.Name = "ListePaneli";
            this.ListePaneli.Size = new System.Drawing.Size(856, 611);
            this.ListePaneli.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 50);
            this.label2.TabIndex = 1;
            this.label2.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Controls.Add(this.TxtAramaYap);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(856, 51);
            this.panel2.TabIndex = 4;
            // 
            // TxtAramaYap
            // 
            this.TxtAramaYap.BackColor = System.Drawing.Color.Silver;
            this.TxtAramaYap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtAramaYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAramaYap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(107)))), ((int)(((byte)(131)))));
            this.TxtAramaYap.Location = new System.Drawing.Point(588, 16);
            this.TxtAramaYap.Name = "TxtAramaYap";
            this.TxtAramaYap.Size = new System.Drawing.Size(243, 23);
            this.TxtAramaYap.TabIndex = 3;
            this.TxtAramaYap.TextChanged += new System.EventHandler(this.TxtAramaYap_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(475, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ad-Soyad:";
            // 
            // FrmYonetmenListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(856, 713);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(600, 150);
            this.Name = "FrmYonetmenListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FrmYonetmenListesi";
            this.Load += new System.EventHandler(this.FrmYonetmenListesi_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnCikis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel ListePaneli;
        private System.Windows.Forms.TextBox TxtAramaYap;
        private System.Windows.Forms.Label label3;
    }
}
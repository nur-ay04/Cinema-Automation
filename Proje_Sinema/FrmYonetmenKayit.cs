using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;

namespace Proje_Sinema
{
    public partial class FrmYonetmenKayit : Form
    {
        public FrmYonetmenKayit()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source= LAPTOP-QL9SNOH8\\SQLEXPRESS; Initial Catalog = Sinema;Integrated Security= True");
        string resimYolu;
        private void BtnKaydet_Click(object sender, EventArgs e)
        {

            yasHesapla();

            if (TxtAd.Text != "" && TxtSoyad.Text != "" && TxtBio.Text != "" && PcResim.Image != null)
            {
                string adSoyad = TxtAd.Text.ToUpper() + " " + TxtSoyad.Text.ToUpper();
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into TblYonetmenler (yonetmenAdSoyad, yonetmenCinsiyet, yonetmenYas, yonetmenBio, yonetmenResim) values(@p1, @p2, @p3, @p4, @p5)", baglanti);
                komut.Parameters.AddWithValue("@p1", adSoyad);
                komut.Parameters.AddWithValue("@p2", cinsiyet);
                komut.Parameters.AddWithValue("@p3", hesaplananYas);
                komut.Parameters.AddWithValue("@p4", TxtBio.Text.ToString().ToUpper());
                komut.Parameters.AddWithValue("@p5", resimYolu);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Yönetmen bilgileri başarıyla kaydedilmiştir.");
                bilgileriTemizle();
            }
            else
            {
                MessageBox.Show("Lütfen eksiksiz doldurduğunuzdan emin olun!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnResimYukle_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Resim Seçme Ekranı";
            openFileDialog1.Filter = "PNG (*.png)|*.png|JPG (*.jpg)|*.jpg|JPEG (*.jpeg)|*.jpeg|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 0;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    PcResim.Image = new Bitmap(openFileDialog1.FileName);
                    resimYolu = openFileDialog1.FileName;  
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Resim yüklenirken bir hata oluştu: " + ex.Message);
                }
            }
         }
        public string cinsiyet = "Kadın";
        public string hesaplananYas = "0";
        void bilgileriTemizle()
        {
            TxtAd.Text = "";
            TxtSoyad.Text = "";
            TxtBio.Text = "";
            PcResim.ImageLocation = @"C:\\Users\\nuray\\Downloads\ noim.png";
            rbErkek.Checked = false;
            rbKadın.Checked = true;
            LblKarakter.Text = "300";
            hesaplananYas = "0";
            NmrcGun.Value = 1;
            NmrcAy.Value = 1;
            NmrcYil.Value = 2010;
            TxtAd.Focus();

        }
        void yasHesapla()
        {
            string dogum = NmrcGun.Value.ToString() + "/" + NmrcAy.Value.ToString() + "/" + NmrcYil.Value.ToString();
            DateTime dogumTarihi;
            dogumTarihi = Convert.ToDateTime(dogum);
            DateTime bugun = DateTime.Now;
            int yas = Convert.ToInt32(bugun.Year - dogumTarihi.Year);
            hesaplananYas = yas.ToString();
        }
        private void rbKadın_CheckedChanged(object sender, EventArgs e)
        {
            cinsiyet = "Kadın";
        }

        private void rbErkek_CheckedChanged(object sender, EventArgs e)
        {
            cinsiyet = "Erkek";
        }

        private void TxtBio_TextChanged(object sender, EventArgs e)
        {
            TxtBio.MaxLength = 300;
            int karakterSayisi = TxtBio.Text.Length;
            int geri = 300 - karakterSayisi;
            LblKarakter.Text = geri.ToString();
            if (geri < 20)
            {
                LblKarakter.ForeColor = Color.Red;
            }
            else
            {
                LblKarakter.ForeColor = Color.FromArgb(101, 107, 131);
            }
        }

    }
}

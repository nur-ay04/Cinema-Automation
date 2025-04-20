using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Sinema
{
    public partial class FrmFilmKayit : Form
    {
        public FrmFilmKayit()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source= LAPTOP-QL9SNOH8\\SQLEXPRESS; Initial Catalog = Sinema;Integrated Security= True");
        private void BtnCikis_Click(object sender, EventArgs e)
        {
            this.Close();

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TxtBio.MaxLength = 300;
            int karakterSayisi = TxtBio.Text.Length;
            int geri = 300 - karakterSayisi;
            labelKarakter.Text = geri.ToString();
            if (geri < 20)
            {
                labelKarakter.ForeColor = Color.Red;
            }
            else
            {
                labelKarakter.ForeColor = Color.FromArgb(101, 107, 131);
            }
        }

        private void rb1_CheckedChanged(object sender, EventArgs e)
        {
            LblRating.Text = rb1.Text;
        }

        private void rb2_CheckedChanged(object sender, EventArgs e)
        {
            LblRating.Text = rb2.Text;
        }

        private void rb3_CheckedChanged(object sender, EventArgs e)
        {
            LblRating.Text = rb3.Text;
        }

        private void rb4_CheckedChanged(object sender, EventArgs e)
        {
            LblRating.Text = rb4.Text;
        }

        private void rb5_CheckedChanged(object sender, EventArgs e)
        {
            LblRating.Text = rb5.Text;
        }

        private void rb6_CheckedChanged(object sender, EventArgs e)
        {
            LblRating.Text = rb6.Text;
        }

        private void rb7_CheckedChanged(object sender, EventArgs e)
        {
            LblRating.Text = rb7.Text;
        }

        private void rb8_CheckedChanged(object sender, EventArgs e)
        {
            LblRating.Text = rb8.Text;
        }

        private void rb9_CheckedChanged(object sender, EventArgs e)
        {
            LblRating.Text = rb9.Text;
        }

        private void rb10_CheckedChanged(object sender, EventArgs e)
        {
            LblRating.Text = rb10.Text;
        }
        string resimYolu;
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
        void yListesiGetir()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            fYonetmenAraPaneli.Controls.Clear();
            string sorgu = "select * from TblYonetmenler order by yonetmenAdSoyad asc";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                yListesiGetir arac = new yListesiGetir();
                arac.LblYonetmenAdi.Text = dr["yonetmenAdSoyad"].ToString();
                fYonetmenAraPaneli.Controls.Add(arac);

            }
            baglanti.Close();
        }
        void oListesiGetir()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            fOyuncuAraPaneli.Controls.Clear();
            string sorgu = "select * from TblOyuncular order by oyuncuAdSoyad asc";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                oListesiGetir arac = new oListesiGetir();
                arac.LblOyuncuAdi.Text = dr["oyuncuAdSoyad"].ToString();
                fOyuncuAraPaneli.Controls.Add(arac);

            }
            baglanti.Close();
        }

        private void FrmFilmKayit_Load(object sender, EventArgs e)
        {
            yListesiGetir();
            oListesiGetir();
            bugununTarihi();
            //secilenOyuncular();
            //secilenYonetmenler();
        }

        void bugununTarihi()
        {
            NmrcGun.Value = DateTime.Today.Day;
            NmrcAy.Value = DateTime.Today.Month;
            NmrcYil.Value = DateTime.Today.Year;
        }

        private void TxtYonetmenAra_MouseMove(object sender, MouseEventArgs e)
        {
            LblYonetmenAra.Visible = true;
        }

        private void TxtYonetmenAra_MouseLeave(object sender, EventArgs e)
        {
            LblYonetmenAra.Visible = false;
        }

        private void TxtOyuncuAra_MouseMove(object sender, MouseEventArgs e)
        {
            LblOyuncuAra.Visible = true;
        }

        private void TxtOyuncuAra_MouseLeave(object sender, EventArgs e)
        {
            LblOyuncuAra.Visible = false;
        }

        private void TxtYonetmenAra_TextChanged(object sender, EventArgs e)
        {
            string sorgu = "select * from TblYonetmenler where yonetmenAdSoyad Like @arama collate Turkish_CI_AS order by yonetmenAdSoyad asc";
            fYonetmenAraPaneli.Controls.Clear();
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            SqlCommand ara = new SqlCommand(sorgu, baglanti);
            ara.Parameters.AddWithValue("@arama", "%" + TxtYonetmenAra.Text + "%");
            SqlDataReader dr = ara.ExecuteReader();
            while (dr.Read())
            {
                yListesiGetir arac = new yListesiGetir();
                arac.LblYonetmenAdi.Text = dr["yonetmenAdSoyad"].ToString();
                fYonetmenAraPaneli.Controls.Add(arac);
            }
            baglanti.Close();
        }

        private void TxtOyuncuAra_TextChanged(object sender, EventArgs e)
        {
            fOyuncuAraPaneli.Controls.Clear();
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            string sorgu = "select * from TblOyuncular where oyuncuAdSoyad Like @arama collate Turkish_CI_AS order by oyuncuAdSoyad asc";
            SqlCommand ara = new SqlCommand(sorgu, baglanti);
            ara.Parameters.AddWithValue("@arama", "%" + TxtOyuncuAra.Text + "%");
            SqlDataReader dr = ara.ExecuteReader();
            while (dr.Read())
            {
                oListesiGetir arac = new oListesiGetir();
                arac.LblOyuncuAdi.Text = dr["oyuncuAdSoyad"].ToString();
                fOyuncuAraPaneli.Controls.Add(arac);

            }
            baglanti.Close();
        }

        private void LblAksiyon_Click(object sender, EventArgs e)
        {
            if (LblAksiyon.ForeColor == Color.FromArgb(101, 107, 131))
            {
                LblAksiyon.ForeColor = Color.Gold;
            }
            else
            {
                LblAksiyon.ForeColor = Color.FromArgb(101, 107, 131);
            }
        }

        private void LblKorku_Click(object sender, EventArgs e)
        {
            if (LblKorku.ForeColor == Color.FromArgb(101, 107, 131))
            {
                LblKorku.ForeColor = Color.Gold;
            }
            else
            {
                LblKorku.ForeColor = Color.FromArgb(101, 107, 131);
            }
        }

        private void LblRomantik_Click(object sender, EventArgs e)
        {
            if (LblRomantik.ForeColor == Color.FromArgb(101, 107, 131))
            {
                LblRomantik.ForeColor = Color.Gold;
            }
            else
            {
                LblRomantik.ForeColor = Color.FromArgb(101, 107, 131);
            }
        }

        private void LblPolisiye_Click(object sender, EventArgs e)
        {
            if (LblPolisiye.ForeColor == Color.FromArgb(101, 107, 131))
            {
                LblPolisiye.ForeColor = Color.Gold;
            }
            else
            {
                LblPolisiye.ForeColor = Color.FromArgb(101, 107, 131);
            }
        }

        private void LblGerilim_Click(object sender, EventArgs e)
        {
            if (LblGerilim.ForeColor == Color.FromArgb(101, 107, 131))
            {
                LblGerilim.ForeColor = Color.Gold;
            }
            else
            {
                LblGerilim.ForeColor = Color.FromArgb(101, 107, 131);
            }
        }

        private void LblKomedi_Click(object sender, EventArgs e)
        {
            if (LblKomedi.ForeColor == Color.FromArgb(101, 107, 131))
            {
                LblKomedi.ForeColor = Color.Gold;
            }
            else
            {
                LblKomedi.ForeColor = Color.FromArgb(101, 107, 131);
            }
        }

        private void LblKorkuSiddet_Click(object sender, EventArgs e)
        {
            if (LblKorkuSiddet.ForeColor == Color.FromArgb(101, 107, 131))
            {
                LblKorkuSiddet.ForeColor = Color.Gold;
                pctrKorkuSiddet.ImageLocation = "C:\\Users\\nuray\\OneDrive\\Pictures\\Screenshots\\resimler\\acik_kilit_ikonu.png";
            }
            else
            {
                LblKorkuSiddet.ForeColor = Color.FromArgb(101, 107, 131);
                pctrKorkuSiddet.ImageLocation = "C:\\Users\\nuray\\OneDrive\\Pictures\\Screenshots\\resimler\\kilit_ikonu.png";
            }
        }

        private void LblOlumsuzIcerik_Click(object sender, EventArgs e)
        {
            if (LblOlumsuzIcerik.ForeColor == Color.FromArgb(101, 107, 131))
            {
                LblOlumsuzIcerik.ForeColor = Color.Gold;
                pctrOlumsuzIcerik.ImageLocation = "C:\\Users\\nuray\\OneDrive\\Pictures\\Screenshots\\resimler\\acik_kilit_ikonu.png";
            }
            else
            {
                LblOlumsuzIcerik.ForeColor = Color.FromArgb(101, 107, 131);
                pctrOlumsuzIcerik.ImageLocation = "C:\\Users\\nuray\\OneDrive\\Pictures\\Screenshots\\resimler\\kilit_ikonu.png";
            }
        }

        private void LblGenelIzleyici_Click(object sender, EventArgs e)
        {
            if (LblGenelIzleyici.ForeColor == Color.FromArgb(101, 107, 131))
            {
                LblGenelIzleyici.ForeColor = Color.Gold;
                pctrGenelIzleyici.ImageLocation = "C:\\Users\\nuray\\OneDrive\\Pictures\\Screenshots\\resimler\\acik_kilit_ikonu.png";
            }
            else
            {
                LblGenelIzleyici.ForeColor = Color.FromArgb(101, 107, 131);
                pctrGenelIzleyici.ImageLocation = "C:\\Users\\nuray\\OneDrive\\Pictures\\Screenshots\\resimler\\kilit_ikonu.png";
            }
        }

        private void LblCinsellik_Click(object sender, EventArgs e)
        {
            if (LblCinsellik.ForeColor == Color.FromArgb(101, 107, 131))
            {
                LblCinsellik.ForeColor = Color.Gold;
                pctrCinsellik.ImageLocation = "C:\\Users\\nuray\\OneDrive\\Pictures\\Screenshots\\resimler\\acik_kilit_ikonu.png";
            }
            else
            {
                LblCinsellik.ForeColor = Color.FromArgb(101, 107, 131);
                pctrCinsellik.ImageLocation = "C:\\Users\\nuray\\OneDrive\\Pictures\\Screenshots\\resimler\\kilit_ikonu.png";
            }
        }

        private void Lbl7Yas_Click(object sender, EventArgs e)
        {
            if (Lbl7Yas.ForeColor == Color.FromArgb(101, 107, 131))
            {
                Lbl7Yas.ForeColor = Color.Gold;
                pctr7Yas.ImageLocation = "C:\\Users\\nuray\\OneDrive\\Pictures\\Screenshots\\resimler\\acik_kilit_ikonu.png";
            }
            else
            {
                Lbl7Yas.ForeColor = Color.FromArgb(101, 107, 131);
                pctr7Yas.ImageLocation = "C:\\Users\\nuray\\OneDrive\\Pictures\\Screenshots\\resimler\\kilit_ikonu.png";
            }
        }

        private void Lbl13Yas_Click(object sender, EventArgs e)
        {
            if (Lbl13Yas.ForeColor == Color.FromArgb(101, 107, 131))
            {
                Lbl13Yas.ForeColor = Color.Gold;
                pctr13Yas.ImageLocation = "C:\\Users\\nuray\\OneDrive\\Pictures\\Screenshots\\resimler\\acik_kilit_ikonu.png";
            }
            else
            {
                Lbl13Yas.ForeColor = Color.FromArgb(101, 107, 131);
                pctr13Yas.ImageLocation = "C:\\Users\\nuray\\OneDrive\\Pictures\\Screenshots\\resimler\\kilit_ikonu.png";
            }
        }

        private void LblTurkce_Click(object sender, EventArgs e)
        {
            if (LblTurkce.ForeColor == Color.FromArgb(101, 107, 131))
            {
                LblTurkce.ForeColor = Color.Gold;
            }
            else
            {
                LblTurkce.ForeColor = Color.FromArgb(101, 107, 131);
            }
        }

        private void LblIngilizceUs_Click(object sender, EventArgs e)
        {
            if (LblIngilizceUs.ForeColor == Color.FromArgb(101, 107, 131))
            {
                LblIngilizceUs.ForeColor = Color.Gold;
            }
            else
            {
                LblIngilizceUs.ForeColor = Color.FromArgb(101, 107, 131);
            }
        }

        private void LblIngilizceEng_Click(object sender, EventArgs e)
        {
            if (LblIngilizceEng.ForeColor == Color.FromArgb(101, 107, 131))
            {
                LblIngilizceEng.ForeColor = Color.Gold;
            }
            else
            {
                LblIngilizceEng.ForeColor = Color.FromArgb(101, 107, 131);
            }
        }

        private void LblIspanyolca_Click(object sender, EventArgs e)
        {
            if (LblIspanyolca.ForeColor == Color.FromArgb(101, 107, 131))
            {
                LblIspanyolca.ForeColor = Color.Gold;
            }
            else
            {
                LblIspanyolca.ForeColor = Color.FromArgb(101, 107, 131);
            }
        }

        private void LblAltyazi_Click(object sender, EventArgs e)
        {
            if (LblAltyazi.ForeColor == Color.FromArgb(101, 107, 131))
            {
                LblAltyazi.ForeColor = Color.Gold;
            }
            else
            {
                LblAltyazi.ForeColor = Color.FromArgb(101, 107, 131);
            }
        }

        private void BtnTarihSec_Click(object sender, EventArgs e)
        {
            vizyonTarihiHesapla();
        }
        string vTarihi = "";
        void vizyonTarihiHesapla()
        {
            vTarihi = NmrcGun.Value + "/" + NmrcAy.Value + "/" + NmrcYil.Value;
            DateTime dVTarihi = Convert.ToDateTime(vTarihi);
            DateTime bTarihi = DateTime.Today;

            TimeSpan tTarih = dVTarihi - bTarihi;
            if (TxtFilmAdi.Text == "")
            {
                MessageBox.Show("Filmin ismini giriniz.", "UYARI");
            }
            else
            {
                if (tTarih.TotalDays < 0)
                {
                    MessageBox.Show("Vizyon tarihi geçmiş bir gün olamaz!", "UYARI");
                    bugununTarihi();
                }
                else if (tTarih.TotalDays == 0)
                {
                    MessageBox.Show("Bügun " + TxtFilmAdi.Text.ToUpper() + " " + "filmi vizyonda!!!", "UYARI");
                    filmDurumu = "1";
                }
                else
                {
                    MessageBox.Show(TxtFilmAdi.Text.ToUpper() + " filmi " + tTarih.TotalDays + " gün sonra vizyonda....", "UYARI");
                    filmDurumu = "0";
                }
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LblTarih.Text = DateTime.Now.ToShortDateString();
            lblSaat.Text = DateTime.Now.ToShortTimeString();
        }
        string filmDurumu = "0";
        string secilenTur;
        string secilenOzellik;
        string secilenBicim;
        void tur()
        {
            secilenTur = "";
            foreach (Control secilenArac in grbFilmTurleri.Controls)
            {
                if (secilenArac is Label)
                {
                    if (secilenArac.ForeColor == Color.FromArgb(101, 107, 131))
                    {
                    }
                    else
                    {
                        secilenTur += " ," + secilenArac.Text.ToString();
                    }
                }
            }
        }
        void ozellik()
        {
            secilenOzellik = "";
            foreach (Control secilenArac in grbFilmOzellikleri.Controls)
            {
                if (secilenArac is Label)
                {
                    if (secilenArac.ForeColor == Color.FromArgb(101, 107, 131))
                    {
                    }
                    else
                    {
                        secilenOzellik += " ," + secilenArac.Text.ToString();
                    }
                }
            }
        }
        void bicim()
        {
            secilenBicim = "";
            foreach (Control secilenArac in grbFilmBicimleri.Controls)
            {
                if (secilenArac is Label)
                {
                    if (secilenArac.ForeColor == Color.FromArgb(101, 107, 131))
                    {
                    }
                    else
                    {
                        secilenBicim += " ," + secilenArac.Text.ToString();
                    }
                }
            }
        }
        string oyuncu = "";
        string yonetmen = "";
        private void BtnKayitTamamla_Click(object sender, EventArgs e)
        {
            string sorgu = "insert into TblFilmler (filmAdi, filmTurleri, filmOzellikleri, filmBicimleri, filmYonetmenleri, filmOyunculari, filmVizyonTarihi, filmPuani, filmAfisi, filmDetayi, filmDurum) values (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10, @p11)";
            tur();
            ozellik();
            bicim();
            if (TxtFilmAdi.Text != "" && secilenTur != "" && secilenOzellik != "" && secilenBicim != "" && vTarihi != "" && resimYolu != "" && TxtBio.Text != "")
            {
                List<string> yonetmenler = secilenYonetmenler();
                List<string> oyuncular = secilenOyuncular();

                baglanti.Open();
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@p1", TxtFilmAdi.Text);
                if (secilenTur.Length > 2)
                {
                    komut.Parameters.AddWithValue("@p2", secilenTur.Substring(2));
                }
                else
                {
                    komut.Parameters.AddWithValue("@p2", secilenTur);
                }
                if (secilenOzellik.Length > 2)
                {
                    komut.Parameters.AddWithValue("@p3", secilenOzellik.Substring(2));
                }
                else
                {
                    komut.Parameters.AddWithValue("@p3", secilenOzellik);
                }
                if (secilenBicim.Length > 2)
                {
                    komut.Parameters.AddWithValue("@p4", secilenBicim.Substring(2));
                }
                else
                {
                    komut.Parameters.AddWithValue("@p4", secilenBicim);
                }
                komut.Parameters.AddWithValue("@p5", string.Join(", ", yonetmenler));
                komut.Parameters.AddWithValue("@p6", string.Join(", ", oyuncular));
                komut.Parameters.AddWithValue("@p7", vTarihi.ToString());
                komut.Parameters.AddWithValue("@p8", LblRating.Text);
                komut.Parameters.AddWithValue("@p9", resimYolu);
                komut.Parameters.AddWithValue("@p10", TxtBio.Text);
                komut.Parameters.AddWithValue("@p11", filmDurumu);
                komut.ExecuteNonQuery();

                foreach (var yonetmen in yonetmenler)
                {
                    string sorguSecilen = "INSERT INTO TblSecilenler (secilenTur, secilenKisi) VALUES ('YÖNETMEN', @kisiAdi)";
                    SqlCommand komutSecilen = new SqlCommand(sorguSecilen, baglanti);
                    komutSecilen.Parameters.AddWithValue("@kisiAdi", yonetmen);
                    komutSecilen.ExecuteNonQuery();
                }

                foreach (var oyuncu in oyuncular)
                {
                    string sorguSecilen = "INSERT INTO TblSecilenler (secilenTur, secilenKisi) VALUES ('OYUNCU', @kisiAdi)";
                    SqlCommand komutSecilen = new SqlCommand(sorguSecilen, baglanti);
                    komutSecilen.Parameters.AddWithValue("@kisiAdi", oyuncu);
                    komutSecilen.ExecuteNonQuery();
                }


                MessageBox.Show("Kayıt başarılı bir şekilde gerçekleşti.", "BİLGİ");
                verileriTemizle();
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanı doldurduğunuzdan emin olunuz!");
            }
            baglanti.Close();
        }

        void verileriTemizle()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            SqlCommand komut1 = new SqlCommand("delete from TblSecilenler", baglanti);
            komut1.ExecuteNonQuery();
            this.Controls.Clear();
            this.InitializeComponent();
            TxtFilmAdi.Focus();
            yListesiGetir();
            oListesiGetir();
            bugununTarihi();
            baglanti.Close();
        }
        List<string> secilenYonetmenler()
        {
            List<string> yonetmenListesi = new List<string>();
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            SqlCommand komut = new SqlCommand("select * from TblSecilenler where secilenTur = 'Yönetmen'", baglanti);
            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                yonetmenListesi.Add(dr["secilenKisi"].ToString());
            }
            dr.Close();
            baglanti.Close();
            return yonetmenListesi; 
        }

        List<string> secilenOyuncular()
        {
            List<string> oyuncuListesi = new List<string>();
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            SqlCommand komut = new SqlCommand("select * from TblSecilenler where secilenTur = 'OYUNCU'", baglanti);
            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                oyuncuListesi.Add(dr["secilenKisi"].ToString());
            }
            dr.Close();
            baglanti.Close();
            return oyuncuListesi; 
        }
    }
}



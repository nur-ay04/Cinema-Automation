using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;
namespace Proje_Sinema
{
    public partial class FrmBiletOlustur : Form
    {
        public FrmBiletOlustur()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source= LAPTOP-QL9SNOH8\\SQLEXPRESS; Initial Catalog = Sinema;Integrated Security= True");
        private void BtnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmBiletOlustur_Load(object sender, EventArgs e)
        {
            FilmAdiGetir();
            BiletNumarasıOlustur();
        }
        void BiletNumarasıOlustur()
        {
            Random random = new Random();
            string karakterler = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            string biletNo = "";

            for (int i = 1; i < 11; i++)
            {
                biletNo += karakterler[random.Next(karakterler.Length)];
            }
            TxtBiletNo.Text= biletNo;
        }
        void FilmAdiGetir()
        {
            string sorgu = "select * from TblFilmler order by filmAdi asc";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader dr = komut .ExecuteReader();
            while(dr.Read())
            {
                string gelenTarih = dr["filmVizyonTarihi"].ToString();
                DateTime bugun = DateTime.Today;
                DateTime fTarih = Convert.ToDateTime(gelenTarih);
                TimeSpan timeSpan = fTarih- bugun;
                if (timeSpan.TotalDays <= 0)
                {
                    cbFilmAdi.Items.Add(dr["filmAdi"].ToString());
                }
            }
            baglanti.Close();

        }

        private void cbFilmAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbTarih.Items.Clear();
            string sorgu = "select distinct tarih from TblKontrol where filmAdi = @filmAdi";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@filmAdi",cbFilmAdi.Text.ToString());
            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                cbTarih.Items.Add(dr["tarih"].ToString());
            }
            baglanti.Close();
        }

        private void cbTarih_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelFilmSaati.Controls.Clear();
            string saatler = "";
            string sorgu = "select distinct saat from TblKontrol where filmAdi = @filmAdi and tarih = @tarih";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@filmAdi", cbFilmAdi.Text.ToString());
            komut.Parameters.AddWithValue("@tarih", cbTarih.Text.ToString());
            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                saatler = dr["saat"].ToString();
                RadioButton rnd = new RadioButton();
                rnd.Text = saatler;
                rnd.CheckedChanged += new EventHandler(SeansSaatleri);
                panelFilmSaati.Controls.Add(rnd);
            }
            baglanti.Close();
        }
        void SeansSaatleri(object sender, EventArgs e)
        {
            foreach (Control item in panelFilmSaati.Controls)
            {
                if (item is RadioButton radioButton && radioButton.Checked)
                {
                    lblSeansBilgisi.Text = radioButton.Text;
                    cbSalonAdi.Items.Clear(); 

                    string sorgu = "SELECT DISTINCT salonNo FROM TblKontrol WHERE filmAdi = @filmAdi AND tarih = @tarih AND saat = @saat";

                    using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@filmAdi", cbFilmAdi.Text);
                        komut.Parameters.AddWithValue("@tarih", cbTarih.Text);
                        komut.Parameters.AddWithValue("@saat", lblSeansBilgisi.Text);

                        baglanti.Open();
                        using (SqlDataReader dr = komut.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                string salonNo = dr["salonNo"].ToString();
                                if (!cbSalonAdi.Items.Contains(salonNo)) 
                                {
                                    cbSalonAdi.Items.Add(salonNo);
                                }
                            }
                        }
                        baglanti.Close();
                    }
                    break;
                }
            }
        }

        private void cbSalonAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            salonDurumu();

        }

        void salonDurumu()
        {
            baglanti.Close();
            baglanti.Open();
            string sorgu = "select * from TblSalonlar where salonAd = @salonAdi";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@salonAdi", cbSalonAdi.Text.ToString());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblSalon.Text = dr["salonKoltukSayisi"].ToString();
            }
            baglanti.Close();
            KoltukGetir();
            KoltukRenkleri();
            secilenKoltukNo();
        }
        void KoltukRenkleri()
        {
            KoltukPaneli.Controls.Clear();
            int koltukSayisi = Convert.ToInt16(lblSalon.Text);

            for (int i = 1; i <= koltukSayisi; i++)
            {
                Button btn = new Button();
                btn.Text = i.ToString();
                btn.Name = i.ToString();
                btn.Width = 63;
                btn.Height = 40;
                btn.ForeColor = Color.White;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.Click += Btn_Click;
                if (listeGelenKoltuk.Items.Contains(btn.Text))
                {
                    btn.ImageAlign = ContentAlignment.MiddleCenter;
                    btn.ForeColor =Color.Black;
                    btn.Image = new Bitmap(Image.FromFile("C:\\Users\\nuray\\OneDrive\\Pictures\\Screenshots\\resimler\\kirmizi_koltuk.png"), new Size(58, 38));
                }
                else
                {
                    btn.ImageAlign = ContentAlignment.MiddleCenter;
                    btn.Cursor = Cursors.Hand;
                    btn.Image = new Bitmap(Image.FromFile("C:\\Users\\nuray\\OneDrive\\Pictures\\Screenshots\\resimler\\mavi_koltuk.png"), new Size(58, 38));
                }
                KoltukPaneli.Controls.Add(btn);
            }
        }
        void KoltukGetir()
        {
            lblGelenKoltuk.Text = "";
            string sorgu = "select *from TblKontrol where filmAdi = @filmAdi and tarih = @tarih and salonNo = @salonAdi and saat = @saat";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@filmAdi", cbFilmAdi.Text.ToString());
            komut.Parameters.AddWithValue("@tarih", cbTarih.Text.ToString());
            komut.Parameters.AddWithValue("@salonAdi", cbSalonAdi.Text.ToString());
            komut.Parameters.AddWithValue("@saat", lblSeansBilgisi.Text.ToString());
            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                lblGelenKoltuk.Text += " ," + dr["koltuklar"].ToString();
                if (lblGelenKoltuk.Text.Length >2)
                {
                    lblGelenKoltuk.Text = lblGelenKoltuk.Text.Substring(2);
                }
                else
                {
                    lblGelenKoltuk.Text = "";
                }
            }
            baglanti.Close();
            KoltukAyirma();
        }
        void KoltukAyirma()
        {
            listeGelenKoltuk.Items.Clear();
            string no = "";
            string[] secilen;
            no = lblGelenKoltuk.Text;
            secilen = no.Split(',');
            foreach (string bulunan in secilen)
            {
                listeGelenKoltuk.Items.Add(bulunan);
            }
        }
        void biletNoSorgula()
        {
            baglanti.Close();
            baglanti.Open();
            string sorgu = "select * from TblBiletler where biletKodu = @biletKodu";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@biletKodu", TxtBiletNo.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (!dr.Read()) 
            {
                bilgileriKaydetme();
            }
            else
            {
                BiletNumarasıOlustur();
                dr.Close();
                biletNoSorgula();
            }
            baglanti.Close();
        }

        void bilgileriKaydetme()
        {
            baglanti.Close();
            baglanti.Open();
            string sorgu = "insert into TblBiletler (biletKodu, adSoyad, telNo, koltukNo, filmAdı, tarih, saat, salon, tur, islemSaati ) values (@biletKodu, @adSoyad, @telNo, @koltukNo, @filmAdı, @tarih, @saat, @salon, @tur, @islemSaati)";
            SqlCommand kayit = new SqlCommand(sorgu, baglanti);
            kayit.Parameters.AddWithValue("@biletKodu", TxtBiletNo.Text);
            kayit.Parameters.AddWithValue("@adSoyad", TxtAdSoyad.Text.ToUpper());
            kayit.Parameters.AddWithValue("@telNo", TxtTelNo.Text.ToString());
            kayit.Parameters.AddWithValue("@filmAdı", cbFilmAdi.Text);
            kayit.Parameters.AddWithValue("@tarih", cbTarih.Text);
            kayit.Parameters.AddWithValue("@saat", lblSeansBilgisi.Text);
            kayit.Parameters.AddWithValue("@salon", cbSalonAdi.Text);
            kayit.Parameters.AddWithValue("@tur", cbBiletTuru.Text);
            kayit.Parameters.AddWithValue("@islemSaati", DateTime.Now.ToString());
            kayit.Parameters.AddWithValue("@koltukNo", TxtSecilenKoltuklar.Text);
            kayit.ExecuteNonQuery();
            baglanti.Close();

            baglanti.Open();
            string sorgu2 = "update TblKontrol set koltuklar = @koltuklar where filmAdi = @filmAdi and tarih = @tarih and saat=@saat and salonNo = @salonNo";
            SqlCommand guncelle = new SqlCommand(sorgu2, baglanti);
            if (lblGelenKoltuk.Text == "")
            {
                guncelle.Parameters.AddWithValue("@koltuklar",TxtSecilenKoltuklar.Text.ToString());
            }
            else
            {
                guncelle.Parameters.AddWithValue("@koltuklar", lblGelenKoltuk.Text + "," + TxtSecilenKoltuklar.Text.ToString());
            }
            guncelle.Parameters.AddWithValue("@filmAdi", cbFilmAdi.Text);
            guncelle.Parameters.AddWithValue("@tarih", cbTarih.Text);
            guncelle.Parameters.AddWithValue("@saat", lblSeansBilgisi.Text);
            guncelle.Parameters.AddWithValue("@salonNo", cbSalonAdi.Text);
            guncelle.ExecuteNonQuery();
            MessageBox.Show("Bilet Başarılı bir şekilde oluşturuldu!", "UYARI", MessageBoxButtons.OK);
            salonDurumu();
            baglanti.Close();
        }

        void temizleme()
        {
            TxtBiletNo.Text = "";
            BiletNumarasıOlustur();
            TxtAdSoyad.Text = "";
            TxtBiletNo.Text = "";
            TxtSecilenKoltuklar.Text = "";
            TxtTelNo.Text = "";
            lblSeansBilgisi.Text = "";
            cbBiletTuru.Items.Clear();
            cbFilmAdi.Items.Clear();
            FilmAdiGetir();
            cbTarih.Items.Clear();
            cbSalonAdi.Items.Clear();
            KoltukGetir();
            panelFilmSaati.Controls.Clear();
            lblGelenKoltuk.Text = "";
            lblSeansBilgisi.Text = "";
            lblSalon.Text = "";
            listBelirlenenKoltuklar.Items.Clear();
            listeGelenKoltuk.Items.Clear();
            cbBiletTuru.Items.Add( "Yetişkin");
            cbBiletTuru.Items.Add("Öğrenci");
            TxtAdSoyad.Focus();
            BiletNumarasıOlustur();

        }
        private void BtnOlustur_Click(object sender, EventArgs e)
        {
            if (TxtAdSoyad.Text != "" && TxtTelNo.Text != "" && TxtSecilenKoltuklar.Text != "" && cbFilmAdi.Text != "" && cbSalonAdi.Text != "" && cbTarih.Text != "" && cbBiletTuru.Text != "" && lblSeansBilgisi.Text != "")
            {
                biletNoSorgula();
                temizleme();
            }
            else
            {
                MessageBox.Show("Lütfen bilgileri eksiksiz doldurduğunuzdan emin olunuz!", "UYARI", MessageBoxButtons.OK);
            }
        }

        void secilenKoltukNo()
        {
            TxtSecilenKoltuklar.Text = "";
            foreach (string item in listBelirlenenKoltuklar.Items)
            {
                TxtSecilenKoltuklar.Text += "," + item;
            }
            if (TxtSecilenKoltuklar.Text.Length > 1)
            {
                TxtSecilenKoltuklar.Text = TxtSecilenKoltuklar.Text.Substring(1);
            }
        }
        void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.ForeColor == Color.Black)
            {
                MessageBox.Show("Bu koltuk doludur.", "UYARI", MessageBoxButtons.OK);
            }
            else
            {
                if (btn.ForeColor == Color.White)
                {
                    btn.ForeColor = Color.DarkBlue;
                    btn.Image = new Bitmap(Image.FromFile("C:\\Users\\nuray\\OneDrive\\Pictures\\Screenshots\\resimler\\sari_koltuk.png"), new Size(58, 38));
                    listBelirlenenKoltuklar.Items.Add(btn.Text);
                    secilenKoltukNo();
                }
                else
                {
                    btn.ForeColor = Color.White;
                    btn.Image = new Bitmap(Image.FromFile("C:\\Users\\nuray\\OneDrive\\Pictures\\Screenshots\\resimler\\mavi_koltuk.png"), new Size(58, 38));
                    listBelirlenenKoltuklar.Items.Remove(btn.Text);
                    secilenKoltukNo();
                }
            }
        }
    }
}

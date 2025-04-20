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
    public partial class FrmSalonAtama : Form
    {
        public FrmSalonAtama()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source= LAPTOP-QL9SNOH8\\SQLEXPRESS; Initial Catalog = Sinema;Integrated Security= True");
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmSalonAtama_Load(object sender, EventArgs e)
        {
            bugununTarihi();
            FilmAdiGetir();
            SalonAdiGetir();
        }
        void bugununTarihi()
        {
            NmrcGun.Value = DateTime.Today.Day;
            NmrcAy.Value = DateTime.Today.Month;
            NmrcYil.Value = DateTime.Today.Year;
        }
        void FilmAdiGetir()
        {
            string sorgu = "select * from TblFilmler order by filmAdi asc";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                string gelenTarih = dr["filmVizyonTarihi"].ToString();
                DateTime bugun = DateTime.Today;
                DateTime fTarih = Convert.ToDateTime(gelenTarih);
                TimeSpan timeSpan = fTarih - bugun;
                if (timeSpan.TotalDays <= 0)
                {
                    cbFilmAdi.Items.Add(dr["filmAdi"].ToString());
                }
            }
            baglanti.Close();

        }
        void SalonAdiGetir()
        {
            string sorgu = "select * from TblSalonlar order by salonAd asc";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                    cbSalonAdi.Items.Add(dr["SalonAd"].ToString());
            }
            baglanti.Close();

        }

        private void BtnOlustur_Click(object sender, EventArgs e)
        {
            if (BtnOlustur.Text == "Tamamla")
            {
                string sorgu = "select distinct saat from TblKontrol where tarih = @tarih and salonNo = @salonNo";
                string tarih = NmrcGun.Value.ToString("00") + "-" + NmrcAy.Value.ToString("00") + "-" + NmrcYil.Value.ToString("0000");
                baglanti.Open();
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@tarih", tarih);
                komut.Parameters.AddWithValue("@salonNo", cbSalonAdi.Text.ToString());
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    cbDoluSaatler.Items.Add(dr["saat"].ToString());
                }
                dr.Close();
                baglanti.Close();
                SeansKontrol();

                BtnOlustur.Text = "Oluştur";
                BtnOlustur.BackColor = Color.Gold;
            }
            else
            {
                kaydet();
                Temizle();
                BtnOlustur.Text = "Tamamla";
                BtnOlustur.BackColor = Color.FromArgb(101, 107, 131);
            }
        }
        void kaydet()
        {
            string tarih = NmrcGun.Value.ToString("00") + "-" + NmrcAy.Value.ToString("00") + "-" + NmrcYil.Value.ToString("0000");
            baglanti.Open();
            string sorgu = "insert into TblKontrol (filmAdi, tarih, saat, salonNO) values (@p1, @p2, @p3, @p4)";
            SqlCommand kaydet = new SqlCommand(sorgu, baglanti);
            kaydet.Parameters.AddWithValue("@p1",cbFilmAdi.Text);
            kaydet.Parameters.AddWithValue("@p2", tarih);
            kaydet.Parameters.AddWithValue("@p3", lblSecilenSaat.Text);
            kaydet.Parameters.AddWithValue("@p4", cbSalonAdi.Text);
            kaydet.ExecuteNonQuery();
            MessageBox.Show("Salon atama işlemi başarılı bir şekilde gerçekleşti.", "BİLGİ", MessageBoxButtons.OK);

            baglanti.Close();
        }
        void SeansSaatler(object sender, EventArgs e )
        {
            foreach (RadioButton item in panelFilmSaati.Controls)
            {
                if (item.Checked)
                {
                    lblSecilenSaat.Text = item.Text;
                }
            }
        }

        void SeansKontrol()
        {
            panelFilmSaati.Controls.Clear();

            for (int i = 10; i < 23; i++)
            {
                for (int j = 0; j < 30; j += 30)
                {
                    RadioButton rnd = new RadioButton();
                    rnd.ForeColor = Color.Gold;
                    rnd.CheckedChanged += new EventHandler(SeansSaatler);
                    if (j == 0)
                    {
                        rnd.Text = i.ToString() + ":" + j.ToString() + "0";
                    }
                    else
                    {
                        rnd.Text = i.ToString() + ":" + j.ToString();
                    }
                    if (cbDoluSaatler.Items.Contains(rnd.Text))
                    {
                        rnd.Visible = false;
                    }
                    panelFilmSaati.Controls.Add(rnd);
                }
            }
        }

        void Temizle()
        {
            cbDoluSaatler.Items.Clear();
            cbFilmAdi.Items.Clear();
            cbSalonAdi.Items.Clear();
            lblSecilenSaat.Text = "";
            panelFilmSaati.Controls.Clear();
            bugununTarihi();
            FilmAdiGetir();
            SalonAdiGetir();
        }
    }
}

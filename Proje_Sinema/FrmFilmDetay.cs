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
    public partial class FrmFilmDetay : Form
    {
        public FrmFilmDetay()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source= LAPTOP-QL9SNOH8\\SQLEXPRESS; Initial Catalog = Sinema;Integrated Security= True");
        private void BtnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public short filmIdNo;
        string oyuncular = "";
        private void FrmFilmDetay_Load(object sender, EventArgs e)
        {
            //baglanti.Open();
            //string sorgu = "select * from TblFilmler where filmID = @p1";
            //SqlCommand komut = new SqlCommand(sorgu, baglanti);
            //komut.Parameters.AddWithValue("@p1", filmIdNo);
            //SqlDataReader dr = komut.ExecuteReader();
            //if (dr.Read())
            //{
            //    lblFilmAdi.Text = dr["filmAdi"].ToString();
            //    lblFilmDurumu.Text = dr["filmDurum"].ToString();
            //    lblFilmOyunculari.Text = dr["filmOyunculari"].ToString();
            //    lblFilmOzellikleri.Text = dr["filmOzellikleri"].ToString();
            //    lblFilmTuru.Text = dr["filmTurleri"].ToString();
            //    LblFilmBicimi.Text = dr["filmBicimleri"].ToString();
            //    LblFilmYonetmenleri.Text = dr["filmYonetmenleri"].ToString();
            //    LblFilmVizyonTarihi.Text = dr["filmVizyonTarihi"].ToString();
            //    lblFilmPuanı.Text = dr["filmPuani"].ToString();
            //    lblFilmDetayi.Text = dr["filmDetayi"].ToString();
            //    PcResim.ImageLocation = dr["filmAfisi"].ToString();
            //    }

            //    baglanti.Close();
            //    if (lblFilmDurumu.Text == "1")
            //    {
            //        lblFilmDurumu.Text = "Film Vizyonda!";
            //    }
            //    else
            //    {
            //        lblFilmDurumu.Text = "Film Vizyona Girecek!";
            //    }
            baglanti.Open();
            string sorgu = "SELECT * FROM TblFilmler WHERE filmID = @p1";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@p1", filmIdNo);
            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                lblFilmAdi.Text = dr["filmAdi"].ToString();
                lblFilmDurumu.Text = dr["filmDurum"].ToString();
                lblFilmOyunculari.Text = FormatList(dr["filmOyunculari"].ToString());
                lblFilmOzellikleri.Text = dr["filmOzellikleri"].ToString();
                lblFilmTuru.Text = dr["filmTurleri"].ToString();
                LblFilmBicimi.Text = dr["filmBicimleri"].ToString();
                LblFilmYonetmenleri.Text = FormatList(dr["filmYonetmenleri"].ToString());
                LblFilmVizyonTarihi.Text = dr["filmVizyonTarihi"].ToString();
                lblFilmPuanı.Text = dr["filmPuani"].ToString();
                lblFilmDetayi.Text = dr["filmDetayi"].ToString();
                PcResim.ImageLocation = dr["filmAfisi"].ToString();
            }
            baglanti.Close();
            if (lblFilmDurumu.Text == "1")
            {
                lblFilmDurumu.Text = "Film Vizyonda!";
            }
            else
            {
                lblFilmDurumu.Text = "Film Vizyona Girecek!";
            }
        }
        private string FormatList(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return "Bilinmiyor";

            return string.Join(", ", input
                .Split(',')                  
                .Select(s => s.Trim())         
                .Where(s => !string.IsNullOrEmpty(s)));
        }

    }
}

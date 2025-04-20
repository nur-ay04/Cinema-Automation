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

namespace Proje_Sinema
{
    public partial class FrmYonetmenListesi : Form
    {
        public FrmYonetmenListesi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source= LAPTOP-QL9SNOH8\\SQLEXPRESS; Initial Catalog = Sinema;Integrated Security= True");
        private void FrmYonetmenListesi_Load(object sender, EventArgs e)
        {
            ListePaneli.Controls.Clear();
            baglanti.Open();
            string sorgu = "select * from TblYonetmenler order by yonetmenAdSoyad asc";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                YonetmenListesi arac = new YonetmenListesi();
                arac.LblId.Text = dr["yonetmenID"].ToString();
                arac.LblAdSoyad.Text = dr["yonetmenAdSoyad"].ToString();
                arac.pctrResim.ImageLocation = dr["yonetmenResim"].ToString();
                arac.LblCinsiyet.Text = dr["yonetmenCinsiyet"].ToString();
                ListePaneli.Controls.Add(arac);
            }

            baglanti.Close();
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtAramaYap_TextChanged(object sender, EventArgs e)
        {
            ListePaneli.Controls.Clear();
            baglanti.Open();
            string sorgu = "select * from TblYonetmenler where yonetmenAdSoyad Like @arama order by yonetmenAdSoyad asc";
            SqlCommand ara = new SqlCommand(sorgu, baglanti);
            ara.Parameters.AddWithValue("@arama", "%" + TxtAramaYap.Text + "%");
            SqlDataReader dr = ara.ExecuteReader();
            while (dr.Read())
            {
                YonetmenListesi arac = new YonetmenListesi();
                arac.LblId.Text = dr["yonetmenID"].ToString();
                arac.LblAdSoyad.Text = dr["yonetmenAdSoyad"].ToString();
                arac.pctrResim.ImageLocation = dr["yonetmenResim"].ToString();
                arac.LblCinsiyet.Text = dr["yonetmenCinsiyet"].ToString();
                ListePaneli.Controls.Add(arac);
            }

            baglanti.Close();
        }

    }
}

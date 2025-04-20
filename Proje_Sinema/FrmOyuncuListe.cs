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
using System.Data.SqlClient;

namespace Proje_Sinema
{
    public partial class FrmOyuncuListe : Form
    {
        public FrmOyuncuListe()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source= LAPTOP-QL9SNOH8\\SQLEXPRESS; Initial Catalog = Sinema;Integrated Security= True");
        private void BtnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtAramaYap_TextChanged(object sender, EventArgs e)
        {
            ListePaneli.Controls.Clear();
            baglanti.Open();
            string sorgu = "select * from TblOyuncular where oyuncuAdSoyad Like @arama order by oyuncuAdSoyad asc";
            SqlCommand ara = new SqlCommand(sorgu, baglanti);
            ara.Parameters.AddWithValue("@arama", "%" + TxtAramaYap.Text + "%");
            SqlDataReader dr = ara.ExecuteReader();
            while (dr.Read())
            {
                OyuncuListesi arac = new OyuncuListesi();
                arac.LblId.Text = dr["oyuncuID"].ToString();
                arac.LblAdSoyad.Text = dr["oyuncuAdSoyad"].ToString();
                arac.pctrResim.ImageLocation = dr["oyuncuResim"].ToString();
                arac.LblCinsiyet.Text = dr["oyuncuCinsiyet"].ToString();
                ListePaneli.Controls.Add(arac);
            }

            baglanti.Close();
        }

        private void FrmOgrenciListe_Load(object sender, EventArgs e)
        {
            ListePaneli.Controls.Clear();
            baglanti.Open();
            string sorgu = "select * from Tbloyuncular order by oyuncuAdSoyad asc";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                OyuncuListesi arac = new OyuncuListesi();
                arac.LblId.Text = dr["oyuncuID"].ToString();
                arac.LblAdSoyad.Text = dr["oyuncuAdSoyad"].ToString();
                arac.pctrResim.ImageLocation = dr["oyuncuResim"].ToString();
                arac.LblCinsiyet.Text = dr["oyuncuCinsiyet"].ToString();
                ListePaneli.Controls.Add(arac);
            }

            baglanti.Close();
            TxtAramaYap.Focus();
        }
    }
}

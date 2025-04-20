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
    public partial class FrmFilmListesi : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source= LAPTOP-QL9SNOH8\\SQLEXPRESS; Initial Catalog = Sinema;Integrated Security= True");
        public FrmFilmListesi()
        {
            InitializeComponent();
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FrmFilmListesi_Load(object sender, EventArgs e)
        {
               {
                ListePaneli.Controls.Clear();
                baglanti.Open();
                string sorgu = "select * from TblFilmler order by filmAdi asc";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    FilmListesi arac = new FilmListesi();
                    arac.lblFilmAdi.Text = dr["filmAdi"].ToString();
                    arac.PcResim.ImageLocation = dr["filmAfisi"].ToString();
                    arac.lblNo.Text = dr["filmID"].ToString();
                    ListePaneli.Controls.Add(arac);
                }
                baglanti.Close();
            }
        }

        private void TxtAramaYap_TextChanged(object sender, EventArgs e)
        {
            ListePaneli.Controls.Clear();
            baglanti.Open();
            string sorgu = "select * from TblFilmler where filmAdi Like @arama order by filmAdi asc";
            SqlCommand ara = new SqlCommand(sorgu, baglanti);
            ara.Parameters.AddWithValue("@arama", "%" + TxtAramaYap.Text + "%");
            SqlDataReader dr = ara.ExecuteReader();
            while (dr.Read())
            {
                FilmListesi arac = new FilmListesi();
                arac.lblFilmAdi.Text = dr["filmAdi"].ToString();
                arac.PcResim.ImageLocation = dr["filmAfisi"].ToString();
                arac.lblNo.Text = dr["filmID"].ToString();
                ListePaneli.Controls.Add(arac);
            }

            baglanti.Close();
        }
    }
}

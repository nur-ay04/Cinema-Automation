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
    public partial class YonetmenListesi : UserControl
    {
        public YonetmenListesi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source= LAPTOP-QL9SNOH8\\SQLEXPRESS; Initial Catalog = Sinema;Integrated Security= True");
        private void YonetmenListesi_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = "select * from TblYonetmenler where yonetmenID = @p1";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@p1", LblId.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if(LblCinsiyet.Text == "Erkek")
            {
                pctrCinsiyet.ImageLocation = "C:\\Users\\nuray\\OneDrive\\Pictures\\Screenshots\\resimler\\erkek_sembolu.png";
            }
            else
            {
                pctrCinsiyet.ImageLocation = "C:\\Users\\nuray\\OneDrive\\Pictures\\Screenshots\\resimler\\kadin_sembolu.png";
            }

            baglanti.Close();
        }


        private void BtnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sil = new SqlCommand("delete from TblYonetmenler where yonetmenID = @p1", baglanti);
            sil.Parameters.AddWithValue("@p1", LblId.Text);
            sil.ExecuteNonQuery();
            MessageBox.Show(LblAdSoyad.Text + " kişisi başarılı bir şekilde silindi.","Silme İşlemi",MessageBoxButtons.OK, MessageBoxIcon.Stop);
            this.Hide();
            baglanti.Close();
        }

        private void BtnDetay_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = "select * from TblYonetmenler where yonetmenID = @p1";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@p1", LblId.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Biyografi: " +dr["yonetmenBio"].ToString(),dr["yonetmenAdSoyad"].ToString(), MessageBoxButtons.OK);
            }
            baglanti.Close();
        }
    }
}

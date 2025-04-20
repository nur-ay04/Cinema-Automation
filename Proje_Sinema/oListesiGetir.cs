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
    public partial class oListesiGetir : UserControl
    {
        public oListesiGetir()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source= LAPTOP-QL9SNOH8\\SQLEXPRESS; Initial Catalog = Sinema;Integrated Security= True");
        private void LblOyuncuAdi_Click(object sender, EventArgs e)
        {
            if (LblOyuncuAdi.ForeColor == Color.FromArgb(101, 107, 131))
            {
                LblOyuncuAdi.ForeColor = Color.Gold;
                pictureBox1.ImageLocation = "C:\\Users\\nuray\\OneDrive\\Pictures\\Screenshots\\resimler\\sari_ekleme_ikonu.png";
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into TblSecilenler (secilenKisi, secilenTur) values (@kisi, @tur)", baglanti);
                komut.Parameters.AddWithValue("@kisi", LblOyuncuAdi.Text);
                komut.Parameters.AddWithValue("@tur", "OYUNCU");
                komut.ExecuteNonQuery();
                baglanti.Close();

            }
            else
            {
                LblOyuncuAdi.ForeColor = Color.FromArgb(101, 107, 131); ;
                pictureBox1.ImageLocation = "C:\\Users\\nuray\\OneDrive\\Pictures\\Screenshots\\resimler\\ekleme_ikonu.png";
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from TblSecilenler where @kisi= secilenKisi and @tur= secilenTur", baglanti);
                komut.Parameters.AddWithValue("@kisi", LblOyuncuAdi.Text);
                komut.Parameters.AddWithValue("@tur", "OYUNCU");
                komut.ExecuteNonQuery();
                baglanti.Close();
            }

        }

        private void LblOyuncuAdi_MouseMove(object sender, MouseEventArgs e)
        {
            LblOyuncuAdi.Font = new Font(LblOyuncuAdi.Font, LblOyuncuAdi.Font.Style | FontStyle.Underline);
        }

        private void LblOyuncuAdi_MouseLeave(object sender, EventArgs e)
        {
            LblOyuncuAdi.Font = new Font(LblOyuncuAdi.Font, LblOyuncuAdi.Font.Style & ~FontStyle.Underline);
        }

        private void oListesiGetir_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from TblSecilenler where @kisi = secilenKisi and @tur = secilenTur", baglanti);
            komut.Parameters.AddWithValue("@kisi", LblOyuncuAdi.Text);
            komut.Parameters.AddWithValue("@tur", "OYUNCU");
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {

                LblOyuncuAdi.ForeColor = Color.Gold;
                pictureBox1.ImageLocation = "C:\\Users\\nuray\\OneDrive\\Pictures\\Screenshots\\resimler\\sari_ekleme_ikonu.png";
            }
            else
            {
                LblOyuncuAdi.ForeColor = Color.FromArgb(101, 107, 131); ;
                pictureBox1.ImageLocation = "C:\\Users\\nuray\\OneDrive\\Pictures\\Screenshots\\resimler\\ekleme_ikonu.png";
            }
            baglanti.Close();
        }
    }
}

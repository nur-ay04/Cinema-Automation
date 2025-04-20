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
    public partial class yListesiGetir : UserControl
    {
        public yListesiGetir()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source= LAPTOP-QL9SNOH8\\SQLEXPRESS; Initial Catalog = Sinema;Integrated Security= True");
        private void LblYonetmenAdi_Click(object sender, EventArgs e)
        {
            if(LblYonetmenAdi.ForeColor == Color.FromArgb(101, 107, 131))
            {
                LblYonetmenAdi.ForeColor = Color.Gold;
                pictureBox1.ImageLocation ="C:\\Users\\nuray\\OneDrive\\Pictures\\Screenshots\\resimler\\sari_ekleme_ikonu.png";

                baglanti.Open();
                SqlCommand komut = new SqlCommand("Insert into TblSecilenler (secilenKisi, secilenTur) values (@kisi, @tur)", baglanti);
                komut.Parameters.AddWithValue("@kisi",LblYonetmenAdi.Text);
                komut.Parameters.AddWithValue("@tur", "Yönetmen");
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            else
            {
                LblYonetmenAdi.ForeColor = Color.FromArgb(101, 107, 131); ;
                pictureBox1.ImageLocation = "C:\\Users\\nuray\\OneDrive\\Pictures\\Screenshots\\resimler\\ekleme_ikonu.png";
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from TblSecilenler where secilenKisi= @kisi and secilenTur= @tur", baglanti);
                komut.Parameters.AddWithValue("@kisi", LblYonetmenAdi.Text);
                komut.Parameters.AddWithValue("@tur", "Yönetmen");
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
        }

        private void LblYonetmenAdi_MouseMove(object sender, MouseEventArgs e)
        {
            LblYonetmenAdi.Font = new Font(LblYonetmenAdi.Font, LblYonetmenAdi.Font.Style | FontStyle.Underline);
        }

        private void LblYonetmenAdi_MouseLeave(object sender, EventArgs e)
        {
            LblYonetmenAdi.Font = new Font(LblYonetmenAdi.Font, LblYonetmenAdi.Font.Style & ~FontStyle.Underline);
        }

        private void yListesiGetir_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from TblSecilenler where @kisi=secilenKisi and @tur= secilenTur", baglanti);
            komut.Parameters.AddWithValue("@kisi", LblYonetmenAdi.Text);
            komut.Parameters.AddWithValue("@tur", "YÖNETMEN");
            SqlDataReader dr = komut.ExecuteReader();
            if(dr.Read())
            {
                LblYonetmenAdi.ForeColor = Color.Gold;
                pictureBox1.ImageLocation = "C:\\Users\\nuray\\OneDrive\\Pictures\\Screenshots\\resimler\\sari_ekleme_ikonu.png";

            }
            else
            {

                LblYonetmenAdi.ForeColor = Color.FromArgb(101, 107, 131); ;
                pictureBox1.ImageLocation = "C:\\Users\\nuray\\OneDrive\\Pictures\\Screenshots\\resimler\\ekleme_ikonu.png";
            }
            baglanti.Close();
        }
    }
}

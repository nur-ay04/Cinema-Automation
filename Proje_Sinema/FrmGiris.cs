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
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source= LAPTOP-QL9SNOH8\\SQLEXPRESS; Initial Catalog = Sinema;Integrated Security= True");
        private void BtnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            //baglanti.Open();
            //if(baglanti.State == ConnectionState.Open)
            //{
            //    MessageBox.Show("bağlantı başarılı.");
            //}
            //baglanti.Close();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SElect * from TblKullanicilar where AD = @p1 and KullaniciSifre = @p2", baglanti);
            komut.Parameters.AddWithValue("@p1", TxtKullanici.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
            SqlDataReader oku = komut.ExecuteReader();

            if (oku.Read())
            {
                FrmAnaform frm = new FrmAnaform();
                frm.Show();
                MessageBox.Show("adınız: " + oku["KullaniciFulName"]);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adınız veya şifreniz yanlış", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            baglanti.Close();

            TxtKullanici.Text = "";
            TxtSifre.Text = "";
            TxtKullanici.Focus();

        }

        private void FrmGiris_Load(object sender, EventArgs e)
        {

        }
    }
}

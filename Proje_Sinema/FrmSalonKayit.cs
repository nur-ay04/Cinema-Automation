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
    public partial class FrmSalonKayit : Form
    {
        public FrmSalonKayit()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source= LAPTOP-QL9SNOH8\\SQLEXPRESS; Initial Catalog = Sinema;Integrated Security= True");
        private void BtnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            if (TxtSalonAd.Text != "" && cbKoltukSayisi.Text != "")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into TblSalonlar (salonAd, salonKoltukSayisi)values(@p1, @p2)", baglanti);
                komut.Parameters.AddWithValue("@p1", TxtSalonAd.Text.ToUpper());
                komut.Parameters.AddWithValue("@p2", cbKoltukSayisi.Text.ToUpper());
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Salon başarılı bir şekilde kaydedildi.", "BİLGİ", MessageBoxButtons.OK);
                TxtSalonAd.Text = "";
                cbKoltukSayisi.Text = "";
                TxtSalonAd.Focus();
                listele();
            }
            else
            {
                MessageBox.Show("Lütfen tüm yerleri doldurduğunuzdan emin olunuz!", "UYARI", MessageBoxButtons.OK);
            }

        }

        private void FrmSalonKayit_Load(object sender, EventArgs e)
        {
            listele();
            koltukSayisi();
        }
        void listele()
        {
            PnlSalon.Controls.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from TblSalonlar order by salonAd asc", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                SalonListesi arac = new SalonListesi();
                arac.label1.Text = dr["salonAD"].ToString();
                arac.LblKoltukSayisi.Text = dr["salonKoltukSayisi"].ToString();
                PnlSalon.Controls.Add(arac);
            }
            baglanti.Close();
        }
        void koltukSayisi()
        {
            for(int i = 100; i<999; i+=100)
            {
                cbKoltukSayisi.Items.Add(i);
            }
        }
    }
}

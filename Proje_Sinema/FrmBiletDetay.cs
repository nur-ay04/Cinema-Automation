using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;

namespace Proje_Sinema
{
    public partial class FrmBiletDetay : Form
    {
        public FrmBiletDetay()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source= LAPTOP-QL9SNOH8\\SQLEXPRESS; Initial Catalog = Sinema;Integrated Security= True");
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string biletNo = "";
        public string biletNo2 = "";
        public Bitmap barkodResmi;

        public void BiletDetay()
        {
            baglanti.Open();
            string sorgu = "select * from TblBiletler where biletKodu = @biletkodu";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@biletkodu",biletNo);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read()) 
            {
                lblAdSoyad.Text = dr["adSoyad"].ToString();
                lblTelNo.Text = dr["telNo"].ToString();
                lblKoltukNo.Text = dr["koltukNo"].ToString();
                labelKoltukNo.Text = dr["koltukNo"].ToString();
                lblFilmAdi.Text = dr["filmAdı"].ToString();
                labelFilmAdi.Text = dr["filmAdı"].ToString();
                lblSalonAdi.Text = dr["salon"].ToString();
                LblSalonNo.Text = dr["salon"].ToString();
                lblBiletTuru.Text = dr["tur"].ToString();
                LblİslemSaati.Text = dr["islemSaati"].ToString();
                lblTarih.Text = dr["tarih"].ToString() + " " + dr["saat"].ToString();
                lblTarihSaat.Text = dr["tarih"].ToString() + " " + dr["saat"].ToString();
            }
            dr.Close();
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        private void FrmBiletDetay_Load(object sender, EventArgs e)
        {
            lblBiletNo.Text = biletNo;
            lblBiletNo2.Text = biletNo2;
            lblBarkod.Text = biletNo;  
            pcBarkod.Image = barkodResmi; 
            pcBarkod2.Image = barkodResmi;
            BiletDetay();

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

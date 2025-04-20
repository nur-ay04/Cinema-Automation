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
using ZXing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proje_Sinema
{
    public partial class FrmBiletSorgula : Form
    {
        public FrmBiletSorgula()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source= LAPTOP-QL9SNOH8\\SQLEXPRESS; Initial Catalog = Sinema;Integrated Security= True");
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmBiletSorgula_Load(object sender, EventArgs e)
        {
            TxtBiletNo.Select();
        }
        private void BtnSorgula_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtBiletNo.Text))
            {
                MessageBox.Show("Lütfen bir bilet numarası girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            baglanti.Open();
            string sorgu = "select biletKodu from TblBiletler where biletKodu = @biletkodu";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@biletKodu",TxtBiletNo.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read()) 
            {
                BarcodeWriter barkodYazici = new BarcodeWriter
                {
                    Format = BarcodeFormat.CODE_128, // Barkod formatı
                    Options = new ZXing.Common.EncodingOptions
                    {
                        Width = 146,
                        Height = 85
                    }
                };
                Bitmap barkodGoruntu = barkodYazici.Write(TxtBiletNo.Text);
                FrmBiletDetay frm = new FrmBiletDetay();
                frm.biletNo = TxtBiletNo.Text;
                frm.biletNo2 = TxtBiletNo.Text;
                frm.barkodResmi = barkodGoruntu;
                frm.ShowDialog();
                TxtBiletNo.Text = "";
            }
            else
            {
                MessageBox.Show("Bilet numarası bulunamadı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            baglanti.Close();

        }
    }
}

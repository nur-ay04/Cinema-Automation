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
    public partial class FrmAnaform : Form
    {
        public FrmAnaform()
        {
            InitializeComponent();
        }
       // SqlConnection baglanti = new SqlConnection("Data Source= LAPTOP-QL9SNOH8\\SQLEXPRESS; Initial Catalog = Sinema;Integrated Security= True");
        private void BtnYonetmenKayit_Click(object sender, EventArgs e)
        {
            FrmYonetmenKayit frm = new FrmYonetmenKayit();
            frm.ShowDialog();
        }

        private void BtnCikis_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmAnaform_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmYonetmenListesi frm = new FrmYonetmenListesi();
            frm.ShowDialog();
        }

        private void BtnOyuncuKayit_Click(object sender, EventArgs e)
        {
            FrmOyuncuKayit frm = new FrmOyuncuKayit();
            frm.ShowDialog();
        }

        private void BtnOyuncuListe_Click(object sender, EventArgs e)
        {
            FrmOyuncuListe frm = new FrmOyuncuListe();
            frm.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            FrmSalonKayit frm = new FrmSalonKayit();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmFilmKayit frm = new FrmFilmKayit();
            frm.ShowDialog();
        }
        private void BtnFilmListesi_Click(object sender, EventArgs e)
        {
            FrmFilmListesi frm = new FrmFilmListesi();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmBiletOlustur frm = new FrmBiletOlustur();
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmBiletSorgula frm = new FrmBiletSorgula();
            frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmSalonAtama frm = new FrmSalonAtama();
            frm.ShowDialog();
        }
    }
}

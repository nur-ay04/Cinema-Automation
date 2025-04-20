using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Sinema
{
    public partial class SalonListesi : UserControl
    {
        public SalonListesi()
        {
            InitializeComponent();
        }


        private void gel(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.LightGray;
        }

        private void ayril(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control;
        }
    }
}

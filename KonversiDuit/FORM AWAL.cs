using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KonversiDuit
{
    public partial class FORM_AWAL : MaterialSkin.Controls.MaterialForm
    {
        public FORM_AWAL()
        {
            InitializeComponent();
        }

        private void FORM_AWAL_Load(object sender, EventArgs e)
        {

        }

        private void materialFlatButton4_Click(object sender, EventArgs e)
        {
            Form1 konversi = new Form1();
            konversi.Show();

        }

        private void materialFlatButton5_Click(object sender, EventArgs e)
        {
            about tentang = new about();
            tentang.Show();
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            info infouang = new info();
            infouang.Show();
        }
    }
}

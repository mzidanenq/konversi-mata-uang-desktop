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
    public partial class info : MaterialSkin.Controls.MaterialForm
    {
        public info()
        {
            InitializeComponent();
        }

        private void info_Load(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
                this.chart1.Series["IDR"].Points.Clear();
                this.chart1.Series["IDR"].Points.AddXY("2017", 0.0000740263);

     
                
        }

        private void materialFlatButton4_Click(object sender, EventArgs e)
        {
            this.chart1.Series["USD"].Points.Clear();
            this.chart1.Series["USD"].Points.AddXY("2017", 1);

        }

        private void materialFlatButton5_Click(object sender, EventArgs e)
        {
            this.chart1.Series["EUR"].Points.Clear();
            this.chart1.Series["EUR"].Points.AddXY("2017", 1.16);

        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            this.chart1.Series["USD"].Points.Clear();
            this.chart1.Series["IDR"].Points.Clear();
            this.chart1.Series["EUR"].Points.Clear();
            this.chart1.Series["JPY"].Points.Clear();
            this.chart1.Series["CNY"].Points.Clear();
            this.chart1.Series["GBP"].Points.Clear();
            this.chart1.Series["MYR"].Points.Clear();
            this.chart1.Series["AUD"].Points.Clear();
            this.chart1.Series["PHP"].Points.Clear();
            this.chart1.Series["VND"].Points.Clear();
            this.chart1.Series["SAR"].Points.Clear();
            this.chart1.Series["CZK"].Points.Clear();
            this.chart1.Series["SGD"].Points.Clear();
            this.chart1.Series["ZAR"].Points.Clear();
            this.chart1.Series["RUB"].Points.Clear();
            this.chart1.Series["ZWD"].Points.Clear();
            this.chart1.Series["BTC"].Points.Clear();
            this.chart1.Series["HKD"].Points.Clear();
            this.chart1.Series["THB"].Points.Clear();



        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            this.chart1.Series["JPY"].Points.Clear();
            this.chart1.Series["JPY"].Points.AddXY("2017", 0.00897357);
        }

        private void materialFlatButton6_Click(object sender, EventArgs e)
        {
            this.chart1.Series["CNY"].Points.Clear();
            this.chart1.Series["CNY"].Points.AddXY("2017", 0.151759); 
        }

        private void materialFlatButton7_Click(object sender, EventArgs e)
        {
            this.chart1.Series["GBP"].Points.Clear();
            this.chart1.Series["GBP"].Points.AddXY("2017", 1.32919);
        }

        private void materialFlatButton14_Click(object sender, EventArgs e)
        {
            this.chart1.Series["MYR"].Points.Clear();
            this.chart1.Series["MYR"].Points.AddXY("2017", 0.242801);
        }

        private void materialFlatButton18_Click(object sender, EventArgs e)
        {
            this.chart1.Series["AUD"].Points.Clear();
            this.chart1.Series["AUD"].Points.AddXY("2017", 0.762477);
        }

        private void materialFlatButton16_Click(object sender, EventArgs e)
        {
            this.chart1.Series["PHP"].Points.Clear();
            this.chart1.Series["PHP"].Points.AddXY("2017", 0.0197160);
        }

        private void materialFlatButton20_Click(object sender, EventArgs e)
        {
            this.chart1.Series["VND"].Points.Clear();
            this.chart1.Series["VND"].Points.AddXY("2017", 0.0000439848);
        }

        private void materialFlatButton13_Click(object sender, EventArgs e)
        {
            this.chart1.Series["SAR"].Points.Clear();
            this.chart1.Series["SAR"].Points.AddXY("2017", 0.266647);
        }

        private void materialFlatButton12_Click(object sender, EventArgs e)
        {
            this.chart1.Series["CZK"].Points.Clear();
            this.chart1.Series["CZK"].Points.AddXY("2017", 0.0466200);
        }

        private void materialFlatButton11_Click(object sender, EventArgs e)
        {
            this.chart1.Series["SGD"].Points.Clear();
            this.chart1.Series["SGD"].Points.AddXY("2017", 0.742840);
        }

        private void materialFlatButton10_Click(object sender, EventArgs e)
        {
            this.chart1.Series["ZAR"].Points.Clear();
            this.chart1.Series["ZAR"].Points.AddXY("2017", 0.0719288);
        }

        private void materialFlatButton9_Click(object sender, EventArgs e)
        {
            this.chart1.Series["RUB"].Points.Clear();
            this.chart1.Series["RUB"].Points.AddXY("2017", 0.0171013);
        }

        private void materialFlatButton8_Click(object sender, EventArgs e)
        {
            this.chart1.Series["ZWD"].Points.Clear();
            this.chart1.Series["ZWD"].Points.AddXY("2017", 0.00276319);
        }

        private void materialFlatButton15_Click(object sender, EventArgs e)
        {
            this.chart1.Series["BTC"].Points.Clear();
            this.chart1.Series["BTC"].Points.AddXY("2017", 8080.31);
        }

        private void materialFlatButton17_Click(object sender, EventArgs e)
        {
            this.chart1.Series["HKD"].Points.Clear();
            this.chart1.Series["HKD"].Points.AddXY("2017", 0.128049);
        }

        private void materialFlatButton19_Click(object sender, EventArgs e)
        {
            this.chart1.Series["THB"].Points.Clear();
            this.chart1.Series["THB"].Points.AddXY("2017", 0.151759);
        }
    }
}

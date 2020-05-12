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
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {


        public Form1()
        {
            InitializeComponent();
            // all refer to USD
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            double c1 = 0;
            double c2 = 0;
            double harga1;
            double harga2;
            if (double.TryParse(textBox1.Text, out harga1));
            if (double.TryParse(textBox2.Text, out harga2)) ;


            if (comboBox1.SelectedIndex == 1)
            {
                c1 = 13500;
            }

            else if (comboBox1.SelectedIndex == 0)
            {
                c1 = 1;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                c1 = 0.8;
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                c1 = 111.29;
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                c1 = 6.57;
            }
            else if (comboBox1.SelectedIndex == 5)
            {
                c1 = 0.75;
            }
            else if (comboBox1.SelectedIndex == 6)
            {
                c1 = 4.11;
            }
            else if (comboBox1.SelectedIndex == 7)
            {
                c1 = 1.31;
            }
            else if (comboBox1.SelectedIndex == 8)
            {
                c1 = 50.66;
            }
            else if (comboBox1.SelectedIndex == 9)
            {
                c1 = 22737.39;
            }
            else if (comboBox1.SelectedIndex == 10)
            {
                c1 = 3.75;
            }
            else if (comboBox1.SelectedIndex == 11)
            {
                c1 = 21.45;
            }
            else if (comboBox1.SelectedIndex == 12)
            {
                c1 = 1.34;
            }
            else if (comboBox1.SelectedIndex == 13)
            {
                c1 = 13.89;
            }
            else if (comboBox1.SelectedIndex == 14)
            {
                c1 = 58.47;
            }
            else if (comboBox1.SelectedIndex == 15)
            {
                c1 = 361.90;
            }
            else if (comboBox1.SelectedIndex == 16)
            {
                c1 = 0.000123689;
            }
            else if (comboBox1.SelectedIndex == 17)
            {
                c1 = 7.81013;
            }
            else if (comboBox1.SelectedIndex == 18)
            {
                c1 = 32.6559;
            }



            if (comboBox2.SelectedIndex == 1)
            {
                c2 = 13500;
            }
            else if (comboBox2.SelectedIndex == 0)
            {
                c2 = 1;
            }
            else if (comboBox2.SelectedIndex == 2)
            {
                c2 = 0.8;
            }
            else if (comboBox2.SelectedIndex == 3)
            {
                c2 = 111.29;
            }
            else if (comboBox2.SelectedIndex == 4)
            {
                c2 = 6.57;
            }
            else if (comboBox2.SelectedIndex == 5)
            {
                c2 = 0.75;
            }
            else if (comboBox2.SelectedIndex == 6)
            {
                c2 = 4.11;
            }
            else if (comboBox2.SelectedIndex == 7)
            {
                c2 = 1.31;
            }
            else if (comboBox2.SelectedIndex == 8)
            {
                c2 = 50.66;
            }
            else if (comboBox2.SelectedIndex == 9)
            {
                c2 = 22737.39;
            }
            else if (comboBox2.SelectedIndex == 10)
            {
                c2 = 3.75;
            }
            else if (comboBox2.SelectedIndex == 11)
            {
                c2 = 21.45;
            }
            else if (comboBox2.SelectedIndex == 12)
            {
                c2 = 1.34;
            }
            else if (comboBox2.SelectedIndex == 13)
            {
                c2 = 13.89;
            }
            else if (comboBox2.SelectedIndex == 14)
            {
                c2 = 58.47;
            }
            else if (comboBox2.SelectedIndex == 15)
            {
                c2 = 361.90;
            }
            else if (comboBox2.SelectedIndex == 16)
            {
                c2 = 0.000123689;
            }
            else if (comboBox2.SelectedIndex == 17)
            {
                c2 = 7.81013;
            }
            else if (comboBox2.SelectedIndex == 18)
            {
                c2 = 32.6559;
            }



            double hasil = (c2 / c1 * harga1);
            textBox2.Text = "" + string.Format("{0:#,###0.########}", hasil);

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
         

        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            String swap;
            int index;
            swap = textBox2.Text;
            textBox2.Text = textBox1.Text;
            textBox1.Text = swap;
            index = comboBox2.SelectedIndex;
            comboBox2.SelectedIndex = comboBox1.SelectedIndex;
            comboBox1.SelectedIndex = index;


        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}

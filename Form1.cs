using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabRab12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

            textBox4.Text = e.X.ToString();
            textBox5.Text = e.Y.ToString();
            double z = Convert.ToDouble(textBox6.Text);
            double d = Convert.ToDouble(textBox7.Text);
            if(e.X == 0)
            {
                textBox8.Text = string.Format("ERROR");
            }
            else
            {
                double A = -d * (z / Math.Sqrt(Math.Abs(e.X))) + Math.Abs(Math.Sin(e.X) + Math.Cos(e.Y));
                textBox8.Text = A.ToString();
            }
            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

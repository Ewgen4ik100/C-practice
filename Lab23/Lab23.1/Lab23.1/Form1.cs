using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab23._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.BackColor == Color.Red)
            {
                button1.BackColor = Color.Blue;
            }
            else
                button1.BackColor = Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.BackColor == Color.Blue)
            {
                button2.BackColor = Color.Red;
            }
            else
                button2.BackColor = Color.Blue;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double x = 6.37;
            double a = 2.56;
            double b = 7.18;
            MessageBox.Show(Convert.ToString((Math.Pow(a+x, 1/3)+ 0.25* Math.Tan(x))/(x-4.87)));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

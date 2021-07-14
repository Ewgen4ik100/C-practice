using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab24._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str1 = textBox1.Text.Replace(" ", "");
            label3.Text = str1;
        }
        string wiw;
        private void button2_Click(object sender, EventArgs e)
        {
            string[] arr1 = textBox2.Text.Split(' ');
            string[] rez = arr1.Distinct().ToArray();
            for (int i = 0; i < rez.Length; i++)
            wiw = String.Join(" ", rez);
            label4.Text = wiw;
        }
    }
}

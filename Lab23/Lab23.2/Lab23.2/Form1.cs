using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab23._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                CheckBox cb = new CheckBox();
                
                if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0)
                {
                    MessageBox.Show("Error: TexBox == null");
                }
                else
                {
                    if (checkBox1.Checked == true)
                    {
                        label3.Text = $"{textBox1.Text} + {textBox2.Text} = {Convert.ToString(Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text))}";
                    }
                    if (checkBox2.Checked == true)
                    {
                        label3.Text = $"{textBox1.Text} - {textBox2.Text} = {Convert.ToString(Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox2.Text))}";
                    }
                    if (checkBox3.Checked == true)
                    {
                        label3.Text = $"{textBox1.Text} : {textBox2.Text} = {Convert.ToString(Convert.ToInt32(textBox1.Text) / Convert.ToInt32(textBox2.Text))}";
                    }
                    if (checkBox4.Checked == true)
                    {
                        label3.Text = $"{textBox1.Text} * {textBox2.Text} = {Convert.ToString(Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox2.Text))}";
                    }
                    if (checkBox5.Checked == true)
                    {
                        label3.Text = $"Корень числа: {textBox1.Text} степени: {textBox2.Text} = {Convert.ToString(Math.Pow(Convert.ToDouble(textBox1.Text), 1 / Convert.ToDouble(textBox2.Text)))}";
                    }
                    if (checkBox6.Checked == true)
                    {
                        label3.Text = $"Квадрат числа: {textBox1.Text} степени: {textBox2.Text} = {Convert.ToString(Math.Pow(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)))}";
                    }
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Error");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox3.Text.Length == 0)
                {
                    MessageBox.Show("Error!");
                }
                else
                {
                    string value_1 = Convert.ToString(Convert.ToInt32(textBox3.Text), 2);
                    string value_2 = Convert.ToString(Convert.ToInt32(textBox3.Text), 8);
                    string value_3 = Convert.ToString(Convert.ToInt32(textBox3.Text), 16);
                    if (checkBox7.Checked == true)
                    {
                        label5.Text = value_1;
                    }
                    if (checkBox8.Checked == true)
                    {
                        label5.Text = value_2;
                    }
                    if (checkBox9.Checked == true)
                    {
                        label5.Text = value_3;
                    }
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Error: Exception!");
            }
        }
    }
}

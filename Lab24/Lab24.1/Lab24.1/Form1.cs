using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab24._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int[,] arr;
        int[,] arr2;
        int n;
        private void button1_Click(object sender, EventArgs e)
        {
            n = Convert.ToInt32(numericUpDown1.Value);
            dataGridView1.RowCount = n;
            dataGridView1.ColumnCount = n;
            for(int i = 0; i < n; i++)
            {
                dataGridView1.Columns[i].Width = 30;
                dataGridView1.Rows[i].Height = 30;
            }
            arr = new int[n, n];
            Random rnd = new Random();
            for(int i = 0; i <n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    arr[i, j] = rnd.Next(-100, 100);
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = arr[i, j];
                }
            }

            dataGridView2.RowCount = n;
            dataGridView2.ColumnCount = n;
            for (int i = 0; i < n; i++)
            {
                dataGridView2.Columns[i].Width = 30;
                dataGridView2.Rows[i].Height = 30;
            }
            arr2 = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr2[i, j] = rnd.Next(-100, 100);
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    dataGridView2.Rows[i].Cells[j].Value = arr2[i, j];
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int[,] arr_rez;
        double opr;
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView3.RowCount = n;
                dataGridView3.ColumnCount = n;
                dataGridView4.RowCount = n;
                dataGridView4.ColumnCount = n;
                for (int i = 0; i < n; i++)
                {
                    dataGridView3.Columns[i].Width = 50;
                    dataGridView3.Rows[i].Height = 30;
                    dataGridView4.Columns[i].Width = 50;
                    dataGridView4.Rows[i].Height = 30;
                }
                if (radioButton1.Checked == true)
                {
                    label4.Text = "+";
                    arr_rez = new int[n, n];
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            arr_rez[i, j] = arr[i, j] + arr2[i, j];
                        }
                    }
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            dataGridView3.Rows[i].Cells[j].Value = arr_rez[i, j];
                        }
                    }
                }
                if (radioButton2.Checked == true)
                {
                    label4.Text = "-";
                    arr_rez = new int[n, n];
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            arr_rez[i, j] = arr[i, j] - arr2[i, j];
                        }
                    }
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            dataGridView3.Rows[i].Cells[j].Value = arr_rez[i, j];
                        }
                    }
                }
                if (radioButton3.Checked == true)
                {
                    label4.Text = "*";
                    arr_rez = new int[n, n];
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            arr_rez[i, j] = arr[i, j] * arr2[i, j];
                        }
                    }
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            dataGridView3.Rows[i].Cells[j].Value = Math.Round(Convert.ToDouble(arr_rez[i, j]));
                        }
                    }
                }
                if (radioButton4.Checked == true)
                {
                    label4.Text = ":";
                    arr_rez = new int[n, n];
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            arr_rez[i, j] = arr[i, j] / arr2[i, j];
                        }
                    }
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            dataGridView3.Rows[i].Cells[j].Value = arr_rez[i, j];
                        }
                    }
                }
                if(radioButton5.Checked == true)
                {
                    label4.Text = null;
                    arr_rez = new int[n, n];
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            arr_rez[i, j] = arr[i, j] * Convert.ToInt32(textBox1.Text);
                        }
                    }
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            dataGridView4.Rows[i].Cells[j].Value = arr_rez[i, j];
                        }
                    }
                }
                if(radioButton6.Checked == true)
                {
                    label6.Text = "Транспонированная матрица:";
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            dataGridView4.Rows[j].Cells[i].Value = arr_rez[i, j];
                        }
                    }
                }
                if(radioButton7.Checked == true)
                {
                    double sum1 = 1;
                    double sum2 = 1;
                    for (int i = 0; i < n; i++)
                    {
                        sum1 *= arr_rez[i, i];
                    }
                    for(int j = n - 1, i = 0; j >= 0; i++, j--)
                    {
                        sum2 *= arr_rez[i, j];
                    }
                    opr = sum1 - sum2;
                    MessageBox.Show(Convert.ToString("Определитель = " + opr));
                }
                if(radioButton8.Checked == true && opr != 0)
                {
                    label6.Text = "Обратная матрица";
                    uint round = 0;
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            double tmp = arr_rez[i, j];
                            arr_rez[i, j] = Convert.ToInt32(round == 0 ? (1 / opr) * opr : Math.Round(((1 / opr) * opr), (int)round, MidpointRounding.ToEven));
                        }
                    }
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            dataGridView4.Rows[j].Cells[i].Value = arr_rez[i, j];
                        }
                    }
                }
                else if(opr == 0)
                {
                    MessageBox.Show("Определитель равен нулю, обратной матрицы не существует!");
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Error");
            }
}
    }
}

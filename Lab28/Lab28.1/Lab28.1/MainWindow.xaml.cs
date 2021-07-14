using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab28._1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        int[,] arr;
        int[,] arr2;
        int n;

        private void bGen_Click(object sender, RoutedEventArgs e)
        {
            n = Convert.ToInt32(tn.Text);
            arr = new int[n, n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = rnd.Next(-100, 100);
                }
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
                    lArrA.Content += arr[i, j] + " ";
                    lArrB.Content += arr2[i, j] + " ";
                }
                lArrA.Content += "\n";
                lArrB.Content += "\n";
            }


        }
        int[,] arr_rez;
        double opr;
        private void bRez_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                if (radioButton1.IsChecked == true)
                {
                    label4.Content = "+";
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
                            lArrRez.Content += arr_rez[i, j]+ " ";
                        }
                        lArrRez.Content += "\n";
                    }
                }
                if (radioButton2.IsChecked == true)
                {
                    label4.Content = "-";
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
                            lArrRez.Content += arr_rez[i, j] + " ";
                        }
                        lArrRez.Content += "\n";
                    }
                }
                if (radioButton3.IsChecked == true)
                {
                    label4.Content = "*";
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
                            lArrRez.Content += arr_rez[i, j] + " ";
                        }
                        lArrRez.Content += "\n";
                    }
                }
                if (radioButton4.IsChecked == true)
                {
                    label4.Content = ":";
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
                            lArrRez.Content += arr_rez[i, j] + " ";
                        }
                        lArrRez.Content += "\n";
                    }
                }
                if (radioButton5.IsChecked == true)
                {
                    label4.Content = null;
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
                            lArrRez.Content += arr_rez[i, j] + " ";
                        }
                        lArrRez.Content += "\n";
                    }
                }
                if (radioButton6.IsChecked == true)
                {
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            lArrRezQ.Content += arr_rez[j, i] + " ";
                        }
                        lArrRez.Content += "\n";
                    }
                }
                if (radioButton7.IsChecked == true)
                {
                    double sum1 = 1;
                    double sum2 = 1;
                    for (int i = 0; i < n; i++)
                    {
                        sum1 *= arr_rez[i, i];
                    }
                    for (int j = n - 1, i = 0; j >= 0; i++, j--)
                    {
                        sum2 *= arr_rez[i, j];
                    }
                    opr = sum1 - sum2;
                    MessageBox.Show(Convert.ToString("Определитель = " + opr));
                }
                if (radioButton8.IsChecked == true && opr != 0)
                {
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
                            lArrRezQ.Content += arr_rez[i, j] + " ";
                        }
                        lArrRezQ.Content += "\n";
                    }
                }
                else if (opr == 0)
                {
                    MessageBox.Show("Определитель равен нулю, обратной матрицы не существует!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error!");
            }
        }
    }
}

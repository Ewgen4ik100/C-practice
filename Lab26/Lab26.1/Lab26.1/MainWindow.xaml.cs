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

namespace Lab26._1
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
        string t = "";
        const double p = 3.14;
        private void bRezq_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int n = Convert.ToInt32(textbox1.Text);
                if (n < 1 || n > 99)
                {
                    MessageBox.Show("Неверный диапазон значений, верный диапазон от 1 до 99!");
                }
                else
                {
                    t = Convert.ToString(n);
                }
                string s = t.Substring(t.Length - 1);
                if (s == "1" && t != "11")
                {
                    lRez.Content = $"{t} копейка";
                }
                else if (s == "2" && t != "12" || s == "3" && t != "13" || s == "4" && t != "14")
                {
                    lRez.Content = $"{t} копейки";
                }
                else
                {
                    lRez.Content = $"{t} копеек";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка, проверьте правильность введенных данных!");
            }
        }

        private void bRezw_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double x = Convert.ToInt32(tx.Text);
                double y = Convert.ToInt32(ty.Text);
                lRez2.Content = Convert.ToString(((Math.Cos(x)) / (p - 2 * x)) - 16 * Math.Cos(x * y) - 2);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка, проверьте правильность введенных данных!");
            }
        }
    }
}

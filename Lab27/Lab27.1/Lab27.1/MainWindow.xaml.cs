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

namespace Lab27._1
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
        string rez;
        private void bRez_Click(object sender, RoutedEventArgs e)
        {
            string str = Convert.ToString(ts.Text);
            HashSet<char> val = new HashSet<char>(str);
            val.IntersectWith("аеёиоуыэюя");
            List<char> lst = new List<char>();
            lst = val.ToList<char>();
            lst.Sort();
            foreach(char m in lst)
            {
                rez += m + " ";
            }
            lRez.Content = rez;
        }
        string srez = "";
        private void bRez2_Click(object sender, RoutedEventArgs e)
        {
            larr.Content = " ";
            srez = String.Empty;
            int[,] arr = new int[4, 4];
            Random rnd = new Random();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    arr[i, j] = rnd.Next(-100, 100);
                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    larr.Content += arr[i,j] + " ";
                }
                larr.Content += "\n";
            }
            for (int i = 0; i < 4; i++)
            {
                if(arr[i,i] < 0)
                {
                    srez += arr[i, i] + " ";
                }
            }
            lrez2.Content = srez;

        }
    }
}

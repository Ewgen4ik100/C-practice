using System;

namespace lab2._1
{
    class Program
    {
        static void Main(string[] args) 
        { 
            double a = -1.5;
            double b = 15.5;
            double x = -2.9;
            double w = Math.Sqrt(Math.Pow(x, 2) + b) - Math.Pow(b, 2) * Math.Pow(Math.Sin((x + a) / x), 3);
            Console.WriteLine("W = " + string.Format("{0:N2}", w));
            double y = Math.Pow(Math.Cos(Math.Pow(x, 3)), 2) - (x / (Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2))));
            Console.WriteLine("Y = " + string.Format("{0:N2}", y));
        }
    }
}

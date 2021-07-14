using System;
namespace lab2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите N: ");
            double n = double.Parse(Console.ReadLine());
            Console.Write("Введите X: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Введите B: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Введите A: ");
            double a = double.Parse(Console.ReadLine());
            double p = Primer(n, x, a, b);
            Console.WriteLine(p);
        }
        static double Primer(double n, double x, double a, double b)
        {
            if (n >= 2)
            {
                return ((Math.Exp(a * x) * Math.Pow(Math.Cos(x), 2) * (a * Math.Cos(x) + n * Math.Sin(x)) / (Math.Pow(a, 2) + Math.Pow(n, 2)))) * Primer(n - 2, x, a, b);
            }
            else if (n == 1)
            {
                return ((-Math.Exp(a * x) * (Math.Sin(x) + Math.Cos(x))) / (Math.Pow(a,2) + Math.Pow(n, 2)));
            }
            else if (n == 0)
            {
                return ((Math.Exp(a * x) / a));
            }
            return 0;
        }
    }
}

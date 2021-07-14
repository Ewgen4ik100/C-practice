using System;

namespace Lab5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите +, -, /, *");
            string wib = Console.ReadLine();
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            switch (wib)
            {
                case "+":
                    {
                        Uan.Plus(x1, y1);
                        break;
                    }
                case "-":
                    {
                        Tu.Minus(x1, y1);
                        break;
                    }
                case "/":
                    {
                        Fri.Del(x1, y1);
                        break;
                    }
                case "*":
                    {
                        Fier.Umn(x1, y1);
                        break;
                    }
            }
        }
    }
    public class Uan
    {
        public static void Plus(double x, double y)
        {
            Console.WriteLine(x + y);
        }
    }
    public class Tu
    {
        public static void Minus(double x, double y)
        {
            Console.WriteLine(x - y);
        }
    }
    public class Fri
    {
        public static void Del(double x, double y)
        {
            Console.WriteLine(x / y);
        }
    }
    public class Fier
    {
        public static void Umn(double x, double y)
        {
            Console.WriteLine(x * y);
        }
    }
}

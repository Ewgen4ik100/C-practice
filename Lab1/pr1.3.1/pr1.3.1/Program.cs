using System;

namespace pr1._3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Vinnik();
        }
        static void Vinnik()
        {
            double a = 1;
            double z;
            Console.Write("Введите T (1 - лаба со счетчиком; 2 - лаба с предусловием; 3 - лаба с постусловием): ");
            int t = Int32.Parse(Console.ReadLine());
            switch (t)
            {
                case 1:
                    for (a = 1; a <= 3; a = a + 0.2)
                    {
                        z = (2 * Math.Sin(a) + 5 * Math.Sin(a) - 3 * Math.Sin(a)) / (Math.Cos(a) + 1 - 2 * Math.Pow(Math.Sin(2 * a), 2));
                        Console.WriteLine("Счетчик: " + z);
                    }
                    break;
                case 2:
                    while (a >= 1 & a <= 3)
                    {
                        a = a + 0.2;
                        z = (2 * Math.Sin(a) + 5 * Math.Sin(a) - 3 * Math.Sin(a)) / (Math.Cos(a) + 1 - 2 * Math.Pow(Math.Sin(2 * a), 2));
                        Console.WriteLine("Предусловие: " + z);
                    }
                    break;
                case 3:
                    do
                    {
                        a = a + 0.2;
                        z = (2 * Math.Sin(a) + 5 * Math.Sin(a) - 3 * Math.Sin(a)) / (Math.Cos(a) + 1 - 2 * Math.Pow(Math.Sin(2 * a), 2));
                        Console.WriteLine("Постусловие: " + z);
                    }
                    while (a >= 1 & a <= 3);
                    break;
            }
        }
    }
}

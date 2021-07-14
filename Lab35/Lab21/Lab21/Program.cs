using System;
using System.Threading;
using System.Threading.Tasks;

namespace Lab21
{
    class Program
    {
        static int n;
        static Task[] tr = new Task[3];
        static void Main(string[] args)
        {
            Console.Write("Введите число до которого искать простые числа: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Числа которые будут проверяться: ");
            for (int i = 2; i < n; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.Write("Простые числа: ");
            int first = 2;
            int last = n / 3;

            for (int i = 0; i < 3; i++)
            {
                tr[i] = new Task(() => Prow(first, last));
                tr[i].Start();
                Thread.Sleep(100);
                first = last;
                last += last;
                if (last > n)
                    last = n;
            }
        }
        public static void Prow(int first, int last)
        {
            for (int i = first; i < last; i++)
            {
                if (Chisl(i))
                {
                    Console.Write(i.ToString() + " ");  
                }
            }
        }
        public static bool Chisl(int n)
        {
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0 && i != n)
                    return false;
            }
            return true;
        }
    }
}

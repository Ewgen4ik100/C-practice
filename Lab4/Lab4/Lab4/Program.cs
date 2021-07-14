using System;
using System.Linq;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            GetNatue();
            Console.ReadLine();
        }
        static void GetNatue()
        {
            Console.Write("Введите N: ");
            int N = int.Parse(Console.ReadLine());
            for (int ch = 100; ch < 1000; ch++)
            {
                del(N, ch);
            }
        }

        static void del(int N, int ch)
        {
            int Ni = 0;
            int?[] listi = new int?[N + 1];
            for (int i = 1; i <= ch; i++)
            {
                if (ch % i == 0)
                {
                    listi[Ni] = i;
                    Ni++;
                }
                if ((Ni == N) && (i == ch))
                {
                    Console.WriteLine("Найдено число: " + ch + " с делителями: " + String.Join(" ", listi));
                    return;
                }
                if (N < Ni) return;
            }
        }
    }
}

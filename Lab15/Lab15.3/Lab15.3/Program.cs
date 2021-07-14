using System;
using System.Threading;

namespace Lab15._3
{
    class Program
    {
        
        static Thread td = new Thread(new ParameterizedThreadStart(Matr));
        static void Main(string[] args)
        {
            Zna zn = new Zna();
            Console.Write("Введите длину матрицы: ");
            zn.n = int.Parse(Console.ReadLine());
            Console.Write("Введите ширину матрицы: ");
            zn.m = int.Parse(Console.ReadLine());
            td.Start(zn);
        }
        static void Matr(object obj)
        {
            Zna c = (Zna)obj;
            int pod = 1;
            int[,] arr = new int[c.n, c.m];
            Random rnd = new Random();
            for (int i = 0; i < c.n; i++)
            {
                for (int j = 0; j < c.m; j++)
                {
                    arr[i, j] = rnd.Next(-100, 100);
                }
            }
            Console.WriteLine("Исходная мтарица: ");
            for (int i = 0; i < c.n; i++)
            {
                for (int j = 0; j < c.m; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < c.n; i++)
            {
                for (int j = 0; j < c.m; j++)
                {
                    if(arr[i,j] % 2 == 0)
                    {
                        pod *= arr[i, j];
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Подмножество равно: {pod}");
        }

    }
    class Zna
    {
        public int n;
        public int m;
    }
}

using System;

namespace lab1._3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Vinnik();
        }
        static void Vinnik()
        {
            int sum = 0;
            int i;
            int[] s = new int[4];
            Random rnd = new Random();
            Console.WriteLine("Ваш массив: ");
            for (i = 0; i < s.Length; i++)
            {
                s[i] = rnd.Next(10, 99);
                Console.WriteLine(s[i]);
            }
            for (i = 0; i < s.Length; i++)
            {
                if (s[i] % 2 == 0)
                {
                    sum = sum + s[i];
                }

            }
            Console.WriteLine("Сумма четных чисел: " + sum);
        }
    }
}

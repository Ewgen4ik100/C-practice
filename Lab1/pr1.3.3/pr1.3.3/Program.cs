using System;

namespace pr1._3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int i;
            Console.Write("Введите кол-во эллементов: ");
            int n = Int32.Parse(Console.ReadLine());
            int[] s = new int[n];
            Random rand = new Random();
            Console.WriteLine("Ваш массив: ");
            for (i = 0; i < n; i++)
            {
                s[i] = rand.Next(-100, 100);
                Console.WriteLine(s[i]);
            }
            for (i = 0; i < n; i++)
            {
                if(s[i] > 0)
                {
                    sum = sum + s[i];
                }
            }
            Console.Write("Сумма положительных эллементов: " + sum);
        }
    }
}

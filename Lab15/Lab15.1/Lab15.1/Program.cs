using System;
using System.Linq;
using System.Threading;

namespace Lab15._1
{
    class Program
    {
        static char pos;
        static string str;
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            str = Console.ReadLine();
            Console.Write("Введите искомое в строке: ");
            pos = Convert.ToChar(Console.ReadLine());
            Thread[] td = new Thread[1];
            for(int i = 0; i<1; i++)
            {
                td[i] = new Thread(Method);
                td[i].Start();
            }
        }
        static void Method()
        {
            int count = 0;
            for(int i = 0; i < str.Length; i++)
            {
                if(str[i] == pos)
                {
                    count++;
                }
            }
            if(count != 2 && count != 3 && count != 4)
                Console.WriteLine($"В веденной строке символ {pos} встречается {count} раз");
            else
                Console.WriteLine($"В веденной строке символ {pos} встречается {count} разa");
        }
    }
}

using System;
using System.Threading;
using System.Linq;

namespace Lab15._2
{
    class Program
    {
        public delegate void Threading(string message);
        static event Threading Trids;
        static Thread[] td = new Thread[3];
        static void Main(string[] args)
        {
            Trids += Mess;
            for (int i = 0; i < 3; i++)
            {
                td[i] = new Thread(Method);
                td[i].Priority = ThreadPriority.Normal+i;
                Trids?.Invoke($"Поток №{i + 1} запущен с приоритетом {td[i].Priority}!");
            }
            td[0].Name = "Valera";
            td[1].Name = "Valero4ka";
            td[2].Name = "Valeron4ik";
            Trids -= Mess;
            Trids += Mess2;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Отсортированные потоки!");
            Console.ResetColor();
            Array.Reverse(td);
            for (int i = 0; i < 3; i++)
            {
                td[i].Start();
                Trids?.Invoke($"Поток {td[i].Name} приоритет {td[i].Priority}");
            }
            
        }
        static void Method()
        {
            
        }
        static void Mess(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        static void Mess2(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}

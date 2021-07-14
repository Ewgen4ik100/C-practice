using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab19._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер поезда: ");
            string nam = Console.ReadLine();
            Trains(nam);
        }
        public static void Trains(string nam)
        {
            List<Train> tr = new List<Train>();
            for (int i = 0; i < 8; i++)
            {
                Console.Write($"Введите номер поезда №{i + 1}: ");
                string NumP = Console.ReadLine();
                Console.Write("Введите пункт назначения: ");
                string PunktN = Console.ReadLine();
                Console.Write("Введите время отправления: ");
                string Time = Console.ReadLine();
                tr.Add(new Train(PunktN, NumP, Time));
            }
            var sortTrain = from t in tr orderby t.NumP select t;
            Console.WriteLine("Отсортированные поезда: ");
            foreach(Train t in tr)
            {
                t.GetInfo();
            }
            Console.WriteLine("Найденные поезда: ");
            bool val = false;
            foreach (Train t in sortTrain)
            {
                if (t.NumP == nam)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    t.GetInfo();
                    Console.ResetColor();
                    val = true;
                }
            }
            if(val==false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Поездов с номером {nam} не существует!");
                Console.ResetColor();
            }
        }
    }
    public struct Train
    {
        public string PunktN { get; set; }
        public string NumP { get; set; }
        public string Time { get; set; }
        public Train(string punktn, string nump, string time)
        {
            PunktN = punktn;
            NumP = nump;
            Time = time;
        }
        public void GetInfo()
        {
            Console.WriteLine($"Пункт назначения: {PunktN}; Номер поезда: {NumP}; Время отправления: {Time}");
        }
    }
    
}

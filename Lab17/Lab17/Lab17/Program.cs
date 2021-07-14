using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lab17
{
    delegate void Files(string message);
    class Program
    {
        public static event Files Messag;
        static string path = @"output.txt";
        static void Main(string[] args)
        {
            Uan();
        }
        static void Uan()
        {
            Console.Write("Введите кол-во объектов: ");
            int n = int.Parse(Console.ReadLine());
            List<Musik> mus = new List<Musik>();
            for (int i = 0; i < n; i++)
            {
                mus.Add(new Musik());
                Console.Write("Введите ФИО: ");
                mus[i].Fio = Console.ReadLine();
                Console.Write("Введите страну: ");
                mus[i].Strana = Console.ReadLine();
                Console.Write("Инструмент: ");
                mus[i].Instrument = Console.ReadLine();
            }
            Console.WriteLine("Ваши объекты: ");
            mus.Sort((left, right) => left.Fio.CompareTo(right.Fio));
            string[] last_arr = new string[n];
            for (int i = 0; i < n; i++)
            {
                Musik ms = mus[i];
                last_arr[i] = ms.ToString();
                mus[i].GetInfo();
            }
            for (int i = 0; i < n; i++)
            {
                File.WriteAllLines(path, last_arr, Encoding.UTF8);
            }
            FileInfo fi = new FileInfo(path);
            if (!fi.Exists)
            {
                Messag += Mess2;
                Messag?.Invoke("Файла не существует! \n Создаем!");
                File.Create(path);
                Messag -= Mess2;
            }
            else
            {
                Messag += Mess1;
                Messag?.Invoke("Файл существует! \nНачинаем сортировку!");
            }
            for (int i = 0; i < n; i++)
            {
                
            }
        }
        public static void Mess1(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        public static void Mess2(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
    public class Musik
    {
        public string Fio { get; set; }
        public string Strana { get; set; }
        public string Instrument { get; set; }
        public Musik() { }
        public Musik(string fio, string strana, string instrument)
        {
            Fio = fio;
            Strana = strana;
            Instrument = instrument;
        }
        public void GetInfo()
        {
            Console.WriteLine($"ФИО: {Fio}, Страна: {Strana}, Инструмент: {Instrument}");
        }
        public override string ToString()
        {
            return $"ФИО: {Fio}, Страна: {Strana}, Инструмент: {Instrument}";     
        }
    }
}

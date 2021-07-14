using System;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст: ");
            string str = Console.ReadLine();
            string[] arrstr = str.Split(' ');
            for (int i = 0; i <= arrstr.Length; i++)
            {
                if (arrstr[i].Substring(0) != "-" && arrstr[i].Substring(arrstr[i].Length - 1) != "-")
                {
                    if (arrstr[i] == arrstr[i + 1])
                    {
                        Console.Write(arrstr[i] + " ");
                    }
                }
                else
                    Console.WriteLine("Слово не может начинаться с дефиса!");
            }
        }
    }
}

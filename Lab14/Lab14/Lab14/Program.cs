using System;

namespace Lab14
{
    public delegate void AccountHandler(string message);
    class Program
    {
        public static event AccountHandler Notify;
        static int[] arr;
        static int n;
        static void Main(string[] args)
        {
            Console.Write("Введите длину массива: ");
            n = int.Parse(Console.ReadLine());
            arr = new int[n];
            Random rnd = new Random();
            Console.Write("Исходный массив: ");
            for (int i = 0; i < n; i++)
            {
                arr[i] = rnd.Next(-100, 100);
                Console.Write(arr[i] + " ");
            }
            Notify += Message;
            Up();
            Notify -= Message;
            Notify += Msg;
            Down();
        }
        public static void Message(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        public static void Msg(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static void Up()
        {
            int temp;
            for(int i = 0; i < n; i++)
            {
                for(int j = i + 1; j < n; j++)
                {
                    if(arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                        Console.WriteLine();
                        Notify?.Invoke($"Сортируем число: {temp}");
                    }
                }
            }
            Console.WriteLine();
            Console.Write("Отсортированный массив: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
        public static void Down()
        {
            int temp;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                        Console.WriteLine();
                        Notify?.Invoke($"Сортируем число: {temp}");
                    }
                }
            }
            Console.WriteLine();
            Console.Write("Отсортированный массив: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}

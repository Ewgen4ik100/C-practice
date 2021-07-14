using System;
using System.Linq;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            Fi.Fis();
        }
        public class Uan
        {
            public static void Uans()
            {
                int[] arr = new int[100];
                Random rnd = new Random();
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = rnd.Next(0, 1000);
                }
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i] + " ");
                }
                Console.WriteLine();
                Console.Write("Введите цифру от 0 до 1000: ");
                int n = int.Parse(Console.ReadLine());
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == n)
                    {
                        Console.WriteLine($"Элемент {arr[i]} его индекс: {i}");
                    }
                    else
                        Console.WriteLine($"Элемента {n} в списке нет!");
                }
            }
        }
        public class Tu
        {
            public static void Tus()
            {
                Console.Write("Введите длину массива: ");
                int sizeArray = int.Parse(Console.ReadLine());
                int[] a = new int[sizeArray];
                Random r = new Random();
                for (int i = 0; i < sizeArray; ++i)
                {
                    a[i] = r.Next(-50, 100);
                }
                Console.WriteLine("Исходный массив:");
                for (int i = 0; i < sizeArray; ++i)
                {
                    Console.Write(a[i] + ", ");
                }
                int min = a.Min(t => Math.Abs(t));
                Console.WriteLine("Минимальный элемент = {0}, Index: {1}", min, Array.IndexOf(a, Math.Abs(min)));
                int sum = 0;
                bool flag = false;
                for (int i = 1; i < sizeArray; ++i)
                {
                    if (a[i] == 0)
                        flag = true;
                    if (flag)
                        sum += Math.Abs(a[i]);
                }
                int tmp;
                Console.WriteLine("Сумма модулей элементов = " + sum);
                for (int i = 0; i < sizeArray / 2; i++)
                {
                    if (i % 2 == 0)
                    {
                        tmp = a[i + a.Length / 2];
                        a[i + a.Length / 2] = a[i];
                        a[i] = tmp;
                    }
                }

                // выводим в label2 для наглядности
                foreach (int i in a)
                {
                    Console.Write(i + ", ");
                }
            }
        }
        public class Fi
        {
            public static void Fis()
            {
                int[,] mas = new int[10, 10];
                Random rnd = new Random();
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        mas[i, j] = -5 + rnd.Next(15);
                        Console.Write(mas[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                //подсчет локальных минимумов
                int count = 0;
                for (int i = 1; i < 9; i++)
                {
                    for (int j = 1; j < 9; j++)
                    {
                        if (mas[i - 1, j] > mas[i, j] && mas[i + 1, j] > mas[i, j])
                            if (mas[i, j - 1] > mas[i, j] && mas[i, j + 1] > mas[i, j])
                                count++;
                    }
                }
                Console.WriteLine("Количество локальных минимумов: " + count);
                //сумма модулей элементов, расположенных выше главной диагонали
                int summa = 0;
                for (int i = 0; i < 10; i++)
                {
                    for (int j = i + 1; j < 10; j++)
                    {
                        summa += Math.Abs(mas[i, j]);
                    }
                }
                Console.WriteLine("Сумма модулей элементов, расположенных выше главной диагонали = " + summa);
                Console.ReadKey();
            }
        }
        public class Fier
        {
            public static void Fiers()
            {
                Console.Write("Введите длину матрицы: ");
                int n = int.Parse(Console.ReadLine());
                int[,] mas = new int[n, n];
                Random rnd = new Random();
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        mas[i, j] = -5 + rnd.Next(15);
                        Console.Write(mas[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                //подсчет локальных минимумов
                int count = 0;
                for (int i = 1; i < n-1; i++)
                {
                    for (int j = 1; j < n-1; j++)
                    {
                        if (mas[i - 1, j] > mas[i, j] && mas[i + 1, j] > mas[i, j])
                            if (mas[i, j - 1] > mas[i, j] && mas[i, j + 1] > mas[i, j])
                                count++;
                    }
                }
                Console.WriteLine("Количество локальных минимумов: " + count);
                //сумма модулей элементов, расположенных выше главной диагонали
                int summa = 0;
                for (int i = 0; i < n; i++)
                {
                    for (int j = i + 1; j < n; j++)
                    {
                        summa += Math.Abs(mas[i, j]);
                    }
                }
                Console.WriteLine("Сумма модулей элементов, расположенных выше главной диагонали = " + summa);
                Console.ReadKey();
            }
        }
    }
}

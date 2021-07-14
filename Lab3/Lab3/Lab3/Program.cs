using System;

namespace Lab3
{
    class ClassTest
    {
        static void Main(string[] args)
        {
            ClassLibrary.Posled();
        }
    }
    public class ClassLibrary
    {
        public static void Posled()
        {
            int rez = 0;
            int ell;
            int[] arr1 = new int[5];
            int[] arr2 = new int[5];
            for (int i = 0; i < 5; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
                arr2[i] = arr1[i];
            }
            Array.Sort(arr2);
            for (int i = 0; i < 5; i++)
            {
                if(arr1[i] == arr2[i])
                {
                    ell = arr1[2];
                    arr1[i] = arr1[i] * ell;
                }
                else
                {
                    Console.WriteLine(arr1[i]);
                }
            }
            Console.WriteLine($"Индекс среднего элемента 2, значение {arr2[2]}\nРезультат умножения:{arr1[0]} {arr1[1]} {arr1[2]} {arr1[3]} {arr1[4]}");
        }
    }
}

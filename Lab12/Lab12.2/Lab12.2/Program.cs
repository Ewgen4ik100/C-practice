using System;

namespace Lab12._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Mass m1 = new Mass(new int[]{ 1,2,3,4});
            Mass m2 = new Mass(new int[] { 1, 2, 3, 4, 5 });
            bool result = m1 == m2;
            Console.WriteLine(result);
        }
    }
    public class Mass
    {
        public int[] arr;
        public Mass(int[] arr1)
        {
            arr = arr1;
        }
        public static bool operator == (Mass arr1, Mass arr2)
        {
            for (int i = 0; i < arr1.arr.Length; i++)
            {
                Console.Write(arr1.arr[i] + " ");
            }

            Console.WriteLine();
            for (int i = 0; i < arr2.arr.Length; i++)
            {
                Console.Write(arr2.arr[i] + " ");
            }

            Console.WriteLine();
            if (arr1.arr.Length == arr2.arr.Length)
            {
                return true;
            }
            else
                return false;


        }
        public static bool operator !=(Mass arr1, Mass arr2)
        {
            if(arr1==arr2)
                return false;
            return true;
        }
    }
}

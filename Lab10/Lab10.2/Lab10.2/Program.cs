using System;

namespace Lab10._2
{
    interface ISequence
    {
        void GetElement(int nam);
        void Sum();
    }
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Введите элемент: ");
            int s = int.Parse(Console.ReadLine());
            GeometricProgression gm = new GeometricProgression();
            gm.Geometric(2, 2, 10);
            gm.GetElement(s);
            gm.Sum();
            ArithmeticProgression am = new ArithmeticProgression();
            am.Arithmetic(2, 3, 30);
            am.Sum();
            am.GetElement(s);
        }
    }
    public class GeometricProgression : ISequence
    {
        int i;
        public int sum;
        public int[] arr_a;
        public void Geometric(int uan, int tm, int n)
        {
            Console.Write("Ваши элементы геометрической прогресси: ");
            arr_a = new int[n];
            for (i = 0; i < n; i++,uan*=tm)
            {
                arr_a[i] = uan * tm;
                Console.Write(arr_a[i] + " ");
            }
            Console.WriteLine();
        }
        public void Sum()
        {
            Console.Write("До какого элемента вывести сумму? ");
            int kon = int.Parse(Console.ReadLine());
            int sum = 0;
            for(i = 0; i < kon; i++)
            {
                sum += arr_a[i];
            }
            Console.WriteLine($"GF: Сумма элементов до элемента под №{kon} равна: {sum}");
        }
        public void GetElement(int nam)
        {
            int nams = arr_a[nam];
            Console.WriteLine($"GF: Под номером {nam}, лежит {nams} элемент");
        }
    }
    public class ArithmeticProgression : ISequence
    {
         
        public int[] arr_a;
        public void Arithmetic(int uan, int razn, int n)
        {
            Console.Write("Ваши элементы арифметической прогресси: ");
            arr_a = new int[n];
            for (int i = 0; i < n; i++, uan += razn)
            {
                arr_a[i] = uan + razn;
                Console.Write(arr_a[i] + " ");
            }
            Console.WriteLine();
        }
        public void Sum()
        {
            Console.Write("До какого элемента вывести сумму? ");
            int kon = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < kon; i++)
            {
                sum += arr_a[i];
            }
            Console.WriteLine($"AF: Сумма элементов до элемента под №{kon} равна: {sum}");
        }
        public void GetElement(int nam)
        {
            int nams = arr_a[nam];
            Console.WriteLine($"AF: Под номером {nam}, лежит {nams} элемент");
        }
    }
}





using System;

namespace Lab13._1
{
    class Program
    {
        static void Main(string[] args)
        {
            char x1 = Convert.ToChar("Д");
            char x2 = Convert.ToChar("р");
            Console.WriteLine("Hello World!");
            Action < Func<int>, char, char> op = Test2;
            Func<int> fc = Test1;
            fc.Invoke();
            op.Invoke(fc, x1, x2);
        }
        static public void Test2(Func<int> t, char ch, char ch2)
        {
            Console.WriteLine($"{ch}елегат - {ch2}еализован!");
        }
        static public int Test1()
        {
            return 2;
        }
    }
}

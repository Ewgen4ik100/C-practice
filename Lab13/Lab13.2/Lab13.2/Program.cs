using System;
using System.Text;

namespace Lab13._2
{
    delegate void Meth();
    class Program
    {
        const string alfabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        static void Main(string[] args)
        {
            Console.Write("Введите строку для шифровки: ");
            string stroka = Console.ReadLine();
            Console.Write("Введите ключ для сдвига: ");
            int n = int.Parse(Console.ReadLine());
            Meth mt = () => Method(stroka, n);
            mt();
        }
        public static void Method(string str, int n)
        {
            var rez = new StringBuilder();
            string alf = alfabet + alfabet.ToLower();
            for(int i = 0; i < str.Length; i++)
            {
                for(int j = 0; j < alf.Length; j++)
                {
                    if(str[i] == alf[j])
                    {
                        rez.Append(alf[j + n]);
                    }
                }
            }
            Console.WriteLine($"Зашифрованый текст: {rez.ToString()}");
        }
    }
}

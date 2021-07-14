using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b[aeiouy][A-z]*[aeiouy]\b";
            string filecontent = string.Empty;
            filecontent = System.IO.File.ReadAllText(@"import.txt");
            int counter = 0;
            StringBuilder result = new StringBuilder();
            try
            {
                Regex regexObj = new Regex(pattern);
                Match matchResult = regexObj.Match(filecontent);
                while (matchResult.Success)
                {
                    result.AppendFormat("{1,-3}{0}", matchResult.Value, counter.ToString());
                    result.AppendLine();
                    matchResult = matchResult.NextMatch();
                    counter++;
                }
            }
            catch (ArgumentException)
            {
                // Ошибка в регулярном выражении
            }
            Console.WriteLine(result.ToString());
            Console.ReadLine();
            string str = "4 3 2 5 6 1 9 7 8 9";

            string[] elStr = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int[] arr = new int[10];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(elStr[i]);
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Reaultat: ");

            Array.Sort(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ConsoleApplicationTest
{
    public static class Program
    {
        static string input = @"users.txt";
        static string output = @"output.txt";

        private static void Main()
        {
            FileInfo fi = new FileInfo(output);
            Auth();
            string[] allLines = File.ReadAllLines(input);
            List<Student> st = new List<Student>();
            string[] fields = new string[5];
            for (int i = 0; i < allLines.Length; i++)
            {
                string line = allLines[i];
                fields = line.Split(';');
                Student student = new Student(fields[0], fields[1], fields[2], fields[3], fields[4]);
                st.Add(student);
            }
            
            foreach(Student student in st)
            {
                //Console.WriteLine(student);
            }
            List<string> isx = new List<string>();
            var sortCors = from u in st orderby u.Name select u;
            sortCors = from u in sortCors orderby u.Cours select u;
            foreach (Student u in sortCors)
            {
                Console.WriteLine(u);
                isx.Add(Convert.ToString(u));
            }

            // Сохраняем в файл
            if (fi.Exists)
            {
                File.WriteAllLines(output, isx, Encoding.UTF8);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Отсортированные данные записаны в файл {output}");
                Console.ResetColor();
            }
            else
            {
                File.Create(output);
                File.WriteAllLines(output, isx, Encoding.UTF8);
                Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Отсортированные данные записаны в файл {output}");
                Console.ResetColor();
            }
        }
        public static void Auth()
        {
            FileInfo fn = new FileInfo(input);
            if (fn.Exists)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Файл {input} существует! Продолжаем работу!");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Файл {input} не найден! Проверьте расположение файла!");
                Console.ResetColor();
            }
        }
    }
    public struct Student : IComparable
    {
        public Student(string name, string fac, string group, string cours, string nums)
            : this()
        {
            Name = name;
            Fac = fac;
            Group = group;
            Cours = cours;
            Nums = nums;
            string[] str = nums.Split(' ');
            Ocen = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Ocen[i] = Convert.ToInt32(str[i]);
            }
        }
        public string Name { get; set; }
        public string Fac { get; set; }
        public string Group { get; set; }
        public string Cours { get; set; }
        public string Nums { get; set; }
        public int[] Ocen { get; set; }
        public int CompareTo(object obj)
        {
            return Fac.CompareTo(((Student)obj).Fac);
        }
        public override string ToString()
        {
            return string.Format($"Фамилия: {Name}; Факультет: {Fac}; Группа: {Group}; Курс: {Cours}; Отметки: {Nums}");
        }
    }
}

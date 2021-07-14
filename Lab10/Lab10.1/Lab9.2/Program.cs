using System;
using System.IO;
using System.Text;

namespace ConsoleApplicationTest
{
    public static class Program
    {
        static string path = @"users.txt";
        static string outs = @"output.txt";
        
        private static void Main()
        {
            Auth();
            string[] allLines = File.ReadAllLines(path);
            Student[] students = new Student[allLines.Length];
            string[] fields = new string[5];
            for (int i = 0; i < allLines.Length; i++)
            {
                string line = allLines[i];
                fields = line.Split(';');
                Student student = new Student(fields[0], fields[1], fields[2], fields[3], fields[4]);
                students[i] = student;
            }
            Array.Sort(students);
            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }
            string[] linesToSave = new string[students.Length];
            for (int i = 0; i < students.Length; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    if (students[i].Ocen[j] == 2)
                    {
                        Student student = students[i];
                        linesToSave[i] = student.ToString();
                    }
                }
            }
            // Сохраняем в файл
            FileInfo fi = new FileInfo(outs);
            if (fi.Exists)
            {
                File.WriteAllLines(outs, linesToSave, Encoding.UTF8);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Отсортированные данные записаны в файл {outs}");
                Console.ResetColor();
            }
            else
            {
                File.Create(outs);
                File.WriteAllLines(outs, linesToSave);
                Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Отсортированные данные записаны в файл {outs}");
                Console.ResetColor();

            }
        }
        public static void Auth()
        {
            FileInfo fn = new FileInfo(path);
            if (fn.Exists)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Файл {path} существует! Продолжаем работу!");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Файл {path} не найден! Проверьте расположение файла!");
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
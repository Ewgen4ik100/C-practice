using System;
using System.Collections.Generic;

namespace Lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Кого вы хотите ввести? Y - школьники R - студенты: ");
            //string selection1 = Console.ReadLine();
            Console.Write("Введите количество объектов: ");
            int n = int.Parse(Console.ReadLine());
            Student st = new Student(); 
            Shoolboy sb = new Shoolboy();
            Base[] b = new Base[n];
            for (int i = 0; i < n; i++)
            {
                b[i] = new Base();
                Console.Write($"Введите имя объекта №{i + 1}: ");
                b[i].Name = Console.ReadLine();
                Console.Write($"Введите возраст объекта №{i + 1}: ");
                b[i].Age = int.Parse(Console.ReadLine());
                Console.Write($"Введите место обучения объекта №{i + 1}: ");
                b[i].Geo = Console.ReadLine();
                if (b[i].Geo.ToLower() == "школа" || b[i].Geo.ToLower() == "гимназия")
                {
                    Console.Write($"Введите класс объекта №{i + 1}: ");
                    sb.Clas = Console.ReadLine();
                    sb.Name = b[i].Name;
                    sb.Age = b[i].Age;
                    sb.Geo = b[i].Geo;
                }
                else
                {
                    Console.Write($"Введите группа объекта №{i + 1}: ");
                    st.Group = Console.ReadLine();
                    st.Name = b[i].Name;
                    st.Age = b[i].Age;
                    st.Geo = b[i].Geo;
                }
                
            }
            st.GetInfo();
                sb.GetInfo();
            //for(int i = 0; i < n; i++)
            //{
            //    if (b[i].Geo.ToLower() != "школа")
            //    {
            //        st.Name = b[i].Name;
            //        st.Age = b[i].Age;
            //        st.Geo = b[i].Geo;
            //    }
            //    else
            //    {
            //        sb.Name = b[i].Name;
            //        sb.Age = b[i].Age;
            //        sb.Geo = b[i].Geo;
            //    }
            //}
            //st.GetInfo();
            //sb.GetInfo();
            //switch (selection1)
            //{
            //    case "Y":
            //        for (int i = 0; i < n; i++)
            //        {
            //            Console.Write($"Введите имя объекта №{i + 1}: ");
            //            sb.Name = Console.ReadLine();
            //            Console.Write($"Введите возраст объекта №{i + 1}: ");
            //            sb.Age = int.Parse(Console.ReadLine());
            //            Console.Write($"Введите место обучения объекта №{i + 1}: ");
            //            sb.Geo = Console.ReadLine();
            //            Console.Write($"Введите класс объекта №{i + 1}: ");
            //            sb.Clas = Console.ReadLine();
            //        }
            //        break;
            //    case "R":
            //        for (int i = 0; i < n; i++)
            //        {
            //            Console.Write($"Введите имя объекта №{i + 1}: ");
            //            st.Name = Console.ReadLine();
            //            Console.Write($"Введите возраст объекта №{i + 1}: ");
            //            st.Age = int.Parse(Console.ReadLine());
            //            Console.Write($"Введите место обучения объекта №{i + 1}: ");
            //            st.Geo = Console.ReadLine();
            //            Console.Write($"Введите группа объекта №{i + 1}: ");
            //            st.Group = Console.ReadLine();
            //        }
            //        break;
            //}
            //if(selection1 == "Y")
            //{
            //    Console.WriteLine("Школьники: ");
            //    for (int i = 0; i < n; i++)
            //    {
            //        sb.GetInfo();
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Студенты: ");
            //    for (int i = 0; i < n; i++)
            //    {
            //        st.GetInfo();
            //    }
            //}
            Console.WriteLine(st.ToString());
        }
    }
    public class Base
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Geo { get; set; }
        public Base()
        { }
        public Base(string name, int age, string geo)
        {
            Name = name;
            Age = age;
            Geo = geo;
        }
        public virtual void GetInfo()
        {
            Console.WriteLine($"Имя: {Name}, Возраст: {Age}, Место учебы: {Geo}");
        }
    }
    public class Student : Base
    {
        public string Group { get; set; }
        public Student()
        { }
        public Student(string name, int age, string geo, string group):base(name, age, geo)
        {
            Group = group; 
        }
        public override void GetInfo() 
        {
            Console.WriteLine("Студенты: ");
            Console.WriteLine($"Имя: {Name}, Возраст: {Age}, Место учебы: {Geo}, Группа: {Group}");
        }
        public override string ToString()
        {
            return $"Перегруженый метод: \n Имя: {Name}, Возраст: {Age}, Место учебы: {Geo}, Группа: {Group}";
        }
    }
    public class Shoolboy : Base
    {
        public string Clas { get; set; }
        public Shoolboy()
        { }
        public Shoolboy(string name, int age, string geo, string clas):base(name, age, geo)
        {
            Clas = clas;
        }
        public override void GetInfo()
        {
            Console.WriteLine("Школьники: ");
            Console.WriteLine($"Имя: {Name}, Возраст: {Age}, Место учебы: {Geo}, Класс: {Clas}");
        }
    } 
}

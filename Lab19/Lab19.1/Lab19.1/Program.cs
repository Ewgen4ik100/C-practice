using System;
using System.Collections.Generic;

namespace Lab19._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите кол-во сторон многоугольника: ");
            int n = int.Parse(Console.ReadLine());
            Totchka(n);
        }
        public static void Totchka(int n)
        {
            List<Point> point = new List<Point>();
            for (int i = 0; i < n; i++)
            {
                point.Add(new Point());
                Console.Write($"Введите координату Х{i + 1}: ");
                point[i].X = int.Parse(Console.ReadLine());
                Console.Write($"Введите координату Y{i + 1} : ");
                point[i].Y = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                point[i].GetInfo();
            }
        }
    }
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point() { }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public virtual void GetInfo()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Координаты вершин: {X}, {Y}");
            Console.ResetColor();
        }
    }
    public class ColoredPoint:Point
    {
        public string ColorP { get; set; }
        public ColoredPoint(int x, int y, string colorp):base(x,y)
        {
            ColorP = colorp;
        }
        public override void GetInfo()
        {
            Console.WriteLine($"Координаты точки: {X}, {Y}; Цвет: {ColorP}");
        }
    }
    public class Line:Point
    {
        public int Xl { get; set; }
        public int Yl { get; set; }
        public Line(int xl, int yl, int x, int y) : base(x, y)
        {
            Xl = xl;
            Yl = yl;
        }
        public override void GetInfo()
        {
            Console.WriteLine($"Координаты точки №1: {X}, {Y}; Координаты точки №2: {Xl}, {Yl}");
        }
    }
    public class ColoredLine:Line
    {
        public string ColorL { get; set; }
        public ColoredLine(int xl, int yl, int x, int y, string colorl):base(xl, yl, x, y)
        {
            ColorL = colorl;
        }
        public override void GetInfo()
        {
            Console.WriteLine($"Координаты точки №1: {X}, {Y}; Координаты точки №2: {Xl}, {Yl}; Цвет: {ColorL}");
        }
    }
    public class PolyLine:Line
    {
        public List<string> PolL;
        public PolyLine(List<string> poll, int x, int y, int xl, int yl) : base(x, y, xl, yl)
        {
            PolL = poll;
        }
        public override void GetInfo()
        {
            Console.WriteLine($"Координаты точки №1: {X}, {Y}; Координаты точки №2: {Xl}, {Yl};");
        }
    }
}

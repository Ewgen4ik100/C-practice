using System;
using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        var s = new DecString(12);
        var x = new DecString(8);

        Console.WriteLine(s.bs);
        DecString t = s - x;
        Console.WriteLine(t.bs);
        var l = new DecString(16);
        var r = new DecString(20);
        bool result = l > r;
        if (result)
        {
            Console.WriteLine($"{l.bs} Больше {r.bs}");
        }
        else Console.WriteLine($"{l.bs} Меньше {r.bs}");
    }
}
public class Str
{
    public ushort dlina;
    public string str;

    // конструктор без параметро
    public Str()
    {

    }

    // конструктор, принимающий в качестве параметра строковый литерал
    public Str(string str)
    {
        this.str = str;
        dlina = (ushort)str.Length;
    }

    // конструктор, принимающий в качестве параметра символ;
    public Str(char ch)
    {
        str = Convert.ToString(ch);
        dlina = 1;
    }
    //Метод, возвращающий длину строки
    public ushort Leng(string str)
    {
        return dlina = Convert.ToUInt16(str.Length);
    }

    // Метод очищающий стоку.
    public void Clear()
    {
        str = "";
        dlina = 0;
    }
}
public class DecString : Str
{
    // Конструктор для десятичной строки.
    
    public DecString(int x)
    {
        var sb = new StringBuilder();
        if (x < 0)
        {
            sb.Append('-');
        }
        x = Math.Abs(x);

        while (x > 0)
        {
            int temp = x % 10;
            sb.Insert(0, temp.ToString());
            x /= 10;
        }

        bs = sb.ToString();
    }

    public string bs { get; set; }

    public static DecString operator -(DecString l, DecString r)
    {
        int result = Int32.Parse(l.bs) - Int32.Parse(r.bs);

        return new DecString(result);
    }

    public static bool operator <(DecString l, DecString r)
    {
        int li = Int32.Parse(l.bs);
        int ri = Int32.Parse(r.bs);

        return li < ri;
    }

    public static bool operator >(DecString l, DecString r)
    {
        int li = Int32.Parse(l.bs);
        int ri = Int32.Parse(r.bs);

        return li > ri;
    }
}
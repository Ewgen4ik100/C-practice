using selBride.Enums;
using System;
using System.Linq;

namespace selBride
{
    class Program
    {
        private static Bride[] Brides = Settings.GetBrides();

        static void Main(string[] args)
        {
            var bride = new PropBride();


            try
            {
                OutputOnDisplay("Введите от скольки лет желаете выбрать невесту:");
                bride.Age = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                bride.Age = 0;
            }

            Console.Clear();

            try
            {
                OutputOnDisplay("Введите от какого роста желаете выбрать невесту:");
                bride.Growth = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                bride.Growth = 0;
            }

            Console.Clear();

            try
            {
                OutputOnDisplay("Введите от скакого веса желаете выбрать невесту:");
                bride.Weight = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                bride.Weight = 0;
            }

            Console.Clear();

            try
            {
                OutputOnDisplay("Выберете отношение к курению:");
                OutputOnDisplay($"1) {nameof(Smoking.Smokes)}");
                OutputOnDisplay($"2) {nameof(Smoking.Negative)}");
                OutputOnDisplay($"3) {nameof(Smoking.Neutral)}");

                int i = Convert.ToInt32(Console.ReadLine());

                bride.Smoking = i < 4 && i > 0
                    ? (Smoking)i
                    : Smoking.NaN;
            }
            catch
            {
                bride.Smoking = 0;
            }

            Console.Clear();

            try
            {
                OutputOnDisplay("Выберете отношение к алкаголю:");
                OutputOnDisplay($"1) {nameof(Alcohol.Alcoholic)}");
                OutputOnDisplay($"2) {nameof(Alcohol.Moderately)}");
                OutputOnDisplay($"3) {nameof(Alcohol.NotDrinking)}");

                int i = Convert.ToInt32(Console.ReadLine());

                bride.Alcohol = i < 4 && i > 0
                    ? (Alcohol)i
                    : Alcohol.NaN;
            }
            catch
            {
                bride.Alcohol = 0;
            }

            Console.Clear();

            try
            {
                OutputOnDisplay("Выберете телосложение:");
                OutputOnDisplay($"1) {nameof(BodyType.Fat)}");
                OutputOnDisplay($"2) {nameof(BodyType.Сommon)}");
                OutputOnDisplay($"3) {nameof(BodyType.Thin)}");
                OutputOnDisplay($"4) {nameof(BodyType.Sports)}");

                int i = Convert.ToInt32(Console.ReadLine());

                bride.BodyType = i < 5 && i >0 
                    ? (BodyType)i
                    : BodyType.NaN;
            }
            catch
            {
                bride.BodyType = 0;
            }

            Console.Clear();

            printPropBride(bride);
            Console.ReadKey();
            Console.Clear();

            for (int i = 0; i < Brides.Length; i++)
            {
                if(bride.Age > 0 && Brides[i].Age >= bride.Age)
                {
                    Brides[i].Priority++;
                }
                if (bride.Weight > 0 && Brides[i].Weight >= bride.Weight)
                {
                    Brides[i].Priority++;
                }
                if (bride.Growth > 0 && Brides[i].Growth >= bride.Growth)
                {
                    Brides[i].Priority++;
                }
                if (bride.Alcohol > 0 && Brides[i].Alcohol == bride.Alcohol)
                {
                    Brides[i].Priority++;
                }
                if (bride.BodyType > 0 && Brides[i].BodyType == bride.BodyType)
                {
                    Brides[i].Priority++;
                }
                if (bride.Smoking > 0 && Brides[i].Smoking == bride.Smoking)
                {
                    Brides[i].Priority++;
                }
            }

            var selBrides = Brides.Where(b => b.Priority > 0).OrderByDescending(b => b.Priority);

            foreach (var b in selBrides)
            {
                printBride(b);
            }
        }

        private static void printPropBride(PropBride bride)
        {
            OutputOnDisplay($"Возрст: {bride.Age}");
            OutputOnDisplay($"Вес: {bride.Weight} кг");
            OutputOnDisplay($"Рост: {bride.Growth} см");
            OutputOnDisplay($"Отношение к курению: {bride.Smoking}");
            OutputOnDisplay($"Отношение к алкоолю: {bride.Alcohol}");
            OutputOnDisplay($"Телосложение: {bride.BodyType}");
        }

        private static void printBride(Bride bride)
        {
            OutputOnDisplay($"Имя: {bride.Name}");
            OutputOnDisplay($"Возрст: {bride.Age}");
            OutputOnDisplay($"Вес: {bride.Weight} кг");
            OutputOnDisplay($"Рост: {bride.Growth} см");
            OutputOnDisplay($"Отношение к курению: {bride.Smoking}");
            OutputOnDisplay($"Отношение к алкоолю: {bride.Alcohol}");
            OutputOnDisplay($"Телосложение: {bride.BodyType}");
            OutputOnDisplay($"Приоритет: {bride.Priority}");
            OutputOnDisplay("__________________________________");
        }

        private static void OutputOnDisplay(string message)
        {
            Console.WriteLine(message);
        }

        private class PropBride
        {
            public int Age { get; set; }
            public int Weight { get; set; }
            public int Growth { get; set; }
            public Alcohol Alcohol { get; set; }
            public Smoking Smoking { get; set; }
            public BodyType BodyType { get; set; }
        }
    }
}

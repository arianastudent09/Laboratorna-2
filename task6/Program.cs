using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Console.InputEncoding = System.Text.Encoding.UTF8;
            double usd = 26.73;
            double eur = 31.32;
            double rub = 0.37;
            Converter ex1 = new Converter(usd, eur, rub);
            Converter.Output();
        }
    }
    class Converter
    {
        public static string choice;
        public static double amount;
        public static double vuvid;
        public Converter(double usd, double eur, double rub)
        {
            Console.WriteLine("З якої валюти в яку відбувається переведення?");
            Console.WriteLine("Введіть 1, якщо переведення відбувається UAH в USD");
            Console.WriteLine("Введіть 2, якщо переведення відбувається UAH в EUR");
            Console.WriteLine("Введіть 3, якщо переведення відбувається UAH в RUB");
            Console.WriteLine("Введіть 4, якщо переведення відбувається USD в UAH");
            Console.WriteLine("Введіть 5, якщо переведення відбувається EUR в UAH");
            Console.WriteLine("Введіть 6, якщо переведення відбувається RUB в UAH");
            choice = Console.ReadLine();
            Console.WriteLine("Ввести суму обраної валюти:");
            amount = Convert.ToDouble(Console.ReadLine());
            if (choice == "1")
            {
                vuvid = amount / usd;
            }
            else if (choice == "2")
            {
                vuvid = amount / eur;

            }
            else if (choice == "3")
            {
                vuvid = amount / rub;

            }
            else if (choice == "4")
            {
                vuvid = usd * amount;

            }
            else if (choice == "5")
            {
                vuvid = eur * amount;

            }
            else if (choice == "6")
            {
                vuvid = rub * amount;
            }
        }
        public static void Output()
        {
            Console.WriteLine(vuvid);
        }

    }
}

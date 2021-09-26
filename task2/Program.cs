using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввести значення сторони a:");
            Console.WriteLine("Ввести значення сторони b:");

            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());

            Rectangle exampler1 = new Rectangle(a, b);
            exampler1.AreaCalculator();
            exampler1.PerimeterCalculator();

            Console.WriteLine($" Area = {exampler1.AreaCalculator()}, P = {exampler1.PerimeterCalculator()}");
            Console.ReadLine();


        }
    }
    class Rectangle
    {
        private double side1, side2;
        public double Side1
        {
            get
            {
                return side1;
            }
            set
            {
                side1 = value;
            }
        }
        public double Side2
        {
            get
            {
                return side2;
            }
            set
            {
                side2 = value;
            }
        }
        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        public double AreaCalculator()
        {
            return side1 * side2;
        }
        public double PerimeterCalculator()
        {
            return (side1 + side2) * 2;
        }
    }
}

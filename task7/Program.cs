using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Console.InputEncoding = System.Text.Encoding.UTF8;
            Employee emp = new Employee();
            Employee.Oznach();
        }
    }
    class Employee
    {
        public static string name, surname, position;
        public static double years;
        public static string input;
        public static double nalog, oklad;
        public Employee()
        {
            Console.WriteLine("Ввести ім'я: ");
            name = Console.ReadLine();
            Console.WriteLine("Ввести фамілію : ");
            surname = Console.ReadLine();
            Console.WriteLine("Введіть роки стажу: ");
            years = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введіть свою посаду: ");
            Console.WriteLine("Введіть 1, якщо посада менджер ");
            Console.WriteLine("Введіть 2, якщо посада спеціаліст");
            Console.WriteLine("Введіть 3, якщо посада директор");
            input = Console.ReadLine();



        }
        public static void Oznach()
        {
            Console.WriteLine("Ім'я: " + name);
            Console.WriteLine("Фамілія: " + surname);


            if (input == "1")
            {
                nalog = 20000 * 0.2 / years;
                oklad = 20000 - nalog;
                Console.WriteLine("Посада: менеджер");

            }
            else if (input == "2")
            {
                nalog = 30000 * 0.2 / years;
                oklad = 30000 - nalog;
                Console.WriteLine("Посада: спеціаліст ");


            }
            else if (input == "3")
            {
                nalog = 40000 * 0.2 / years;
                oklad = 40000 - nalog;
                Console.WriteLine("Посада: директор");

            }
            Console.WriteLine("Налог: " + nalog);
            Console.WriteLine("Оклад: " + oklad);



        }
    }
}

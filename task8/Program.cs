using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть назву товару: ");
            string tovar = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введіть  кількість товару: ");
            int quantity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть ціну товару: ");
            double price = Convert.ToDouble(Console.ReadLine());
            Invoice human = new Invoice(45567, "Petro", "Ivan");
            Invoice tov = new Invoice(tovar, quantity, price);


        }
    }
    class Invoice
    {
        private string article;
        private static int quantity;
        public static double sum;
        public static double price;
        string customer, provider;
        int account;
        public Invoice(int account, string provider, string customer)
        {
            this.account = account;
            this.provider = provider;
            this.customer = customer;
        }
        public Invoice(string tovar, int quantity, double price)
        {
            Invoice.quantity = quantity;
            Invoice.price = price;
            Invoice.bezNDS();
            Invoice.zNDS();

        }
        public static void bezNDS()
        {
            sum = quantity * price;
            Console.WriteLine("Оплата без НДС: " + sum);
        }
        public static void zNDS()
        {
            sum = quantity * price * 0.2;
            Console.WriteLine("Оплата з НДС: " + sum);

        }



    }
}

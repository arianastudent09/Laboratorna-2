using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Address
    {
        private string country, city, street;
        private int index, house, apartment;
        public int Index
        {
            get
            {
                return index;


            }
            set
            {
                index = value;

            }
        }
        public int House
        {
            get
            {
                return house;

            }
            set
            {
                house = value;
            }
        }
        public int Apartment
        {
            get
            {
                return apartment;

            }
            set
            {
                apartment = value;
            }
        }
        public string Country
        {
            get
            {
                return country;

            }
            set
            {
                country = value;
            }
        }
        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }
        public string Street
        {
            get
            {
                return street;
            }
            set
            {
                street = value;
            }
        }

    }




    class Program
    {
        static void Main(string[] args)
        {
            Address exampler = new Address();
            exampler.Index = 78500;
            exampler.City = "Lviv";
            exampler.Country = "Ukraine";
            exampler.Apartment = 45;
            exampler.House = 67;
            exampler.Street = "Bogdana Khmelnitskogo";
            Console.WriteLine($"{exampler.Index},{exampler.City},{exampler.Country},{exampler.Apartment},{exampler.House},{exampler.Street}");
            Console.ReadLine();

        }
    }


}

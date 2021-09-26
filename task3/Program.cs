using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Title constr = new Title();
            Author constr1 = new Author();
            Content constr2 = new Content();

            Book.Show();

        }
    }
    class Book
    {
        static public void Show()
        {
            Title.Show();
            Author.Show();
            Content.Show();
        }
    }
    class Title
    {
        public static string information;
        public Title()
        {
            Console.WriteLine("Ввести назву книги:");
            information = Console.ReadLine();
        }
        public static void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Назва книги: " + information);
        }
    }
    class Author
    {
        public static string author;
        public Author()
        {
            Console.WriteLine("Ввести автора:");
            author = Console.ReadLine();
        }
        public static void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Автор: " + author);
        }
    }
    class Content
    {
        public static string zmist;
        public Content()
        {
            Console.WriteLine("Ввести опис:");
            zmist = Console.ReadLine();
        }
        public static void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Опис книги: " + zmist);
        }
    }
}

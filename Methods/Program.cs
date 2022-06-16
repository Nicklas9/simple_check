using System;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("overtwist", "Nicklas", 400);
            Book book2 = new Book("Crazy Gods", "Jacob", 900);
            Console.WriteLine(book1.author);
            Console.WriteLine(book1.hasStandardPage());
            Console.WriteLine(book2.author);
            Console.WriteLine(book2.hasStandardPage());
        }
    }
}

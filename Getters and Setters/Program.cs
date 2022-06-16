using System;

namespace Getters_and_Setters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Movies amazingSpiderMan = new Movies("2hours", "Noel", "PG");
            Console.WriteLine(amazingSpiderMan.Rating);
        }
    }
}

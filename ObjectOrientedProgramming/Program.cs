using System;

namespace ObjectOrientedProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Person person = new Person("name","123@t.com",89);
            person.IsEligibleForVisa();
            Student student = new Student();
            Console.Read();
        }
    }
}

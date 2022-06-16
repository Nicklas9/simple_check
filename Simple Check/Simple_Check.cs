using System;

class Simple_Check
{
    static void Main()
    {
        //Console.Write("what is your score in algorithm: ");
        //int score = int.Parse(Console.ReadLine());
        //if(score >= 70)
        //{
        //    Console.WriteLine("excellence!");
        //}
        //else
        //    Console.WriteLine("do better next time.");
        Console.WriteLine("what is the day of week? ");
        string dayOfTheWeek = Console.ReadLine();
        Console.WriteLine("hello");
        Console.WriteLine("i want some mangoes, bananas, oranges.");
        if(dayOfTheWeek == "monday" || dayOfTheWeek == "friday")
        {
            Console.WriteLine("please do add some apples too.");
        }
        else if(dayOfTheWeek == "tuesday" || dayOfTheWeek == "sunday" || dayOfTheWeek == "thursday")
        {
            Console.WriteLine(" please do add some watermelo, paw-paw and grapes");
        }
        else
        {
            Console.WriteLine(" please do add some cashew, pear and dates");
        }
        Console.WriteLine("thank you good sir");
    }
}


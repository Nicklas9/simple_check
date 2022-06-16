using System;
class Prime_Number
{
    static void Main()
    {
        Console.Write("num1: ");
        int num1 = int.Parse(Console.ReadLine());
        //Console.Write("num2: ");
        //int num2 = int.Parse(Console.ReadLine());
        if (num1 % 2 != 0 && num1 / num1 == 1)
        {
            Console.WriteLine("prime number");
        }
        else
        {
            Console.WriteLine("not a prime number");
        }
    }
}


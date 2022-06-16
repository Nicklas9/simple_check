using System;
class Check_Series
{
    static void Main()
    {
        Console.Write("number: ");
        int number = int.Parse(Console.ReadLine());
        //if(number == 1)
        //{
        //    Console.WriteLine("one");
        //}
        //else if(number == 2)
        //{
        //    Console.WriteLine("two"); 
        //}
        //else if (number == 3)
        //{
        //    Console.WriteLine("three");
        //}
        //else if (number == 4)
        //{
        //    Console.WriteLine("four");
        //}
        //else if (number == 5)
        //{
        //    Console.WriteLine("five");
        //}
        //else if (number == 6)
        //{
        //    Console.WriteLine("six");
        //}
        //else if (number == 7)
        //{
        //    Console.WriteLine("seven");
        //}
        //else if (number == 8)
        //{
        //    Console.WriteLine("eight");
        //}
        //else if (number == 9)
        //{
        //    Console.WriteLine("nine");
        //}
        //else if (number == 10)
        //{
        //    Console.WriteLine("ten");
        //}
        //else if (number >= 0)
        //{
        //    Console.WriteLine("number less than one");
        //}
        //else
        //{
        //    Console.WriteLine("its more than ten");
        //}
        Console.WriteLine(NumberToWords(number));

    }
    static string NumberToWords(int number)
    {
        string numberInWord;
        switch (number)
        {
            case 0:
                numberInWord = "zero";
                break;
            case 1:
                numberInWord = "one";
                break;
            case 2:
                numberInWord = "two";
                break;
            case 3:
                numberInWord = "three";
                break;
            case 4:
                numberInWord = "four";
                break;
            case 5:
                numberInWord = "five";
                break;
            case 6:
                numberInWord = "six";
                break;
            case 7:
                numberInWord = "seven";
                break;
            case 8:
                numberInWord = "eight";
                break;
            case 9:
                numberInWord = "nine";
                break;
            case 10:
                numberInWord = "ten";
                break;
            default:
                numberInWord = "number greater than ten";
                break;
        }
        return numberInWord;
    }
}


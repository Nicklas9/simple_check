using System;

namespace Static_Class_Attribute
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Song lie = new Song("Lie", "Kiss Daniel", 300);
            Console.WriteLine(Song.songCount);
            Song sweet_love = new Song("Sweet Love", "Wizkid",360);
            Console.WriteLine(Song.songCount);

        }
    }
}

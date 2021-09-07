using System;

namespace greetings
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja nime
            //programm tervtab kasutajat nimepidi
            Console.WriteLine("Mis su nimi on?");

            string UserName = Console.ReadLine();
            //Console.WriteLine("Hello, " + UserName);

            //string interpolation

            // {} - alrGr + 7 / altGr + 0
            Console.WriteLine($"Hello, {UserName}");

            Console.ReadLine();
        }
    }
}

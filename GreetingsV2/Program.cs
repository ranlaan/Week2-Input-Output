using System;

namespace GreetingsV2
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja eesnime
            //programm küsib kasutaja perekonnanime
            //programm tervitab kasutajat, kasutades neid andmeid 

            Console.WriteLine("Mis su eesnimi on?");
            String UserName1 = Console.ReadLine();

            Console.WriteLine("Mis su perekonna nimi on?");
            String Username2 = Console.ReadLine();

            Console.WriteLine($"Hello, {UserName1} {Username2}");


        }
    }
}

using System;

namespace Chocolate_Lazy
{
    class Program
    {
        static void Main(string[] args)
        {
            // ÖVNING - ÖVNING - ÖVNING - ÖVNING - ÖVNING - ÖVNING - ÖVNING - ÖVNING -
            // ÖVNING - ÖVNING - ÖVNING - ÖVNING - ÖVNING - ÖVNING - ÖVNING - ÖVNING -
            // ÖVNING - ÖVNING - ÖVNING - ÖVNING - ÖVNING - ÖVNING - ÖVNING - ÖVNING -
            // ÖVNING - ÖVNING - ÖVNING - ÖVNING - ÖVNING - ÖVNING - ÖVNING - ÖVNING -

            // 1. Följ exemplet och skriv koden i denna fil "Singleton Design Pattern.pdf"
            // 2. Rita ditt eget UML diagram i Draw.io som beskriver din kod

            // OBS: Exemplet i pdf filen är skriven i Java... du ska så klart skriva i C#!
            // ///////////////////////////////////////////////////////////////////////////

            // Lazy instantiation
            // Lazy instantiation
            // Lazy instantiation
            // Lazy instantiation

            Console.WriteLine("Lazy instantiation");
            Console.WriteLine("First we get an instance of our singleton");
            Console.WriteLine("Now we can call for next id...");
            Console.WriteLine("ID: " + Singleton.GetInstance().GetNextId());
            Console.WriteLine();

            Console.WriteLine("If we try to get our singleton again... it returns the same object");
            Console.WriteLine("So the next id will be 2... ");
            Console.WriteLine("(if it was a new Singleton object the id would be 1 again)");
            Console.WriteLine("ID: " + Singleton.GetInstance().GetNextId());

            // Eager instantiation
            // Eager instantiation
            // Eager instantiation
            // Eager instantiation

            Console.WriteLine("=========================================================");
            Console.WriteLine("Eager instantiation");
            Console.WriteLine("First we get an instance of our singleton");
            Console.WriteLine("Now we can call for next id...");
            Console.WriteLine("ID: " + SingletonEager.GetInstance().GetNextId());
            Console.WriteLine();

            Console.WriteLine("If we try to get our singleton again... it returns the same object");
            Console.WriteLine("So the next id will be 2... ");
            Console.WriteLine("(if it was a new Singleton object the id would be 1 again)");
            Console.WriteLine("ID: " + SingletonEager.GetInstance().GetNextId());
        }
    }
}

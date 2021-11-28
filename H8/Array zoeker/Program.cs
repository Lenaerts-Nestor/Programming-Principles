using System;

namespace Array_zoeker
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //variabelen
            int[] arrayZ = new int[10];
            int waardevragen;
            int waardeTeVerwijderen;
            int tevervangendewaarde = -1; //volgens de oefening: laatste plek krijgt de waard -1

            //array invullen
            for (int i = 0; i < arrayZ.Length; i++)
            {
                Console.Write($"{i} waarde:  ");
                waardevragen = Convert.ToInt32(Console.ReadLine());
                arrayZ[i] = waardevragen;
            }

            //waarde vinden die je wilt verwijderen
            Console.WriteLine("welke waarde wil je bewegen");
            waardeTeVerwijderen = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();
            Console.Clear();
            //dit is om de positie te weten in de array
            int indexnummer = 0;

            //de waarde zoeken
            for (int P = 0; P < arrayZ.Length; P++)
            {
                if (arrayZ[P] == waardeTeVerwijderen )
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("waarde gevonden");
                    Console.ResetColor();
                    Console.WriteLine($"positie:{P}, waarde:{arrayZ[P]}");

                    indexnummer = P;
                }
            }


            //alle elementen vanaf die index naar vooropshuifen
            Console.WriteLine($"\nalle elementen vanaf positie: {indexnummer}, naar vooropshuifen \n");
            for (int T = indexnummer; T < arrayZ.Length-1; T++)
            {
                
                arrayZ[T] = arrayZ[T + 1];
                Console.WriteLine($"positie: {T}, waarde {arrayZ[T]}");
                
            }
            Console.WriteLine();
            // de laatste nummer derbij doen
            arrayZ[10 - 1] = tevervangendewaarde;
            // controleren als alles correct is:
            Console.WriteLine("de array controleren: \n");
            for (int W = 0; W < arrayZ.Length; W++)
            {
                Console.WriteLine($"positie: {W}, waarde: {arrayZ[W]}");

            }


            

        }
    }
}

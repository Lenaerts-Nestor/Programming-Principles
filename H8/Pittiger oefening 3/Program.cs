using System;

namespace Pittiger_oefening_3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Er worden 20 getallen ingelezen. De getallen worden 3 plaatsen naar achter verschoven afgedrukt,
            //d.w.z. eerst het derde laatste ingelezen getal, dan het voorlaatste ingelezen getal, dan het laatste ingelezen getal,
            //dan het eerste ingelezen getal, dan het tweede ingelezen getal en tenslotte het vierde laatste ingelezen getal.

            int[] arrayY = new int[20];
            int[] arrayP = new int[3]; 
            //array invullen
            for (int i = 0; i < arrayY.Length; i++)
            {
                arrayY[i] = i;
                //ik toon de eerste 3 waarde in groen
                if (arrayY[i] == arrayY[0] || arrayY[i] == arrayY[1] || arrayY[i] == arrayY[2] )
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"array inhoud {i}: {arrayY[i]}");
                    //ik bewaar de eerste 3 nummers ergens anders bv: in een andere array
                    arrayP[i] = arrayY[i];
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine($"array inhoud {i}: {arrayY[i]}");
                    
                }
            }

            //spatie
            Console.WriteLine("\n");
            Console.ReadKey();

            // je kan dit kleiner shrijven, maar ik heb het zo gedaan
            for (int O = 3; O < arrayY.Length; O++)
            {
                Console.WriteLine($"array inhoud {O}: {arrayY[O]}");
            }
            for (int P = 0; P < arrayP.Length; P++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"array inhoud {P}: {arrayY[P]}");
                Console.ResetColor();
            }

            Console.ReadKey();


        }
    }
}

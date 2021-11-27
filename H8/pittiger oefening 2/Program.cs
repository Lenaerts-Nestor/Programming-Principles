using System;

namespace pittiger_oefening_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Er worden 20 getallen ingelezen. De getallen worden 1 plaats naar voor verschoven afgedrukt,
            //d.w.z. eerst het tweede ingelezen getal, dan het derde ingelezen getal, dan het vierde ingelezen getal , ... ,
            //dan het laatste ingelezen getal en tenslotte het eerste ingelezen getal.

           int[] arrayX = new int[20];
            //array invullen
            for (int i = 0; i < arrayX.Length; i++)
            {
                arrayX[i] = i;
                //ik toon eerste waarde in groen
                if (arrayX[i] == arrayX[0])
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"array inhoud {i}: {arrayX[i]}");
                    Console.ResetColor();
                    i = 1;
                }
                Console.WriteLine($"array inhoud {i}: {arrayX[i]}");
                
            }
            Console.WriteLine("\n");
            //array tonen vanaf de tweede waard : dus 1 in deze geval
            for (int o = 1; o < arrayX.Length; o++)
            {
                
                Console.WriteLine($"array inhoud {o}: {arrayX[o]}");

            }
            // de eerste array waarde tonen: dus 0
            Console.WriteLine($"array inhoud 0: {arrayX[0]}");



        }
    }
}

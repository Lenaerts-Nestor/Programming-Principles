using System;

namespace Pittiger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // 1: Er worden 20 getallen ingelezen. De getallen worden in omgekeerde volgorde afgedrukt.

            //variabelen
            int[] array1 = new int[20];
            //array invullen met nummers
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = i;
                Console.WriteLine($"array inhoud {i}: {array1[i]}");
            }
            //controleer hoeveel de lengte is:
            Console.WriteLine($"array lengte: {array1.Length}");
            Console.WriteLine("");
            //array omgekeerd tonnen
            Console.WriteLine($"array lengte omgekeerd");
            for (int o = array1.Length-1; o > -1; o--)
            {
                Console.WriteLine(array1[o]);
            }
            


            
        }
    }
}

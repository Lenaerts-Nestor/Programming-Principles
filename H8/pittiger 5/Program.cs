using System;

namespace pittiger_5
{
    class Program
    {

        //nog niet aff
        static void indrukken(int[] getal, int aantalrijen, int aantalkollomen)
        {
            for (int i = 1; i < aantalkollomen; i++)
            {
                
                Console.WriteLine($"{i}: {getal[i]}");
            }


        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //variabelen
            int[] arrayGetallen = new int[] { 4, 5, 8, 7, 5, 2, 6, 8, 7, 1, 3, 2 };
            
            int aantalkollomen = 3;
            int aantalrijen = 3;


            //array 
            for (int i = 0; i < aantalrijen; i++)
            {
                if (true)
                {
                    Console.WriteLine($"{i}: ");
                }
            }








        }
    }
}

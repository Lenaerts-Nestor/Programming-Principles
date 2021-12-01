using System;

namespace Hamming_distance
{
    class Program
    {

        static void arraytonen(string[] array1)
        {
            
            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write($"{array1[i]}");
            }
            Console.WriteLine();

        }
        static void Main(string[] args)
        {
            //variabelen
            string[] dna1 = new string[14] { "G","A","G","C","C","T","A","C","T","A","A","C","G","A"} ;
            string[] dna2 = new string[14] { "T","A","G","T","C","T","A","R","P","A","A","T","T","A" };
            string[] hamming = new string[14];
            for (int i = 0; i < dna1.Length; i++)
            {
                if (dna1[i] != dna2[i])
                {
                    hamming[i] = "^";
                }
                else
                {
                    hamming[i] = " ";
                }
            }


            arraytonen(dna1);
            arraytonen(dna2);
            arraytonen(hamming);



        }
    }
}

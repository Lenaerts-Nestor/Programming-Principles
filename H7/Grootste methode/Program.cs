using System;

namespace Grootste_methode
{
    class Program
    {
        static int grootsteMethode(int bedrag1, int bedrag2, int bedrag3)
        {
            int grootste = 0;
            if (bedrag1 > bedrag2 & bedrag1 > bedrag3)
            {
                grootste = bedrag1;
            }
            else if (bedrag2 > bedrag1 & bedrag2 > bedrag3)
            {
                grootste = bedrag2;
            }
            else if (bedrag3 > bedrag1 & bedrag3 > bedrag2)
            {
                grootste = bedrag3;
            }
            return grootste;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("shrijf 3 bedragen");
            int bedrag1t = Convert.ToInt32(Console.ReadLine());
            int bedrag2t = Convert.ToInt32(Console.ReadLine());
            int bedrag3t = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"de grootste bedrag: {grootsteMethode(bedrag1t, bedrag2t, bedrag3t)}");
        }
    }
}

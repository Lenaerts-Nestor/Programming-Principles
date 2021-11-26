using System;

namespace Paswoord_generator_methode
{
    
    class Program
    {
        static double Deel(double getal1, double getal2)
        {
            double getal = getal1 / getal2;
            return getal;
        }
        static double VermenigVuldig(double getal1, double getal2)
        {
            double getal = getal1 * getal2;
            return getal;
        }
        static double TrekAf(double getal1, double getal2)
        {
            double getal = getal1 - getal2;
            return getal;
        }
        static double TelOp(double getal1, double getal2)
        {
            double getal = getal1 + getal2;
            return getal;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("rekenmachine");
            Console.WriteLine("kies een van de volgende (1:som),(2:min),(3:maal),(4:deel)");
            int antwoord = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("shrijf twee getalen");
            int getal1 = Convert.ToInt32(Console.ReadLine());
            int getal2 = Convert.ToInt32(Console.ReadLine());
            switch (antwoord)
            {
                case 1:
                    Console.WriteLine(TelOp(getal1,getal2));
                    break;
                case 2:
                    Console.WriteLine(TrekAf(getal1, getal2));
                    break;
                case 3:
                    Console.WriteLine(VermenigVuldig(getal1, getal2));
                    break;
                case 4:
                    Console.WriteLine(Deel(getal1,getal2));
                    break;
                default:
                    Console.WriteLine("ERROR, Herstat de programma");
                    break;
            }


        }
    }
}

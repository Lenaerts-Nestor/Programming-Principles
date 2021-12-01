using System;

namespace LeveringsBedrijf
{
    class Program
    {
        
        static void Main(string[] args)
        {

            //variabelen + array invullen direct (zelf kiezen)

            int[] postcode = new int[10] { 2000, 2020, 2030, 2050, 2060, 2080, 2100, 2120, 2200, 2500 };
            int[] prijsPerKilo = new int[10] { 35, 37, 38, 42, 46, 70, 80, 90, 120, 300 };
            int gekozenlocatie = 0;
            int index = 0;
            int gewicht = 0;
            bool gevonden = false;
            //vraag welke postcode hij wilt 
            Console.WriteLine("naar waar wil je het pakket sturen");
            gekozenlocatie = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("geef gewicht van pakket");
            gewicht = Convert.ToInt32(Console.Read());
            //controleer gekozenlocatie in de array en doe hele oefening
            for (int i = 0; i < postcode.Length; i++)
            {
                if (gekozenlocatie == postcode[i])
                {
                    index = i;
                    gevonden = true;
                }
                else
                {
                    gevonden = false;
                }

            }

            if (gevonden = true)
            {
                Console.Write($"Prijs om te verzenden: {gewicht * prijsPerKilo[index]}$ naar postcode: {postcode[index]} ");
                Console.WriteLine("");

            }
            else
            {
                Console.WriteLine($"de locatie: {gevonden} leveren we niet");
            }








        }
    }
}

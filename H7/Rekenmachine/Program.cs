using System;

namespace Rekenmachine
{
    class Program
    {
        static string passwordGeneratorMethode(int lengte)
        {
            //ik heb de oefening juist gemaakt, maar der is een kleine probleempje:
            //de lengte word eentje langer of kleiner (bv: lengte = 15, resultaat: 14 of 16)

            //variabelen
            Random Generatormethode = new Random();
            int bepaaldelengte = lengte;
            char letters;
            char hoofdletters;
            int cijfers;
            string password = "";

            //bewerking
            for (int i = 0; i <= bepaaldelengte; i++)
            {
                //random bedragen/letters genereren
                letters = Convert.ToChar(Generatormethode.Next(60,90));
                hoofdletters = Convert.ToChar(Generatormethode.Next(97, 123));
                cijfers = Generatormethode.Next(1, 99);


                //bijvoegen
                password += letters;
                i++;
                password += hoofdletters;
                i++;
                password += Convert.ToString(cijfers);
                i++;

            }

            //return de password
             return password ;

        }
        static void Main(string[] args)
        {

            //variabelen
            int lengte = 0;
            //pasword generator:
            Console.WriteLine("welkom bij de password generator: ");
            Console.WriteLine("shrijf de lengte van de password:");
            lengte = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"het password is: {passwordGeneratorMethode(lengte)}");
            
        }
    }
}

using System;

namespace Vraag_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /*
            Maak een array die 6 strings kan bevatten.
            Ieder element van de array bevat een vraag (naar keuze te verzinnen) als string waar de gebruiker met een getal op moet antwoorden.
            Maak een array aan die tot 6 ints kan bevatten. Lees 1 voor 1 de vraag uit de string-array uit en toon deze op het scherm.
            Lees vervolgens het antwoord uit dat de gebruiker intypt en bewaar dit als int in de 2e array.
             */

            //variabelen: om dat ik al de waarde weet wat in de array moet staan, schrijf ik ze meteeen.
            string[] arrayT = new string[6]
            {
                "Hoe oud ben je? ",
                "Wat is je postcode? ",
                "Hoeveel broers heb je? ",
                "hoeveel zussen heb je? ",
                "Wanneer ben je geboren? ",
                "hoeveel is 3+5 ?"
        };
            int[] arrayX = new int[6];

            //vragen voor lezen en arrayX invullen.
            for (int i = 0; i < arrayT.Length-1; i++)
            {
                Console.Write(arrayT[i]);
                arrayX[i] = Convert.ToInt32(Console.ReadLine());
              
            }
            Console.ReadKey();
            Console.Clear();

            //alles vragen en antwoorden tonen
            Console.WriteLine("je antwoorden:");
            for (int P = 0; P < arrayT.Length; P++)
            {
                Console.Write(arrayT[P]);
                Console.WriteLine(arrayX[P]);
            }
            




        }
    }
}

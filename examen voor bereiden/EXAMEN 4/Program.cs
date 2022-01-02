using System;

namespace EXAMEN_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //array met lengte 100;
            char[] code = new char[100];
            code = MaakSignaal(code);

            //Toon de gegenereerde code op het scherm
            for (int i = 0; i < code.Length; i++)
            {
                Console.Write(code[i]);
            }
            Console.WriteLine("\n");
            VisualiseerCode(code);
            Console.WriteLine("\n");
            
            
        }
        static char[] MaakSignaal(char[] characters)
        {
            //genereert een radom array met lengte 100 en zet random Hoofdletters derin
            Random Letter = new Random();
            for (int i = 0; i < characters.Length; i++)
            {
                characters[i] = Convert.ToChar(Letter.Next(65, 91));
            }

            return characters;

        }
        static void VisualiseerCode(char[] code)
        {

            //element per element overlopen, ik gebruik een for omdat ik weet de aantal keer dat het moet gebeuren.
            for (int i = 0; i < code.Length; i++)
            {
                
                if (NeedsColor(code[i]) == true)
                {
                    WriteCharInRed(code[i]);
                }
                else
                {
                    Console.Write($".");
                }


            }


        }
        static bool NeedsColor(char element)
        {
            bool teruggeven = false;
            
            switch (element)
            {
                case 'X':
                case 'Y':
                case 'Z':
                case 'Q':
                    teruggeven = true;
                    break;
                default:
                    teruggeven = false;
                    break;
            }
            


            return teruggeven;
        }
        static void WriteCharInRed(char element)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"{element}");
            Console.ResetColor();
        }
        static void AnalyseerCode(char[] code)
        {


        }
        static int CountSpecial(char[] code)
        {

            return 1;
        }
    }
}

using System;

namespace Film_Default
{
    class Program
    {
        //je kan meer genre's derbij zetten
        enum genre { Drama,Actie,onbekend}

        static void FilmRunTime(string naam, int duur =90, genre genrefilm = genre.onbekend)
        {
            Console.WriteLine($"{naam} ({duur} minuten,{genrefilm})");
        }
        static void Main(string[] args)
        {

            //variabelen
            string naam = "";
            int duur = 0;
            int vraaggenre = 0;
            genre filmgenre = genre.onbekend;

            //waarden vragen aan user als jij de waarden wilt invullen.
            Console.Write("naam van de film? ");
            naam = Console.ReadLine();
            Console.WriteLine($"duur van de film?");
            duur = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"genre van de film? (1: Drama, 2:Actie, 3: onbekend)");
            vraaggenre = Convert.ToInt32(Console.ReadLine());
            //controleer de genre
            switch (vraaggenre)
            {
                case 1:
                    filmgenre = genre.Drama;
                    break;
                case 2:
                    filmgenre = genre.Actie;
                    break;
                case 3:
                    filmgenre = genre.onbekend;
                    break;
                default:
                    filmgenre = genre.onbekend;
                    break;
            }
            //voer de methode uit
            FilmRunTime(naam, duur, filmgenre);






        }
    }
}

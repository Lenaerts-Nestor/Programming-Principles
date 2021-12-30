using System;

namespace examen_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //arrays voor fase 3
            bool[] kopenJa = new bool[20];
            int[] prijzen = new int[20];


            //1.2 Fase 1: Setup (4 punten)
            Console.WriteLine("Geef moeilijkheidsgraad in (een getal van 1 tot en met 9)");
            int moeilijkheidsgraad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Krijg de trainee een startbonus? [j/n]");
            string traineeantwoord = Console.ReadLine();
            bool traineBonus;

            if (traineeantwoord == "j")
            {
                traineBonus = true;
            }
            else
            {
                traineBonus = false;
            }

            Console.WriteLine($"je start budget is {(BudgetGenerator(moeilijkheidsgraad, traineBonus))}");
            double budget = BudgetGenerator(moeilijkheidsgraad, traineBonus);
            //decoratie
            Console.WriteLine("******************");




            //Fase 2: Training (8 punten)
            string kopen;


            int i = -1;
            do
            {
                int huisprijs = Huisprijs();
                i++;
                Console.WriteLine($"je budget is nu {budget}");
                Console.WriteLine("------------------");

                Console.WriteLine($"Wil je dit huis nr{i} kopen? het kost {huisprijs} euro. [j/n]");
                kopen = Console.ReadLine();
                if (kopen == "j")
                {
                    if (budget > huisprijs)
                    {
                        kopenJa[i] = true;
                        prijzen[i] = huisprijs;
                        budget -= huisprijs;
                    }
                    else
                    {
                        kopenJa[i] = false;
                        Console.WriteLine("je hebt niet genoeg saldo");
                    }
                }
                else
                {
                    kopenJa[i] = false;
                    prijzen[i] = huisprijs;
                }
                Console.Clear();
            } while (i < kopenJa.Length-1 && budget > 0);
                

            
            Console.WriteLine("einde fase 2");
            Console.ReadKey();
            Console.Clear();

            //fase 3
            double gemiddeldeAntwoord = BerekenGemiddelde(kopenJa, prijzen);
            Console.WriteLine($"gemiddelde: " + gemiddeldeAntwoord);




        }
        

        //1.2.1 Methode BudgetGenerator
        static double BudgetGenerator(int graad, bool bonus = true)
        {
            //variabelen
            const int basisbudget = 5000;
            double budget = basisbudget;
            
            //bonus
            if (bonus == true)
            {
                budget += 2500;
            }
            else
            {
                //niks
            }

            //alles uitwerken

            budget -= (100 * graad);

            return budget;


        }

        //Methode HuisPrijs
        static int Huisprijs()
        {
            
            //kamers van 1 tot 3
            Random kamers = new Random();
            int aantalkamers = kamers.Next(1, 4);
            // 1/3 van de huizen krijt een terras
            Random terrasKans = new Random();
            bool krijtTeras = false;

            if (terrasKans.Next(1,4) > 2)
            {
                krijtTeras = true;
            }


            //prijzen
            int PrijsHuiz = 1000;
            int PrijsSlaapkamers = 120;
            int PrijsTerras = 450;
            int totaal;
            
            //return
            if (krijtTeras == true)
            {
                totaal = PrijsHuiz + (aantalkamers * PrijsSlaapkamers) + PrijsTerras;
                Console.WriteLine($"Huis met {aantalkamers} kamers en een terras: {totaal}");
                return totaal;
            }
            else
            {
                totaal = PrijsHuiz + (aantalkamers * PrijsSlaapkamers);
                Console.WriteLine($"Huis met {aantalkamers} kamers en geen terras: {totaal}");
                return totaal;
            }
        }
        static double BerekenGemiddelde(bool[] array, int[] Prijzen)
        {
            int som = 0;
            int gemiddelde = 0;
            Console.WriteLine("fase 3");
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == true)
                {
                    som += Prijzen[i];
                    Console.WriteLine($"Huis met prijs {Prijzen[i]} heb je gekocht");
                    gemiddelde++;
                }
                else
                {
                    Console.WriteLine($"Huis met prijs {Prijzen[i]} heb je niet gekocht");
                }

            }
            int antwoord = som / gemiddelde;
            
            return antwoord;

        }



    }
}

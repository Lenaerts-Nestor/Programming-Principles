using System;

namespace examen_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Hoofdprogramma (6p)

            Console.ResetColor();
            //variabelen
            char gestart;
            int teller = 1;    //dit is de jaren
            int[] array = new int[52]; //dit is de weeklogboek
            int[] Jaarlogbook = new int[10];

            //een hoofdloop die de jaren voorstelt: 10 keer
            
            do
            {
                //na eerste jaar van teller, word ToonLogbook methode getoont
                if (teller > 1)
                {
                    
                    Console.WriteLine($"\n Jaar {teller-1} ");
                    Toonlogbook(array);
                    Console.ResetColor();
                    Console.WriteLine("\n");
                    
                }
                
                Console.WriteLine("moet er nog een jaar gestart?");
                gestart = Convert.ToChar(Console.ReadLine());
                if (gestart == 'n')
                {
                    //programma stopt
                    gestart = 'n';
                }
                else   //loop for de weken
                {
                    //weekloop wordt gestart (52 keer herhalen)
                    for (int i = 1; i <= array.Length-1; i++)
                    {
                        Console.WriteLine($"week: {i}, jaar {teller}");
                        //test alarm gestart && methode TestAlarm word aangeroept
                        if (i == 1 || i == 11 || i == 21 || i == 31 || i == 41 || i == 51)
                        {
                            TestAlarm();
                            array[i] = 0;
                        }
                        else   //25% kans dat de alarm afgaat && StartAlarmGebouw word aangeroept
                        {
                            Random kans = new Random();
                            if (kans.Next(1,5) == 1)
                            {
                                Random gebouw = new Random();
                                //Methode Start AlarmGebouw moet hier
                                //Het alarm gaat in een van de 3 willekeurige gebouwen door (=eerste parameter).  De kans is per gebouw even groot.
                                //Via de tweede parameter wordt aangegeven dat het niét om een test gaat
                                StartAlarmgebouw(gebouw.Next(1, 4), false);
                                array[i] = 1;
                            }  
                            else   //else moet niet maar ik heb het gezet voor duidelijkheid
                            {
                                array[i] = 2;
                            }


                        }
                    }

                }

                teller++;
                //stuf inzeten in de array i suppose ;c

            } while (teller <= 10 && gestart != 'n');


            
        }

        static void StartAlarmgebouw(int gebouwNr, bool alarm )
        {
            if (alarm == true)
            {
                Console.WriteLine($"Gebouw {gebouwNr} geevacueerd tgv alarm (ECHT ALARM).");
            }
            else
            {
                Console.WriteLine($"Gebouw {gebouwNr} geevacueerd tgv alarm (dit was een test).");
            }
           

        }
        static void TestAlarm()
        {
            //wilkeurige gebouw generator
            Random randomGebouw = new Random();
            int Rnummer = randomGebouw.Next(1, 11);
            int gekozenGebouw =0;
            if (Rnummer < 3)
            {
                gekozenGebouw = 1;
            }
            else if (Rnummer >= 3 && Rnummer < 6 )
            {
                gekozenGebouw = 2;
            }
            else if (Rnummer >= 5) // ik kan gewoon else schrijven maar ik heb else if voor zekerheid gedaan
            {
                gekozenGebouw = 3;
            }

            StartAlarmgebouw(gekozenGebouw, true);

        }
        static void Toonlogbook(int[] array)
        {
            int[] newearray = new int[array.Length];

            int nummertje = 0;
            for ( int teller1 = 1 ; teller1 < array.Length; teller1++)
             {
                
                nummertje++;
                Console.ResetColor();
                switch (array[teller1])
                {
                    case 0:
                        //als ze het aan doen
                        Console.BackgroundColor = ConsoleColor.Green;
                        newearray[teller1] = teller1;
                        Console.Write($"{newearray[nummertje]}");
                        break;
                    case 1:
                        //als ze de alarm afdoen
                        Console.BackgroundColor = ConsoleColor.Red;
                        newearray[teller1] = teller1;
                        Console.Write($"{newearray[nummertje]}");

                        break;
                    default:
                        Console.BackgroundColor = ConsoleColor.Blue;
                        newearray[teller1] = teller1;
                        Console.Write($"{newearray[nummertje]}");
                        break;
                }
                if (nummertje == 9)
                {
                    nummertje = 0;
                }

            }
            
        }
    }
}

namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            int menyVal = 0;
            int minTal = 1;
            int maxTal = 13;
            int dittTal = 0;
            int datornsTal = 0;
            string svårGrad = " ";
            string välkomstMeddelande = "Hej, välkommen till gissa avfarten.";


            string speletsRegler = "I varje omgång av gissa avfarten slumpar dator fram ett heltal mellan 1 och 13." +
                "\nAnvändaren ska gissa vilken avfart som leder till Arlanda, tills hen gissar rätt. " +
                "\nEfter varje gissning ska användaren få veta om gissningen är för hög eller för låg." +
                "\n";


            Random slumpTal = new Random();

            for (int i = 0; i < välkomstMeddelande.Length; i++)
            {
                Console.Write(välkomstMeddelande[i]);
                if (välkomstMeddelande[i] == '.')
                {
                    Thread.Sleep(1000);
                }
                else
                {
                    Thread.Sleep(100);
                }

            }

            Console.WriteLine();
            Console.WriteLine("Gör ett menyval.");

            while (menyVal != 4)
            {
                Console.WriteLine("1. Spela gissa avfarten.");
                Console.WriteLine("2. Spelets regler.");
                Console.WriteLine("3. Svårighetsgrad.");
                Console.WriteLine("4. Avsluta program.");


                menyVal = Convert.ToInt32(Console.ReadLine());

                switch (menyVal)
                {

                    case 1:

                        datornsTal = slumpTal.Next(minTal, maxTal);


                        Console.WriteLine("Gissa avfarten, 1-13");
                        dittTal = Convert.ToInt32(Console.ReadLine());

                        while (dittTal != datornsTal)
                        {
                            if (dittTal > datornsTal)
                            {
                                Console.WriteLine("     /\\\n    /  \\\n   /    \\\n  /   !  \\\n /________\\");
                                Console.WriteLine($"Du gissade fel. Talet {dittTal} var för högt.");
                            }

                            else if (dittTal < datornsTal)

                            {
                                Console.WriteLine("     /\\\n    /  \\\n   /    \\\n  /   !  \\\n /________\\");
                                Console.WriteLine($"Du gissade fel. Talet {dittTal} var för lågt.");
                            }


                            Console.WriteLine("Gissa avfarten igen, 1-13");
                            dittTal = Convert.ToInt32(Console.ReadLine());

                        }
                        if (dittTal == datornsTal)
                        {
                            Console.WriteLine($"Grattis! Du gissade rätt. Den korrekta avfarten var nummer {dittTal}!");
                            break;
                        }

                        break;

                    case 2:

                        Console.WriteLine($"Detta är spelets regler: {speletsRegler}");

                        break;

                    case 3:

                        Console.WriteLine("Välj svårighetsgrad. (Lätt/svår) ");
                        Console.WriteLine("Lätt: Du gissar på samma slumpade tal.");
                        Console.WriteLine("Svår: Du gissar på nytt slumpat tal.");
                        svårGrad = Console.ReadLine();

                        if (svårGrad.ToLower() == "lätt")
                        {
                            datornsTal = slumpTal.Next(minTal, maxTal);

                            Console.WriteLine("Gissa avfarten, 1-13");
                            dittTal = Convert.ToInt32(Console.ReadLine());


                            while (dittTal != datornsTal)
                            {
                                if (dittTal > datornsTal)
                                {
                                    Console.WriteLine("     /\\\n    /  \\\n   /    \\\n  /   !  \\\n /________\\");
                                    Console.WriteLine($"Du gissade fel. Talet {dittTal} var för högt.");
                                }

                                else if (dittTal < datornsTal)

                                {
                                    Console.WriteLine("     /\\\n    /  \\\n   /    \\\n  /   !  \\\n /________\\");
                                    Console.WriteLine($"Du gissade fel. Talet {dittTal} var för lågt.");
                                }


                                Console.WriteLine("Gissa avfarten igen, 1-13");
                                dittTal = Convert.ToInt32(Console.ReadLine());

                            }
                            if (dittTal == datornsTal)
                            {
                                Console.WriteLine($"Grattis! Du gissade rätt. Den korrekta avfarten var nummer {dittTal}!");
                                break;
                            }
                            break;
                        }
                        else if (svårGrad.ToLower() == "svår")
                        {
                            datornsTal = slumpTal.Next(minTal, maxTal);

                            Console.WriteLine("Gissa avfarten, 1-13");
                            dittTal = Convert.ToInt32(Console.ReadLine());


                            while (dittTal != datornsTal)
                            {
                                if (dittTal > datornsTal)
                                {
                                    Console.WriteLine("     /\\\n    /  \\\n   /    \\\n  /   !  \\\n /________\\");
                                    Console.WriteLine($"Du gissade fel. Talet {dittTal} var för högt.");
                                }

                                else if (dittTal < datornsTal)

                                {
                                    Console.WriteLine("     /\\\n    /  \\\n   /    \\\n  /   !  \\\n /________\\");
                                    Console.WriteLine($"Du gissade fel. Talet {dittTal} var för lågt.");
                                }

                                datornsTal = slumpTal.Next(minTal, maxTal);


                                Console.WriteLine("Gissa avfarten igen, 1-13");
                                dittTal = Convert.ToInt32(Console.ReadLine());

                            }
                            if (dittTal == datornsTal)
                            {
                                Console.WriteLine($"Grattis! Du gissade rätt. Den korrekta avfarten var nummer {dittTal}!");
                                break;
                            }

                        }
                        break;

                    case 4:

                        Console.WriteLine("Programmet avslutas..");
                        break;

                    default:

                        Console.WriteLine("Felaktig inmatning.. vänligen försök igen. Välj menyval 1-4.");

                        break;
                }


            }
            Console.ReadLine();
        }
    }
}
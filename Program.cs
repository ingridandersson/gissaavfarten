Console.ForegroundColor = ConsoleColor.Yellow;

int menyVal = 0;
int minTal = 1;
int maxTal = 13;
int dittTal = 0;
int datornsTal = 0;
string svårGrad = " ";
string välkomstMeddelande = "Hej, välkommen till Gissa Avfarten.";

string speletsRegler = "I varje omgång av Gissa Avfarten ska datorn slumpa fram ett heltal, som representerar en avfart, mellan 1 och 13." +
    "\nAnvändaren ska gissa vilket talet är ända tills hen gissar rätt. " +
    "\nEfter varje gissning ska användaren få veta om gissningen var rätt, för hög eller för låg.";

Random slumpTal = new Random();

// Välkomna användaren till Gissa Talet
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

//Presentera menyval
while (menyVal != 4)
{
    Console.WriteLine("1. Spela Gissa Avfarten.");
    Console.WriteLine("2. Spelets regler.");
    Console.WriteLine("3. Svårighetsgrad.");
    Console.WriteLine("4. Avsluta program.");

    menyVal = Convert.ToInt32(Console.ReadLine());

    switch (menyVal)
    {
         
        case 1:
            //Datorn slumpar fram ett tal mellan 1-13
            datornsTal = slumpTal.Next(minTal, maxTal);

            //Användaren gissar vilket tal som datorn slumpat fram
            Console.WriteLine("Gissa vilken avfart som leder till Arlanda, 1-13");
            dittTal = Convert.ToInt32(Console.ReadLine());

            //Användaren gissar tills talet är rätt
            //Efter varje gissning får användaren veta om hen gissat rätt, för högt eller för lågt.
            while (dittTal != datornsTal)
            {
                if (dittTal > datornsTal)
                {
                    Console.WriteLine("     /\\\n    /  \\\n   /    \\\n  /   !  \\\n /________\\");
                    Console.WriteLine($"Du gissade fel. Avfartens nummer {dittTal} var för högt.");
                }

                else if (dittTal < datornsTal)

                {
                    Console.WriteLine("     /\\\n    /  \\\n   /    \\\n  /   !  \\\n /________\\");
                    Console.WriteLine($"Du gissade fel. Avfartens nummer {dittTal} var för lågt.");
                }
              

                Console.WriteLine("Gissa talet igen, 1-13");
                dittTal = Convert.ToInt32(Console.ReadLine());

            }
            if (dittTal == datornsTal)
            {
                Console.WriteLine($"Grattis! Du gissade rätt. Den korrekta avfarten till Arlanda var {dittTal}!");
                break;
            }
            
            break;

        case 2:

            Console.WriteLine($"Detta är spelets regler: {speletsRegler}");
            
            break;

        case 3:

            Console.WriteLine("Välj svårighetsgrad. Skriv lätt eller svår.");
            Console.WriteLine("Lätt: Du gissar på samma slumpade tal.");
            Console.WriteLine("Svår: Du gissar på nytt slumpat tal.");
            svårGrad = Console.ReadLine();

            if (svårGrad.ToLower() == "lätt")
            {
                //Datorn slumpar fram ett tal mellan 1-13
                datornsTal = slumpTal.Next(minTal, maxTal);

                //Användaren gissar vilket tal som datorn slumpat fram
                Console.WriteLine("Gissa talet, 1-13");
                dittTal = Convert.ToInt32(Console.ReadLine());

                //Användaren gissar tills talet är rätt
                //Efter varje gissning får användaren veta om den gissat rätt, för högt eller för lågt.
                while (dittTal != datornsTal)
                {
                    if (dittTal > datornsTal)
                    {
                        Console.WriteLine("     /\\\n    /  \\\n   /    \\\n  /   !  \\\n /________\\");
                        Console.WriteLine($"Du gissade fel. Avfartens nummer {dittTal} var för högt.");
                    }

                    else if (dittTal < datornsTal)

                    {
                        Console.WriteLine("     /\\\n    /  \\\n   /    \\\n  /   !  \\\n /________\\");
                        Console.WriteLine($"Du gissade fel. Avfartens nummer {dittTal} var för lågt.");
                    }

                    Console.WriteLine("Gissa talet igen, 1-13");
                    dittTal = Convert.ToInt32(Console.ReadLine());
                }
                if (dittTal == datornsTal)
                {
                    Console.WriteLine($"Grattis! Du gissade rätt. Den korrekta avfarten till Arlanda var {dittTal}!");
                    break;
                }

                break;

            }
            else if (svårGrad.ToLower() == "svår")
            {
                //Datorn slumpar fram ett tal mellan 1-13
                datornsTal = slumpTal.Next(minTal, maxTal);

                //Användaren gissar vilket tal som datorn slumpat fram
                Console.WriteLine("Gissa talet, 1-13");
                dittTal = Convert.ToInt32(Console.ReadLine());

                //Användaren gissar tills talet är rätt
                //Efter varje gissning får användaren veta om den gissat rätt, för högt eller för lågt.
                while (dittTal != datornsTal)
                {
                    if (dittTal > datornsTal)
                    {
                        Console.WriteLine("     /\\\n    /  \\\n   /    \\\n  /   !  \\\n /________\\");
                        Console.WriteLine($"Du gissade fel. Avfartens nummer {dittTal} var för högt.");
                    }

                    else if (dittTal < datornsTal)

                    {
                        Console.WriteLine("     /\\\n    /  \\\n   /    \\\n  /   !  \\\n /________\\");
                        Console.WriteLine($"Du gissade fel. Avfartens nummer {dittTal} var för lågt.");
                    }


                    datornsTal = slumpTal.Next(minTal, maxTal);


                    Console.WriteLine("Gissa talet igen, 1-13");
                    dittTal = Convert.ToInt32(Console.ReadLine());

                }
                if (dittTal == datornsTal)
                {
                    Console.WriteLine($"Grattis! Du gissade rätt. Den korrekta avfarten till Arlanda var {dittTal}!");
                    break;
                }
            }


                break;
           
        case 4:

            Console.WriteLine("Programmet avslutas..");

            break;

        default:

            Console.WriteLine("     /\\\n    /  \\\n   /    \\\n  /   !  \\\n /________\\");
            Console.WriteLine("Felaktig inmatning.. vänligen försök igen. Välj menyval 1-4.");

            break;
    }

    
}
Console.ReadLine();

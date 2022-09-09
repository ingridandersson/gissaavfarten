Console.ForegroundColor = ConsoleColor.Yellow;
int menyVal = 0;
int minTal = 1;
int maxTal = 13;
int dittTal = 0;
int datornsTal = 0;
string svårGrad = " ";
string välkomstMeddelande = "Hej, välkommen till Gissa afarten!";


string speletsRegler = "I varje omgång av gissa afarten ska datorn slumpa fram ett heltal som representerar avfarten mellan 1 och 13." +
    "\nAnvändaren ska gissa vilken avfart som leder till Arlanda och vilken som är den rätta, tills hen gissar rätt. " +
    "\nEfter varje gissning ska användaren få veta om gissningen var rätt, om gissningen är för hög eller om den är för låg.\n";

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

// Välkomna användaren till Gissa Gissa
Console.WriteLine("Gör ett menyval.");

//Presentera menyval
//1. Spela "Gissa Avfarten"
//2. Spelets regler.
//3. Avsluta program
// Default
while (menyVal != 4)
{
    Console.WriteLine("1. Spela Gissa Afarten.");
    Console.WriteLine("2. Spelets regler.");
    Console.WriteLine("3. Svårighetsgrader.");
    Console.WriteLine("4. Avsluta Program.");

    menyVal = Convert.ToInt32(Console.ReadLine());

    switch (menyVal)
    {

        case 1:
            //Datorn slumpar fram ett tal mellan 1-10
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
                    Console.WriteLine($"Du gissade fel. Talet {dittTal} var för högt.");
                }

                else if (dittTal < datornsTal)

                {
                    Console.WriteLine("     /\\\n    /  \\\n   /    \\\n  /   !  \\\n /________\\");
                    Console.WriteLine($"Du gissade fel. Talet {dittTal} var för lågt.");
                }


                Console.WriteLine("Gissa talet igen, 1-13");
                dittTal = Convert.ToInt32(Console.ReadLine());

            }
            if (dittTal == datornsTal)
            {
                Console.WriteLine($"Grattis! Du gissade rätt. Den korrekta avfarten var nummer {dittTal}");
                break;
            }

            break;

        case 2:

            Console.WriteLine($"Detta är spelets regler: {speletsRegler}");

            break;

        case 3:
            Console.WriteLine("Välj svårighetsgrad. (Lätt/Svår).");
            Console.WriteLine("Lätt. Du gissar på samma slumpande tal");
            Console.WriteLine("Svår. Du gissar på nytt slumpat tal efter varje försök");
            svårGrad = Console.ReadLine();

            if (svårGrad.ToLower() == "lätt")
            {
                //Datorn slumpar fram ett tal mellan 1-10
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
                        Console.WriteLine($"Du gissade fel. Talet {dittTal} var för högt.");
                    }

                    else if (dittTal < datornsTal)

                    {
                        Console.WriteLine($"Du gissade fel. Talet {dittTal} var för lågt.");
                    }


                    Console.WriteLine("Gissa talet igen, 1-13");
                    dittTal = Convert.ToInt32(Console.ReadLine());

                }
                if (dittTal == datornsTal)
                {
                    Console.WriteLine($"Grattis! Du gissade rätt. Den korrekta avfarten till Arlanda var {dittTal}");

                    break;
                }

                break;

            }
            else if (svårGrad.ToLower() == "svår")
            {
                //Datorn slumpar fram ett tal mellan 1-10
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
                        Console.WriteLine($"Du gissade fel. Talet {dittTal} var för högt.");
                    }

                    else if (dittTal < datornsTal)

                    {
                        Console.WriteLine($"Du gissade fel. Talet {dittTal} var för lågt.");
                    }

                    datornsTal = slumpTal.Next(minTal, maxTal);


                    Console.WriteLine("Gissa talet igen, 1-13");
                    dittTal = Convert.ToInt32(Console.ReadLine());

                }
                if (dittTal == datornsTal)
                {
                    Console.WriteLine($"Grattis! Du gissade rätt. Talet var {dittTal}");
                    break;
                }

            }

            // Thread Sleep på "Välkommen..."
            // Välja färg i menyn.
            // Ändra instruktioner.


            break;

        case 4:

            Console.WriteLine("Programmet avslutas..");

            break;

        default:

            Console.WriteLine("Felaktig inmatning.. vänligen försök igen. Välj menyval 1-3.");

            break;
    }


}
Console.ReadLine();
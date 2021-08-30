using System;
using System.Collections.Generic;

namespace Programmering
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Fordon> bilar = new List<Fordon>();

            int meny = 0;

            while(meny != 4)
            {
                Console.WriteLine("\n\n\n\n\n\n");
                Console.WriteLine("1. Lägg till nytt fordon.");
                Console.WriteLine("2. Ta bort fordon");
                Console.WriteLine("3. Lista upp alla fordon.");
                Console.WriteLine("4. Stäng programmet.");
                meny = int.Parse(Console.ReadLine());

                if (meny == 1)
                {
                    Console.Write("Märke: ");
                    string MAKE = Console.ReadLine();
                    Console.Write("Modell: ");
                    string MODEL = Console.ReadLine();
                    Console.Write("Årsmodell: ");
                    int YEAR = int.Parse(Console.ReadLine());
                    bilar.Add(new Fordon(MAKE, MODEL, YEAR));
                }

                if (meny == 2)
                {
                    Console.Write("Vilket fordon vill du ta bort? ");
                    int tabort = int.Parse(Console.ReadLine());
                    bilar.RemoveAt(tabort - 1);  
                }

                if (meny == 3)
                {
                    Console.WriteLine("\n\n\n\n\n\n");
                    int id = 1;
                    foreach (Fordon a in bilar)
                    {
                        Console.WriteLine("===================");
                        Console.WriteLine("ID: " + id + "\n" + a);
                        id++;
                    }
                    Console.WriteLine("===================");
                }
            }
        }
    }
}

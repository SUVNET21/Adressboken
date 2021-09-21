using System;
using System.Collections.Generic;

namespace AdressbokEtt
{
    class Program
    {
        static List<string> nameList = new();
        static List<string> numberList = new();
        static char choice;
        static bool extraChoice;
        //string contacts = "";
        //string numbers = "";

        static void Main(string[] args)

        {
            while (true)
            {
                ShowMenu();
                Console.Write("Val: ");
                GetChoice();

                if (choice == 'l')
                {
                    AddName();
                }
                else if (choice == 'v')
                {
                    ShowNames();
                }
                else if (choice == 'r')
                {
                    ClearNames();
                }
                else if (choice == 'a')
                {
                    Console.Clear();
                    Console.WriteLine("Ha en fin dag! Hejdå!");
                    Environment.Exit(0);
                }

                else if (choice == 'n')
                {
                    AddNumber();
                }

                else if (choice == 's')
                {
                    ShowNumbers();
                }
                else if (choice == 't')
                {
                    ClearNumbers();
                }
                else if (choice == '1')
                {
                    SearchName();
                }
                else if (choice == '2')
                {
                    SearchNumber();
                }
            }
        }

        static void ShowMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"~: Välkommen till din adressbok :~\n");
            Console.WriteLine("Denna av version av adressboken kan spara både namn och telefonnummer.");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("[L]ägg till namn.\n[V]isa sparade namn.\n[R]ensa adressboken på namn.");
            Console.WriteLine("[N]ytt telefonnummer.\n[S]kriv ut alla telefonnummer.\n[T]a bort alla telefonnummer.");
            Console.WriteLine("[A]vsluta adressboken\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Nyhet! Extrafunktioner: [1] Sök efter ett namn. [2] Sök efter ett nummer.");
            Console.ResetColor();
        }


        static char GetChoice()
        {
            return choice = Char.ToLower(Console.ReadKey(true).KeyChar);
        }
        static void AddName()
        {
                    Console.Clear();
                    Console.Write("\nNamn: ");
                    string newPerson = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(newPerson))
                    {
                        nameList.Add(newPerson);
                    }
                    
        }
        
        static void ShowNames()
        {
                    if (nameList.Count == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Du har inte sparat några namn.");
                    }
                    else
                    {
                        Console.Clear();
                        foreach (string name in nameList)
                        {
                            Console.WriteLine(name);
                        }
                    }
                    Console.ReadKey();
        }

        static void ClearNames()
        {
        if (nameList.Count == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Du har inte sparat några namn.");
                        Console.ReadKey();
                    }
                

                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Är du säker på att du vill rensa adressboken? Detta går inte att ångra! Y/N)");
                        GetChoice();

                        if (choice == 'y')
                        {
                            Console.Clear();
                            Console.WriteLine("Då rensar vi alla namn.");
                            nameList.Clear();
                            Console.ReadKey();
                        }
                        else if (choice == 'n')
                        {
                            Console.Clear();
                            Console.WriteLine("Okej, då rensar vi inte!");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Hoppsan! Nu gick något snett. Använd knappen Y eller N för att svara.");
                            Console.ReadKey();
                        }
                    }
        }

        static void AddNumber()
        {
        Console.Clear();
                    Console.Write("\nTelefonnummer: ");
                    string newNumber = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(newNumber))
                    {
                        numberList.Add(newNumber);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Du har matat in ett felaktigt telefonnummer. Använd bara siffror!");
                        Console.ReadKey();
                    }
        }

        static void ShowNumbers()
        {
        
                    if (numberList.Count == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Du har inte sparat några nummer.");
                    }
                    else
                    {
                        Console.Clear();
                        foreach (string number in numberList)
                        {
                            Console.WriteLine(number);
                        }
                    }
                    Console.ReadKey();
        }

        static void ClearNumbers()
        {
        

                    if (numberList.Count == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Du har inte sparat några nummer.");
                        Console.ReadKey();
                    }

                    else
                    {
                        extraChoice = true;

                        while (extraChoice == true)
                        {
                        Console.Clear();
                        Console.WriteLine("Är du säker på att du vill ta bort alla telefonnummer? Detta går inte att ångra! Y/N)");
                        GetChoice();


                        if (choice == 'y')
                        {
                            Console.Clear();
                            Console.WriteLine("Då rensar vi alla nummer.");
                            numberList.Clear();
                            Console.ReadKey();
                            extraChoice=false;
                        }
                        else if (choice == 'n')
                        {
                            Console.Clear();
                            Console.WriteLine("Okej, då rensar vi inte!");
                            Console.ReadKey();
                            extraChoice=false;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Hoppsan! Nu gick något snett. Använd knapparna Y eller N för att svara.");
                            Console.ReadKey();
                            
                        }
                        }
                    }
        }
        static void SearchName()
        {
        Console.Clear();
        System.Console.WriteLine("Test message");
        Console.ReadKey();
        }

        static void SearchNumber()
        {
        Console.Clear();
        System.Console.WriteLine("Test message");
        Console.ReadKey();
        }

    }
}

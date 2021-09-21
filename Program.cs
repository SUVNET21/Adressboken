using System;
using System.Collections.Generic;

namespace AdressbokEtt
{
    class Program
    {
        static List<string> nameList = new();
        static List<string> numberList = new();
        static char choice;
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
                    Console.Clear();
                    Console.Write("\nNamn: ");
                    string newPerson = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(newPerson))
                    {
                        nameList.Add(newPerson);
                    }
                }
                else if (choice == 'v')
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
                else if (choice == 'r')
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
                else if (choice == 'a')
                {
                    Console.Clear();
                    Console.WriteLine("Ha en fin dag! Hejdå!");
                    Environment.Exit(0);
                }

                else if (choice == 'n')
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

                else if (choice == 's')
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
                else if (choice == 't')
                {

                    if (numberList.Count == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Du har inte sparat några nummer.");
                        Console.ReadKey();
                    }

                    else
                    {
                        Console.Clear();
                        Console.WriteLine("\nÄr du säker på att du vill ta bort alla telefonnummer? Detta går inte att ångra! Y/N)");
                        GetChoice();


                        if (choice == 'y')
                        {
                            Console.Clear();
                            Console.WriteLine("Då rensar vi alla nummer.");
                            numberList.Clear();
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
                            Console.WriteLine("Hoppsan! Nu gick något snett. Använd knapparna Y eller N för att svara.");
                            Console.ReadKey();
                        }
                    }
                }
            }
        }

        static void ShowMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"~: Välkommen till din adressbok :~\n");
            Console.WriteLine("Denna av version av adressboken kan spara både namn och telefonnummer.");
            Console.ResetColor();
            Console.WriteLine("[L]ägg till namn.\n[V]isa sparade namn.\n[R]ensa adressboken på namn.");
            Console.WriteLine("[N]ytt telefonnummer.\n[S]kriv ut alla telefonnummer.\n[T]a bort alla telefonnummer.");
            Console.WriteLine("[A]vsluta adressboken");
        }


        static char GetChoice()
        {
            return choice = Char.ToLower(Console.ReadKey(true).KeyChar);
        }
    }
}

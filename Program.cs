using System;
using System.Collections.Generic;

namespace AdressbokEtt
{
    class Program
    {
        static char choice;
        // static bool extraChoice;
        static void Main(string[] args)
        {
            ContactBook contactBook = new();


            while (true)
            {
                ShowMenu();

                if (choice == 'l')
                {
                    Console.Clear();
                    Contact contact = new Contact();
                    contact.Name = ConsoleUtils2.ReadString("Enter the name of your contact: ");
                    contact.TelefonNummer = ConsoleUtils2.ReadInt("Enter your contact's telephone number: ");
                    if (!string.IsNullOrWhiteSpace(contact.Name))
                    {
                        contactBook.AddContacts(contact);
                    }
                }
                else if (choice == 'v')
                {
                    Console.Clear();
                    List<Contact> ContactList = contactBook.GetAllContacts();
                    if (ContactList.Count == 0)
                    {
                        Console.WriteLine("Du har inte sparat några kontakter i listan än. Lägg till några och försök igen.");
                    }

                    else
                    {
                        foreach (var Friend in ContactList)
                        {
                            int Position = ContactList.IndexOf(Friend) + 1;
                            Console.WriteLine($"Sparad kontakt nr {Position} heter {Friend.Name}, och har telefonnummer: {Friend.TelefonNummer}.");
                        }
                    }
                    Pause();
                }
                else if (choice == 'r')
                {
                    ClearNames(contactBook);
                }
                else if (choice == 'a')
                {
                    Console.Clear();
                    Console.WriteLine("Ha en fin dag! Hejdå!");
                    Environment.Exit(0);
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
            Console.WriteLine("[A]vsluta adressboken\n");
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine("Nyhet! Extrafunktioner: [1] Sök efter ett namn. [2] Sök efter ett nummer.");
            Console.ResetColor();
            GetChoice();
        }


        static char GetChoice()
        {
            return choice = Char.ToLower(Console.ReadKey(true).KeyChar);
        }
        static void Pause()
        {
            Console.WriteLine("Tryck på valfri knapp för att gå vidare!");
            Console.ReadKey();
        }

        static void ClearNames(ContactBook contactBook)
        {
            List<Contact> ContactList = contactBook.GetAllContacts();
            if (ContactList.Count == 0)
            {
                Console.Clear();
                Console.WriteLine("Du har inte sparat några namn.");
                Pause();
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
                    contactBook.ClearContacts();
                    Pause();
                }
                else if (choice == 'n')
                {
                    Console.Clear();
                    Console.WriteLine("Okej, då rensar vi inte!");
                    Pause();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Hoppsan! Nu gick något snett. Använd knappen Y eller N för att svara.");
                    Pause();
                }
            }
        }
    }
}

// static void AddNumber()
// {
//     Console.Clear();
//     Console.Write("\nTelefonnummer: ");
//     string newNumber = Console.ReadLine();
//     if (!string.IsNullOrWhiteSpace(newNumber))
//     {
//         numberList.Add(newNumber);
//     }
//     else
//     {
//         Console.Clear();
//         Console.WriteLine("Du har matat in ett felaktigt telefonnummer. Använd bara siffror!");
//         Console.ReadKey();
//     }
// }

using System;
using System.Collections.Generic;
using System.Linq;

namespace AdressbokEtt
{
    class Program
    {
        static char choice;
        static public string searchedName;
        static public int deletionChoice;

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
                    contact.TelefonNummer = ConsoleUtils2.ReadString("Enter your contact's telephone number: ");
                    contact.Adress = ConsoleUtils2.ReadString("Enter the adress of your contact: ");
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
                            Console.WriteLine($"Kontakt {Position} heter {Friend.Name}, har telefonnummer: {Friend.TelefonNummer} och bor på adressen {Friend.Adress}.");
                        }
                    }
                    Pause();
                }
                else if (choice == 'r')
                {
                    ClearNames(contactBook);
                }
                else if (choice == 't')
                {
                    RemoveSingleContact(contactBook);
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
            Console.WriteLine("Denna av version av adressboken sparar namn, telefonnummer och adress.");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("[L]ägg till en kontakt.\n[V]isa sparade kontakter.\n[T]ag bort en kontakt. \n[R]ensa adressboken på kontakter.");
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
                    Console.WriteLine("Då rensar vi bort alla namn.");
                    contactBook.ClearContacts();
                    Pause();
                }
                else if (choice == 'n')
                {
                    Console.Clear();
                    Console.WriteLine("Okej, då rensar vi inte några namn!");
                    Pause();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Hoppsan! Nu gick något snett. Använd knapparna Y eller N för att svara.");
                    Pause();
                }
            }
        }
        static void RemoveSingleContact(ContactBook contactBook)
        {
            List<Contact> ContactList = contactBook.GetAllContacts();
            if (ContactList.Count == 0)
            {
                Console.Clear();
                Console.WriteLine("Du har inte sparat någon kontakt.");
                Pause();
            }

            else if (ContactList.Count > 0)
            {
                Console.Clear();
                Console.WriteLine("Är du säker på att du vill ta bort en kontakt? En kontakt som tas bort kan du inte få tillbaka. Y/N)");
                GetChoice();

                if (choice == 'y')
                {
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine("Vilken kontakt vill du ta bort? Du kan välja mellan följande kontakter:");
                        foreach (var Friend in ContactList)
                        {
                            int Position = ContactList.IndexOf(Friend) + 1;
                            Console.WriteLine($"Kontakt {Position}: {Friend.Name}.");
                        }
                        deletionChoice = ConsoleUtils2.ReadInt("Mata in en siffra för att radera den tillhörande kontakten.\n");
                        if (deletionChoice > ContactList.Count || deletionChoice <= 0)
                        {
                            Console.WriteLine("Felaktig inmatning. Försök igen!");
                            Pause();
                        }
                        else if (ContactList.Count == 1 && deletionChoice == 1)
                        {
                            Console.WriteLine("Kontakt raderad.");
                            contactBook.ClearContacts();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Kontakt raderad.");
                            contactBook.RemoveContact(deletionChoice-1);
                            break;
                        }
                    }
                Pause();
                }
            }

            
                else if (choice == 'n')
            {
                Console.Clear();
                Console.WriteLine("Okej, då tar vi inte bort den!");
                Pause();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Hoppsan! Nu gick något snett. Använd knapparna Y eller N för att svara.");
                Pause();
            }
        }
        static void SearchName(ContactBook contactBook)
        {
            // List<Contact> ContactList = contactBook.GetAllContacts();
            // searchedName = ConsoleUtils2.ReadString("Vilket namn vill du söka på?");
            // var matchingvalues = ContactList.Contains
            // .Where(searchedName => searchedName.Contains(searchedName));
            // ej färdigt
        }
    }
}

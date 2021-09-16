using System;

string contacts = "";
int numberOfPeopleInList = 0;

while (true)
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"~: ADRESSBOKEN ({numberOfPeopleInList} personer, {contacts.Length} tecken) :~\n");
    Console.ResetColor();
    Console.WriteLine("[V]isa kontakter");
    Console.WriteLine("[L]ägg till person");
    Console.WriteLine("\n[A]vsluta [R]ensa adressboken");

    // Console.Write("\nVal: ");
    char choice = Console.ReadKey(true).KeyChar;

    if (choice == 'v')
    {
        Console.Clear();
        Console.WriteLine(Environment.NewLine + contacts + Environment.NewLine + (contacts.Split("\n").Length - 1) + " personer totalt");
        Console.ReadKey();
    }
    else if (choice == 'l')
    {
        Console.Clear();
        Console.Write("\nNamn: ");
        string newPerson = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(newPerson))
        {
            contacts += contacts.Length >= 0 ? newPerson + Environment.NewLine : newPerson;
            numberOfPeopleInList++;
        }
    }
    else if (choice == 'r')
    {
        Console.WriteLine("\nÄr du säker på att du vill rensa adressboken? Detta går inte att ångra! (j/n)");
        choice = Console.ReadKey(true).KeyChar;
        if (choice == 'j')
        {
            contacts = "";
            numberOfPeopleInList = 0;
        }
    }
    else if (choice == 'a') Environment.Exit(0);
}
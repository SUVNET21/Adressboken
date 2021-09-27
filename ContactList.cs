using System.Collections.Generic;
namespace AdressbokEtt
{
    public class ContactList
    {
        List<Contact> BossesLista = new();
        Contact contact = new Contact("Test",25);

        public void CreateContact()
        {
                string contactName = ConsoleUtils2.ReadString("Enter the name of your contact");
                int telefonNummer = ConsoleUtils2.ReadInt("Enter your contact's telephone number");
                if (!string.IsNullOrWhiteSpace(contactName))
                {
                    BossesLista.Add(contact);
                }
        }
        public void ShowInfo()
        {
            foreach (var Friend in BossesLista)
            {
                string name = contact.Name;
                int number = contact.TelefonNummer;
            }
        }

    }
}

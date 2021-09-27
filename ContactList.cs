using System;
using System.Collections.Generic;
namespace AdressbokEtt
{
    public class ContactList
    {
        List<Contact> BossesLista = new();
        public Contact NewestContact = new();

        public void CreateContact()
        {
            NewestContact
            if (!string.IsNullOrWhiteSpace(NewestContact))
            {
                BossesLista.Add(NewestContact);
            }
        }

    }
}

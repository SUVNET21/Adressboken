using System.Collections.Generic;
namespace AdressbokEtt
{
    public class ContactBook
    {
        private List<Contact> BossesLista = new();
        Contact contact = new Contact();

        public void AddContacts(Contact Kompis)
        {
            BossesLista.Add(Kompis);
        }
        public List<Contact> GetAllContacts()
        {
            return BossesLista;
        }

        public void ClearContacts()
        {
            BossesLista.Clear();
        }
        public void RemoveContact(int deletionChoice)
        {
            BossesLista.RemoveAt(deletionChoice);
        }
    }
}

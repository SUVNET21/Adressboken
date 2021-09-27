namespace AdressbokEtt
{
    public class Contact
    {
        Contact newContact = new();
        string name;
        int telefonNummer;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int TelefonNummer
        {
            get
            {
                return telefonNummer;
            }
            set
            {
                telefonNummer = value;
            }
        }
        public Contact NewContact(string name, int TelefonNummer)
        {
            this.Name = "Testnamn";
            this.TelefonNummer = 50;
        }

    }
}

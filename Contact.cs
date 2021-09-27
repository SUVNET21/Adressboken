using System.Collections.Generic;

namespace AdressbokEtt
{
    public class Contact
    {
        string contactName;
        int telefonNummer;

        public string Name
        {
            get
            {
                return contactName;
            }
            set
            {
                contactName = value;
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
    }
}

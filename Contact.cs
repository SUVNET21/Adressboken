using System.Collections.Generic;

namespace AdressbokEtt
{
    public class Contact
    {
        string contactName;
        string telefonNummer;
        string contactAdress;

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
        public string TelefonNummer
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
        public string Adress
        {
            get
            {
                return contactAdress;
            }
            set
            {
                contactAdress = value;
            }
        }
    }
}

using System.Collections.Generic;

namespace AdressbokEtt
{
    public class Contact
    {
        string contactName;
        int telefonNummer;
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

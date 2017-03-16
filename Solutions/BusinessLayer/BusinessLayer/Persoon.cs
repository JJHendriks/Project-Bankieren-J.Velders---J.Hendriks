using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Persoon
    {
        private string voornaam;

        public string Voornaam
        {
            get { return voornaam; }
        }

        private string achternaam;

        public string Achternaam
        {
            get { return achternaam; }
        }

        private string bsn;

        public string BSN
        {
            get { return bsn; }
        }

        private string gebruikersnaam;

        public string Gebruikersnaam
        {
            get { return gebruikersnaam; }
        }

        private string wachtwoord;

        public string Wachtwoord
        {
            get { return wachtwoord; }
        }

        public Persoon(string _voornaam,string _achternaam,string _bsn, string _gebruikersnaam, string _wachtwoord)
        {
            if (DataProvider.BsnElfProef(_bsn))
            {
                this.voornaam = _voornaam;
                this.achternaam = _achternaam;
                this.bsn = _bsn;
                this.gebruikersnaam = _gebruikersnaam;
                this.wachtwoord = _wachtwoord;
            }
            else
            {
                throw new ArgumentException("Het opgeven bsn nummer is niet geldig, het voldoet niet aan de Elfproef");
            }
        }

        public override string ToString()
        {
            return string.Format("Voornaam: {0}\nAchternaam: {1}\nbsn: {2}\ngebruikersnaam: {3}\nwachtwoord: {4}\n",this.voornaam,this.achternaam,this.bsn,this.gebruikersnaam,this.wachtwoord);
        }
    }
}

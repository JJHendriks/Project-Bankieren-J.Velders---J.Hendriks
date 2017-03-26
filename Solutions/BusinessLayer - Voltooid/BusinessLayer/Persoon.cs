using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Persoon
    {
        /// <summary>
        /// Property voor voornaam
        /// </summary>
        private string voornaam;

        public string Voornaam
        {
            get { return voornaam; }
        }
        /// <summary>
        /// Property voor achternaam
        /// </summary>
        private string achternaam;

        public string Achternaam
        {
            get { return achternaam; }
        }
        /// <summary>
        /// Property voor bsn
        /// </summary>
        private string bsn;

        public string BSN
        {
            get { return bsn; }
        }
        /// <summary>
        /// Property voor gebruikersnaam
        /// </summary>
        private string gebruikersnaam;

        public string Gebruikersnaam
        {
            get { return gebruikersnaam; }
        }
        /// <summary>
        /// Property voor wachtwoord
        /// </summary>
        private string wachtwoord;

        public string Wachtwoord
        {
            get { return wachtwoord; }
        }
        /// <summary>
        /// De constructor van de class persoon
        /// </summary>
        /// <param name="_voornaam"></param>
        /// <param name="_achternaam"></param>
        /// <param name="_bsn"></param>
        /// <param name="_gebruikersnaam"></param>
        /// <param name="_wachtwoord"></param>
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

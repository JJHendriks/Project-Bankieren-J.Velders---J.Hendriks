using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nintendo
{
    public class Persoon
    {
        private string voornaam;

        private string achternaam;

        private long bsn;

        private string gebruikersnaam;

        private string wachtwoord;

        public Persoon(string _voornaam,string _achternaam,long _bsn)
        {
            this.voornaam = _voornaam;
            this.achternaam = _achternaam;
            this.bsn = _bsn;
        }

        public override string ToString()
        {
            return string.Format("Voornaam: {0}\nAchternaam: {1}\nbsn: {2}\ngebruikersnaam: {3}\nwachtwoord: {4}\n",this.voornaam,this.achternaam,this.bsn,this.gebruikersnaam,this.wachtwoord);
        }
    }
}

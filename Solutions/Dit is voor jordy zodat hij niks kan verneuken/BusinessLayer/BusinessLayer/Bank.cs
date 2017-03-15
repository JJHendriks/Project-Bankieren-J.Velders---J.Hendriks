using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    //Deze class wordt pas verder uitgewerkt op niveau 3

    public class Bank
    {
        private string bankNaam;

        private string gebruikersnaam;

        private string wachtwoord;

        public Bank()
        {

        }

        public Bank(string _bankNaam, string _gebruikersnaam, string _wachtwoord)
        {
            this.bankNaam = _bankNaam;
            this.gebruikersnaam = _gebruikersnaam;
            this.wachtwoord = _wachtwoord;
        }

        public void ToevoegenBankrekeninghouder(string _voornaam, string _achternaam, long _bsn, string _gebruikersnaam, string _wachtwoord,
            string _rekeningnrSparen, decimal _spaarSaldo, decimal _rentepercentage, string _rekeningnrBetalen, decimal _BetaalSaldo, decimal _maxkrediet)
        {
            Bankrekeninghouder Bankrekeninghouder = new Bankrekeninghouder(_voornaam, _achternaam, _bsn, _gebruikersnaam, _wachtwoord, _rekeningnrSparen, _spaarSaldo, _rentepercentage, _rekeningnrBetalen, _BetaalSaldo, _maxkrediet);

            //DataProvider.AlleBankrekeningHouders
        }

        public bool BankRekeninghouderOpheffen(long _bsn)
        {
            /*
            AlleBankrekeningHouders.remove(..);


            */
            return true;
        }

        public bool Rentebijschrijven()
        {
            return true;
        }
    }
}
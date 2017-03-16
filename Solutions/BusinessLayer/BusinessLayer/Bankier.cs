using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    

    public class Bankier
    {

        private string bankNaam;

        private string gebruikersnaam;
    
        private string wachtwoord;


        public Bankier(string _bankNaam, string _gebruikersnaam, string _wachtwoord)
        {
            this.bankNaam = _bankNaam;
            this.gebruikersnaam = _gebruikersnaam;
            this.wachtwoord = _wachtwoord;
        }

        public void ToevoegenBankrekeninghouder(string _voornaam, string _achternaam, long _bsn, string _gebruikersnaam, string _wachtwoord,
            string _rekeningnrSparen, decimal _spaarSaldo, decimal _rentepercentage, string _rekeningnrBetalen, decimal _BetaalSaldo, decimal _maxkrediet)
        {
            try
            {
                Bankrekeninghouder bankrekeninghouder = new Bankrekeninghouder(_voornaam, _achternaam, _bsn, _gebruikersnaam, _wachtwoord, _rekeningnrSparen, _spaarSaldo, _rentepercentage, _rekeningnrBetalen, _BetaalSaldo, _maxkrediet);

                DataProvider.BankrekeningHouders.Add(bankrekeninghouder);
            }
            catch(Exception)
            {
                throw ;
            }
        }

        public bool BankRekeninghouderOpheffen(string _gebruikersnaam)
        {
            try
            {
                DataProvider.LijstBankrekeninghoudersVullen();

                Bankrekeninghouder bankrekeninghouder = DataProvider.GebruikerVerkrijgen(_gebruikersnaam);

                DataProvider.BankrekeningHouders.Remove(bankrekeninghouder);

                return true;
            }
            catch(Exception )
            {
                throw ;
            }
        }

        public bool Rentebijschrijven()
        {
            try
            {
                DataProvider.LijstBankrekeninghoudersVullen();
                List<Bankrekeninghouder> list = DataProvider.BankrekeningHouders;

                foreach (var item in list)
                {
                    item.Spaarrekening.Bijschrijven = item.Spaarrekening.HuidigeRenteBerekenen;
                }
                return true;
            }
            catch (Exception)
            {
                throw;
            }
           
        }
    }
}
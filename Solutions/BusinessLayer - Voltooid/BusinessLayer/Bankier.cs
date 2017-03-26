using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{

    public class Bankier
    {
        /// <summary>
        /// De naam van de bank
        /// </summary>
        private string bankNaam;
        /// <summary>
        /// De gebruikersnaam van de bankier
        /// </summary>
        private string gebruikersnaam;

        public string Gebruikersnaam
        {
            get { return gebruikersnaam; }
        }
        /// <summary>
        /// Het wachtwoord van de bankier
        /// </summary>
        private string wachtwoord;

        public string Wachtwoord
        {
            get { return wachtwoord; }
        }

        /// <summary>
        /// De constructor van de class Bankier
        /// </summary>
        /// <param name="_bankNaam"></param>
        /// <param name="_gebruikersnaam"></param>
        /// <param name="_wachtwoord"></param>
        public Bankier(string _bankNaam, string _gebruikersnaam, string _wachtwoord)
        {
            this.bankNaam = _bankNaam;
            this.gebruikersnaam = _gebruikersnaam;
            this.wachtwoord = _wachtwoord;
        }

        /// <summary>
        /// Deze methode maakt een instance van bankrekeninghouder aan doormiddel van de van te voren opgeven waardes, 
        /// En voegt deze daarna toe aan de lijst met bankrekeninghouders
        /// </summary>
        /// <param name="_voornaam"></param>
        /// <param name="_achternaam"></param>
        /// <param name="_bsn"></param>
        /// <param name="_gebruikersnaam"></param>
        /// <param name="_wachtwoord"></param>
        /// <param name="_rekeningnrSparen"></param>
        /// <param name="_spaarSaldo"></param>
        /// <param name="_rentepercentage"></param>
        /// <param name="_rekeningnrBetalen"></param>
        /// <param name="_BetaalSaldo"></param>
        /// <param name="_maxkrediet"></param>
        public void ToevoegenBankrekeninghouder(string _voornaam, string _achternaam, string _bsn, string _gebruikersnaam, string _wachtwoord,
            string _rekeningnrSparen, decimal _spaarSaldo, decimal _rentepercentage, string _rekeningnrBetalen, decimal _BetaalSaldo, decimal _maxkrediet)
        {
            try
            {
                Bankrekeninghouder bankrekeninghouder = new Bankrekeninghouder(_voornaam, _achternaam, _bsn, _gebruikersnaam, _wachtwoord, _rekeningnrSparen, _spaarSaldo, _rentepercentage, _rekeningnrBetalen, _BetaalSaldo, _maxkrediet);

                DataProvider.LijstBankrekeninghoudersVullen();

                DataProvider.BankrekeningHouders.Add(bankrekeninghouder);
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// Deze methode verwijdert een bankrekeninghouder uit de lijst doormiddel van een van te voren opgeven gebruikersnaam
        /// </summary>
        /// <param name="_gebruikersnaam"></param>
        /// <returns>true or false</returns>
        public bool BankRekeninghouderOpheffen(string _gebruikersnaam)
        {
            try
            {
                DataProvider.LijstBankrekeninghoudersVullen();

                Bankrekeninghouder bankrekeninghouder = DataProvider.GebruikerVerkrijgenGebruikersnaam(_gebruikersnaam);

                DataProvider.BankrekeningHouders.Remove(bankrekeninghouder);

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Deze methode schrijft de rente bij elke bankrekeninghouder bij.
        /// </summary>
        /// <returns>true or false</returns>
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
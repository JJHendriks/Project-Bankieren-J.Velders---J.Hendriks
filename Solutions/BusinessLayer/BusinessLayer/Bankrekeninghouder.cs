using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Bankrekeninghouder
    {
        /// <summary>
        /// Een simpele class die naam, bsn en inlogdata bij houd.
        /// </summary>
        private Persoon rekeninghouder;

        public Persoon Rekeninghouder
        {
            get { return rekeninghouder; }
        }
           

        /// <summary>
        /// Een rekening die bedoeld is om te betalen.
        /// </summary>
        private BetaalRekening betaalrekening;

        public BetaalRekening Betaalrekening
        {
            get { return betaalrekening; }
        }
        /// <summary>
        /// Een rekening die bedoeld is om te sparen.
        /// </summary>
        private SpaarRekening spaarrekening;

        public SpaarRekening Spaarrekening
        {
            get { return spaarrekening; }
        }

        /// <summary>
        /// De constuctor van de bankrekeinghouder.
        /// </summary>
        /// <param name="voornaam">De voornaam van de Bankrekeninghouder.</param>
        /// <param name="achternaam">De achternaam van de bankrekeninghouder.</param>
        /// <param name="bsn">Het burger service number.</param>
        /// <param name="gebruikersnaam">De gebruikersnaam van de bankrekeninghouder.</param>
        /// <param name="wachtwoord">Het wachtwoord van de bankrekinngohouder.</param>
        /// <param name="rekeningnrSparen">De IBAN van de spaarrekening.</param>
        /// <param name="spaarSaldo">Het saldo van de spaarrekening.</param>
        /// <param name="rentepercentage">De rente.</param>
        /// <param name="rekeningnrBetalen">De IBAN van de betaalrekening.</param>
        /// <param name="BetaalSaldo">Het saldo van de betaalrekening.</param>
        /// <param name="maxkrediet">Het bedrag wat je maximaal in de min kan staan bij de betaalrekening.</param>

        public Bankrekeninghouder(string voornaam, string achternaam, string bsn, string gebruikersnaam, string wachtwoord,
            string rekeningnrSparen, decimal spaarSaldo, decimal rentepercentage ,string rekeningnrBetalen, decimal BetaalSaldo, decimal maxkrediet)
        {
            rekeninghouder = new Persoon(voornaam, achternaam, bsn, gebruikersnaam, wachtwoord);
            spaarrekening = new SpaarRekening(rekeningnrSparen, spaarSaldo, rentepercentage);
            betaalrekening = new BetaalRekening(rekeningnrBetalen, BetaalSaldo, maxkrediet);

            
        }

        /// <summary>
        /// Deze methode retouneert de Gebruikernaam.
        /// </summary>
        /// <returns>De Gebuikersnaam</returns>
        public string Gebruikersnaam()
        {
            return rekeninghouder.Gebruikersnaam;
        }

        /// <summary>
        /// Deze methode retouneert Het wachtwoord.
        /// </summary>
        /// <returns>Het wachtwoord</returns>
        public string Wachtwoord()
        {
            return rekeninghouder.Wachtwoord;
        }

        /// <summary>
        /// Deze methode retouneert De IBAN van de spaarrekening.
        /// </summary>
        /// <returns>De spaarrekening als een string</returns>
        public string SpaarRekeningInzien()
        {
         return spaarrekening.ToString();
        }

        /// <summary>
        /// Deze methode retouneert De IBAN van de betaalrekening.
        /// </summary>
        /// <returns>De betaalrekening als een string</returns>
        public string BankRekeningInzien()
        {
            return betaalrekening.ToString();
        }

        public bool BetalingVerrichten(string rekeningnr, decimal bedrag)
        {
            try
            {
                Bankrekeninghouder gebruiker = DataProvider.GebruikerVerkrijgenRekeningnr(rekeningnr);
                this.Betaalrekening.AfSchrijven(bedrag);
                gebruiker.Betaalrekening.Bijschrijven = bedrag;
                return true;
            }
            catch (Exception)
            {
                throw;
            }
       
        }

        /// <summary>
        /// Schrijft het bedrag van Betaalrekening naar de spaarrekening.
        /// </summary>
        /// <param name="bedrag">De hoeveelheid wat er overgeschreven word.</param>
        /// <returns>een true als het gelukt is een false als het mislukt.</returns>
        public bool OverboekenNaarSpaarRekening(decimal bedrag)
        {
            try
            {
                betaalrekening.AfSchrijven(bedrag);
                spaarrekening.Bijschrijven = bedrag;
                return true;
            }

            catch (Exception exception)
            {
                throw exception;
                return false;
            }
        }

        /// <summary>
        /// Schrijft het bedrag van spaarrekening naar de Betaalrekening.
        /// </summary>
        /// <param name="bedrag">De hoeveelheid wat er overgeschreven word.</param>
        /// <returns>een true als het gelukt is een false als het mislukt.</returns>
        public bool OverboekenNaarBetaalRekening(decimal bedrag)
        {
            try
            {
                spaarrekening.AfSchrijven(bedrag);
                betaalrekening.Bijschrijven = bedrag;
                return true;
            }

            catch(Exception exception)
            {
                throw exception;
                return false;
            }
            
        }

    }
}

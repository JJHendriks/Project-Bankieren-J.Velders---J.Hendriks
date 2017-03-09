using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Bankrekeninghouder
    {
        private Persoon rekeninghouder;

        private Bankrekening betaalrekening;

        private SpaarRekening spaarrekening;

        //public Bankrekeninghouder( Persoon _rekeninghouder, Bankrekening _bankrekening, SpaarRekening _spaarrekening)
        //{
        //    this.rekeninghouder = _rekeninghouder;
        //    this.bankrekening = _bankrekening;
        //    this.spaarrekening = _spaarrekening;
        //}

        public Bankrekeninghouder(string voornaam, string achternaam, long bsn, string gebruikersnaam, string wachtwoord,
            string rekeningnrSparen, decimal spaarSaldo, decimal rentepercentage ,string rekeningnrBetalen, decimal BetaalSaldo, decimal maxkrediet)
        {
            rekeninghouder = new Persoon(voornaam, achternaam, bsn);
            spaarrekening = new SpaarRekening(rekeningnrSparen, spaarSaldo, rentepercentage);
            betaalrekening = new Bankrekening(rekeningnrBetalen, BetaalSaldo, maxkrediet);
        }

        public string SpaarRekeningInzien()
        {
         return spaarrekening.ToString();
        }

        public string BankRekeningInzien()
        {
            return betaalrekening.ToString();
        }

        public bool BetalingVerrichten(string rekeningnr, decimal bedrag)
        {
            //wordt verder aan gewerkt wanneer niveau 1 af is
            return true;
        }

        public bool OverboekenNaarSpaarRekening(decimal bedrag)
        {
            try
            {
                betaalrekening.Afschrijven(bedrag);
                spaarrekening.BijSchrijven = bedrag;
                return true;
            }

            catch (Exception exception)
            {
                throw exception;
                return false;
            }
        }

        public bool OverboekenNaarBetaalRekening(decimal bedrag)
        {
            try
            {
                spaarrekening.Afschrijven(bedrag);
                betaalrekening.BijSchrijven = bedrag;
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

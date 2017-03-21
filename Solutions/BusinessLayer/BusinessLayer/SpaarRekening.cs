using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class SpaarRekening : Rekening
    {
        /// <summary>
        /// Het field rentepercentage 
        ///</summary>
        private decimal Rentepercentage;

        /// <summary>
        /// Dit is de property van het rentepercentage deze retouneert het rentepercentage van het banksaldo
        /// </summary>
        public decimal HuidigeRenteBerekenen
        {
            get { return (Banksaldo * Convert.ToDecimal((Rentepercentage / 100))); }
        }

        /// <summary>
        /// De constructor van Spaarrekening die doormiddel van base overerft van de class Rekening
        /// </summary>
        /// <param name="_rekeningnr"></param>
        /// <param name="_banksaldo"></param>
        /// <param name="_rente"></param>
        public SpaarRekening(string _rekeningnr, decimal _banksaldo, decimal _rente) : base(_rekeningnr, _banksaldo)
        {
            this.Rentepercentage = _rente;
          
        }
            
      /// <summary>
      /// Deze methode haalt een van te voren opgegeven bedrag van de spaarrekening 
      /// af die rekening houdt met het feit dat het saldo niet onder de nul mag
      /// </summary>
      /// <param name="bedrag"></param>
        public void AfSchrijven(decimal bedrag)
        {
            
            try
            {
                Banksaldo -= bedrag;
                if (base.Banksaldo <= 0)
                {
                    Bijschrijven = bedrag;
                    throw new ArgumentException("U kan deze transactie niet uitvoeren omdat uw saldo dan onder nul komt.");
                }
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }


        public override string ToString()
        {
            return base.ToString() +
                string.Format("RentePercentage: {0}\nHuidig Opgebouwede Rente: {1}", Rentepercentage, HuidigeRenteBerekenen);

        }

        public decimal SpaarSaldo()
        {
            return Banksaldo;
        }
        public string SpaarRekeningnr()
        {
            return RekeningNr;
        }

    }
}

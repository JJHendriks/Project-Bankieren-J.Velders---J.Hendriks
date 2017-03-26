using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
   public class BetaalRekening : Rekening
    {
        /// <summary>
        /// Het field voor het maximaal krediet
        /// </summary>
        private decimal maximaalKrediet;

        /// <summary>
        /// De constructor van Betaalrekening die doormiddel van base overerft van de class Rekening
        /// </summary>
        /// <param name="_rekeningnr"></param>
        /// <param name="_banksaldo"></param>
        /// <param name="_maximaalkrediet"></param>
        public BetaalRekening( string _rekeningnr, decimal _banksaldo, decimal _maximaalkrediet) : base(_rekeningnr, _banksaldo)
        {
            this.maximaalKrediet = _maximaalkrediet;

        }


        /// <summary>
        /// Deze methode haalt een van te voren opgegeven bedrag van de betaalrekening
        /// af die rekening houdt met het feit dat het saldo niet onder het maximaal krediet mag
        /// </summary>
        /// <param name="bedrag"></param>
        public void AfSchrijven(decimal bedrag)
        {
            try
            {
                Banksaldo  -= bedrag;
                if (base.Banksaldo <= maximaalKrediet)
                {
                    Bijschrijven = bedrag;
                    throw new ArgumentException("U kan deze transactie niet uitvoeren omdat uw saldo dan onder het maximum krediet komt.");
                }
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("Maximaal krediet: " , maximaalKrediet);
        }

        public decimal BetaalSaldo()
        {
            return Banksaldo;
        }

        public string BetaalRekeningnr()
        {
            return RekeningNr;
        }

    }
}

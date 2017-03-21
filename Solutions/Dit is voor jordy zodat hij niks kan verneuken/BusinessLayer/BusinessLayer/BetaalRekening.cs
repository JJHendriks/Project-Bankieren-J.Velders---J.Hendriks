using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
   public class BetaalRekening : Rekening
    {
        private decimal maximaalKrediet;
       
        public BetaalRekening( string _rekeningnr, decimal _banksaldo, decimal _maximaalkrediet) : base(_rekeningnr, _banksaldo)
        {
            this.maximaalKrediet = _maximaalkrediet;

            //jemoeder
            
        }
       

    
        public void AfSchrijven(decimal bedrag)
        {
            try
            {
                  Banksaldo -= bedrag;
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
   public class BetaalRekening : Rekening, IRekeningRepository 
    {
        private decimal maximaalKrediet;
       
        public BetaalRekening( string _rekeningnr, decimal _banksaldo, decimal _maximaalkrediet) : base(_rekeningnr, _banksaldo)
        {
            this.maximaalKrediet = _maximaalkrediet;
        }


        public void BijSchrijven(decimal bedrag)
        {
            Banksaldo += bedrag;
        }
        public void AfSchrijven(decimal bedrag)
        {
            try
            {
                bedrag -= Banksaldo;
                if (base.Banksaldo <= maximaalKrediet)
                {
                    BijSchrijven(bedrag);
                    throw new ArgumentException("U kan deze transactie niet uitvoeren omdat uw saldo dan onder het maximum krediet komt.");
                }
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
       
   }
}

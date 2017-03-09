using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
   public class Bankrekening : Rekening , IRekening
    {
        private decimal maximaalKrediet;
       
        public Bankrekening( string _rekeningnr, decimal _banksaldo, decimal _maximaalkrediet) : base(_rekeningnr, _banksaldo)
        {
            this.maximaalKrediet = _maximaalkrediet;
        }

        public bool OverboekenSpaarRekening(decimal bedrag)
        {
            
            return true;
        }

        public bool BetalingVerrichten(string rekeningnr, decimal bedrag)
        {
            return true;
        }

        public void Afschrijven(decimal Bedrag)
        {
            try
            {
                base.AfSchrijven = Bedrag;
                if (base.Banksaldo <= maximaalKrediet)
                {
                    base.BijSchrijven = Bedrag;
                    throw new ArgumentException("U kan deze transactie niet uitvoeren omdat uw saldo dan onder nul komt.");
                }
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
    }
}

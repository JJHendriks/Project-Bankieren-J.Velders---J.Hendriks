using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
   public class Bankrekening : Rekening
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
    }
}

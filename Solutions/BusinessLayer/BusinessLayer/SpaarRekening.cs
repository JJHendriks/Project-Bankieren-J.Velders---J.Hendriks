using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class SpaarRekening : Rekening, IRekening
    {
        private decimal Rentepercentage;

        public decimal HuidigeRenteBerekenen
        {
            get { return (Banksaldo * Convert.ToDecimal(0.01)); }
        }

        public SpaarRekening(string _rekeningnr, decimal _banksaldo, decimal _rente) : base(_rekeningnr, _banksaldo)
        {
            this.Rentepercentage = _rente;
           
        }
       

        public override string ToString()
        {
            return base.ToString() + 
                string.Format("RentePercentage: {0}\nHuidig Opgebouwede Rente: {1}", Rentepercentage, HuidigeRenteBerekenen);
           
        }

        

        public void Afschrijven(decimal Bedrag)
        {
            try
            {
                base.AfSchrijven = Bedrag;
                if(base.Banksaldo <= 0)
                {
                    base.BijSchrijven = Bedrag;
                    throw new ArgumentException("U kan deze transactie niet uitvoeren omdat uw saldo dan onder nul komt.");
                }
            }
            catch(Exception exception)
            {
                throw exception;
            }
        }

       

      
           


    }
}

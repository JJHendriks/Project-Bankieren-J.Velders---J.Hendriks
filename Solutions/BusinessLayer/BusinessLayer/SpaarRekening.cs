using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class SpaarRekening : Rekening
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

        public bool OverboekenNaarBetaalrekening(decimal bedrag)
        {
            //Moet nog verder aangevuld worden
            return true;
        }

    }
}

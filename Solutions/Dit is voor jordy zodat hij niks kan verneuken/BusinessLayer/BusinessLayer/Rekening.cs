using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public abstract class Rekening 
    {
        /// <summary>
        /// Protected fields RekeningNr en Banksaldo
        /// </summary>
        protected string RekeningNr;

        protected decimal Banksaldo;

        /// <summary>
        /// Properties om geld af en bij te schrijven op het banksaldo
        /// </summary>
        public decimal Bijschrijven
        {
            set {Banksaldo += value; }
        }

        public decimal Afschrijven
        {
            set { value -= Banksaldo; }
        }

        /// <summary>
        /// De constructor van de abstracte class Rekening, deze constructor geeft een exception als het opgegeven banksaldo onder de 0 is
        /// </summary>
        /// <param name="_rekeningnr">Het rekening nummer van de rekening</param>
        /// <param name="_banksaldo">Het banksaldo van de rekening</param>
        public Rekening(string _rekeningnr, decimal _banksaldo)
        {
            //Hier moet nog een ELFPROEF bij
            if (_banksaldo >= 0)
            {
                this.RekeningNr = _rekeningnr;
                this.Banksaldo = _banksaldo;
            }
            else 
            {
                throw new ArgumentOutOfRangeException("Het startsaldo moet hoger zijn dan 0.");
            }

        }

        /// <summary>
        /// Deze methode zet alle fields om in een string
        /// </summary>
        /// <returns>Een string met alle fields met een return waarde</returns>
        public override string ToString()
        {
            return string.Format("RekeningNr: {0} \nBanksaldo: {1}", this.RekeningNr, this.Banksaldo);
        }



    }
}

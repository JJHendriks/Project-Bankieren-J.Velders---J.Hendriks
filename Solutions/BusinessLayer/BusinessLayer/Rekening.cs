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
        /// Properties voor Geld BijSchrijven op het Banksaldo en om Geld af te schrijven van het Banksaldo
        /// </summary>
        //public decimal BijSchrijven
        //{
        //    set { value += Banksaldo; }
        //}

        //public decimal AfSchrijven
        //{
        //    set
        //    {
               
        //        value -= Banksaldo;
        //    }
        //}


        public Rekening(string _rekeningnr, decimal _banksaldo)
        {
            this.RekeningNr = _rekeningnr;
            this.Banksaldo = _banksaldo;
        }

        public override string ToString()
        {
            return string.Format("RekeningNr: {0} \nBanksaldo: {1}", this.RekeningNr, this.Banksaldo);
        }



    }
}

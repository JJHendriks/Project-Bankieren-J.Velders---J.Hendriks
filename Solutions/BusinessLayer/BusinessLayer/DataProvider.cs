using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
   public static class DataProvider
    {
       public static List<Bankrekeninghouder> AlleBankrekeninghoudersVerkrijgen()
        {
            List<Bankrekeninghouder> AlleBankrekeningHouders = new List<Bankrekeninghouder>();

            AlleBankrekeningHouders.Add(new Bankrekeninghouder
                (
                voornaam: "Marietje",
                achternaam: "Kwakman",
                bsn: 232391464,
                gebruikersnaam: "M.Kwakman",
                wachtwoord: "Kwak41",
                rekeningnrSparen: "NL68RABO0121946746",
                spaarSaldo: 100,
                rentepercentage: 1,
                rekeningnrBetalen: "NL74RABO0380333589",
                BetaalSaldo: 10,
                maxkrediet: 1200

                ));

            AlleBankrekeningHouders.Add(new Bankrekeninghouder
              (
              voornaam: "Jim",
              achternaam: "Hendriks",
              bsn: 233865937,
              gebruikersnaam: "J.Hendriks",
              wachtwoord: "geheim",
              rekeningnrSparen: "NL68RABO0121946746",
              spaarSaldo: 1000,
              rentepercentage: 1,
              rekeningnrBetalen: "NL74RABO0380333589",
              BetaalSaldo: 100,
              maxkrediet: 1200

                ));

            AlleBankrekeningHouders.Add(new Bankrekeninghouder
              (
              voornaam: "Jordy",
              achternaam: "Velders",
              bsn: 232391464,
              gebruikersnaam: "J.Velders",
              wachtwoord: "jevolo",
              rekeningnrSparen: "NL68RABO0121946746",
              spaarSaldo: 554,
              rentepercentage: 1,
              rekeningnrBetalen: "NL74RABO0380333589",
              BetaalSaldo: 323,
              maxkrediet: 1500

                ));

            AlleBankrekeningHouders.Add(new Bankrekeninghouder
              (
              voornaam: "Tom",
              achternaam: "Tomson",
              bsn: 232391464,
              gebruikersnaam: "T.Tomson",
              wachtwoord: "geheim",
              rekeningnrSparen: "NL68RABO0121946746",
              spaarSaldo: 1200,
              rentepercentage: 1,
              rekeningnrBetalen: "NL74RABO0380333589",
              BetaalSaldo: 12,
              maxkrediet: 1200

                ));

            AlleBankrekeningHouders.Add(new Bankrekeninghouder
              (
              voornaam: "Max",
              achternaam: "Kwakman",
              bsn: 233865937,
              gebruikersnaam: "M.Kwakman",
              wachtwoord: "Kwak42",
              rekeningnrSparen: "NL68RABO0121946746",
              spaarSaldo: 100,
              rentepercentage: 1,
              rekeningnrBetalen: "NL74RABO0380333589",
              BetaalSaldo: 10,
              maxkrediet: 1200

                ));

            return AlleBankrekeningHouders;
        }

        /// <summary>
        /// Deze methode haalt een bankrekeninghouder uit de lijst 
        /// </summary>
        /// <param name="_gebruikersnaam"></param>
        /// <param name="_wachtwoord"></param>
        /// <returns></returns>
      public  static Bankrekeninghouder Inloggen(string _gebruikersnaam, string _wachtwoord)
        {
            var list = AlleBankrekeninghoudersVerkrijgen();
            
            foreach (var item in list )
            {
                if (_gebruikersnaam == item.Gebruikersnaam())
                {
                    if(_wachtwoord == item.Wachtwoord())
                    {
                        return item;
                        
                    }
                    else
                    {
                        throw new ArgumentException("Het opgegeven wachtwoord is incorrect");
                        return null;
                    }
                }
               
            }
            throw new ArgumentException("De opgegeven gebruikersnaam bestaat niet");
            return null;
            
            
        }

     public   static bool BnsElfProef(string _bsnN)
        {
            string cleanBsnNr = _bsnN.Trim().Replace(".", "");


            if (cleanBsnNr.Length != 9) return false;


            long l;
            if (!long.TryParse(cleanBsnNr, out l)) return false;
            else if (l == 0) return false;


            long total = 0;
            for (int i = 1; i <= 9; i++)
            {
                int number = Convert.ToInt32(cleanBsnNr[i - 1].ToString());
                int multiplier = 10 - i;
                if (i == 9) multiplier = -1 * multiplier;

                total += number * multiplier;
            }
            if (total == 0) return false;
            return total % 11 == 0;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Classes
{
   static class DataProvider
    {
       public static List<Bankrekeninghouder> AlleBankrekeninghoudersVerkrijgen()
        {
            List<Bankrekeninghouder> AlleBankrekeningHouders = new List<Bankrekeninghouder>();

            AlleBankrekeningHouders.Add(new Bankrekeninghouder
                (
                voornaam: "Marietje",
                achternaam: "Kwakman",
                bsn: 7778686889,
                gebruikersnaam: "M.Kwakman",
                wachtwoord: "Kwak41",
                rekeningnrSparen: "5363738",
                spaarSaldo: 100,
                rentepercentage: 1,
                rekeningnrBetalen: "5323748",
                BetaalSaldo: 10,
                maxkrediet: 1200

                ));

            AlleBankrekeningHouders.Add(new Bankrekeninghouder
              (
              voornaam: "Jim",
              achternaam: "Hendriks",
              bsn: 777883869,
              gebruikersnaam: "J.Hendriks",
              wachtwoord: "geheim",
              rekeningnrSparen: "5363758",
              spaarSaldo: 1000,
              rentepercentage: 1,
              rekeningnrBetalen: "5393748",
              BetaalSaldo: 100,
              maxkrediet: 1200

                ));

            AlleBankrekeningHouders.Add(new Bankrekeninghouder
              (
              voornaam: "Jordy",
              achternaam: "Velders",
              bsn: 7668686889,
              gebruikersnaam: "J.Velders",
              wachtwoord: "jevolo",
              rekeningnrSparen: "5477738",
              spaarSaldo: 554,
              rentepercentage: 1,
              rekeningnrBetalen: "5377848",
              BetaalSaldo: 323,
              maxkrediet: 1500

                ));

            AlleBankrekeningHouders.Add(new Bankrekeninghouder
              (
              voornaam: "Tom",
              achternaam: "Tomson",
              bsn: 7778123459,
              gebruikersnaam: "T.Tomson",
              wachtwoord: "geheim",
              rekeningnrSparen: "5366543",
              spaarSaldo: 1200,
              rentepercentage: 1,
              rekeningnrBetalen: "53321423",
              BetaalSaldo: 12,
              maxkrediet: 1200

                ));

            AlleBankrekeningHouders.Add(new Bankrekeninghouder
              (
              voornaam: "Max",
              achternaam: "Kwakman",
              bsn: 7778689989,
              gebruikersnaam: "M.Kwakman",
              wachtwoord: "Kwak42",
              rekeningnrSparen: "5369938",
              spaarSaldo: 100,
              rentepercentage: 1,
              rekeningnrBetalen: "5329948",
              BetaalSaldo: 10,
              maxkrediet: 1200

                ));

            return AlleBankrekeningHouders;
        }

        
        static Bankrekeninghouder Inloggen(string _gebruikersnaam, string _wachtwoord)
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
                else
                {
                    
                    throw new ArgumentException("De opgegeven gebruikersnaam is bestaat niet");
                    return null;
                }
            }
            return null;
            
            
        }
        

    }
}

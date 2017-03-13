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
                rekeningnrSparen: "NL68RABO5221349043",
                spaarSaldo: 100,
                rentepercentage: 1,
                rekeningnrBetalen: "NL68RABO6722349043",
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
              rekeningnrSparen: "NL53RABO6722449043",
              spaarSaldo: 1000,
              rentepercentage: 1,
              rekeningnrBetalen: "NL53RABO6722341236",
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
              rekeningnrSparen: "NL23RABO6722345578",
              spaarSaldo: 554,
              rentepercentage: 1,
              rekeningnrBetalen: "NL23RABO6722322136",
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
              rekeningnrSparen: "NL21RABO6722324456",
              spaarSaldo: 1200,
              rentepercentage: 1,
              rekeningnrBetalen: "NL21RABO67223223211",
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
              rekeningnrSparen: "NL19RABO67223228899",
              spaarSaldo: 100,
              rentepercentage: 1,
              rekeningnrBetalen: "NL19RABO6722322335",
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
                    
                    throw new ArgumentException("De opgegeven gebruikersnaam bestaat niet");
                    return null;
                }
            }
            return null;
            
            
        }
        

    }
}

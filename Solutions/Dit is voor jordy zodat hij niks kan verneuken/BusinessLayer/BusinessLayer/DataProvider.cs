using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
   public static class DataProvider
    {
        public static List<Bankrekeninghouder> BankrekeningHouders;

        public static List<Bankier> Bankiers;
        /// <summary>
        /// Deze methode vult de list BankrekeningHouders met instances van Bankrekeninghouder als de list null is. 
        /// En deze methode throwed een exception als je constructor van de bankrekeninghouder fout gaat door bijvoorbeeld een verkeerd bsn nummer
        /// </summary>
       public static void LijstBankrekeninghoudersVullen()
        {
            if (BankrekeningHouders == null)
            {
                try
                {
                    BankrekeningHouders = new List<Bankrekeninghouder>();


                    BankrekeningHouders.Add(new Bankrekeninghouder
                        (
                        voornaam: "Marietje",
                        achternaam: "Kwakman",
                        bsn: "232391464",
                        gebruikersnaam: "M.Kwakman",
                        wachtwoord: "Kwak41",
                        rekeningnrSparen: "NL68RABO0121946746",
                        spaarSaldo: 100,
                        rentepercentage: 1,
                        rekeningnrBetalen: "NL74RABO0380333589",
                        BetaalSaldo: 10,
                        maxkrediet: -1200

                        ));

                    BankrekeningHouders.Add(new Bankrekeninghouder
                      (
                      voornaam: "Jim",
                      achternaam: "Hendriks",
                      bsn: "233865937",
                      gebruikersnaam: "J.Hendriks",
                      wachtwoord: "geheim",
                      rekeningnrSparen: "NL68RABO0121946476",
                      spaarSaldo: 1000,
                      rentepercentage: 1,
                      rekeningnrBetalen: "NL74RABO0380333598",
                      BetaalSaldo: 100,
                      maxkrediet: -1200

                        ));

                    BankrekeningHouders.Add(new Bankrekeninghouder
                      (
                      voornaam: "Jordy",
                      achternaam: "Velders",
                      bsn: "618230488",
                      gebruikersnaam: "J.Velders",
                      wachtwoord: "jevolo",
                      rekeningnrSparen: "NL68RABO0121947646",
                      spaarSaldo: 10000,
                      rentepercentage: 1,
                      rekeningnrBetalen: "NL74RABO0381333589",
                      BetaalSaldo: 15000,
                      maxkrediet: -1500

                        ));

                    BankrekeningHouders.Add(new Bankrekeninghouder
                      (
                      voornaam: "Tom",
                      achternaam: "Tomson",
                      bsn: "342007063",
                      gebruikersnaam: "T.Tomson",
                      wachtwoord: "geheim",
                      rekeningnrSparen: "NL68RABO0211946746",
                      spaarSaldo: 1200,
                      rentepercentage: 1,
                      rekeningnrBetalen: "NL74RABO0510333589",
                      BetaalSaldo: 12,
                      maxkrediet: -1200

                        ));

                    BankrekeningHouders.Add(new Bankrekeninghouder
                      (
                      voornaam: "Max",
                      achternaam: "Kwakman",
                      bsn: "285835622",
                      gebruikersnaam: "M.Kwakman",
                      wachtwoord: "Kwak42",
                      rekeningnrSparen: "NL68RABO0121496746",
                      spaarSaldo: 100,
                      rentepercentage: 1,
                      rekeningnrBetalen: "NL74RABO0381133589",
                      BetaalSaldo: 10,
                      maxkrediet: -1200

                        ));
                }
                catch (Exception)
                {
                    throw;
                }
            }
            
        }
        /// <summary>
        /// Deze methode vult de list bankiers met een aantal instances van Bankier als de list null is.
        /// </summary>
        public static void LijstBankiersVullen()
        {
            if (Bankiers == null)
            {
                try
                {
                    Bankiers = new List<Bankier>();


                    Bankiers.Add(new Bankier
                        (
                        _bankNaam: "Rabobank",
                        _gebruikersnaam: "H.Helperton",
                        _wachtwoord: "welkom01"

                        ));

                    Bankiers.Add(new Bankier
                        (
                        _bankNaam: "Rabobank",
                        _gebruikersnaam: "J.Man",
                        _wachtwoord: "welkom01"

                        ));
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
        

        /// <summary>
        /// Deze methode haalt een bankrekeninghouder uit de lijst doormiddel van de gebruikersnaam en het wachtwoord
        /// </summary>
        /// <param name="_gebruikersnaam">De gebruikersnaam van de bankrekeninghouder</param>
        /// <param name="_wachtwoord">Het wachtwoord van de bankrekeninghouder</param>
        /// <returns>Een instance van bankrekeninghouder</returns>
      public  static Bankrekeninghouder Inloggen(string _gebruikersnaam, string _wachtwoord)
        {
            LijstBankrekeninghoudersVullen();
            var list = BankrekeningHouders;
            
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
        /// <summary>
        /// Deze methode retourneert een gebruiker doormiddel van een van te voren opgegeven gebruikersnaam
        /// </summary>
        /// <param name="_gebruikersnaam"></param>
        /// <returns>Een instance van bankrekeninghouder</returns>
        public static Bankrekeninghouder GebruikerVerkrijgenGebruikersnaam(string _gebruikersnaam)
        {
            LijstBankrekeninghoudersVullen();
            var list = BankrekeningHouders;

            foreach (var item in list)
            {
                if (_gebruikersnaam == item.Gebruikersnaam())
                { 
                        return item;
                }
            
            }
            throw new ArgumentException("De opgegeven gebruikersnaam bestaat niet");
            return null;


        }

        public static Bankrekeninghouder GebruikerVerkrijgenRekeningnr(string _rekeningnr)
        {
            LijstBankrekeninghoudersVullen();
            var list = BankrekeningHouders;

            foreach (var item in list)
            {
                if (_rekeningnr == item.Betaalrekening.BetaalRekeningnr())
                {
                    return item;
                }

            }
            throw new ArgumentException("Het opgegeven bankrekeningnummer bestaat niet");
            return null;


        }
        /// <summary>
        /// Deze methode voert je elfproef uit op een BSN nummer
        /// </summary>
        /// <param name="_bsnN">Het bsn nummer waarop de elfproef op uitgevoerd moet worden</param>
        /// <returns>true or false</returns>
        public   static bool BsnElfProef(string _bsnN)
        {
            //Dit zorgt ervoor dat alle eventuele spaties worden weggehaald
            string cleanBsnNr = _bsnN.Trim().Replace(".", "");

            //Als de string langer of korter is dan 9 wordt false geretouneerd
            if (cleanBsnNr.Length != 9) return false;

            //Als de string met het bsn nummer niet naar long geconverteerd kan worden wordt false geretouneerd
            long l;
            if (!long.TryParse(cleanBsnNr, out l)) return false;
            else if (l == 0) return false;

            //Hier wordt de uiteindelijke elfproef uitgevoerd
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

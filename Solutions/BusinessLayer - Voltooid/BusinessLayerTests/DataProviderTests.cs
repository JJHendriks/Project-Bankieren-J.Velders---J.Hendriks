using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLayer;

namespace BusinessLayerTests
{
    [TestClass]
    public class DataProviderTests
    {

        [TestMethod]
        public void LijstBankrekeninghoudersvullenTest()
        {
            //arrange

            //act
            DataProvider.LijstBankrekeninghoudersVullen();

            //assert
            Assert.IsNotNull(DataProvider.BankrekeningHouders);
        }

        [TestMethod]
        public void LijstBankiersvullenTest()
        {
            //arrange

            //act
            DataProvider.LijstBankiersVullen();

            //assert
            Assert.IsNotNull(DataProvider.Bankiers);
        }

        [TestMethod]
        public void BsnElfproefTestTrue()
        {
            //arrange
            string text = "232391464";
            //act
            bool boolean = DataProvider.BsnElfProef(text);
            //assert

            Assert.IsTrue(boolean);
        }

        [TestMethod]
        public void BsnElfproefTestFalse()
        {
            //arrange
            string text = "132391464";
            //act
            bool boolean = DataProvider.BsnElfProef(text);
            //assert

            Assert.IsFalse(boolean);
        }

        [TestMethod]
        public void IbanElfproefTestTrue()
        {
            //arrange
            string text = "NL68RABO0232391464";
            //act
            bool boolean = DataProvider.IbanElfProef(text);
            //assert

            Assert.IsTrue(boolean);
        }

        [TestMethod]
        public void IbanElfproefTestFalse()
        {
            //arrange
            string text = "NL68RABO0132391464";
            //act
            bool boolean = DataProvider.IbanElfProef(text);
            //assert

            Assert.IsFalse(boolean);
        }

        [TestMethod]
        public void InloggenGebruikerTestTrue()
        {
            //arrange
            string gebruikersnaam = "M.Kwakman";
            string wachtwoord = "Kwak41";
            //act
            Bankrekeninghouder gebruiker = DataProvider.InloggenGebruiker(gebruikersnaam, wachtwoord);

            //assert
            Assert.IsNotNull(gebruiker);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),"De opgegeven gebruikersnaam bestaat niet")]
        public void InloggenGebruikerTestFalseUserName()
        {
            //arrange
            string gebruikersnaam = "L.Kwakman";
            string wachtwoord = "Kwak41";
            //act
            Bankrekeninghouder gebruiker = DataProvider.InloggenGebruiker(gebruikersnaam, wachtwoord);

            //assert
            Assert.IsNotNull(gebruiker);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException),"Het opgegeven wachtwoord is incorrect")]
        public void InloggenGebruikerTestFalsePassword()
        {
            //arrange
            string gebruikersnaam = "M.Kwakman";
            string wachtwoord = "Kwak48";
            //act
            Bankrekeninghouder gebruiker = DataProvider.InloggenGebruiker(gebruikersnaam, wachtwoord);

            //assert
            Assert.IsNotNull(gebruiker);
        }

        [TestMethod]
        public void InloggenGebruikerBankierTestTrue()
        {
            //arrange
            string gebruikersnaam = "H.Helperton";
            string wachtwoord = "welkom01";
            //act
            Bankier bankier = DataProvider.InloggenBankier(gebruikersnaam, wachtwoord);

            //assert
            Assert.IsNotNull(bankier);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "De opgegeven gebruikersnaam bestaat niet")]
        public void InloggenBankierTestFalseUserName()
        {
            //arrange
            string gebruikersnaam = "H.Elperton";
            string wachtwoord = "welkom01";
            //act
            Bankier bankier = DataProvider.InloggenBankier(gebruikersnaam, wachtwoord);

            //assert
            Assert.IsNotNull(bankier);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Het opgegeven wachtwoord is incorrect")]
        public void InloggenBankierTestFalsePassword()
        {
            //arrange
            string gebruikersnaam = "H.Helperton";
            string wachtwoord = "elkom01";
            //act
            Bankier bankier = DataProvider.InloggenBankier(gebruikersnaam, wachtwoord);

            //assert
            Assert.IsNotNull(bankier);
        }

        [TestMethod]
        public void GebruikerVerkrijgenViaGebruikersnaamTestTrue()
        {
            //arrange
            string gebruikersnaam = "J.Velders";
            //act
            Bankrekeninghouder gebruiker = DataProvider.GebruikerVerkrijgenGebruikersnaam(gebruikersnaam);
            //assert
            Assert.IsNotNull(gebruiker);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),"De opgegeven gebruikersnaam bestaat niet")]
        public void GebruikerVerkrijgenViaGebruikersnaamTestFalse()
        {
            //arrange
            string gebruikersnaam = "J.Kelders";
            //act
            Bankrekeninghouder gebruiker = DataProvider.GebruikerVerkrijgenGebruikersnaam(gebruikersnaam);
            
            //assert
           
        }

        [TestMethod]
        public void GebruikerVerkrijgenViaRekeningnrTestTrue()
        {
            //arrange
            string rekeningnr = "NL74RABO0900467563";
            //act
            Bankrekeninghouder gebruiker = DataProvider.GebruikerVerkrijgenRekeningnr(rekeningnr);
            //assert
            Assert.IsNotNull(gebruiker);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "De opgegeven gebruikersnaam bestaat niet")]
        public void GebruikerVerkrijgenViaRekeningnrTestFalse()
        {
            //arrange
            string rekeningnr = "NL74RABO0900067560";
            //act
            Bankrekeninghouder gebruiker = DataProvider.GebruikerVerkrijgenRekeningnr(rekeningnr);

            //assert

        }
    }
}

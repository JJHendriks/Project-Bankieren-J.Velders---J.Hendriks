using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLayer;

namespace BusinessLayerTests
{
    [TestClass]
    public class BankierTests
    {
        [TestMethod]
        public void RenteBijschrijvenTest()
        {
            //arrange
            Bankier bank = DataProvider.InloggenBankier("H.Helperton", "welkom01");

            Bankrekeninghouder gebruiker = DataProvider.GebruikerVerkrijgenGebruikersnaam("J.Hendriks");

            decimal getal = gebruiker.Spaarrekening.HuidigeRenteBerekenen;
            decimal resultaat = gebruiker.Spaarrekening.SpaarSaldo() + getal;

            //act
            bank.Rentebijschrijven();

            //assert
            Bankrekeninghouder gebruikertest = DataProvider.GebruikerVerkrijgenGebruikersnaam("J.Hendriks");

            Assert.AreEqual(resultaat, gebruikertest.Spaarrekening.SpaarSaldo());
        }

        [TestMethod]
        public void GebruikerAanmakenTestTrue()
        {
            //arrange
            Bankier bank = DataProvider.InloggenBankier("H.Helperton", "welkom01");

            //act
            bank.ToevoegenBankrekeninghouder("Jan", "Detest", "841911605", "J.Detest", "welkom01", "NL68RABO0841911605", 1200, 1, "NL68RABO0721946483", 20, -1200);

            //assert
            Assert.IsTrue(DataProvider.BankrekeningHouders.Count == 6);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GebruikerAanmakenTestFalse()
        {
            //arrange
            Bankier bank = DataProvider.InloggenBankier("H.Helperton", "welkom01");

            //act
            bank.ToevoegenBankrekeninghouder("Jan", "Detest", "841911606", "J.Detest", "welkom01", "NL68RABO0841911605", 1200, 1, "NL68RABO0721946483", 20, -1200);

            //assert
           

        }
        [TestMethod]
        public void GebruikerOpheffenTest()
        {
            //arrange
            Bankier bank = DataProvider.InloggenBankier("H.Helperton", "welkom01");

            //assert
            Assert.IsTrue(bank.BankRekeninghouderOpheffen("J.Hendriks"));
        }

    }
}

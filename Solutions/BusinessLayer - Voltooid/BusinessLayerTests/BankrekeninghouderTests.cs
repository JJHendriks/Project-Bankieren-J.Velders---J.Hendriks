using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLayer;

namespace BusinessLayerTests
{
    [TestClass]
   
    public class BankrekeninghouderTests
    {
        //Al deze tests moeten INDIVIDUEEL gerunt worden. Omdat de lijst van de dataprovider static is worden
        //alle veranderingen op deze lijst bewaard en daardoor falen deze unit tests al je ze tegelijk met de andere
        //unit tests runt 


        [TestMethod]
        public void BetalingVerrichtenTest()
        {
            //arrange
            Bankrekeninghouder gebruiker = DataProvider.GebruikerVerkrijgenGebruikersnaam("J.Velders");
            Bankrekeninghouder gebruikertest = DataProvider.GebruikerVerkrijgenGebruikersnaam("T.Tomson");

            //act
            gebruiker.BetalingVerrichten("NL74RABO0736998275", 40);

            //assert
            Assert.AreEqual(52 , gebruikertest.Betaalrekening.BetaalSaldo());

        }

        [TestMethod]
        public void OverboekenNaarSpaarrekening()
        {
            //arrange
            Bankrekeninghouder gebruiker = DataProvider.GebruikerVerkrijgenGebruikersnaam("MM.Kwakman");

            //act
            gebruiker.OverboekenNaarSpaarRekening(5);

            //assert
            Assert.AreEqual(105, gebruiker.Spaarrekening.SpaarSaldo());
        }
        [TestMethod]
        public void OverboekenNaarBetaalrekening()
        {
            //arrange
            Bankrekeninghouder gebruiker = DataProvider.GebruikerVerkrijgenGebruikersnaam("MM.Kwakman");

            //act
            gebruiker.OverboekenNaarBetaalRekening(50);

            //assert
            Assert.AreEqual(50, gebruiker.Spaarrekening.SpaarSaldo());
        }


    }
}

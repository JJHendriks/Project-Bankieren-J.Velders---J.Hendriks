using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLayer;

namespace BusinessLayerTests
{
    [TestClass]
    public class RekeningTests
    {
        //Bijschrijven is hetzelfde bij betaalrekening en spaarrekening
        [TestMethod]
        public void BijSchrijvenTest()
        {
            //arrange
            BetaalRekening testrekening = new BetaalRekening("NL68RABO0121946746", 100, -1000);
            
            //act
            testrekening.Bijschrijven = 100;

            //assert
            Assert.AreEqual(200, testrekening.BetaalSaldo());

        }

        [TestMethod]
        public void AfSchrijvenSpaarrekeningTest()
        {
            //arrange
            SpaarRekening testrekening = new SpaarRekening("NL68RABO0121946746", 1000, 1);
            //act
            testrekening.AfSchrijven(500);
            //assert
            Assert.AreEqual(500, testrekening.SpaarSaldo());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
    "U kan deze transactie niet uitvoeren omdat uw saldo dan onder nul komt.")]
        public void AfSchrijvenSpaarrekeningOndernulTest()
        {
            //arrange
            SpaarRekening testrekening = new SpaarRekening("NL68RABO0121946746", 1000, 1);
            //act
            testrekening.AfSchrijven(1500);
            //assert
        }

        [TestMethod]
        public void AfSchrijvenBetaalrekeningTest()
        {
            //arrange
            BetaalRekening testrekening = new BetaalRekening("NL68RABO0121946746", 100, -1000);
            //act
            testrekening.AfSchrijven(50);
            //assert
            Assert.AreEqual(50, testrekening.BetaalSaldo());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
    "U kan deze transactie niet uitvoeren omdat uw saldo dan onder het maximum krediet komt.")]
        public void AfSchrijvenBetaalrekeningOnderMaxKredietTest()
        {
            //arrange
            BetaalRekening testrekening = new BetaalRekening("NL68RABO0121946746", 100, -1000);
            //act
            testrekening.AfSchrijven(2000);
            //assert
        }
    }
}

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
    }
}

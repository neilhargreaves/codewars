using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CodeWars.Tests
{
    [TestClass]
    public class MoneyMoneyMoneyTests
    {
        [TestMethod]
        public void GetNumberOfYears0()
        {
            Assert.AreEqual(0, MoneyMoneyMoney.CalculateYears(1000, 0.05, 0.18, 1000));
        }

        [TestMethod]
        public void GetNumberOfYears1()
        {
            Assert.AreEqual(14, MoneyMoneyMoney.CalculateYears(1000, 0.01625, 0.18, 1200));
        }
    }
}



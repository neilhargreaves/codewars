﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars.Tests
{
    [TestClass]
    public class WeightForWeightTests
    {
        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual("2000 103 123 4444 99", 
                WeightForWeight.OrderWeight("103 123 4444 99 2000"));
            Assert.AreEqual("11 11 2000 10003 22 123 1234000 44444444 9999", 
                WeightForWeight.OrderWeight("2000 10003 1234000 44444444 9999 11 11 22 123"));
        }

        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual("2000 103 123 4444 99", 
                WeightForWeight.OrderWeight("103 123 4444 99 2000"));
            Assert.AreEqual("11 11 2000 10003 22 123 1234000 44444444 9999", 
                WeightForWeight.OrderWeight("2000 10003 1234000 44444444 9999 11 11 22 123"));
            Assert.AreEqual("", WeightForWeight.OrderWeight(""));
            Assert.AreEqual("2000 10003 1234000 44444444 9999 123456789", 
                WeightForWeight.OrderWeight("10003 1234000 44444444 9999 2000 123456789"));
            string a = "3 16 9 38 95 1131268 49455 347464 59544965313 496636983114762 85246814996697";
            string r = "3 16 9 38 95 1131268 49455 347464 59544965313 496636983114762 85246814996697";
            Assert.AreEqual(r, WeightForWeight.OrderWeight(a));
            a = "71899703 200 6 91 425 4 67407 7 96488 6 4 2 7 31064 9 7920 1 34608557 27 72 18 81";
            r = "1 2 200 4 4 6 6 7 7 18 27 72 81 9 91 425 31064 7920 67407 96488 34608557 71899703";
            Assert.AreEqual(r, WeightForWeight.OrderWeight(a));
            a = "387087 176 351832 100 430372 8 58052 54 175432 120 269974 147 309754 91 404858 67 271476 164 295747 111 40";
            r = "100 111 120 40 8 54 91 164 147 67 176 430372 58052 175432 351832 271476 309754 404858 387087 295747 269974";
            Assert.AreEqual(r, WeightForWeight.OrderWeight(a));
        }
    }
}
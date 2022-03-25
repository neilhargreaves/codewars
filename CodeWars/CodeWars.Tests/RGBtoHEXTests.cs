using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars.Tests
{
    [TestClass()]
    public class RGBtoHEXTests
    {
        [TestMethod()]
        public void RgbtoHexTest()
        {
            Assert.AreEqual("FFFFFF", RGBtoHEX.RgbtoHex(255, 255, 255));
            Assert.AreEqual("FFFFFF", RGBtoHEX.RgbtoHex(255, 255, 300));
            Assert.AreEqual("000000", RGBtoHEX.RgbtoHex(0, 0, 0));
            Assert.AreEqual("9400D3", RGBtoHEX.RgbtoHex(148, 0, 211));
            Assert.AreEqual("9400D3", RGBtoHEX.RgbtoHex(148, -20, 211), "Handle negative numbers.");
            Assert.AreEqual("90C3D4", RGBtoHEX.RgbtoHex(144, 195, 212));
            Assert.AreEqual("D4350C", RGBtoHEX.RgbtoHex(212, 53, 12), "Consider single hex digit numbers.");
        }
    }
}
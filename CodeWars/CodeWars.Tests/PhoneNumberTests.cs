using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars.Tests
{
    [TestClass]
    public class PhoneNumberTests
    {
        [TestMethod]
        public void FixedTest()
        {
            Assert.AreEqual("(123) 456-7890", 
                PhoneNumber.CreatePhoneNumber(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }));
            Assert.AreEqual("(111) 111-1111",
                PhoneNumber.CreatePhoneNumber(new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }));
        }
    }
}

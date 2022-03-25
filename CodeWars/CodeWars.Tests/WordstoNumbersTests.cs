using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars.Tests
{
    [TestClass()]
    public class WordstoNumbersTests
    {
        [TestMethod()]
        public void ParseIntTest()
        {
            Assert.AreEqual(1, WordstoNumbers.ParseInt("one"));
            Assert.AreEqual(20, WordstoNumbers.ParseInt("twenty"));
            Assert.AreEqual(246, WordstoNumbers.ParseInt("two hundred forty-six"));
            Assert.AreEqual(-146, WordstoNumbers.ParseInt("minus one hundred forty-six"));
            Assert.AreEqual(2000166, WordstoNumbers.ParseInt("two million one hundred sixty-six"));
            Assert.AreEqual(2001256, WordstoNumbers.ParseInt("two million one thousand two hundred and fifty-six"));
            Assert.AreEqual(2001246, WordstoNumbers.ParseInt("two million one thousand two hundred & forty-six"));
            Assert.AreEqual(2000000000, WordstoNumbers.ParseInt("two billion"));
            Assert.AreEqual(8000000000000, WordstoNumbers.ParseInt("eight trillion"));
        }
    }
}
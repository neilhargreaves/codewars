using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars.Tests
{
    [TestClass]
    public class DubstepTests
    {
        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual("ABC", Dubstep.SongDecoder("WUBWUBABCWUB"));
        }

        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual("R L", Dubstep.SongDecoder("RWUBWUBWUBLWUB"));
        }

        [TestMethod]
        public void Test3()
        {
            Assert.AreEqual("JKD WBIRAQKF YE WV", Dubstep.SongDecoder("WUBJKDWUBWUBWBIRAQKFWUBWUBYEWUBWUBWUBWVWUBWUB"));
        }

        [TestMethod]
        public void Test4()
        {
            Assert.AreEqual("KSDHEMIXUJ R S H", Dubstep.SongDecoder("WUBKSDHEMIXUJWUBWUBRWUBWUBWUBSWUBWUBWUBHWUBWUBWUB"));
        }

        [TestMethod]
        public void Test5()
        {
            Assert.AreEqual("Q QQ I WW JOPJPBRH", Dubstep.SongDecoder("QWUBQQWUBWUBWUBIWUBWUBWWWUBWUBWUBJOPJPBRH"));
        }

        [TestMethod]
        public void Test6()
        {
            Assert.AreEqual("O IPVCQAFWY Q XHDKCPYKCTWWY V FZ", Dubstep.SongDecoder("WUBWUBOWUBWUBWUBIPVCQAFWYWUBWUBWUBQWUBWUBWUBXHDKCPYKCTWWYWUBWUBWUBVWUBWUBWUBFZWUBWUB"));
        }

        [TestMethod]
        public void Test7()
        {
            Assert.AreEqual("YYRTSMNWU C C FSYUINDWOBV F AU V JB", Dubstep.SongDecoder("WUBYYRTSMNWUWUBWUBWUBCWUBWUBWUBCWUBWUBWUBFSYUINDWOBVWUBWUBWUBFWUBWUBWUBAUWUBWUBWUBVWUBWUBWUBJB"));
        }

        [TestMethod]
        public void Test8()
        {
            Assert.AreEqual("KSDHEMIXUJ R S H", Dubstep.SongDecoder("WUBKSDHEMIXUJWUBWUBRWUBWUBWUBSWUBWUBWUBHWUBWUBWUB"));
        }

        [TestMethod]
        public void Test9()
        {
            Assert.AreEqual("A", Dubstep.SongDecoder("AWUBWUBWUB"));
        }

        [TestMethod]
        public void Test10()
        {
            Assert.AreEqual("A B C D", Dubstep.SongDecoder("AWUBBWUBCWUBD"));
        }

        [TestMethod]
        public void Test11()
        {
            Assert.AreEqual("W U B", Dubstep.SongDecoder("WUBWWUBWUBWUBUWUBWUBBWUB"));
        }

        [TestMethod]
        public void Test12()
        {
            Assert.AreEqual("WU BW UB", Dubstep.SongDecoder("WUWUBBWWUBUB"));
        }

        [TestMethod]
        public void Test13()
        {
            Assert.AreEqual("WUAB", Dubstep.SongDecoder("WUBWUBWUBWUBWUBWUBWUBWUBWUBWUBWUBWUBWUBWUBWUBWUBWUBWUBWUBWUBWUBWUBWUBWUBWUBWUBWUBWUBWUBWUABWUBWUBWUBWUBWUBWUBWUBWUBWUBWUBWUBWUBWUBWUBWUBWUBWUBWUBWUBWUBWUBWUBWUBWUBWUBWUBWUB"));
        }

        [TestMethod]
        public void Test14()
        {
            Assert.AreEqual("U", Dubstep.SongDecoder("U"));
        }

        [TestMethod]
        public void Test15()
        {
            Assert.AreEqual("WU", Dubstep.SongDecoder("WUWUB"));
        }

        [TestMethod]
        public void Test16()
        {
            Assert.AreEqual("UB", Dubstep.SongDecoder("UBWUB"));
        }

        [TestMethod]
        public void Test17()
        {
            Assert.AreEqual("WU UB U", Dubstep.SongDecoder("WUWUBUBWUBUWUB"));
        }

        [TestMethod]
        public void Test18()
        {
            Assert.AreEqual("W A", Dubstep.SongDecoder("WUBWWUBAWUB"));
        }

        [TestMethod]
        public void Test19()
        {
            Assert.AreEqual("WUUUUU", Dubstep.SongDecoder("WUUUUU"));
        }

        [TestMethod]
        public void Test20()
        {
            Assert.AreEqual("A", Dubstep.SongDecoder("WUBWUBA"));
        }
    }
}

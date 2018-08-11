using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace CodeWars.Tests
{
    [TestClass]
    public class KataTests
    {
        [TestMethod]
        public void Test1()
        {
            string[] expected = { "Ryan", "Mark" };
            string[] names = { "Ryan", "Kieran", "Mark", "Jimmy", "Lee" };
            CollectionAssert.AreEqual(expected, Kata.FriendOrFoe(names).ToList());
        }

        [TestMethod]
        public void Test2()
        {
            string[] expected = { "Mark", "Abel" };
            string[] names = { "Mark", "Jimmy", "Abel", "Amanda" };
            CollectionAssert.AreEqual(expected, Kata.FriendOrFoe(names).ToList());
        }

        [TestMethod]
        public void Test3()
        {
            string[] expected = { "Anna" };
            string[] names = { "Peter", "Anna", "Michael" };
            CollectionAssert.AreEqual(expected, Kata.FriendOrFoe(names).ToList());
        }

        [TestMethod]
        public void Test4()
        {
            string[] expected = { "Beau", "Azul" };
            string[] names = { "Linus", "Beau", "Azul" };
            CollectionAssert.AreEqual(expected, Kata.FriendOrFoe(names).ToList());
        }
    }
}



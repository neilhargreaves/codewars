using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars.Tests
{
    [TestClass]
    public class SquaresInRectangleTests
    {
        [TestMethod]
        public void Test1()
        {
            int[] r = new int[] { 3, 2, 1, 1 };
            CollectionAssert.AreEqual(r, SquaresInRectangle.SquareCalculator(5, 3));
        }

        [TestMethod]
        public void Test3()
        {
            CollectionAssert.AreEqual(null, SquaresInRectangle.SquareCalculator(5, 5));       
        }

        [TestMethod]
        public void Test11()
        {
            int[] r = new int[] { 3, 2, 1, 1 };
            CollectionAssert.AreEqual(r, SquaresInRectangle.SquareCalculator(5, 3));
        }

        [TestMethod]
        public void Test2()
        {
            int[] r = new int[] { 3, 2, 1, 1 };
            CollectionAssert.AreEqual(r, SquaresInRectangle.SquareCalculator(3, 5));
        }

        [TestMethod]
        public void Test13()
        {
            CollectionAssert.AreEqual(null, SquaresInRectangle.SquareCalculator(5, 5));
        }

        [TestMethod]
        public void Test4()
        {
            int[] r = new int[] { 14, 6, 6, 2, 2, 2 };
            CollectionAssert.AreEqual(r, SquaresInRectangle.SquareCalculator(20, 14));
        }

        [TestMethod]
        public void Test5()
        {
            int[] r = new int[] { 14, 6, 6, 2, 2, 2 };
            CollectionAssert.AreEqual(r, SquaresInRectangle.SquareCalculator(14, 20));
        }

        [TestMethod]
        public void Test6()
        {
            int[] r = new int[] { 32, 32, 32, 32, 32, 32, 32, 16, 16 };
            CollectionAssert.AreEqual(r, SquaresInRectangle.SquareCalculator(240, 32));
        }

        [TestMethod]
        public void Test7()
        {
            int[] r = new int[] { 230, 230, 165, 65, 65, 35, 30, 5, 5, 5, 5, 5, 5 };
            CollectionAssert.AreEqual(r, SquaresInRectangle.SquareCalculator(625, 230));
        }

        [TestMethod]
        public void Test8()
        {
            int[] r = new int[] { 230, 230, 230, 41, 41, 41, 41, 41, 25, 16, 9, 7, 2, 2, 2, 1, 1 };
            CollectionAssert.AreEqual(r, SquaresInRectangle.SquareCalculator(731, 230));
        }

        [TestMethod]
        public void Test9()
        {
            int[] r = new int[] { 14, 14, 9, 5, 4, 1, 1, 1, 1 };
            CollectionAssert.AreEqual(r, SquaresInRectangle.SquareCalculator(37, 14));
        }

        [TestMethod]
        public void Test10()
        {
            int[] r = new int[] { 1, 1 };
            CollectionAssert.AreEqual(r, SquaresInRectangle.SquareCalculator(2, 1));
        }
    }
}

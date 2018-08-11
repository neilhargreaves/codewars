using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars.Tests
{
    [TestClass]
   public class MemberServiceTests
    {
        [TestMethod]
        public void SampleTest()
        {
            CollectionAssert.AreEqual(new[] { "Open", "Senior", "Open", "Senior" }, 
                MembersService.OpenOrSenior(new[] { new[] { 45, 12 }, new[] { 55, 21 }, new[] { 19, 2 }, new[] { 104, 20 } })
                .ToList());
            CollectionAssert.AreEqual(new[] { "Open", "Open", "Open", "Open" }, 
                MembersService.OpenOrSenior(new[] { new[] { 3, 12 }, new[] { 55, 1 }, new[] { 91, -2 }, new[] { 54, 23 } })
                .ToList());
            CollectionAssert.AreEqual(new[] { "Senior", "Open", "Open", "Open" }, 
                MembersService.OpenOrSenior(new[] { new[] { 59, 12 }, new[] { 45, 21 }, new[] { -12, -2 }, new[] { 12, 12 } })
                .ToList());
        }

        [TestMethod]
        public void EdgeTest()
        {
            CollectionAssert.AreEqual(new List<string>().ToArray(), 
                MembersService.OpenOrSenior(new int[0][]).ToList(), 
                "Empty array");
            CollectionAssert.AreEqual(new[] { "Open", "Senior" }, 
                MembersService.OpenOrSenior(new[] { new[] { 54, 9 }, new[] { 55, 9 } }).ToList(), 
                "age for 'Senior' should be > 54");
            CollectionAssert.AreEqual(new[] { "Open", "Senior" }, 
                MembersService.OpenOrSenior(new[] { new[] { 55, 7 }, new[] { 55, 9 } }).ToList(), 
                "handicap for 'Senior' should be > 7");
        }

        [TestMethod]
        public void SomeRandomTest()
        {
            var values = new List<Tuple<int[], string>>
            {
                new Tuple<int[], string>(new[] {1, 1}, "Open"),
                new Tuple<int[], string>(new[] {54, 9}, "Open"),
                new Tuple<int[], string>(new[] {90, 7}, "Open"),
                new Tuple<int[], string>(new[] {21, 21}, "Open"),
                new Tuple<int[], string>(new[] {0, 0}, "Open"),
                new Tuple<int[], string>(new[] {55, 10}, "Senior"),
                new Tuple<int[], string>(new[] {90, 8}, "Senior"),
                new Tuple<int[], string>(new[] {90, 9}, "Senior"),
                new Tuple<int[], string>(new[] {60, 12}, "Senior"),
                new Tuple<int[], string>(new[] {75, 11}, "Senior"),
            };

            Random r = new Random();
            for (int t = 0; t < 5; t++)
            {
                var input = new List<int[]>();
                var output = new List<string>();
                for (int k = 0; k < 10; k++)
                {
                    var index = r.Next(0, 9);
                    input.Add(values[index].Item1);
                    output.Add(values[index].Item2);
                }
                CollectionAssert.AreEqual(MembersService.OpenOrSenior(input.ToArray()).ToList(), output.ToArray());
            }
        }
    }
}

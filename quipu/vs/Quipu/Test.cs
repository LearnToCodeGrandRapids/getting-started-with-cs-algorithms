using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Quipu
{
    [TestClass]
    public class Test
    {
        public int ReadKnots(string knots)
        {
            int number = 0;

            // code goes here

            return number;
        }

        [TestMethod]
        public void Test_1()
        {
            const string knots = "-XX-XXXX-XXX-";
            const int expected = 243;
            var actual = ReadKnots(knots);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_2()
        {
            const string knots = "-XX--XXXX---XXX-";
            const int expected = 204003;
            var actual = ReadKnots(knots);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_3()
        {
            const string knots = "-X-";
            const int expected = 1;
            var actual = ReadKnots(knots);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_4()
        {
            const string knots = "-X-------";
            const int expected = 1000000;
            var actual = ReadKnots(knots);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_5()
        {
            const string knots = "-XXXXXXXXX--XXXXXXXXX-XXXXXXXXX-XXXXXXX-XXXXXXXXX-";
            const int expected = 909979;
            var actual = ReadKnots(knots);
            Assert.AreEqual(expected, actual);
        }
    }
}

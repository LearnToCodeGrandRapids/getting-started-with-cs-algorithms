using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cut
{
    [TestClass]
    public class Test
    {
        public int GetMaximum(int[] eelLengths, int maxCuts)
        {
            var eelCount = 0;
            
            // put your code here

            return eelCount;
        }

        [TestMethod]
        public void Test_1()
        {
            var eelLengths = new int[] {13, 20, 13};
            const int maxCuts = 2;
            const int expected = 3;
            var actual = GetMaximum(eelLengths, maxCuts);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_2()
        {
            var eelLengths = new int[] { 5, 5, 5, 5 };
            const int maxCuts = 2;
            const int expected = 0;
            var actual = GetMaximum(eelLengths, maxCuts);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_3()
        {
            var eelLengths = new int[] { 34, 10, 48 };
            const int maxCuts = 4;
            const int expected = 5;
            var actual = GetMaximum(eelLengths, maxCuts);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_4()
        {
            var eelLengths = new int[] { 30, 50, 30, 50 };
            const int maxCuts = 350;
            const int expected = 16;
            var actual = GetMaximum(eelLengths, maxCuts);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_5()
        {
            var eelLengths = new int[] { 20, 20, 21 };
            const int maxCuts = 3;
            const int expected = 5;
            var actual = GetMaximum(eelLengths, maxCuts);
            Assert.AreEqual(expected, actual);
        }
    }
}

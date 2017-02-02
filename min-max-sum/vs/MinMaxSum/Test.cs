using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MinMaxSum
{
    [TestClass]
    public class Test
    {
        public uint[] GetMinMaxSum(uint[] inputs)
        {
            var min = uint.MaxValue;
            var max = uint.MinValue;

            // put your logic here

            return new uint[] { min, max };
        }

        [TestMethod]
        public void Test_1()
        {
            var inputs = new uint[] {1, 2, 3, 4, 5};
            var expected = new uint[] {10, 14};
            var actual = GetMinMaxSum(inputs);
            Assert.AreEqual(expected[0], actual[0]);
            Assert.AreEqual(expected[1], actual[1]);
        }

        [TestMethod]
        public void Test_2()
        {
            var inputs = new uint[] { 258498527, 820282508, 950269751, 289884744, 454266370 };
            var expected = new uint[] { 1822932149, 2514703373 };
            var actual = GetMinMaxSum(inputs);
            Assert.AreEqual(expected[0], actual[0]);
            Assert.AreEqual(expected[1], actual[1]);
        }

        [TestMethod]
        public void Test_3()
        {
            var inputs = new uint[] { 162073876, 341211992, 670687, 353731, 73 };
            var expected = new uint[] { 163098367, 504310286 };
            var actual = GetMinMaxSum(inputs);
            Assert.AreEqual(expected[0], actual[0]);
            Assert.AreEqual(expected[1], actual[1]);
        }
    }
}

using System;
using Xunit;

namespace MinMaxSum
{
    public class Test
    {
        public uint[] GetMinMaxSum(uint[] inputs)
        {
            var min = uint.MaxValue;
            var max = uint.MinValue;

            // put your logic here

            return new uint[] { min, max };
        }

        [Theory]
        [InlineData(new uint[] { 1, 2, 3, 4, 5 }, new uint[] { 10, 14 })]
        [InlineData(new uint[] { 258498527, 820282508, 950269751, 289884744, 454266370 }, new uint[] { 1822932149, 2514703373 })]
        [InlineData(new uint[] { 162073876, 341211992, 670687, 353731, 73 }, new uint[] { 163098367, 504310286 })]
        public void Test_GetMinMaxSum(uint[] inputs, uint[] expected)
        {
            var actual = GetMinMaxSum(inputs);

            Assert.Equal(expected[0], actual[0]);
            Assert.Equal(expected[1], actual[1]);
        }
    }
}

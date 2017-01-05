using System;
using Xunit;

namespace Cut
{
    public class Test
    {
        public int GetMaximum(int[] eelLengths, int maxCuts)
        {
            var eelCount = 0;

            // put your logic here

            return eelCount;
        }

        [Theory]
        [InlineData(new int[] { 13, 20, 13 }, 2, 3)]
        [InlineData(new int[] { 5, 5, 5, 5 }, 2, 0)]
        [InlineData(new int[] { 34, 10, 48 }, 4, 5)]
        [InlineData(new int[] { 30, 50, 30, 50 }, 350, 16)]
        public void Test_GetMaximum(int[] eelLengths, int maxCuts, int expected)
        {
            var actual = GetMaximum(eelLengths, maxCuts);

            Assert.Equal(expected, actual);
        }
    }
}

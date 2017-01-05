using System;
using Xunit;

namespace Quipu
{
    public class Test
    {
        public int ReadKnots(string knots)
        {
            int number = 0;

            // code goes here

            return number;
        }

        [Theory]
        [InlineData("-XX-XXXX-XXX-", 243)]
        [InlineData("-XX--XXXX---XXX-", 204003)]
        [InlineData("-X-", 1)]
        [InlineData("-X-------", 1000000)]
        [InlineData("-XXXXXXXXX--XXXXXXXXX-XXXXXXXXX-XXXXXXX-XXXXXXXXX-", 909979)]
        public void Test_ReadKnots(string knots, int expected)
        {
            var actual = ReadKnots(knots);

            Assert.Equal(expected, actual);
        }
    }
}

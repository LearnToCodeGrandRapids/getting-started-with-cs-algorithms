using NUnit.Framework;
using System;
namespace Quipu
{
	[TestFixture()]
	public class Test
	{
		[TestCase("-XX-XXXX-XXX-", Result = 243)]
		[TestCase("-XX--XXXX---XXX-", Result = 204003)]
		[TestCase("-X-", Result = 1)]
		[TestCase("-X-------", Result = 1000000)]
		[TestCase("-XXXXXXXXX--XXXXXXXXX-XXXXXXXXX-XXXXXXX-XXXXXXXXX-", Result = 909979)]
		public int ReadKnots(string knots)
		{
			int number = 0;

			// code goes here

			return number;
		}
	}
}

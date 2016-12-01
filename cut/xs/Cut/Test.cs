using NUnit.Framework;
using System;
namespace Cut
{
	[TestFixture()]
	public class Test
	{
		[TestCase(new int[] { 13, 20, 13 }, 2, Result = 3)]
		[TestCase(new int[] { 5, 5, 5, 5 }, 2, Result = 0)]
		[TestCase(new int[] { 34, 10, 48 }, 4, Result = 5)]
		[TestCase(new int[] { 30, 50, 30, 50 }, 350, Result = 16)]
		public int GetMaximum(int[] eelLengths, int maxCuts)
		{
			var eelCount = 0;

			// put your logic here

			return eelCount;
		}
	}
}

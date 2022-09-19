using NUnit.Framework;
using UnityEngine;

namespace Tests
{
    public class CombinedFilterTest
    {
        [Test]
        public void CombinedFilterSimple()
        {
            int[] input = { 2, 8, 11, 14, 17 };
            int[] output = CombinedFilter.combinedFilter(input);
            int[] expected = { 0, 0, 1, 0, 1};

            CollectionAssert.AreEqual(expected, output);
        }
    }
}
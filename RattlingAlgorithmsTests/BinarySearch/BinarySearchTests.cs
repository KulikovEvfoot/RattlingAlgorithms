using System.Collections.Generic;
using NUnit.Framework;
using RattlingAlgorithms.BinarySearch;

namespace RattlingAlgorithmsTests.BinarySearch
{
    [TestFixture]
    public class BinarySearchTests
    {
        [Test]
        public void BinarySearchTestInt()
        {
            var newList = new List<int>() { 1, 3, 5, 6, 12, 77 };
            var info = newList.CustomBinarySearch(3);
            Assert.AreEqual(info.SearchableItemId, 1);
        }
        
        [Test]
        public void BinarySearchTestDouble()
        {
            var newList = new [] { 55.04f, 97, 105, 111.4f, 200, 488, 10000.55, 11111 };
            var info = newList.CustomBinarySearch(11111);
            Assert.AreEqual(info.SearchableItemId, 7);
            Assert.AreEqual(info.NumberOfIterationsToSearch, 3);
        }
    }
}
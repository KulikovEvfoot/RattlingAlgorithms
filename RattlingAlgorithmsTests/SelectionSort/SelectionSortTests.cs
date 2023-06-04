using System.Collections.Generic;
using NUnit.Framework;
using RattlingAlgorithms.SelectionSort;

namespace RattlingAlgorithmsTests.SelectionSort
{
    [TestFixture]
    public class SelectionSortTests
    {
        [Test]
        public void SelectionSortTestInt()
        {
            var list = new [] { 11, 3, 45, 456, 11112, 77 };
            list.CustomSelectionSort();
            Assert.AreEqual(list[0], 3);
            Assert.AreEqual(list[1], 11);
            Assert.AreEqual(list[2], 45);
            Assert.AreEqual(list[3], 77);
            Assert.AreEqual(list[4], 456);
            Assert.AreEqual(list[5], 11112);
        }
        
        [Test]
        public void SelectionSortTestDouble()
        {
            var list = new [] { 11.4, 3, 45.088f, 456, 123123131231, 77.44 };
            list.CustomSelectionSort();
            Assert.AreEqual(list[0], 3);
            Assert.AreEqual(list[1], 11.4);
            Assert.AreEqual(list[2], 45.088f);
            Assert.AreEqual(list[3], 77.44);
            Assert.AreEqual(list[4], 456);
            Assert.AreEqual(list[5], 123123131231);
        }
    }
}
using NUnit.Framework;
using RattlingAlgorithms.QuickSort;

namespace RattlingAlgorithmsTests.QuickSort
{
    [TestFixture]
    public class QuickSortTest
    {
        [Test]
        public void QuickSortTestInt()
        {
            var list = new [] { 11, 3, 45, 456, 11112, 77 };
            list.CustomQuickSort(0, list.Length - 1);
            Assert.AreEqual(list[0], 3);
            Assert.AreEqual(list[1], 11);
            Assert.AreEqual(list[2], 45);
            Assert.AreEqual(list[3], 77);
            Assert.AreEqual(list[4], 456);
            Assert.AreEqual(list[5], 11112);
        }
        
        [Test]
        public void QuickSortTestDouble()
        {
            var list = new [] { 11.4, 3, 45.088f, 456, 123123131231, 77.44 };
            list.CustomQuickSort(0, list.Length - 1);
            Assert.AreEqual(list[0], 3);
            Assert.AreEqual(list[1], 11.4);
            Assert.AreEqual(list[2], 45.088f);
            Assert.AreEqual(list[3], 77.44);
            Assert.AreEqual(list[4], 456);
            Assert.AreEqual(list[5], 123123131231);
        }
    }
}
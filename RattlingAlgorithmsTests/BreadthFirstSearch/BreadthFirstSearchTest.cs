using System.Collections.Generic;
using NUnit.Framework;
using RattlingAlgorithms.BreadthFirstSearch;

namespace RattlingAlgorithmsTests.BreadthFirstSearch
{
    [TestFixture]
    public class BreadthFirstSearchTest
    {
        [Test]
        public void BreadthFirstSearchTest1()
        {
            var element10 = new SearchItem(true, new List<ISearchItem>());
            var element9 = new SearchItem(false, new List<ISearchItem>{element10});
            var element8 = new SearchItem(false, new List<ISearchItem>{element9});
            var element7 = new SearchItem(true, new List<ISearchItem>{element9});
            var element6 = new SearchItem(false, new List<ISearchItem>{element7, element8});
            var element5 = new SearchItem(false, new List<ISearchItem>{element6, element7});
            var element4 = new SearchItem(false, new List<ISearchItem>{element5});
            var element3 = new SearchItem(false, new List<ISearchItem>{element4, element5, element6});
            var element2 = new SearchItem(false, new List<ISearchItem>{element3, element4});
            var element1 = new SearchItem(false, new List<ISearchItem>{element2, element3});

            var info = element1.CustomBreadthFirstSearch();
            Assert.AreEqual(info.IsItemFound, true);
            Assert.AreEqual(info.Item, element7);
        }
        
        [Test]
        public void BreadthFirstSearchTest2()
        {
            var element10 = new SearchItem(true, new List<ISearchItem>());
            var element9 = new SearchItem(false, new List<ISearchItem>{element10});
            var element8 = new SearchItem(false, new List<ISearchItem>{element9});
            var element7 = new SearchItem(false, new List<ISearchItem>{element9});
            var element6 = new SearchItem(false, new List<ISearchItem>{element7, element8});
            var element5 = new SearchItem(false, new List<ISearchItem>{element6, element7, element9});
            var element4 = new SearchItem(false, new List<ISearchItem>{element5});
            var element3 = new SearchItem(false, new List<ISearchItem>{element4, element5, element6});
            var element2 = new SearchItem(false, new List<ISearchItem>{element3, element4});
            var element1 = new SearchItem(false, new List<ISearchItem>{element2, element3});

            var info = element1.CustomBreadthFirstSearch();
            Assert.AreEqual(info.IsItemFound, true);
            Assert.AreEqual(info.Item, element10);
        }
        
        [Test]
        public void BreadthFirstSearchTest3()
        {
            var element10 = new SearchItem(false, new List<ISearchItem>());
            var element9 = new SearchItem(false, new List<ISearchItem>{element10});
            var element8 = new SearchItem(false, new List<ISearchItem>{element9});
            var element7 = new SearchItem(false, new List<ISearchItem>{element9});
            var element6 = new SearchItem(false, new List<ISearchItem>{element7, element8});
            var element5 = new SearchItem(false, new List<ISearchItem>{element6, element7, element9});
            var element4 = new SearchItem(false, new List<ISearchItem>{element5});
            var element3 = new SearchItem(false, new List<ISearchItem>{element4, element5, element6});
            var element2 = new SearchItem(false, new List<ISearchItem>{element3, element4});
            var element1 = new SearchItem(false, new List<ISearchItem>{element2, element3});

            var info = element1.CustomBreadthFirstSearch();
            Assert.AreEqual(info.IsItemFound, false);
            Assert.AreEqual(info.Item, null);
        }
    }
}
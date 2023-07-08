using System;
using System.Collections.Generic;
using NUnit.Framework;
using RattlingAlgorithms.DynamicProgramming;

namespace RattlingAlgorithmsTests.DynamicProgramming
{
    [TestFixture]
    public class BackpackChallengeTest
    {
        [Test]
        public void BackpackChallengeTest1()
        {
            var item1 = new BackpackItem<int, int>("Guitar", 1500, 1);
            var item2 = new BackpackItem<int, int>("Tape recorder", 3000, 4);
            var item3 = new BackpackItem<int, int>("Laptop", 2000, 3);
            var item4 = new BackpackItem<int, int>("Iphone", 2000, 1);
            IList<IBackpackItem<int, int>> items = new IBackpackItem<int, int>[] { item1, item2, item3, item4 };
            var backpackChallenge = new BackpackChallenge();
            var priorityItemsInfos = backpackChallenge.CalculateListOfPriorityObjects(items);
            Assert.AreEqual(priorityItemsInfos[2,2].ItemNames, new List<string>{item1.Name, item3.Name});
            Assert.AreEqual(priorityItemsInfos[2,2].TotalValue, 3500);
            Assert.AreEqual(priorityItemsInfos[3,2].ItemNames, new List<string>{item3.Name, item4.Name});
            Assert.AreEqual(priorityItemsInfos[3,2].TotalValue, 4000);
        }
        
        [Test]
        public void BackpackChallengeTest2()
        {
            var item1 = new BackpackItem<int, int>("Beach", 7, 1);
            var item2 = new BackpackItem<int, int>("Theater", 6, 1);
            var item3 = new BackpackItem<int, int>("Gallery", 9, 2);
            var item4 = new BackpackItem<int, int>("Museum", 9, 4);
            var item5 = new BackpackItem<int, int>("Cathedral", 8, 1);
            IList<IBackpackItem<int, int>> items = new IBackpackItem<int, int>[] { item1, item2, item3, item4, item5 };
            var backpackChallenge = new BackpackChallenge();
            var priorityItemsInfos = backpackChallenge.CalculateListOfPriorityObjects(items);
            Assert.AreEqual(priorityItemsInfos[4,2].ItemNames, new List<string>{item1.Name, item3.Name, item5.Name});
            Assert.AreEqual(priorityItemsInfos[4,2].TotalValue, 24);
        }
    }
}
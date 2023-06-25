using System.Collections.Generic;
using NUnit.Framework;
using RattlingAlgorithms.DijkstrasAlgorithm;

namespace RattlingAlgorithmsTests.DijkstrasAlgorithm
{
    [TestFixture]
    public class DijkstrasAlgorithmTest
    {
        [Test]
        public void DijkstrasAlgorithmTest1()
        {
            var aNeighbors = new Dictionary<string, uint>
            {
                {"B", 5},
                {"C", 2},
            };
            
            var bNeighbors = new Dictionary<string, uint>
            {
                {"D", 4},
                {"E", 2},
            };
            
            var cNeighbors = new Dictionary<string, uint>
            {
                {"B", 8},
                {"E", 7},
            };
            
            var dNeighbors = new Dictionary<string, uint>
            {
                {"E", 6},
                {"F", 3},
            };
            
            var eNeighbors = new Dictionary<string, uint>
            {
                {"F", 1},
            };
            
            var fNeighbors = new Dictionary<string, uint>();
            
            var mainMap = new Dictionary<string, Dictionary<string, uint>>
            {
                {"A", aNeighbors},
                {"B", bNeighbors},
                {"C", cNeighbors},
                {"D", dNeighbors},
                {"E", eNeighbors},
                {"F", fNeighbors},
            };

            var dijkstrasAlgorithmInfo = mainMap.CustomDijkstrasAlgorithm();
            Assert.AreEqual(dijkstrasAlgorithmInfo.ShortestPath, "ABEF");
            Assert.AreEqual(dijkstrasAlgorithmInfo.ShortestLength, 8);
        }
        
        [Test]
        public void DijkstrasAlgorithmTest2()
        {
            var aNeighbors = new Dictionary<string, uint>
            {
                {"B", 10},
            };
            
            var bNeighbors = new Dictionary<string, uint>
            {
                {"C", 20},
            };
            
            var cNeighbors = new Dictionary<string, uint>
            {
                {"D", 1},
                {"E", 30},
            };
            
            var dNeighbors = new Dictionary<string, uint>
            {
                {"B", 1},
            };
            
            var eNeighbors = new Dictionary<string, uint>();
            
            var mainMap = new Dictionary<string, Dictionary<string, uint>>
            {
                {"A", aNeighbors},
                {"B", bNeighbors},
                {"C", cNeighbors},
                {"D", dNeighbors},
                {"E", eNeighbors},
            };

            var dijkstrasAlgorithmInfo = mainMap.CustomDijkstrasAlgorithm();
            Assert.AreEqual(dijkstrasAlgorithmInfo.ShortestPath, "ABCE");
            Assert.AreEqual(dijkstrasAlgorithmInfo.ShortestLength, 60);
        }
    }
}
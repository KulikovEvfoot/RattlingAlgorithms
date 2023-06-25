using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RattlingAlgorithms.DijkstrasAlgorithm
{
    public static class DijkstrasAlgorithm
    {
        public static DijkstrasAlgorithmInfo CustomDijkstrasAlgorithm(this IDictionary<string, Dictionary<string, uint>> graph)
        {
            var firstPair = graph.First();
            var parents = new Dictionary<string, string>();
            var costs = new Dictionary<string, uint>();
            foreach (var firstNeighbor in firstPair.Value)
            {
                parents.Add(firstNeighbor.Key, firstPair.Key);
                costs.Add(firstNeighbor.Key, firstNeighbor.Value);
            }

            foreach (var mainMapKey in graph.Keys)
            {
                if (mainMapKey == firstPair.Key)
                {
                    continue;
                }
                
                if (parents.ContainsKey(mainMapKey))
                {
                    continue;
                }
                
                parents.Add(mainMapKey, null);
                costs.Add(mainMapKey, uint.MaxValue);
            }
            
            var processed = new HashSet<string>();
            for (int i = 0; i < graph.Count - 1; i++)
            {
                var node = FindLowestCostNode(costs, processed);
                var cost = costs[node];
                var neighbors = graph[node];
                foreach (var neighbor in neighbors)
                {
                    var newCost = cost + neighbor.Value;
                    var oldCost = costs[neighbor.Key];
                    if (oldCost > newCost)
                    {
                        costs[neighbor.Key] = newCost;
                        parents[neighbor.Key] = node;
                    }
                }

                processed.Add(node);
            }

            var dijkstrasAlgorithmInfo = new DijkstrasAlgorithmInfo();
            var shortestPathBuilder = new StringBuilder();
            var lastPair = parents.Last();
            shortestPathBuilder.Append(lastPair.Key);
            var lastParent = lastPair.Value;
            while (true)
            {
                shortestPathBuilder.Append(lastParent);
                if (lastParent == firstPair.Key)
                {
                    break;
                }
                
                lastParent = parents[lastParent];
            }
            
            var shortestPath = shortestPathBuilder.ToString().Reverse();
            var shortestLenght = costs[lastPair.Key];
            dijkstrasAlgorithmInfo.ShortestPath = shortestPath;
            dijkstrasAlgorithmInfo.ShortestLength = shortestLenght;
            
            return dijkstrasAlgorithmInfo;
        }

        private static string FindLowestCostNode(Dictionary<string, uint> costs, HashSet<string> processed)
        {
            var lowesCost = uint.MaxValue;
            var lowestCostNode = string.Empty;
            foreach (var node in costs)
            {
                var cost = node.Value;
                if (cost < lowesCost && !processed.Contains(node.Key))
                {
                    lowesCost = cost;
                    lowestCostNode = node.Key;
                }
            }

            return lowestCostNode;
        }
        
        private static string Reverse(this string str)
        {
            var charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
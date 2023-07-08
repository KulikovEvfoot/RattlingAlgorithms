using System.Collections.Generic;
using System.Linq;
using RattlingAlgorithms.BinarySearch;

namespace RattlingAlgorithms.DynamicProgramming
{
    public class BackpackChallenge
    {
        public PriorityItemsInfo[,] CalculateListOfPriorityObjects(IList<IBackpackItem<int, int>> backpackItems)
        {
            //todo understand how to determine the accuracy of
            var weightsSet = new HashSet<int>();
            foreach (var item in backpackItems)
            {
                weightsSet.Add(item.Weight);
            }

            var weights = weightsSet.OrderBy(x => x).ToList();
            
            var rowCount = backpackItems.Count;
            var columnCount = weightsSet.Count;
            var table = new PriorityItemsInfo[rowCount , columnCount];
            
            var firstItem = backpackItems[0];
            var firstRow = new PriorityItemsInfo(new List<string>{firstItem.Name}, firstItem.Value, firstItem.Weight);
            for (int i = 0; i < columnCount; i++)
            {
                table[0, i] = firstRow;
            }

            for (int i = 1; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    var columnWeight = weights[j];
                    var previousLineValue = table[i - 1, j];
                    var backpackItem = backpackItems[i];
                    if (backpackItem.Weight > columnWeight)
                    {
                        table[i, j] = previousLineValue;
                        continue;
                    }

                    if (backpackItem.Weight == columnWeight)
                    {
                        
                        if (previousLineValue.TotalValue > backpackItem.Value)
                        {
                            table[i, j] = previousLineValue;
                            continue;
                        }
                        
                        table[i, j] = new PriorityItemsInfo(new List<string>{backpackItem.Name}, backpackItem.Value, backpackItem.Weight);
                        continue;
                    }

                    var remainingWeight = columnWeight - backpackItem.Weight;
                    var binarySearchInfo = weights.CustomBinarySearch(remainingWeight);
                    var maxAdditionalWeightIndex = binarySearchInfo.SearchableItemId;
                    var maxAdditionalInfo = table[i - 1, maxAdditionalWeightIndex];
                    var totalNames = new List<string>(maxAdditionalInfo.ItemNames){backpackItem.Name};
                    var newTotalValue = maxAdditionalInfo.TotalValue + backpackItem.Value;
                    var newTotalWeight = maxAdditionalInfo.TotalWeight + backpackItem.Weight;
                    var priorityItemsInfo = new PriorityItemsInfo(totalNames, newTotalValue, newTotalWeight);
                    table[i, j] = priorityItemsInfo;
                }
            }
            
            return table;
        }
    }
}
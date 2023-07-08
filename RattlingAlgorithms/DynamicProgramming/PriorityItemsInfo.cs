using System.Collections.Generic;

namespace RattlingAlgorithms.DynamicProgramming
{
    public class PriorityItemsInfo
    {
        public List<string> ItemNames;
        public int TotalValue;
        public int TotalWeight;

        public PriorityItemsInfo(List<string> itemNames, int totalValue, int totalWeight)
        {
            ItemNames = itemNames;
            TotalValue = totalValue;
            TotalWeight = totalWeight;
        }
    }
}
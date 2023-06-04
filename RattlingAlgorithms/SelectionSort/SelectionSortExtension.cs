using System;
using System.Collections.Generic;

namespace RattlingAlgorithms.SelectionSort
{
    public static class SelectionSortExtension
    { 
        public static void CustomSelectionSort<T>(this IList<T> list) where T : IComparable<T>
        {
            var listSize = list.Count;
            for (int i = 0; i < listSize - 1; i++)
            {
                var smallestIndex = i;
                for (int j = i + 1; j < listSize; j++)
                {
                    var compare = list[j].CompareTo(list[smallestIndex]);
                    if (compare == -1)
                    {
                        smallestIndex = j;
                    }
                }

                (list[smallestIndex], list[i]) = (list[i], list[smallestIndex]);
            }
        }
    }
}
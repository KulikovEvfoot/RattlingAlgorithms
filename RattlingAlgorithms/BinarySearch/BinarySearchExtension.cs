using System;
using System.Collections.Generic;

namespace RattlingAlgorithms.BinarySearch
{
    public static class BinarySearchExtension
    {
        public static BinarySearchInfo<T> CustomBinarySearch<T>(this IList<T> list, T wantedElement) where T : IComparable<T> 
        {
            var binarySearchInfo = new BinarySearchInfo<T>();
            binarySearchInfo.SearchableItem = wantedElement;
            var low = 0;
            var high = list.Count - 1;
            var iterationCount = 0;

            while (low <= high)
            {
                int mid = (low + high) / 2;
                var guess = list[mid];

                var compare = guess.CompareTo(wantedElement);
                
                if (compare == 0)
                {
                    binarySearchInfo.SearchableItemId = mid;
                    binarySearchInfo.HasSearchableItemInList = true;
                    binarySearchInfo.NumberOfIterationsToSearch = iterationCount;
                    return binarySearchInfo;
                }
                
                if (compare == 1)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
                
                iterationCount++;
            }

            binarySearchInfo.HasSearchableItemInList = false;
            return binarySearchInfo;
        }
    }
}

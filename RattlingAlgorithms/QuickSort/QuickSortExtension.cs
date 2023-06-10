using System;
using System.Collections.Generic;

namespace RattlingAlgorithms.QuickSort
{
    public static class QuickSortExtension
    {
        public static void CustomQuickSort<T>(this IList<T> list, int minIndex, int maxIndex) where T : IComparable<T>
        {
            if (minIndex >= maxIndex)
            {
                return;
            }

            var pivotIndex = GetPivotIndex(list, minIndex, maxIndex);

            list.CustomQuickSort(minIndex, pivotIndex - 1);
            list.CustomQuickSort(pivotIndex + 1, maxIndex);
        }

        private static int GetPivotIndex<T>(this IList<T> list, int minIndex, int maxIndex) where T : IComparable<T>
        {
            var pivot = minIndex - 1;
            for (int i = minIndex; i <= maxIndex; i++)
            {
                var compare = list[i].CompareTo(list[maxIndex]);
                if (compare == -1)
                {
                    pivot++;
                    (list[pivot], list[i]) = (list[i], list[pivot]);
                }
            }

            pivot++;
            (list[pivot], list[maxIndex]) = (list[maxIndex], list[pivot]);
            
            return pivot;
        }
    }
}
using System.Collections.Generic;

namespace RattlingAlgorithms.BreadthFirstSearch
{
    public static class BreadthFirstSearch
    {
        public static BreadthFirstSearchInfo CustomBreadthFirstSearch(this ISearchItem searchItem)
        {
            var breadthFirstSearchInfo = new BreadthFirstSearchInfo();
            var searchQueue = new Queue<ISearchItem>();
            searchQueue.Enqueue(searchItem);
            var searched = new List<ISearchItem>();
            while (searchQueue.Count > 0)
            {
                var item = searchQueue.Dequeue();
                if (searched.Contains(item))
                {
                    continue;
                }
                
                if (item.IsSearchable)
                {
                    breadthFirstSearchInfo.IsItemFound = true;
                    breadthFirstSearchInfo.Item = item;
                    return breadthFirstSearchInfo;
                }
                
                searched.Add(item);
                
                foreach (var searchable in item.Searchables)
                {
                    searchQueue.Enqueue(searchable);
                }
            }

            return breadthFirstSearchInfo;
        }
    }
}
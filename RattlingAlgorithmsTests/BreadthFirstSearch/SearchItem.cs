using System.Collections.Generic;
using RattlingAlgorithms.BreadthFirstSearch;

namespace RattlingAlgorithmsTests.BreadthFirstSearch
{
    public class SearchItem : ISearchItem
    {
        public bool IsSearchable { get; }
        public IList<ISearchItem> Searchables { get; }
        
        public SearchItem(bool isSearchable, IList<ISearchItem> searchables)
        {
            IsSearchable = isSearchable;
            Searchables = searchables;
        }
    }
}
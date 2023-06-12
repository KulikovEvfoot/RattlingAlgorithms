using System.Collections.Generic;

namespace RattlingAlgorithms.BreadthFirstSearch
{
    public interface ISearchItem
    {
        bool IsSearchable { get; }
        IList<ISearchItem> Searchables { get; }
    }
}
using System;

namespace RattlingAlgorithms.DynamicProgramming
{
    public interface IBackpackItem<TValue, TWeight>
        where TValue : IComparable<TValue> 
        where TWeight : IComparable<TWeight>
    {
        string Name { get; }
        TValue Value { get; }
        TWeight Weight { get; }
    }
}
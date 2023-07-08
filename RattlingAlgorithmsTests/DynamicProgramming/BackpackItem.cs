using System;
using RattlingAlgorithms.DynamicProgramming;

namespace RattlingAlgorithmsTests.DynamicProgramming
{
    public class BackpackItem<TValue, TWeight> : IBackpackItem<TValue, TWeight> 
        where TValue : IComparable<TValue> 
        where TWeight : IComparable<TWeight>
    {
        public string Name { get; }
        public TValue Value { get; }
        public TWeight Weight { get; }

        public BackpackItem(string name, TValue value, TWeight weight)
        {
            Name = name;
            Value = value;
            Weight = weight;
        }
    }
}
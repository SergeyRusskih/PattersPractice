using System;

namespace Patterns.GeneratingPatterns.AbstractFactory
{
    public interface IFactory
    {
        IComparable CreateComparable();
        ICloneable CreateCloneable();
    }
}

using System;

namespace Patterns.GeneratingPatterns.AbstractFactory.ConcreteFactories
{
    /// <summary>
    /// Конкретная фабрика
    /// </summary>
    public class WindowsFactory : Factory
    {
        public override IComparable CreateComparable()
        {
            throw new NotImplementedException();
        }

        public override ICloneable CreateCloneable()
        {
            throw new NotImplementedException();
        }
    }
}

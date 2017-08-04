using System;

namespace Patterns.GeneratingPatterns.Builder.ConcreteBuilders
{
    public class Builder2 : IBuilder
    {
        public void BuildPartA()
        {
            throw new NotImplementedException();
        }

        public void BuildPartB()
        {
            throw new NotImplementedException();
        }

        public void BuildPartC()
        {
            throw new NotImplementedException();
        }

        public T GetResult<T>()
        {
            throw new NotImplementedException();
        }
    }
}

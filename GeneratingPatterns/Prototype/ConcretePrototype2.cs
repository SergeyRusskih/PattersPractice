namespace Patterns.GeneratingPatterns.Prototype
{
    public class ConcretePrototype2 : Prototype
    {
        public override string State => "Concrete state 2";

        public override Prototype Clone()
        {
            return new ConcretePrototype2();
        }
    }
}

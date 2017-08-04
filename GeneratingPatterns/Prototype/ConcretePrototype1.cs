namespace Patterns.GeneratingPatterns.Prototype
{
    public class ConcretePrototype1 : Prototype
    {
        public override string State => "Concrete state 1";

        public override Prototype Clone()
        {
            return new ConcretePrototype1();
        }
    }
}

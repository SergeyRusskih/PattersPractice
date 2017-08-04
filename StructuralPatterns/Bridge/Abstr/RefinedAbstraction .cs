namespace Patterns.StructuralPatterns.Bridge.Abstr
{
    public class RefinedAbstraction : Abstraction
    {
        public override void Operation()
        {
            Implementor.Operation();
        }
    }
}

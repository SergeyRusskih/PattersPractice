using Patterns.BehaviouralPatterns.Command;
using Patterns.BehaviouralPatterns.Interpreter;
using Patterns.GeneratingPatterns.AbstractFactory;
using Patterns.GeneratingPatterns.AbstractFactory.ConcreteFactories;
using Patterns.GeneratingPatterns.Builder;
using Patterns.GeneratingPatterns.Builder.ConcreteBuilders;
using Patterns.GeneratingPatterns.FactoryMethod;
using Patterns.GeneratingPatterns.FactoryMethod.Drawing;
using Patterns.GeneratingPatterns.Prototype;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // Abstract factory
            IFactory concreteFactory = new WindowsFactory();
            var obj1 = concreteFactory.CreateCloneable();
            var obj2 = concreteFactory.CreateComparable();

            // Builder 
            IBuilder builder = new Builder1();
            var director = new Director(builder);
            var product = director.Construct<IProduct>();

            // Factory method
            Application app = new DrawingApplication();
            Document document = app.CreateDocument();

            // Prototype
            Prototype prototype = new ConcretePrototype1();
            Prototype newObject = prototype.Clone();

            // Command 
            Receiver receiver = new Receiver();
            Command command = new ConcreteCommand(receiver);
            Invoker invoker = new Invoker();

            invoker.SetCommand(command);
            invoker.ExecuteCommand();

            // Interpreter 
            var context = new Context();

            AbstrcatExpression experssion1 = new NonterminalExpression();
            AbstrcatExpression expression2 = new TerminalExpression();

            experssion1.Interpret(context);
            expression2.Interpret(context);
        }
    }
}

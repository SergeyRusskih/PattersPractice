using Patterns.BehaviouralPatterns.Command;
using Patterns.BehaviouralPatterns.Interpreter;
using Patterns.BehaviouralPatterns.Mediator;
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

            // Mediator
            ConcreteMediator m = new ConcreteMediator();

            ConcreteColleague1 c1 = new ConcreteColleague1(m);
            ConcreteColleague2 c2 = new ConcreteColleague2(m);

            m.Colleague1 = c1;
            m.Colleague2 = c2;

            c1.Send("How are you?");
            c2.Send("Fine, thanks");

            // Memoto
            Originator o = new Originator();
            o.State = "On";

            // Store internal state
            Caretaker c = new Caretaker();
            c.Memento = o.CreateMemento();

            // Continue changing originator
            o.State = "Off";

            // Restore saved state
            o.SetMemento(c.Memento);

            // Observer
            ConcreteSubject s = new ConcreteSubject();

            s.Attach(new ConcreteObserver(s, "X"));
            s.Attach(new ConcreteObserver(s, "Y"));
            s.Attach(new ConcreteObserver(s, "Z"));

            // Change subject and notify observers
            s.SubjectState = "ABC";
            s.Notify();
        }
    }
}

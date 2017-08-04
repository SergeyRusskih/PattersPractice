using System;

namespace Patterns.BehaviouralPatterns.Interpreter
{
    public class NonterminalExpression : AbstrcatExpression
    {
        public override void Interpret(Context context)
        {
            Console.WriteLine("Called Nonterminal.Interpret()");
        }
    }
}

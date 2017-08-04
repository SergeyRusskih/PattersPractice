using System;

namespace Patterns.BehaviouralPatterns.Interpreter
{
    public class TerminalExpression : AbstrcatExpression
    {
        public override void Interpret(Context context)
        {
            Console.WriteLine("Called Terminal.Interpret()");
        }
    }
}

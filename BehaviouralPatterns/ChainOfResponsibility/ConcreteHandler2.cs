using System;

namespace Patterns.BehaviouralPatterns.ChainOfResponsibility
{
    public class ConcreteHandler2 : Handler
    {
        public override void ProcessRequest(int id)
        {
            if (id < 0)
            {
                Console.WriteLine("ConcreteHandler2: id < 0");
            }
            else
            {
                base.ProcessRequest(id);
            }
        }
    }
}

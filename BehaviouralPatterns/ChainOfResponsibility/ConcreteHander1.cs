using System;

namespace Patterns.BehaviouralPatterns.ChainOfResponsibility
{
    public class ConcreteHander1 : Handler
    {
        public override void ProcessRequest(int id)
        {
            if (id > 10)
            {
                Console.WriteLine("ConcreteHander1: id > 10");
                return;
            }

            base.ProcessRequest(id);
        }
    }
}

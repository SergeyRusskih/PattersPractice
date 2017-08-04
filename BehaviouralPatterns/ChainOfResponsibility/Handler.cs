namespace Patterns.BehaviouralPatterns.ChainOfResponsibility
{
    public abstract class Handler
    {
        protected Handler _handler;

        public void SetSetSuccessor(Handler handler)
        {
            _handler = handler;
        }

        public virtual void ProcessRequest(int id)
        {
            _handler.ProcessRequest(id);
        }
    }
}

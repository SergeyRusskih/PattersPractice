namespace Patterns.GeneratingPatterns.FactoryMethod.Drawing
{
    public class DrawingApplication : Application
    {
        public override Document CreateDocument()
        {
            return new DrawingDocument();
        }

        public override Document NewDocument()
        {
            return new DrawingDocument();
        }

        public override Document OpenDocument()
        {
            return new DrawingDocument();
        }
    }
}

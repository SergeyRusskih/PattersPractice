namespace Patterns.GeneratingPatterns.FactoryMethod.Drawing
{
    /// <summary>
    /// Конкретный продукт. Реализует интерфейс <see cref="Document">Document</see>
    /// </summary>
    public class DrawingDocument : Document
    {
        public override void Open()
        {
        }

        public override void Close()
        {
        }

        public override void Save()
        {
        }

        public override void Revert()
        {
        }
    }
}

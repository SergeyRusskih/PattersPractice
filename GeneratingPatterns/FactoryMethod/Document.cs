namespace Patterns.GeneratingPatterns.FactoryMethod
{
    /// <summary>
    /// Определяет интерфейс объектов, создаваемых фабричным методом
    /// </summary>
    public abstract class Document
    {
        public abstract void Open();
        public abstract void Close();
        public abstract void Save();
        public abstract void Revert();
    }
}

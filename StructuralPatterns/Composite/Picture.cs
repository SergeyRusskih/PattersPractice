namespace Patterns.StructuralPatterns.Composite
{
    /// <summary>
    /// Составные объекты (composite - агрегаты) переопределяют операции с потомками (имеют потомков)
    /// </summary>
    public class Picture : Graphic
    {
        public override void Draw()
        {
        }

        public override void Add(Graphic child)
        {
        }

        public override void Remove(Graphic child)
        {
        }

        public override Graphic GetChild(int id)
        {
            return null;
        }
    }
}

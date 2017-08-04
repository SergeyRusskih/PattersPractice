namespace Patterns.StructuralPatterns.Composite
{
    /// <summary>
    /// Простые объекты (leaf) переопределяют только 
    /// обязательные операции (не работают с потомками)
    /// </summary>
    public class Line : Graphic 
    {
        public override void Draw()
        {
        }
    }
}

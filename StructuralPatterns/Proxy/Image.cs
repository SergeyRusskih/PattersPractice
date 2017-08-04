namespace Patterns.StructuralPatterns.Proxy
{
    public class Image : IImage
    {
        public Image(string path)
        {
        }

        public void Draw() { }
        public void Load() { }
        public void Store() { }
    }
}

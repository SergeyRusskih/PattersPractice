namespace Patterns.StructuralPatterns.Proxy
{
    /// <summary>
    /// Proxy (surrogate) - является суррогатом другого объекта и контролирует доступ к нему
    /// 
    /// Реализует интерфейс реального объекта. С помощью паттерна заместитель при доступе к объекту вводится дополнительный уровень косвенности
    /// 
    /// Паттерн заместитель применим во всех случаях, когда возникает необходимость сослаться на объект более изощренно, чем это возможно:
    ///     - lazy-loading
    ///     - права доступа
    ///     - установка блокировки
    /// 
    /// Участники:
    ///     - <see cref="ImageProxy">Proxy</see> - заместитель
    ///         - Хранит ссылку, которая позволяет заместителю обратиться к реальному субъекту.
    ///         - Контролирует доступ к реальному субъекту
    ///     - <see cref="IImage">Subject</see> - определяет общий интерфейс
    ///     - <see cref="Image">RealSubject</see> - определяет реальный объект, представленный заместителем
    /// 
    /// Родственные паттерны:
    ///     - Паттерн адаптер предоставляет другой интерфейс к адаптируемому объекту. Заметитиель - повторяет (или является подмножеством исходного интерфейса)
    ///     - Декоратор. В отличие от него заместитель не добавляет новые обязанности, а контролирует доступ
    /// </summary>
    public class ImageProxy : IImage
    {
        private readonly string _path;
        private Image _image;

        public ImageProxy(string path)
        {
            _path = path;
        }

        public void Draw()
        {
            if (_path.Length == 10) // some condition
                return;

            if (_image == null)
                LoadImage();

            _image.Draw();
        }

        public void Load()
        {
            // do nothing here
        }

        public void Store()
        {
            if (_image == null)
                LoadImage();

            _image.Store();
        }

        private void LoadImage()
        {
            _image = new Image(_path);
        }
    }
}

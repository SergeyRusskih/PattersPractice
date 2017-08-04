﻿namespace Patterns.StructuralPatterns.Adapter
{
    /// <summary>
    /// Преобразует интерфейс одного класса в интерфейс другого, который ожидают клиенты.
    /// Адаптер обеспечивает совместную работу классов с несовместимыми интерфейсами, которая без него была бы невозможна.
    /// 
    /// Другое название - Wrapper
    /// 
    /// Применимость:
    ///     - хотите использовать существующий класс, но его интерфейс не соответствует вашим потребностям
    ///     - собираетесь создать повторно используемый класс, который должен взаимодействовать с заранее 
    ///       неизвестными или не связанными с ним классами, имеющими несовместимые интерфейсы
    ///     - в случае множественного наследования адаптер может объединять несколько классо чтоы создать общий интерфейс
    ///     - чтобы привести объект к представленю (отобразить, но с другим набором полей)
    /// </summary>
    public class MyAdapter : ITargetAdapter
    {
        private readonly OriginalClass _originalClass;

        public MyAdapter(OriginalClass original)
        {
            _originalClass = original;
        }

        public void Open()
        {
            _originalClass.Start();
        }

        public void Close()
        {
            _originalClass.End();
        }
    }
}

using Patterns.GeneratingPatterns.FactoryMethod.Drawing;

namespace Patterns.GeneratingPatterns.FactoryMethod
{
    /// <summary>
    /// Паттерн Factory Method - Делигирование создание объекта подклассам (виртуальный конструктор)
    /// 
    /// Определяет интерфейс для создания объекта, но оставляет подклассам решение о том, какой класс инстанцировать.
    /// 
    /// Используется, когда:
    ///     - классу заранее неизвестно, объекты каких классов ему нужно создавать
    ///     - класс спроектирован так, чтобы объекты, которые он создает, специфицировались подклассами
    ///     - класс делегирует свои обязанности одному из нескольких вспомогательных подклассов, и вы планируете 
    ///       локализовать знание о том, какой класс принимает эти обязанности на себя
    ///     - нужно поддерживать параллельные иерархии классов (как в абстрактной фабрике)
    /// 
    /// Участники:
    ///     - <see cref="Document">Product</see> определяет интерфейс объектов, создаваемых фабричным методом
    ///     - <see cref="Application">Creator</see> объявляет фабричный метод, возвращающий объект типа <see cref="Document">Product</see>
    ///     - <see cref="DrawingApplication">ConcreteCreator</see> замещает фабричный метод, возвращающий объект <see cref="DrawingDocument">ConcreteProduct</see>
    /// 
    /// Абстрактная фабрика часто реализуется с помощью фабричных методов
    /// </summary>
    public abstract class Application
    {
        /// <summary>
        /// Фабричный метод
        /// </summary>
        /// <returns></returns>
        public abstract Document CreateDocument();
        public abstract Document NewDocument();
        public abstract Document OpenDocument();
    }
}

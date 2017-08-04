using Patterns.StructuralPatterns.Bridge.Imp;

namespace Patterns.StructuralPatterns.Bridge.Abstr
{
    /// <summary>
    /// Мост - отделяет <see cref="Abstraction">абстракцию</see> 
    /// от ее <see cref="Implementor">реализации</see> так, чтобы то и другое можно было изменять независимо
    /// 
    /// Другое название - Handle/Body (описатель/тело)
    /// 
    /// Применяется, когда:
    ///     - нужно избежать привязки абстракции к реализации
    ///     - изменения в реализации не должны сказываться на клиентах
    ///     - число классов в иерархии начинает быстро расти - признак того, что иерархию следуюет разделить на две части
    /// 
    /// Имплементация:
    ///     - абстракция и ее реализация помещается в отдельных иерархиях классов
    ///     - все операции подклассов реализованы в терминах абстрактных операций базового класса
    ///     
    /// Участники:
    ///     - <see cref="Abstraction">Абстракция</see> Определяет интерфейс абстракции. Хранит ссылку на имплиментацию
    ///     - <see cref="RefinedAbstraction">Уточненная абстракция</see> Расширяет интерфейс, определенный абстракцией
    ///     - <see cref="Implementor">Реализатор</see> Определяет интерфейс для классов реализации.
    ///     - <see cref="ConcreteImplementorA">Конкретный реализатор</see> Содержит конкретную реализацию интерфейса <see cref="Implementor">Реализатор</see>
    /// </summary>
    public class Abstraction
    {
        private Implementor _implementor;

        // Property
        public Implementor Implementor
        {
            get { return _implementor; }
            set { _implementor = value; }
        }

        public virtual void Operation()
        {
            _implementor.Operation();
        }
    }

}

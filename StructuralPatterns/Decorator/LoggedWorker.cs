﻿namespace Patterns.StructuralPatterns.Decorator
{
    /// <summary>
    /// Декоратор - динамически добавляет объекту новые обязанности.
    /// Другое название - обертка (wrapper).
    /// 
    /// Особенности:
    ///     - является гибкой альтернативой наследованию с целью расширения функциональности
    ///     - следует интерфейсу декорируемого объекта
    ///     - декораторы могут вкладываться друг в друга
    /// 
    /// Применимость:
    ///     - для динамического, прозрачного для клиентов добавления обязанностей объектам
    ///     - для реализации обязанностей, которые могут быть сняты с объекта
    ///     - когда расширение путем наследования приводит к комбинаторному росту числа классов
    /// 
    /// Участники:
    ///     - <see cref="IWorker">Компонент</see> - определяет интерфейс для объекта, на которые могут быть динамически возложены дополнительные обязанности
    ///     - <see cref="Worker">Конкретный компонент</see> - определяет объект, на который возлагаются дополнительные обязанности
    ///     - <see cref="LoggedWorker">Декоратор</see> - возлагает дополнительные обязанности на компонент 
    /// 
    /// Родственные патерны:
    ///     - адаптер в отличие от декоратора изменяет интерфейс
    ///     - компоновщик: декоратор можно считать вырожденным случаем составного объекта, у которого есть только один компонент. Однако декоратор добавляет
    ///       новые обязанности, агрегирование объектов не является его целью.
    ///     - стратегия: декоратор позволяет изменить внешний облик объекта, стратегия - его внутреннее содержание.Это два взаимодополняющих способа изменения объекта.
    /// </summary>
    public class LoggedWorker : IWorker
    {
        private readonly IWorker _worker;

        public LoggedWorker(IWorker worker)
        {
            _worker = worker;
        }

        public void DoSomeWork()
        {
            LogBefore();
            _worker.DoSomeWork();
            LogAfter();
        }

        private void LogBefore()
        {
        }

        private void LogAfter()
        {
        }
    }
}
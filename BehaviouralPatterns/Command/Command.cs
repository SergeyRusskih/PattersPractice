﻿namespace Patterns.BehaviouralPatterns.Command
{
    /// <summary>
    /// Команда - инкапсулирует запрос как объект
    /// 
    /// Конкретные подклассы Command определяют пару «получатель-действие», 
    /// сохраняя получателя в переменной экземпляра, и реализуют операцию Execute, 
    /// так чтобы она посылала запрос.У получателя есть информация, необходимая для выполнения запроса.
    /// 
    /// Подклассы Command хранят информацию о получателе запроса и вызывают одну или несколько операций этого получателя.
    /// 
    /// Паттерн команда отделяет объект, инициирующий операцию, от объекта, который «знает», как 
    /// ее выполнить. Это позволяет добиться высокой гибкости при проектировании пользовательского интерфейса.
    /// 
    /// Особенности:
    ///     - позволяет задавать параметры клиентов для обработки соответствующих запросов
    ///     - ставить запросы в очередь и протоколировать их
    ///     - поддерживает отмену операций
    ///     - поддерживает протоколирование изменений, чтобы их можно было выполнить повторно после аварийной остановки системы
    ///     - разрывает связь между объектом, инициирующим операцию, и объектом, имеющим информацию о том, как ее выполнить
    ///     - из простых команд можно собирать составные
    /// 
    /// Участники:
    ///     - <see cref="Command">Команда</see> 
    ///         - объявляет интерфейс для выполнения операции
    ///     - <see cref="ConcreteCommand">Конкретная команда</see> 
    ///         - определяет связь между объектом-получателем Receiver и действием
    ///         - реализует операцию Execute путем вызова соответствующих операций объекта Receiver
    ///     - <see cref="Program">Клиент</see>
    ///         - создает объект класса ConcreteCommand и устанавливает его получателя
    ///     - <see cref="Invoker">Инициатор</see>
    ///         - обращается к команде для выполнения запроса
    ///     - <see cref="Receiver">Получатель</see>
    ///         - располагает информацией о способах выполнения операций, необходимых для удовлетворения запроса
    /// 
    /// Родственные паттерны:
    ///     - компоновщик можно использовать для реализации макрокоманд
    ///     - хранитель иногда проектируется так, что сохраняет состояние команды, необходимое для отмены ее действия
    ///     - команда, которую нужно копировать перед помещением в список истории, ведет себя, как прототип
    /// </summary>
    public abstract class Command
    {
        protected readonly Receiver Receiver;

        public Command(Receiver receiver)
        {
            Receiver = receiver;
        }

        public abstract void Execute();
    }
}
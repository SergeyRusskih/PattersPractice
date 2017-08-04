namespace Patterns.BehaviouralPatterns.Interpreter
{
    /// <summary>
    /// Интерптитатор - бизнес правила в виде операций, представленных в виде абстрактных синтаксических деревьев
    /// 
    /// Для заданного языка определяет представление его грамматики, а также интерпретатор предложений этого языка
    /// 
    /// Участники:
    ///     - <see cref="AbstrcatExpression">Абстрактное выражение</see>
    ///         - объявляет абстрактную операцию Interpret, общую для всех узлов в абстрактном синтаксическом дереве
    ///     - <see cref="TerminalExpression">Конкретное выражение</see>
    ///         - реализует операцию Interpret
    ///     - 
    /// </summary>
    public abstract class AbstrcatExpression
    {
        public abstract void Interpret(Context context);
    }
}

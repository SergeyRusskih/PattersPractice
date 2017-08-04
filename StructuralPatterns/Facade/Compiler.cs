namespace Patterns.StructuralPatterns.Facade
{
    /// <summary>
    /// Фасад - объединяет интерфейсы
    /// 
    /// Фасад определяет интерфейс более высокого уровня, который упрощает использование подсистемы
    /// 
    /// Используется, когда:
    ///     - нужно предоставить простой интерфейс к сложной подсистеме
    ///     - нужно отделить подсистему как от клиентов, так и от других подсистем для повышения степени независимости и переносимости
    ///     - нужно разложить подсистему на отдельные слои. Фасад как точка входа на каждый уровень подсистемы
    /// 
    /// Участники:
    ///     - <see cref="Compiler">Facade</see> - «знает», каким классам подсистемы адресовать запрос и 
    ///       делегирует запросы клиентов подходящим объектам внутри подсистемы
    ///     - <see cref="Parser">Классы подсистемы</see> - реализуют функциональность подсистемы, выполняют работу, порученную объектом Facade,
    ///       ничего не «знают» о существовании фасада, то есть не хранят ссылок на него
    /// </summary>
    public class Compiler
    {
        private readonly Parser _parser;
        private readonly Scanner _scanner;
        private readonly BytecodeStream _bytecodeStream;

        public Compiler()
        {
            _parser = new Parser();
            _scanner = new Scanner();
            _bytecodeStream = new BytecodeStream();
        }

        public void Parse()
        {
            _parser.Parse();
        }

        public void Scane()
        {
            _scanner.Scanne();
        }

        public void Encode()
        {
            _bytecodeStream.Encode();
        }

        public void Decode()
        {
            _bytecodeStream.Decode();
        }
    }
}

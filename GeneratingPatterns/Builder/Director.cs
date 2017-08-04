﻿namespace Patterns.GeneratingPatterns.Builder
{
    /// Паттерн Builder - Пошаговое конструирование сложного объекта
    /// 
    /// Применимость когда:
    ///     - алгоритм создания сложного объекта не должен зависеть от того, 
    ///       из каких частей состоит объект и как они стыкуются между собой
    ///     - процесс конструирования должен обеспечивать различные представления 
    ///       конструируемого объекта
    /// 
    /// Один алгоритм создания для различных объектов, 
    /// реализующих один интерфейс (один Director, несколько Builder).
    /// 
    /// Классический пример сложного объекта для конструирования которого
    /// может использоваться патерн Builder - построение лабиринта.
    /// У лабиринта есть комнаты, у комнат есть стены и двери и т.д.
    /// Все эти объеты нужно создать, скомпоновать и определить
    /// связи между ними.
    /// 
    /// Строитель часто создает компоновщик
    
     
    /// <summary>
    /// Реализует алгоритм создания сложного объекта. Конструирует
    /// объект, пользуясь интерфейсом <see cref="IBuilder"/>.
    /// 
    /// </summary>
    public class Director
    {
        private readonly IBuilder _builder;

        public Director(IBuilder builder)
        {
            _builder = builder;
        }

        /// <summary>
        /// В типичном случае продукты, изготавливаемые различными строителями, имеют настолько разные
        /// представления, что изобретение для них общего родительского класса ничего не дает.
        /// Поскольку клиент обычно конфигурирует распорядителя подходящим конкретным строителем, то, 
        /// надо полагать, ему известно, какой именно подкласс класса Builder используется и как нужно 
        /// обращаться с произведенными продуктами
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T Construct<T>() where T : class 
        {
            _builder.BuildPartA();
            _builder.BuildPartB();
            _builder.BuildPartC();

            return _builder.GetResult<T>();
        }
    }
}
﻿namespace Patterns.StructuralPatterns.Composite
{
    /// <summary>
    /// Компановщик -  Компонует объекты в древовидные структуры для представления иерархий часть-целое.
    ///
    /// Преимущества:
    ///     - позволяет клиентам единообразно трактовать индивидуальные и составные объекты
    ///     - позволяет применять рекурсивную композицию
    ///     - позволяет представить иерархию объектов вида часть-целое
    /// 
    /// Класс <see cref="Graphic"/> представляет одновременно и примитивы и контейнеры (агрегаты). 
    /// В нем объявлены операции, специфичные для каждого вида объекта(такие как Draw) и общие для всех составных объектов.
    /// 
    /// Участники:
    ///     - <see cref="Graphic"/> Component 
    ///                                     - объявляет интерфейс для компонуемых объектов
    ///                                     - предоставляет подходящую реализацию операций по умолчанию, общую для всех классов
    ///                                     - объявляет интерфейс для доступа к потомкам и управления ими
    ///                                     - определяет интерфейс для доступа к родителю компонента в рекурсивной структуре и при необходимости реализует его
    ///                                       (описанная возможность необязательна)
    /// 
    ///     - <see cref="Line"/> Leaf 
    ///                             - представляет листовые узлы композиции и не имеет потомков
    ///                             - определяет поведение примитивных объектов в композиции
    /// 
    ///     - <see cref="Picture"/> Composite
    ///                                     - определяет поведение компонентов, у которых есть потомки
    ///                                     - хранит компоненты-потомки
    ///                                     - реализует относящиеся к управлению потомками операции в интерфейсе клaсса Component
    /// 
    /// Каждый компонент может хранить ссылку на родителя чтобы упростить обход структуры
    /// 
    /// Родственные паттерны:
    ///     - отношение компонент-родитель используется в паттерне цепочка обязанностей
    ///     - декоратор часто применяется совместно с компоновщиком
    ///     - приспособленец позволяет разделять компоненты, но ссылаться на своих родителей они уже не могут
    ///     - итератор можно использовать для обхода составных объектов
    /// </summary>
    public abstract class Graphic
    {
        public abstract void Draw();

        public virtual void Add(Graphic child)
        {
        }

        public virtual void Remove(Graphic child)
        {
        }

        public virtual Graphic GetChild(int id)
        {
            return null;
        }
    }
}
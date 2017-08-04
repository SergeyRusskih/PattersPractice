using System;

namespace Patterns.GeneratingPatterns.Singleton
{
    /// Можно задвть не один а несколько инстансев!
    /// Удобная альтернатива глобальным переменным
    /// 
    /// Недостаток - приходится создавать все синглетны даже если они не используются.
    /// Через синглетон может быть создана абстрактная фабрика, строитель и прототип.
    /// 
    /// <summary>
    /// Generic singleton class, providing the Instance property, and preventing manual construction.
    /// Designed as a base for inheritance trees of lazy, thread-safe, singleton classes.
    /// Usage:
    /// 1. Sub-class must use itself, or its sub-class, as the type parameter S.
    /// 2. Sub-class must have a public default constructor (or no constructors).
    /// 3. Sub-class might be abstract, which requires it to be generic and demand the generic type
    ///    have a default constructor. Its sub-classes must answer all these requirements as well.
    /// 4. The instance is accessed by the Instance getter. Using a constructor causes an exception.
    /// 5. Accessing the Instance property in an inner initialization in a sub-class constructor
    ///    might cause an exception is some environments.
    /// </summary>
    /// <typeparam name="T">Lowest sub-class type.</typeparam>
    public abstract class Singleton<T> where T : Singleton<T>, new()
    {
        // ReSharper disable once StaticMemberInGenericType
        private static bool _isInstanceCreated;

        private static readonly Lazy<T> LazyInstance = new Lazy<T>(() =>
        {
            var instance = new T();
            _isInstanceCreated = true;
            return instance;
        });

        protected Singleton()
        {
            if (_isInstanceCreated)
            {
                throw new InvalidOperationException("Constructing a " + typeof(T).Name +
                                                    " manually is not allowed, use the Instance property.");
            }
        }

        public static T Instance => LazyInstance.Value;
    }
}

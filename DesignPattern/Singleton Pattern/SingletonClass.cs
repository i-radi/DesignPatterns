using System;

namespace DesignPattern.Singleton_Pattern
{
    sealed class SingletonClass
    {
        private static SingletonClass _instance = null;

        private SingletonClass()
        {
            Console.WriteLine("This's Singleton Class");   
        }

        public static SingletonClass GetInstance() => _instance ?? new SingletonClass();

    }
}

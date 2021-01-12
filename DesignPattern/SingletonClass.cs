using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
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

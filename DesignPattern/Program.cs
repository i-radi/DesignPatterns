using System;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
             #region Singletol
            //Same Instance
            SingletonClass s1= SingletonClass.GetInstance();
            SingletonClass s2= SingletonClass.GetInstance();
            #endregion
            
            
            Console.ReadKey(true);
        }
    }
}

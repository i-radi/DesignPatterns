using System;
using System.Linq;
using DesignPattern.AbstractFactory_Pattern;
using DesignPattern.Factory_Pattern;
using DesignPattern.Singleton_Pattern;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             #region Singletol
            //Same Instance
            SingletonClass s1= SingletonClass.GetInstance();
            SingletonClass s2= SingletonClass.GetInstance();
            #endregion

             #region Factory
            Console.WriteLine("Select Type of Shape\n R => Rectangle\n S => Square\n C => Circle");
            string type = Console.ReadLine();
            
            Shape shape = (new ShapeFactory()).GetShape(type);
            Console.WriteLine($" Area of {shape.GetType().ToString().Split('.').Last()} : {shape.Area()}");

            #endregion
            */
            #region AbstractFactory
            Console.WriteLine("Select Type of Shape\n R => Rectangle\n S => Square\n C => Circle");
            string type = Console.ReadLine();

            AbstractFactory af = new ShapeFactory();
            
            Shape shape =af.GetShape(type);
            Console.WriteLine($" Area of {shape.GetType().ToString().Split('.').Last()} : {shape.Area()}");

            #endregion

            Console.ReadKey(true);
        }
    }
}

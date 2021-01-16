using System;
using System.Linq;
using DesignPattern.AbstractFactory_Pattern;
using DesignPattern.Factory_Pattern;
using DesignPattern.Prototype_Pattern;
using DesignPattern.Singleton_Pattern;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Singletol
            /*
            //Same Instance
            SingletonClass s1= SingletonClass.GetInstance();
            SingletonClass s2= SingletonClass.GetInstance();
            */
            #endregion

            #region Factory
            /*
            Console.WriteLine("Select Type of Shape\n R => Rectangle\n S => Square\n C => Circle");
            string type = Console.ReadLine();

            Shape shape = (new ShapeFactory()).GetShape(type);
            Console.WriteLine($" Area of {shape.GetType().ToString().Split('.').Last()} : {shape.Area()}");
            */
            #endregion

            #region AbstractFactory
            /*
            Console.WriteLine("Select Type of Shape\n R => Rectangle\n S => Square\n C => Circle");
            string type = Console.ReadLine();

            AbstractFactory af = new ShapeFactory();

            Shape shape =af.GetShape(type);
            Console.WriteLine($" Area of {shape.GetType().ToString().Split('.').Last()} : {shape.Area()}");
            */
            #endregion

            #region Prototype
            /*
            Employee tempEmp1 = new Employee();
            tempEmp1.Name = "Ahmed";
            tempEmp1.Id = 1;
            tempEmp1.EmpAddress = new Address { City = "city 1", Building = "B1", StreetName = "street name" };

            Employee tempEmp2 = tempEmp1.Clone();
            Employee tempEmp3 = tempEmp1.DeepCopy();

            Console.WriteLine("========= Temp Emp 1 Original Values=============");
            Console.WriteLine(tempEmp1.ToString());
            Console.WriteLine("========= Temp Emp 2 Copy========================");
            Console.WriteLine(tempEmp2.ToString());
            Console.WriteLine("========= Temp Emp 3 Copy========================");
            Console.WriteLine(tempEmp3.ToString());

            tempEmp1.EmpAddress.City = "new city";
            tempEmp1.Name = "Mohamed";
            tempEmp1.Id = 10;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("========= Temp Emp 1 After Change =============");
            Console.WriteLine(tempEmp1.ToString());
            Console.WriteLine("========= Temp Emp 2 ==========================");
            Console.WriteLine(tempEmp2.ToString());
            Console.WriteLine("========= Temp Emp 3 ==========================");
            Console.WriteLine(tempEmp3.ToString());
            */
            #endregion

            Console.ReadKey(true);
        }
    }
}

using Pattern.Builders;
using Pattern.Decorators;
using Pattern.Factories;
using Pattern.Singletons;
using System;

namespace Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Factories
            Console.WriteLine("--------------Factories--------------------");
            FactoryMain.Run();

            // Factories
            Console.WriteLine("--------------Builders--------------------");
            BuilderMain.Run();

            // Factories
            Console.WriteLine("--------------Singletons--------------------");
            SingletonMain.Run();

            //Decorators
            Console.WriteLine("--------------Decorators--------------------");
            DecoratorMain.Run();

            Console.WriteLine();
            Console.WriteLine("Hello World!");

        }
    }
}

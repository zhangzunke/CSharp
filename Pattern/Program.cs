using Pattern.Builders;
using Pattern.Factories;
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

            Console.WriteLine();
            Console.WriteLine("Hello World!");

        }
    }
}

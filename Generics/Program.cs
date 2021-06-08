using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var person = CreateNewInstance<Person>();
            // var user = CreateNewInstance<User>();
        }

        static T CreateNewInstance<T>() where T : new()
        {
            return new T();
        }
    }

}

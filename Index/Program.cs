using System;

namespace Index
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var person = new Person();
            person.Name = "Mike";
            person.Grade = "First-Year";

            Console.WriteLine(person[0]);
            Console.WriteLine(person[1]);


            var indexedName = new IndexedNames();
            Console.WriteLine(indexedName[0]);
            Console.WriteLine(indexedName["b"]);
        }
    }
}

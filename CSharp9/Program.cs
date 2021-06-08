using System;

namespace CSharp9
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person { FirstName = "Mike", LastName = "Zhang", Age = 30 };
            if (person is { Age: >= 30, FirstName: "Mike1" })
            {

            }
            // canot assign a new value to last name since it is init
            // person.LastName = "";

            var transcation = new Transcation();

            Console.WriteLine("Hello World!");
        }
    }
}

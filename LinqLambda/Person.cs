using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLambda
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public Dog[] Dogs { get; set; }
    }

    public class Dog
    {
        public string Name { get; set; }
    }
}

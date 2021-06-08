﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            var personList = InitPerson();

            var dogs = personList.SelectMany(p => p.Dogs);

            foreach (var dog in dogs)
            {
                Console.WriteLine(dog.Name);
            }

            var dogs1 = personList.SelectMany((p, i) => 
                p.Dogs.Select(d => {
                   d.Name = $"{i},{d.Name}";
                   return d;
            }));

            foreach (var dog in dogs1)
            {
                Console.WriteLine(dog.Name);
            }

            var dogs2 = personList.SelectMany(p => p.Dogs, (p, d) => new
            {
                PersonName = p.Name,
                DogName = d.Name
            });

            foreach (var dog in dogs2)
            {
                Console.WriteLine(dog.DogName);
            }
        }

        private static List<Person> InitPerson()
        {
            List<Person> personList = new List<Person>
            {
                new Person
                {
                    Name = "P1", Age = 18, Gender = "Male",
                    Dogs = new Dog[]
                    {
                        new Dog { Name = "D1" },
                        new Dog { Name = "D2" }
                    }
                },
                new Person
                {
                    Name = "P2", Age = 19, Gender = "Male",
                    Dogs = new Dog[]
                    {
                        new Dog { Name = "D3" }
                    }
                },
                new Person
                {
                    Name = "P3", Age = 17,Gender = "Female",
                    Dogs = new Dog[]
                    {
                        new Dog { Name = "D4" },
                        new Dog { Name = "D5" },
                        new Dog { Name = "D6" }
                    }
                }
            };

            return personList;
        }
    }
}

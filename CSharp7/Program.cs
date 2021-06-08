using System;
using System.Collections.Generic;

namespace CSharp7
{
    class Program
    {
        static void Main(string[] args)
        {
            // out variables
            var input = "123";
            if (int.TryParse(input, out var result))
            {
                Console.WriteLine(result);
            }

            // Tuples
            (string Alpha, string Beta) namedLetters = ("a", "b");
            Console.WriteLine($"{namedLetters.Alpha}, {namedLetters.Beta}");

            var alphabetStart = (Alpha: "a", Beta: "b");
            Console.WriteLine($"{alphabetStart.Alpha}, {alphabetStart.Beta}");

            // Deconstruct
            (var userName, var userAge) = GetUser();
            Console.WriteLine($"UserName : {userName}, UserAge : {userAge}");

            var user = new User
            {
                Name = "Mike",
                Age = 30,
                Email = "zhangzunke@126.com",
                Sex = "Male"
            };

            (var name, var email, var age) = user;
            Console.WriteLine($"UserName : {name}, Email : {email}, Age : {age}");

            //Discard
            var (_, _, _, pop1, _, pop2) = QueryCityDataForYears("New York City", 1960, 2010);
            Console.WriteLine($"Population change, 1960 to 2020 : {pop2 - pop1:N0}");

            //Pattern matching
            object dog = "This is dog";
            if (dog is User convertUser)
            {
                
            }
            var sequence = new List<object>();
            sequence.Add(1);
            sequence.Add(new List<int> { -1, -2, 2, 3, 4 });
            var sum = SumPositiveNumbers(sequence);
            Console.WriteLine($"Sum Total : {sum}");

            //Ref locals and returns
            int x = 3;
            ref int x1 = ref x;
            x1 = 2;
            Console.WriteLine($"The changing x value is {x}");

            int[] arr = { 1, 2, 3, 4, 5 };
            ref int value = ref GetByIndex(arr, 2);
            value = 99;
            Console.WriteLine($"The arr[2] value is {arr[2]}");

            //Local functions
            var charts = AlphabetSubset('a', 'e');
            foreach (var item in charts)
            {
                Console.WriteLine($"The chart value is {item}");
            }

            //More expression-bodied members


            Console.WriteLine("Hello World!");
        }

        static (string name, int age) GetUser()
        {
            return ("Mike", 11);
        }

        static (string, double, int, int, int, int) QueryCityDataForYears(string name, int year1, int year2)
        {
            int population1 = 0, population2 = 0;
            double area = 0;
            if (name == "New York City")
            {
                area = 468.48;
                if (year1 == 1960)
                {
                    population1 = 7781984;
                }
                if (year2 == 2010)
                {
                    population2 = 8175133;
                }
                return (name, area, year1, population1, year2, population2);
            }
            return ("", 0, 0, 0, 0, 0);
        }

        static int SumPositiveNumbers(IEnumerable<object> sequence)
        {
            int sum = 0;
            foreach (var i in sequence)
            {
                switch (i)
                {
                    case 0:
                        break;
                    case IEnumerable<int> childSequence:
                        {
                            foreach (var item in childSequence)
                            {
                                sum += (item > 0) ? item : 0;
                            }
                            break;
                        }
                    case int n when n > 0:
                        sum += n;
                        break;
                    case null:
                        throw new NullReferenceException("Null found in sequence");
                    default:
                        throw new InvalidOperationException("Unrecognized type");
                }
            }
            return sum;
        }

        static ref int GetByIndex(int[] arr, int ix) => ref arr[ix];

        static IEnumerable<char> AlphabetSubset(char start, char end)
        {
            if (start < 'a' || start > 'z')
                throw new ArgumentOutOfRangeException(paramName: nameof(start), message: "start must be a letter");
            if (end < 'a' || end > 'z')
                throw new ArgumentOutOfRangeException(paramName: nameof(end), message: "end must be a letter");

            if (end <= start)
                throw new ArgumentException($"{nameof(end)} must be greater than {nameof(start)}");

            return alphabetSubsetImplementation();

            IEnumerable<char> alphabetSubsetImplementation()
            {
                for (var c = start; c < end; c++)
                {
                    yield return c;
                }
            }
        }
    }
}

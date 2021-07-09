using Pattern.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    public static class StringExtensions
    {
        public static string Dump(this string str)
        {
            Console.WriteLine(str);
            return str;
        }

        public static Dictionary<TKey, TValue> Dump<TKey, TValue>(this Dictionary<TKey, TValue> dict)
        {
            Console.WriteLine(dict);
            return dict;
        }

        public static Car Dump(this Car car)
        {
            Console.WriteLine($"Make: {car.Make}");
            Console.WriteLine($"Make: {car.Colour}");
            Console.WriteLine($"ManifactureDate: {car.ManifactureDate}");
            return car;
        }
    }
}

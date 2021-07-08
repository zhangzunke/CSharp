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
    }
}

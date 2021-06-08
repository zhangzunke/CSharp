using System;
using System.Collections.Generic;

namespace CSharp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Version.TryParse("1.0.0", out var version);
            Console.WriteLine(version!.Major);

            var value = GetValue(true);
            Console.WriteLine(value.Length);

            ValueCannotBeNull(null);

            string? value1 = null;
            ValueCannotBeNull(null);

            string? value2 = "test";
            ValueCannotBeNull(value2);

            string value3 = "test";
            ValueCannotBeNull(value3);

           

            var arr = new string[] { "10", "20", "30", "40", "50", "60", "70", "80", "90", "100" };
            var arr1 = arr[0..3];
            Console.WriteLine($"arr1={string.Join(",", arr1)}");
            Console.WriteLine("Hello World!");
        }
        static void WriteLinesToFile(IEnumerable<string> lines)
        {
            using var file = new System.IO.StreamWriter("WriteLine.txt");
            foreach (string line in lines)
            {
                if (!line.Contains("Second"))
                {
                    file.WriteLine(line);
                }
            }
        }

        int M()
        {
            int y = 5;
            int x = 7;
            return Add(x, y);
            static int Add(int left, int right) => left + right;
        }

        void Sample()
        {
            string str = null;
            string? str2 = null;
        }

        public static void ValueCannotBeNull(string value)
        {
            _ = value.Length;
        }

        public static void ValueMayBeNull(string? value)
        {
            _ = value.Length;
        }

        static string? GetValue(bool returnNotNullValue)
        {
            return returnNotNullValue ? "" : null;
        }
    }
}

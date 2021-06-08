using System;

namespace Enums
{
    [Flags]
    public enum Borders
    { 
        /// <summary>
        /// 2 * 1
        /// </summary>
        Top = 1,
        /// <summary>
        /// 2
        /// </summary>
        Right = 2,
        /// <summary>
        /// 2 * 2
        /// </summary>
        Bottom = 4,
        /// <summary>
        /// 2 * 2 * 2
        /// </summary>
        Left = 8
    }

    class Program
    {
        static void Main(string[] args)
        {
            var b = Borders.Top | Borders.Right | Borders.Bottom;
            Console.WriteLine(b);
            var c = b & Borders.Right;
            Console.WriteLine(c);
            // b ^= Borders.Right;
            b |= Borders.Right;
            Console.WriteLine(b);
            Console.WriteLine("Hello World!");
        }
    }
}

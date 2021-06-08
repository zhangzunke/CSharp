using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp8
{
    public enum Rainbow
    {
        Red,
        Orange,
        Yellow,
        Green,
        Blue
    }

    public class Color
    {
        //Enum patterns
        public static RgbColor FromRainbow(Rainbow colorBand) =>
            colorBand switch
            {
                Rainbow.Red => new RgbColor(0xFF, 0x00, 0x00),
                Rainbow.Blue => new RgbColor(0xFF, 0x00, 0x00),
                _ => throw new ArgumentException(message: "invalid enum value")
            };
    }

    public class RgbColor
    {
        public RgbColor(int r, int g, int b)
        {

        }
    }

    public class Address
    {
        public string State { get; set; }
    }

    public class Tax
    {
        //Property patterns
        public static decimal ComputeSalesTax(Address location, decimal salePrice)
                => location switch
                {
                    { State: "WA" } => salePrice * 0.06M,
                    { State: "MN" } => salePrice * 0.75M,
                    { State: "MI" } => salePrice * 0.05M,
                    _ => 0M
                };
    }

    public class Game
    {
        //Tuple patterns
        public static string RockPaperScissors(string first, string second) =>
                (first, second) switch
                {
                    ("rock", "paper") => "rock is covered by paper. Paper wins.",
                    ("rock", "scissors") => "rock breaks scissors. Rock wins.",
                    ("paper", "rock") => "paper covers rock. Paper wins.",
                    (_, _) => "tie"
                };
    }
}

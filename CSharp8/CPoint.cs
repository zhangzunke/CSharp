using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp8
{
    public class CPoint
    {
        public int X { get; }
        public int Y { get; }
        public CPoint(int x, int y) =>
            (X, Y) = (x, y);
        public void Deconstruct(out int x, out int y) =>
            (x, y) = (X, Y);
        //Positional patterns
        public static Quadrant GetQuadrant(CPoint point) =>
            point switch
            {
                (0, 0) => Quadrant.Origin,
                var (x, y) when x > 0 && y > 0 => Quadrant.One,
                var (x, y) when x < 0 && y > 0 => Quadrant.Two,
                var (x, y) when x < 0 && y < 0 => Quadrant.Three,
                var (x, y) when x > 0 && y < 0 => Quadrant.Four,
                var (_, _) => Quadrant.OnBorder,
                _ => Quadrant.Unknow
            };
    }

    public enum Quadrant
    {
        Unknow,
        Origin,
        One,
        Two,
        Three,
        Four,
        OnBorder
    }
}

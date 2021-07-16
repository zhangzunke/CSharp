using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Prototypes
{
    public interface IBlock
    {
        string Render { get; }
        IBlock Clone();
    }

    public class TextBlock : IBlock
    {
        public string Content { get; set; }
        public IBlock Clone() => new TextBlock { Content = Content };
        public string Render => Content;
    }

    public class NumberBlock : IBlock
    {
        public int Number { get; set; }
        public IBlock Clone() => new NumberBlock { Number = Number };
        public string Render => Number.ToString();
    }

    public class DateTimeBlock : IBlock
    {
        public DateTime DateTime { get; set; }
        public string Format { get; set; }
        public IBlock Clone() => new DateTimeBlock
        {
            Format = Format,
            DateTime = DateTime
        };
        public string Render => DateTime.ToString(Format);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Prototypes
{
    public class BlockFactory
    {
        public static IBlock Create(string content)
        {
            if (DateTime.TryParse(content, out var dt))
                return new DateTimeBlock()
                {
                    Format = "dd/MM/yyyy",
                    DateTime = dt
                };

            if (int.TryParse(content, out var n))
                return new NumberBlock() { Number = n };

            return new TextBlock { Content = content };
        }
    }
}

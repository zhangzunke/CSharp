using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp9
{
    public class Foreach
    {
        public void ForeachNumber()
        {
            var number = "123";
            foreach (var i in number)
            {
                Console.WriteLine(i);
            }
        }
    }
}

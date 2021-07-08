using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Factories
{
    public class FactoryMain
    {
        public static void Run()
        {
            new NavigationBar();
            new DropdownMenu();

            new NavigationBar(new Apple());
            new DropdownMenu(new Apple());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Factories
{
    public partial class NavigationBar
    {
        public NavigationBar(IUIFactory factory) => factory.CreateButton();
    }

    public partial class DropdownMenu
    {
        public DropdownMenu(IUIFactory factory) => factory.CreateButton();
    }

    public interface IUIFactory
    {
        public Button CreateButton();
    }

    public class Apple : IUIFactory
    {
        public Button CreateButton()
        {
            return new Button { Type = "iOS Button".Dump() };
        }
    }

    public class Android : IUIFactory
    {
        public Button CreateButton()
        {
            return new Button { Type = "Android Button".Dump() };
        }
    }
}

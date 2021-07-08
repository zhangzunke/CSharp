using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Factories
{
    public partial class NavigationBar
    {
        // public NavigationBar() => new Button { Type = "Default Button".Dump() };
        public NavigationBar() => ButtonFactory.CreateButton();
    }

    public partial class DropdownMenu
    {
        // public DropdownMenu() => new Button { Type = "Default Button".Dump() };
        public DropdownMenu() => ButtonFactory.CreateButton();
    }

    public class ButtonFactory
    {
        public static Button CreateButton() => new Button { Type = "Default Button".Dump() };
    }

    public class Button
    {
        public string Type { get; set; }
    }
}

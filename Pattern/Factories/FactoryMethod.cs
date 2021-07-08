using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Factories
{
    public abstract class Element
    {
        protected abstract Button CreateButton();

        public Element() => CreateButton();
    }

    public partial class NavigationBar : Element
    {
        protected override Button CreateButton()
        {
            return new Button { Type = "Default Red Button".Dump() };
        }
    }

    public partial class DropdownMenu : Element
    {
        protected override Button CreateButton()
        {
            return new Button { Type = "Default Red Button".Dump() };
        }
    }
}

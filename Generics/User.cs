using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class User
    {
        public User(string userName)
        {
            UserName = userName;
        }

        public string UserName { get; set; }
    }
}

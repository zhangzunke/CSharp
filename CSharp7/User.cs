using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp7
{
    public class User
    {
        public User()
        { 
        }
        public User(string name) => Name = name;
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        private string _label;
        public string Label
        {
            get => _label;
            set => _label = value ?? "Default Value";
        }
        public void Deconstruct(out string name, out string email) => 
            (name, email) = (Name, Email);
        public void Deconstruct(out string name, out string email, out int age) =>
            (name, email, age) = (Name, Email, Age);
    }
}

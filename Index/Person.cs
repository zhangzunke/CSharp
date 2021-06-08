using System;
using System.Collections.Generic;
using System.Text;

namespace Index
{
    public class Person
    {
        private string name;
        private string grade;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Grade
        {
            get { return grade; }
            set { grade = value; }
        }

        public string this[int index]
        {
            get 
            {
                if (index == 0)
                {
                    return name;
                }
                else if (index == 1)
                {
                    return grade;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (index == 0)
                {
                    name = value;
                }
                else if (index == 1)
                {
                    grade = value;
                }
            }
        }
    }
}

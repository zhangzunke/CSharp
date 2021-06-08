using System;
using System.Collections.Generic;
using System.Text;

namespace Index
{
    public class IndexedNames
    {
        private string[] nameList = { "a", "b", "c", "d" };

        public string this[int index]
        {
            get 
            {
                return nameList[index];
            }
            set
            {
                nameList[index] = value;
            }
        }

        public int this[string name]
        {
            get 
            {
                for (int i = 0; i < nameList.Length; i++)
                {
                    if (nameList[i] == name)
                    {
                        return i;
                    }
                }
                return -1;
            }
        }
    }
}

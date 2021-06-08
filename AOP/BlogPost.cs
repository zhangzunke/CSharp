using System;
using System.Collections.Generic;
using System.Text;

namespace AOP
{
    public class BlogPost
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Disabled { get; set; }
        public DateTime Created { get; set; }
    }
}

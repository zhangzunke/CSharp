using System;
using System.Collections.Generic;
using System.Text;

namespace AOP
{
    public interface IBlogService
    {
        void DisablePost(BlogPost post);
        BlogPost GetPost(int id);
    }
}

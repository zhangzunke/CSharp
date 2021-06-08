using System;
using System.Collections.Generic;
using System.Text;

namespace AOP
{
    public class BlogService : IBlogService
    {
        public void DisablePost(BlogPost post)
        {
            post.Disabled = true;
        }

        public BlogPost GetPost(int id)
        {
            return new BlogPost
            {
                Id = id,
                Title = "Title",
                Description = "Description",
                Disabled = false,
                Created = DateTime.Now
            };
        }
    }
}

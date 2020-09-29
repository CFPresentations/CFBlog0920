using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CFBlog0920.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public string ImageUrl { get; set; }
        public DateTimeOffset CreatedTimeStamp { get; set; }
        public DateTimeOffset? UpdatedTimeStamp { get; set; }

        public int BlogId { get; set; }
        public Blog Blog { get; set; }
        public List<Comment> Comments { get; set; }
        public List<Tag> Tags { get; set; }
    }
}

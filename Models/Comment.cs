using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CFBlog0920.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTimeOffset CreatedTimeStamp { get; set; }
        public DateTimeOffset? UpdatedTimeStamp { get; set; }

        public int PostId { get; set; }
        public Post Post { get; set; }

        public ICollection<Tag> Tags { get; set; }

    }
}

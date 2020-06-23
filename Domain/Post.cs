using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Post : BaseEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string PhotoPath { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public int TopicId { get; set; }
        public virtual Topic Topic { get; set; }
        public virtual ICollection<Comment> Comments { get; set; } = new HashSet<Comment>();
        public virtual ICollection<Rating> Ratings { get; set; } = new HashSet<Rating>();

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Comment : BaseEntity
    {
        public string CommentText { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public int PostId { get; set; }        
        public virtual Post Post { get; set; }
    }
}

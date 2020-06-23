using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Topic : BaseEntity
    {
        public string Name { get; set; }
        public virtual ICollection<Post> Posts { get; set; } = new HashSet<Post>();
    }
}

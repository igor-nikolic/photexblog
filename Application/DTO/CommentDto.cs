using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTO
{
    public class CommentDto
    {
        public int Id { get; set; }
        public string CommentText { get; set; }
        public int PostId { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTO
{
    public class ReadCommentDto
    {
        public int Id { get; set; }
        public string CommentText { get; set; }
        public int UserId { get; set; }
        public string UserEmail { get; set; }
        public int PostId { get; set; }
        public string PostTitle { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTO
{
    public class PostDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string PhotoPath { get; set; }
        public int TopicId { get; set; }
        public int UserId { get; set; }
    }
}

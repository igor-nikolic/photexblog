using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTO
{
    public class ReadRatingDto
    {
        public int Id { get; set; }
        public int Value { get; set; }
        public string UserEmail { get; set; }
        public int UserId { get; set; }
        public int PostId { get; set; }
        public string PostTitle { get; set; }
    }
}

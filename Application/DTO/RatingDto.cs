using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTO
{
    public class RatingDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int Value { get; set; }
        public int PostId { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTO
{
    public class ReadUserDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int NumberOfPosts { get; set; }
        public int NumberOfComments { get; set; }
        public int NumberOfRatings { get; set; }

    }
}

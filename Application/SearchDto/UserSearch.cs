using Application.Queries;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.SearchDto
{
    public class UserSearch : PagedSearch
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}

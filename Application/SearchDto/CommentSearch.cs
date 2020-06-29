using Application.Queries;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.SearchDto
{
    public class CommentSearch : PagedSearch
    {
        public string Comment { get; set; }
        public string UserEmail { get; set; }
        public string PostTitle { get; set; }
    }
}

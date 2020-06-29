using Application.Queries;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.SearchDto
{
    public class PostSearch : PagedSearch
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string UserEmail { get; set; }
        public string Topic { get; set; }
    }
}

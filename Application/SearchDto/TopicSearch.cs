using Application.Queries;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.SearchDto
{
    public class TopicSearch : PagedSearch
    {
        public string Topic { get; set; }
    }
}

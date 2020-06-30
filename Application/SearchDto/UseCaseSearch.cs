using Application.Queries;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.SearchDto
{
    public class UseCaseSearch : PagedSearch
    {
        public string Name { get; set; }
    }
}

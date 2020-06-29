using Application.Queries;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.SearchDto
{
    public class UseCaseLogSearch : PagedSearch
    {
        public string UseCaseName { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string UserEmail { get; set; }
    }
}

using Application.Queries;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.SearchDto
{
    public class UserUseCaseSearch : PagedSearch
    {
        public int? UserId { get; set; }
        public int? UseCaseId { get; set; }
        public string UserEmail { get; set; }
        public string UseCaseName { get; set; }
    }
}

using Application.Queries;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.SearchDto
{
    public class RatingSearch :PagedSearch
    {
        public int? MinRatingValue { get; set; }
        public int? MaxRatingValue { get; set; }
        public string UserEmail { get; set; }
        public string PostTitle { get; set; }
    }
}

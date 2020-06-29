using Application.DTO;
using Application.Queries;
using Application.Queries.Topic;
using Application.SearchDto;
using EFDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Implementation.Queries.Topic
{
    public class EfGetTopicsQuery : IGetTopicsQuery
    {
        private readonly PhoTexBlogContext _context;

        public EfGetTopicsQuery(PhoTexBlogContext context)
        {
            _context = context;
        }

        public int Id => 16;

        public string Name => "Search Topics";

        public PagedResponse<ReadTopicDto> Execute(TopicSearch search)
        {
            var query = _context.Topics.AsQueryable();

            if (!string.IsNullOrEmpty(search.Topic) || !string.IsNullOrWhiteSpace(search.Topic))
            {
                query = query.Where(x => x.Name.ToLower().Contains(search.Topic.ToLower()));
            }

            var skipCount = search.PerPage * (search.Page - 1);

            var response = new PagedResponse<ReadTopicDto>
            {
                CurrentPage = search.Page,
                ItemsPerPage = search.PerPage,
                TotalCount = query.Count(),
                Items = query.Skip(skipCount).Take(search.PerPage).Select(x => new ReadTopicDto
                {
                    Id = x.Id,
                    Name = x.Name,
                    NumberOfPosts = x.Posts.Count()
                }).ToList()
            };

            return response;
        }
    }
}

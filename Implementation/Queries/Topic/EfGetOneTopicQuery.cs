using Application.DTO;
using Application.Queries.Topic;
using EFDataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace Implementation.Queries.Topic
{
    public class EfGetOneTopicQuery : IGetOneTopicQuery
    {
        private readonly PhoTexBlogContext _context;

        public EfGetOneTopicQuery(PhoTexBlogContext context)
        {
            _context = context;
        }

        public int Id => 121212;

        public string Name => "Get One Topic";

        public ReadTopicDto Execute(int search)
        {
            var topic = _context.Topics.Find(search);

            return new ReadTopicDto
            {
                Id = topic.Id,
                Name = topic.Name
            };
        }
    }
}

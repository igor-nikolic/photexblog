using Application.DTO;
using Application.Exceptions;
using Application.Queries.Topic;
using EFDataAccess;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Implementation.Queries.Topic
{
    public class EfGetOneTopicQuery : IGetOneTopicQuery
    {
        private readonly PhoTexBlogContext _context;

        public EfGetOneTopicQuery(PhoTexBlogContext context)
        {
            _context = context;
        }

        public int Id => 18;

        public string Name => "Get One Topic";

        public ReadTopicDto Execute(int search)
        {
            var topic = _context.Topics
                .Include(x => x.Posts)
                .SingleOrDefault(x => x.Id == search);

            if(topic == null) throw new EntityNotFoundException(search, typeof(Domain.Topic));
            return new ReadTopicDto
            {
                Id = topic.Id,
                Name = topic.Name,
                NumberOfPosts = topic.Posts.Count()
            };
        }
    }
}

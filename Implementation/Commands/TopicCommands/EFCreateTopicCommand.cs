using Application.Commands.Topic;
using Application.DTO;
using Domain;
using EFDataAccess;
using FluentValidation;
using Implementation.Validators.TopicValidators;

namespace Implementation.Commands.TopicCommands
{
    public class EFCreateTopicCommand : ICreateTopicCommand
    {
        private readonly PhoTexBlogContext _context;
        private readonly CreateTopicValidator _validator;

        public EFCreateTopicCommand(PhoTexBlogContext context, CreateTopicValidator validator)
        {
            _context = context;
            _validator = validator;
        }

        public int Id => 12;

        public string Name => "Create Topic";

        public void Execute(TopicDto request)
        {
            _validator.ValidateAndThrow(request);

            var topic = new Topic 
            {
            Name = request.Name
            };
            _context.Topics.Add(topic);
            _context.SaveChanges();
        }
    }
}

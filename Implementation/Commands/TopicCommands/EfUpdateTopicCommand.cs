using Application.Commands.Topic;
using Application.DTO;
using EFDataAccess;
using FluentValidation;
using Implementation.Validators.TopicValidators;
using System;
using System.Collections.Generic;
using System.Text;

namespace Implementation.Commands.TopicCommands
{
    
    public class EfUpdateTopicCommand : IUpdateTopicCommand
    {
        private readonly PhoTexBlogContext _context;
        private readonly UpdateTopicValidator _validator;

        public EfUpdateTopicCommand(PhoTexBlogContext context, UpdateTopicValidator validator)
        {
            _context = context;
            _validator = validator;
        }

        public int Id => 6;

        public string Name => "Update Topic";

        public void Execute(TopicDto request)
        {
            _validator.ValidateAndThrow(request);
            var topic = _context.Topics.Find(request.Id);
            topic.Name = request.Name;
            _context.SaveChanges();
        }
    }
}

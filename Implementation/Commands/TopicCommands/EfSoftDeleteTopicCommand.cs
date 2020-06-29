using Application.Commands.Topic;
using Application.Exceptions;
using Domain;
using EFDataAccess;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Implementation.Commands.TopicCommands
{
    public class EfSoftDeleteTopicCommand : IDeleteTopicCommand
    {
        private readonly PhoTexBlogContext _context;

        public EfSoftDeleteTopicCommand(PhoTexBlogContext context)
        {
            _context = context;
        }

        public int Id => 5;

        public string Name => "Soft Delete Topic";

        public void Execute(int request)
        {
            var topic = _context.Topics.Find(request);
            if (topic == null) throw new EntityNotFoundException(request, typeof(Topic));

            topic.DeletedAt = DateTime.Now;
            topic.Visible = false;
            _context.SaveChanges();

        }
    }
}

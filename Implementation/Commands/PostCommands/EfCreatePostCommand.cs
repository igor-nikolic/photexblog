using Application.Commands.Post;
using Application.DTO;
using Domain;
using EFDataAccess;
using FluentValidation;
using Implementation.Validators.PostValidators;
using System;
using System.Collections.Generic;
using System.Text;

namespace Implementation.Commands.PostCommands
{
    
    public class EfCreatePostCommand : ICreatePostCommand
    {
        private readonly PhoTexBlogContext _context;
        private readonly CreatePostValidator _validator;

        public EfCreatePostCommand(PhoTexBlogContext context, CreatePostValidator validator)
        {
            _context = context;
            _validator = validator;
        }

        public int Id => 7;

        public string Name => "Create Post";

        public void Execute(PostDto request)
        {
            _validator.ValidateAndThrow(request);

            var post = new Post
            {
                Title = request.Title,
                Content = request.Content,
                PhotoPath = request.PhotoPath,
                UserId = request.UserId,
                TopicId = request.TopicId
            };
            _context.Posts.Add(post);
            _context.SaveChanges();
        }
    }
}

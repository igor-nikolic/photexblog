using Application.Commands;
using Application.Commands.Comments;
using Application.Commands.Post;
using Application.Commands.Rating;
using Application.Commands.Topic;
using Application.Commands.UseCase;
using Application.Commands.User;
using Application.Commands.UserUseCase;
using Application.Queries.Comment;
using Application.Queries.Post;
using Application.Queries.Rating;
using Application.Queries.Topic;
using Application.Queries.UseCase;
using Application.Queries.UseCaseLog;
using Application.Queries.User;
using Application.Queries.UserUseCase;
using Application.UseCase;
using EFDataAccess;
using Implementation.Commands.CommentCommands;
using Implementation.Commands.PostCommands;
using Implementation.Commands.RatingCommands;
using Implementation.Commands.TopicCommands;
using Implementation.Commands.UseCaseCommands;
using Implementation.Commands.UserCommands;
using Implementation.Commands.UserUseCase;
using Implementation.Loggers;
using Implementation.Queries.Comment;
using Implementation.Queries.Post;
using Implementation.Queries.Rating;
using Implementation.Queries.Topic;
using Implementation.Queries.UseCase;
using Implementation.Queries.UseCaseLog;
using Implementation.Queries.User;
using Implementation.Queries.UserUseCase;
using Implementation.Validators.CommentValidators;
using Implementation.Validators.PostValidators;
using Implementation.Validators.RatingValidators;
using Implementation.Validators.TopicValidators;
using Implementation.Validators.UseCaseValidators;
using Implementation.Validators.UserUseCaseValidator;
using Implementation.Validators.UserValidators;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Core
{
    public static class ContainerExtensions
    {
        public static void AddUseCases(this IServiceCollection services) 
        {
            services.AddTransient<IUseCaseLogger, DBLogger>();

            services.AddTransient<IGetTopicsQuery, EfGetTopicsQuery>();
            services.AddTransient<IGetOneTopicQuery, EfGetOneTopicQuery>();
            services.AddTransient<ICreateTopicCommand, EFCreateTopicCommand>();
            services.AddTransient<IUpdateTopicCommand, EfUpdateTopicCommand>();
            services.AddTransient<IDeleteTopicCommand, EfSoftDeleteTopicCommand>();

            services.AddTransient<IGetUsersQuery, EfGetUsersQuery>();
            services.AddTransient<IGetOneUserQuery, EfGetOneUserQuery>();
            services.AddTransient<ICreateUserCommand, EfCreateUserCommand>();
            services.AddTransient<IUpdateUserCommand, EfUpdateUserCommand>();
            services.AddTransient<IDeleteUserCommand, EfSoftDeleteUserCommand>();

            services.AddTransient<IGetPostsQuery, EfGetPostsQuery>();
            services.AddTransient<IGetOnePostQuery, EfGetOnePostQuery>();
            services.AddTransient<ICreatePostCommand, EfCreatePostCommand>();
            services.AddTransient<IUpdatePostCommand, EfUpdatePostCommand>();
            services.AddTransient<IDeletePostCommand, EfSoftDeletePostCommand>();

            services.AddTransient<IGetCommentsQuery, EfGetCommentsQuery>();
            services.AddTransient<IGetOneCommentQuery, EfGetOneCommentQuery>();
            services.AddTransient<ICreateCommentCommand, EfCreateCommentCommand>();
            services.AddTransient<IDeleteCommentCommand, EfSoftDeleteCommentCommand>();
            services.AddTransient<IUpdateCommentCommand, EfUpdateCommentCommand>();

            services.AddTransient<IGetRatingsQuery, EfGetRatingsQuery>();
            services.AddTransient<IGetOneRatingQuery, EfGetOneRatingQuery>();
            services.AddTransient<ICreateRatingCommand, EfCreateRatingCommand>();
            services.AddTransient<IUpdateRatingCommand, EfUpdateRatingCommand>();

            services.AddTransient<IGetUseCasesQuery, EfGetUseCasesQuery>();
            services.AddTransient<IGetOneUseCaseQuery, EfGetOneUseCaseQuery>();
            services.AddTransient<ICreateUseCaseCommand, EfCreateUseCaseCommand>();
            services.AddTransient<IUpdateUseCaseCommand, EfUpdateUseCaseCommand>();

            services.AddTransient<IGetUseCaseLogsQuery, EfGetUseCaseLogsQuery>();

            services.AddTransient<ICreateUserUseCaseCommand, EfCreateUserUseCaseCommand>();
            services.AddTransient<IGetUsersUseCasesQuery, EfGetUsersUseCasesQuery>();
        }
        public static void AddValidators(this IServiceCollection services) 
        {
            services.AddTransient<CreateTopicValidator>();
            services.AddTransient<UpdateTopicValidator>();

            services.AddTransient<CreateUserValidator>();
            services.AddTransient<UpdateUserValidator>();

            services.AddTransient<CreatePostValidator>();
            services.AddTransient<UpdatePostValidator>();

            services.AddTransient<CreateCommentValidator>();
            services.AddTransient<UpdateCommentValidator>();

            services.AddTransient<CreateRatingValidator>();
            services.AddTransient<UpdateRatingValidator>();

            services.AddTransient<CreateUseCaseValidator>();
            services.AddTransient<UpdateUseCaseValidator>();

            services.AddTransient<CreateUserUseCaseValidator>();
        }
        public static void AddAplicationActor(this IServiceCollection services)
        {
            services.AddTransient<IApplicationActor>(x =>
            {
                var accessor = x.GetService<IHttpContextAccessor>();

                var user = accessor.HttpContext.User;

                if (user.FindFirst("ActorData") == null)
                {
                    return new GuestActor();
                }

                var actorString = user.FindFirst("ActorData").Value;

                var actor = JsonConvert.DeserializeObject<JwtActor>(actorString);

                return actor;

            });
        }

        public static void AddJWT(this IServiceCollection services,Settings appSettings)
        {
            services.AddTransient<JwtManager>(x =>
            {
                var context = x.GetService<PhoTexBlogContext>();

                return new JwtManager(context, appSettings.JwtIssuer, appSettings.JwtSecretKey);
            });

            services.AddAuthentication(options =>
            {
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultSignInScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(cfg =>
            {
                cfg.RequireHttpsMetadata = false;
                cfg.SaveToken = true;
                cfg.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidIssuer = appSettings.JwtIssuer,
                    ValidateIssuer = true,
                    ValidAudience = "Any",
                    ValidateAudience = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(appSettings.JwtSecretKey)),
                    ValidateIssuerSigningKey = true,
                    ValidateLifetime = true,
                    ClockSkew = TimeSpan.Zero
                };
            });
        }

        public static void AddSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "PhoTex", Version = "v1" });
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Description = @"JWT Authorization header using the Bearer scheme. \r\n\r\n 
                      Enter 'Bearer' [space] and then your token in the text input below.
                      \r\n\r\nExample: 'Bearer 12345abcdef'",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer"
                });

                c.AddSecurityRequirement(new OpenApiSecurityRequirement()
                {
                    {
                        new OpenApiSecurityScheme
                          {
                            Reference = new OpenApiReference
                              {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                              },
                              Scheme = "oauth2",
                              Name = "Bearer",
                              In = ParameterLocation.Header,

                            },
                            new List<string>()
                          }
                    });
            });
        }


    }
}

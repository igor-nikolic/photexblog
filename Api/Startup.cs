using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Api.Core;
using Application.Commands;
using Application.Commands.Comments;
using Application.Commands.Post;
using Application.Commands.Rating;
using Application.Commands.Topic;
using Application.Commands.UseCase;
using Application.Commands.User;
using Application.Commands.UserUseCase;
using Application.DTO;
using Application.Email;
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
using Implementation.Email;
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
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;

namespace Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var appSettings = new Settings();
            Configuration.Bind(appSettings);

            services.AddTransient<PhoTexBlogContext>();
            services.AddTransient<UseCaseExecutor>();
            //services.AddTransient<IUseCaseLogger, ConsoleLogger>();
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

            services.AddTransient<PostDto>();

            services.AddHttpContextAccessor();
            services.AddTransient<IEmailSender, SMTPEmailSender>(x => new SMTPEmailSender(appSettings.MailFrom, appSettings.MailPassword));
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
            //services.AddTransient<IEmailSender, SmtpEmailSender>(x => new SmtpEmailSender(appSettings.EmailFrom, appSettings.EmailPassword));
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseStaticFiles();
            app.UseMiddleware<GlobalExceptionHandler>();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Api.Core;
using Application.Commands;
using Application.Commands.Post;
using Application.Commands.Topic;
using Application.Queries.Topic;
using Application.UseCase;
using EFDataAccess;
using Implementation.Commands.PostCommands;
using Implementation.Commands.TopicCommands;
using Implementation.Commands.UserCommands;
using Implementation.Loggers;
using Implementation.Queries.Topic;
using Implementation.Validators.PostValidators;
using Implementation.Validators.TopicValidators;
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
            services.AddTransient<IUseCaseLogger, ConsoleLogger>();

            services.AddTransient<ICreateTopicCommand, EFCreateTopicCommand>();
            services.AddTransient<IGetOneTopicQuery, EfGetOneTopicQuery>();
            services.AddTransient<IUpdateTopicCommand, EfUpdateTopicCommand>();
            services.AddTransient<IDeleteTopicCommand, EfSoftDeleteTopicCommand>();
            services.AddTransient<ICreateUserCommand, EfCreateUserCommand>();
            services.AddTransient<CreateTopicValidator>();
            services.AddTransient<UpdateTopicValidator>();
            services.AddTransient<CreateUserValidator>();
            services.AddTransient<ICreatePostCommand, EfCreatePostCommand>();
            services.AddTransient<CreatePostValidator>();
            services.AddHttpContextAccessor();
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

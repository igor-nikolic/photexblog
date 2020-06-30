using System;
using System.Collections.Generic;
using System.Text;
using Api.Core;
using Application.DTO;
using Application.Email;
using Application.UseCase;
using EFDataAccess;
using Implementation.Email;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

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
            services.AddUseCases();
            services.AddValidators();           

            services.AddTransient<PostDto>();
            services.AddHttpContextAccessor();
            services.AddAplicationActor();
            services.AddTransient<IEmailSender, SMTPEmailSender>(x => new SMTPEmailSender(appSettings.MailFrom, appSettings.MailPassword));

            services.AddJWT(appSettings);            
            services.AddControllers();

            services.AddSwagger();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Swagger");
            });

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

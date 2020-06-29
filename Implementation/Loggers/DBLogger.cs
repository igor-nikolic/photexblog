using Application.UseCase;
using EFDataAccess;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Implementation.Loggers
{
    public class DBLogger : IUseCaseLogger
    {
        private readonly PhoTexBlogContext _context;

        public DBLogger(PhoTexBlogContext context)
        {
            _context = context;
        }

        public void Log(IUseCase useCase, IApplicationActor actor, object useCaseData)
        {
            _context.UseCaseLogs.Add(new Domain.UseCaseLog
            {
                Date = DateTime.UtcNow,
                Data = JsonConvert.SerializeObject(useCaseData),
                UseCaseId = useCase.Id,
                UserId = actor.Id
            });
            _context.SaveChanges();
        }
    }
}

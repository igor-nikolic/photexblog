using Application.DTO;
using Application.Exceptions;
using Application.Queries.UseCase;
using EFDataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Implementation.Queries.UseCase
{
    public class EfGetOneUseCaseQuery : IGetOneUseCaseQuery
    {
        private readonly PhoTexBlogContext _context;

        public EfGetOneUseCaseQuery(PhoTexBlogContext context)
        {
            _context = context;
        }

        public int Id => 29;

        public string Name => "Get One UseCase";

        public ReadUseCaseDto Execute(int search)
        {
            var usecase = _context.UseCases
                .Include(x => x.UseCaseLogs)
                .Include(x => x.UserUseCases)
                .SingleOrDefault(x => x.Id == search);

            if (usecase == null) throw new EntityNotFoundException(search, typeof(Domain.UseCase));

            return new ReadUseCaseDto 
            { 
                Id=usecase.Id,
                Name = usecase.Name,
                NumberOfUseCaseLogs = usecase.UseCaseLogs.Count(),
                NumberOfUsers = usecase.UserUseCases.Count()
            };
        }
    }
}

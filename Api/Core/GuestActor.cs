using Application.UseCase;
using System.Collections.Generic;

namespace Api.Core
{
    public class GuestActor : IApplicationActor
    {
        public int Id => 0;

        public string Identity => "Guest";

        public IEnumerable<int> AllowedUseCases => new List<int> { 1, 2, 3, 4, 5 };
    }
}

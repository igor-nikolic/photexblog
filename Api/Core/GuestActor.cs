using Application.UseCase;
using System.Collections.Generic;

namespace Api.Core
{
    public class GuestActor : IApplicationActor
    {
        public int Id => 0;

        public string Identity => "Guest";

        public IEnumerable<int> AllowedUseCases => new List<int> { 1,16,17,18,19,20,21,22,23,24,25 };
    }
}

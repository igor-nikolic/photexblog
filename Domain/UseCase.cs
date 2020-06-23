using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class UseCase
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public virtual ICollection<UserUseCase> UserUseCases { get; set; } = new HashSet<UserUseCase>();
        public virtual ICollection<UseCaseLog> UseCaseLogs { get; set; } = new HashSet<UseCaseLog>();
    }
}

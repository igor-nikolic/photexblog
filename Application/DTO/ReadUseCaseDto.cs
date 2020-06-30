using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTO
{
    public class ReadUseCaseDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumberOfUseCaseLogs { get; set; }
        public int NumberOfUsers { get; set; }
    }
}

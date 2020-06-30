using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTO
{
    public class ReadUserUseCaseDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int UseCaseId { get; set; }
        public string UserEmail { get; set; }
        public string UseCaseName { get; set; }
    }
}

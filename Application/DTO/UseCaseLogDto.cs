using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTO
{
    public class UseCaseLogDto
    {
        public int Id { get; set; }
        public string Data { get; set; }
        public DateTime Date { get; set; }
        public int UseCaseId { get; set; }
        public string UseCaseName { get; set; }
        public int UserId { get; set; }
        public string UserEmail { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class UseCaseLog 
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int UseCaseId { get; set; }
        public virtual UseCase UseCase { get; set; }
        public string Data { get; set; }
        public int? UserId { get; set; }
        public virtual User User { get; set; }
    }
}

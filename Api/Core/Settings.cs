using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Core
{
    public class Settings
    {
        public string SQLConnectionString { get; set; }
        public string JwtSecretKey { get; set; }
        public string JwtIssuer { get; set; }
        public string MailFrom { get; set; }
        public string MailPassword { get; set; }
    }
}

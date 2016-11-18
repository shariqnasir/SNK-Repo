using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KashmirFood.API.Models
{
    public class User
    {
        public Guid UserId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Active { get; set; }
        public bool Authenticated { get; set; }
        public string AuthCode { get; set; }
        public DateTime AuthSentOn { get; set; }
        public DateTime AuthExpiresOn { get; set; }

    }
}
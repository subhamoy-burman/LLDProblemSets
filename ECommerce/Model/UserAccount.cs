using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Model
{
    internal class UserAccount
    {
        public Guid UserId { get; set; }
        public string? UserName { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        = string.Empty;
        public int PhoneNumber { get; set; }
        public List<string>? Addresses { get; set; }
    }
}

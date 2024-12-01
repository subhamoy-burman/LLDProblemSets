using ATM.Models;
using ATM.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Services.Implementations
{
    internal class UserService : IUserService
    {
        public (UserTypes, bool) Authenticate(string cardNumber, string pin)
        {
            throw new NotImplementedException();
        }
    }
}

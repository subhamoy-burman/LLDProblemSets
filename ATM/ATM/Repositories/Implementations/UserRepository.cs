using ATM.Models;
using ATM.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Repositories.Implementations
{
    internal class UserRepository : IUserRepository
    {
        public (UserTypes, bool) AuthenticateUser(string Id, string pin)
        {
            throw new NotImplementedException();
        }
    }
}

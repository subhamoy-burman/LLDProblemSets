using ATM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Repositories.Interfaces
{
    internal interface IUserRepository
    {
        public (UserTypes, bool) AuthenticateUser(string Id, string pin);
        
    }
}

using ATM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Services.Interfaces
{
    internal interface IUserService
    {
        public (UserTypes, bool) Authenticate(string cardNumber, string pin)
        {
            throw new NotImplementedException();
        }
    }
}

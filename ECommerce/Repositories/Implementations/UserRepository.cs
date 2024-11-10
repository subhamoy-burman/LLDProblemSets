using ECommerce.Model;
using ECommerce.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Repositories.Implementations
{
    internal class UserRepository : IUserRepository
    {
        public void LogOut(UserAccount userInfo)
        {
            throw new NotImplementedException();
        }

        public void RegisterAsSeller(SellerAccount sellerUser)
        {
            throw new NotImplementedException();
        }

        public void RegisterBuyerWithPhoneNumber(UserAccount user, string phoneNumber)
        {
            throw new NotImplementedException();
        }

        public void UnregisterAsSeller(SellerAccount sellerUser)
        {
            throw new NotImplementedException();
        }
    }
}

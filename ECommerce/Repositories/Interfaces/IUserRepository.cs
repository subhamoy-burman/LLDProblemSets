using ECommerce.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Repositories.Interfaces
{
    internal interface IUserRepository
    {
        public void RegisterAsSeller(SellerAccount sellerUser);
        public void UnregisterAsSeller(SellerAccount sellerUser);
        public void RegisterBuyerWithPhoneNumber(UserAccount userInfo, string phoneNumber);
        public void LogOut(UserAccount userInfo);
    }
}

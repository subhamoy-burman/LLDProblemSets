using ECommerce.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Repositories.Interfaces
{
    internal interface IOrderRepository
    {
        public void PlaceOrder(Order order);
        public void CancelOrder(Order order);
    }
}

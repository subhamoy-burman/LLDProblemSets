using ECommerce.Model;
using ECommerce.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Repositories.Implementations
{
    internal class PaymentRepository : IPaymentRepository
    {
        public void MakePayment(Guid userId, Guid orderId, PaymentMode paymentMode, int amount)
        {
            throw new NotImplementedException();
        }
    }
}

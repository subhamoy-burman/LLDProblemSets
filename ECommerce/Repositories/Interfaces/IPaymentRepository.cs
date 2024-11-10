using ECommerce.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Repositories.Interfaces
{
    internal interface IPaymentRepository
    {
        public void MakePayment(Guid userId, Guid orderId, PaymentMode paymentMode, int amount);
    }
}

using ECommerce.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Infrastructure
{
    internal class PaymentService : IPaymentService
    {
        public void MakePayment(Guid userId, Guid orderId, PaymentMode paymentMode, int amount)
        {
            /*Suppose we are using RazorPay interface*/
            throw new NotImplementedException();
        }
    }
}

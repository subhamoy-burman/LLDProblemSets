using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Model
{
    internal class Payment
    {
        public Guid PaymentId { get; set; }
        public PaymentMode ModeOfPayment { get; set; }
        public int Amount { get; set; }
    }

    public enum PaymentMode
    {
        CASH, CREDIT_CARD, DEBIT_CARD, NEFT
    }


}

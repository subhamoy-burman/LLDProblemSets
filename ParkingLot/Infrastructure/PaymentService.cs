using ParkingLot.Infrastructure.Interface;
using ParkingLot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot.Infrastructure
{
    internal class PaymentService : IPaymentService
    {
        public IPaymentStrategy? GetPaymentInterface(PaymentMode mode)
        {
            if(mode == PaymentMode.UPI)
            {
                return new UPIPayment();
            }
            else if(mode == PaymentMode.CARD)
            {
                return new CardPayment();
            }
            else if(mode == PaymentMode.CASH)
            {
                return new CashPayment();
            }

            return null;
        }
    }
}

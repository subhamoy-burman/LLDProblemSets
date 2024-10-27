using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParkingLot.Infrastructure.Interface;

namespace ParkingLot.Infrastructure
{
    internal class CashPayment : IPaymentStrategy
    {
        public void MakePayement(int amount)
        {
            throw new NotImplementedException();
        }
    }
}

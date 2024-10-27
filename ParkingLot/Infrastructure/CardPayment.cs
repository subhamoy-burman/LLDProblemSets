using ParkingLot.Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot.Infrastructure
{
    internal class CardPayment : IPaymentStrategy
    {
        public void MakePayement(int amount)
        {
            throw new NotImplementedException();
        }
    }
}

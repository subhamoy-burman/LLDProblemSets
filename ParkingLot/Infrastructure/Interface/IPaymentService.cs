﻿using ParkingLot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot.Infrastructure.Interface
{
    internal interface IPaymentService
    {
        IPaymentStrategy? GetPaymentInterface(PaymentMode mode);
    }
}

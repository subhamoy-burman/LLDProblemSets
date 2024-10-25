using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot.Models
{
    internal class VehiclePayment
    {
        public Guid VehiclePaymentId { get; set; }
        public int AmountCharged { get; set; }
        public PaymentMode PaymentMode { get; set; }
        public PaidTo? PaidToEntity { get; set; } = null;

    }

    public enum PaidTo
    {
        EXIT_PANEL,
        ATTENDANT,
        FLOOR_INFO_PORTAL
    }
}

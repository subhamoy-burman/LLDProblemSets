using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot.Models
{
    internal class ParkingUnit
    {
        public Guid ParkingUnitId { get; set; }
        public ParkingUnitType ParkingUnitType { get; set; }
        public bool IsAvailable { get; set; }
    }

    public enum ParkingUnitType
    {
        EV,
        Truck,
        Bike,
        LMV_CAR,
        HandiCapped
    }
}

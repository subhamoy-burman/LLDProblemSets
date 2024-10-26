using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot.Models
{
    internal class Vehicle
    {
        public int Id { get; set; }
        public string? VehicleNumberPlate { get; set; }
        public DateTime VehicleEntryTime { get; set; }
        public DateTime VehicleExitTime { get; set; }
        public VehicleType ParkingVehicleType { get; set; }
        public int AmountCharged { get; set; }
        public EntryPoint EntryPoint { get; set; }
        public PaymentMode PaymentMode { get; set; }
        public ExitPoint ExitPoint { get; set; }
        public ParkingUnit ParkingUnit { get; set; }
        public VehiclePayment VehiclePayment { get; set; }


    }


    public enum VehicleType
    {
        COMPACT,
        LARGE,
        EV,
        BIKE,
        Handicapped
    }

    public enum PaymentMode
    {
        CASH,
        CARD,
        UPI
    }
}

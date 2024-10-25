using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot.Models
{
    internal class ParkingLot
    {   
        public List<ParkingLevel> ParkingLevels { get; set; } 
        public List<EntryPoint> EntryPoints { get; set; }
        public List<ExitPoint> ExitPoints { get; set; }


        public List<(Guid,int)> GetLevelWiseEmptyParkingNumbers()
        {
            // First Guid for Parking Level
            // Second Guid for Parking Unit Level
            return new List<(Guid,int)>();
        }

        public List<(VehicleType, int)> GetVehicleTypeWiseEmptySlot()
        {
            return new List<(VehicleType, int)>();
        }
    }
}

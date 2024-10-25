using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot.Models
{
    internal class ParkingLevel
    {
        public Guid ParkingLevelId { get; set; }
        public int ParkingLevelNumber { get; set; }
        public List<ParkingUnit> ParkingUnits { get; set; } = new List<ParkingUnit>();

        public List<(VehicleType, int)> GetFreeParkingSpotForLevel()
        {
            return new List<(VehicleType, int)>();
        }
        
    }

}

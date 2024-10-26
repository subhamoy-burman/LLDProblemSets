using ParkingLot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot.Repositories.Interfaces
{
    internal interface IParkingRepository
    {
        void SaveParkingLot(ParkingLotModel parkingLot);
        List<(Guid, int)> GetLevelWiseEmptyParkingNumbers();
        List<(VehicleType, int)> GetVehicleTypeWiseEmptySlot();
        List<(VehicleType, int)> GetFreeParkingSpotForLevel();
        
    }
}

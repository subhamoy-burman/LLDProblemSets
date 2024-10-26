using ParkingLot.Models;
using ParkingLot.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot.Repositories.Implementations
{
    internal class ParkingLotRepository : IParkingRepository
    {
        public List<(VehicleType, int)> GetFreeParkingSpotForLevel()
        {
            throw new NotImplementedException();
        }

        public List<(Guid, int)> GetLevelWiseEmptyParkingNumbers()
        {
            throw new NotImplementedException();
        }

        public List<(VehicleType, int)> GetVehicleTypeWiseEmptySlot()
        {
            throw new NotImplementedException();
        }

        public void SaveParkingLot(ParkingLotModel parkingLot)
        {
            throw new NotImplementedException();
        }
    }
}

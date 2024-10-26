using ParkingLot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot.Repositories.Interfaces
{
    internal interface IParkingUnitRepository
    {
        void ReserveParking(ParkingUnit parkingUnit);
        void ReleaseParking(ParkingUnit parkingUnit);
    }
}

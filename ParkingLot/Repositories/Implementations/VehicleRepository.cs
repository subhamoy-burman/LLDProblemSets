using ParkingLot.Models;
using ParkingLot.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot.Repositories.Implementations
{
    internal class VehicleRepository : IVehicleRepository
    {
        public void EnterTheParkingLot(EntryPoint entryPoint, Vehicle vehicle)
        {
            throw new NotImplementedException();
        }

        public void MakeExit(ExitPoint exitPoint, Vehicle vehicle)
        {
            throw new NotImplementedException();
        }

        public int GetPaymentAmount(Vehicle vehicle)
        {
            throw new NotImplementedException();
        }

        public void ParkTheCar(ParkingUnit parkingUnit, Vehicle vehicle)
        {
            throw new NotImplementedException();
        }
    }
}

using ParkingLot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot.Repositories.Interfaces
{
    internal interface IVehicleRepository
    {
        void ParkTheCar(ParkingUnit parkingUnit, Vehicle vehicle);
        void EnterTheParkingLot(EntryPoint entryPoint, Vehicle vehicle);
        int GetPaymentAmount(Vehicle vehicle);
        void MakeExit(ExitPoint exitPoint, Vehicle vehicle);

    }
}

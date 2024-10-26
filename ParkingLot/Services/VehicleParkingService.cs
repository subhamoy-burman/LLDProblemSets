using ParkingLot.Models;
using ParkingLot.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot.Services
{
    internal class VehicleParkingService
    {
        private readonly IParkingRepository _parkingRepository;
        private readonly IParkingUnitRepository _parkingUnitRepository;
        private readonly IVehicleRepository _vehicleRepository;
        public VehicleParkingService(IParkingRepository parkingRepository, 
            IParkingUnitRepository parkingUnitRepository, IVehicleRepository vehicleRepository)
        {
            _parkingRepository = parkingRepository;
            _parkingUnitRepository = parkingUnitRepository;
            _vehicleRepository = vehicleRepository;
        }

        public void ParkCar(ParkingUnit parkingUnit, Vehicle vehicle)
        {
            _vehicleRepository.ParkTheCar(parkingUnit, vehicle);
            _parkingUnitRepository.ReserveParking(parkingUnit); //Not necessary becasuse while parking car only we can do all the operations for reserve parking
        }

        public void EnterParkingLot(EntryPoint entryPoint, Vehicle vehicle)
        {
            _vehicleRepository.EnterTheParkingLot(entryPoint, vehicle);
        }

        public void ExitParkingLot(ExitPoint exitPoint, Vehicle vehicle)
        {
            _vehicleRepository.MakeExit(exitPoint, vehicle);
        }

        public void MakePayment(Vehicle vehicle, PaymentMode mode) {

            _vehicleRepository.MakePayment(mode, vehicle);
        }

    }
}

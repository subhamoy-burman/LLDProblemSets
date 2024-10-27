using ParkingLot.Infrastructure.Interface;
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
        private readonly IPaymentService _paymentService;
        public VehicleParkingService(IParkingRepository parkingRepository, 
            IParkingUnitRepository parkingUnitRepository, IVehicleRepository vehicleRepository, IPaymentService paymentService)
        {
            _parkingRepository = parkingRepository;
            _parkingUnitRepository = parkingUnitRepository;
            _vehicleRepository = vehicleRepository;
            _paymentService = paymentService;
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
            _parkingUnitRepository.ReleaseParking(vehicle.ParkingUnit); // Not necessary as in Make Exit function only we can release the Parking spot
        }

        public void MakePayment(Vehicle vehicle, PaymentMode mode) {

            IPaymentStrategy paymentStrategy = _paymentService.GetPaymentInterface(mode)!;
            paymentStrategy.MakePayement(_vehicleRepository.GetPaymentAmount(vehicle));
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot.Models
{
    internal class ParkingLotModel
    {   
        public List<ParkingLevel> ParkingLevels { get; set; } 
        public List<EntryPoint> EntryPoints { get; set; }
        public List<ExitPoint> ExitPoints { get; set; }

    }
}

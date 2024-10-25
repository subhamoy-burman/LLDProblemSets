using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot.Models
{
    internal class ExitPoint
    {
        public Guid ExitPointId { get; set; }
        public string ExitPointName { get; set; } = string.Empty;
    }
}

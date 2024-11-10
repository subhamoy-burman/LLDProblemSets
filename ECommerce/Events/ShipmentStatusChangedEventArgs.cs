using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Events
{
    public delegate void ShipmentStatusChangedEventHandler(object sender, ShipmentStatusChangedEventArgs e);

    public class ShipmentStatusChangedEventArgs : EventArgs
    {
        public Guid ShipmentId { get; }
        public string NewStatus { get; }
        public DateTime StatusChangeTime { get; }

        public ShipmentStatusChangedEventArgs(Guid shipmentId, string newStatus, DateTime statusChangeTime)
        {
            ShipmentId = shipmentId;
            NewStatus = newStatus;
            StatusChangeTime = statusChangeTime;
        }
    }
}

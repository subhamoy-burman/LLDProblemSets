using ECommerce.Events;

namespace ECommerce.Model
{
    public class OrderShipmentDetails
    {
        public Guid ShipmentId { get; set; }
        public string ShipmentName { get; set; }
        public List<string> ShipmentStatusList { get; set; }

        private string _shipmentStatus;
        public string ShippingStatus { get => _shipmentStatus
                set {
                _shipmentStatus = value;
                OnShipmentStatusChange();
            }
            }

        private void OnShipmentStatusChange()
        {
            ShipmentStatusChanged.Invoke(this, new ShipmentStatusChangedEventArgs(ShipmentId, ShippingStatus, DateTime.Now));
        }

        public event ShipmentStatusChangedEventHandler ShipmentStatusChanged;

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Model
{
    internal class Order
    {
        public Guid OrderId { get; set; }
        public Guid ProductId { get; set; }
        public string ShippingAddress { get; set; }
        public OrderShipmentDetails OrderShipmentDetails { get; set; }
        public OrderStatus  OrderStatus { get; set; }
    }

    public enum OrderStatus
    {
        ON_THE_WAY, CANCELLED, RETURN_REQUESTED, RETURNED, DELIVERED
    }
}

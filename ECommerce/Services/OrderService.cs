using ECommerce.Infrastructure;
using ECommerce.Model;
using ECommerce.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Services
{
    internal class OrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly INotificationRepository _notificationRepository;
        private readonly IPaymentService _paymentService;
        public OrderService(IOrderRepository orderRepository, IPaymentService paymentService, INotificationRepository notificationRepository) {
        
            _orderRepository = orderRepository;
            _paymentService = paymentService;
            _notificationRepository = notificationRepository;

        }

        public void PlaceOrder(Order order)
        {
            _orderRepository.PlaceOrder(order);
        }

        public void CancelOrder(Order order)
        {
            _orderRepository.CancelOrder(order);
        }

        public void MakePayment(Order order, UserAccount user) {

            int orderValue = calculateOrderValue(order);
            _paymentService.MakePayment(user.UserId, order.OrderId, PaymentMode.NEFT, orderValue);

        }

        private int calculateOrderValue(Order order)
        {
            throw new NotImplementedException();
        }

        public void UpdateShipmentStatus(OrderShipmentDetails orderShipment) {
            orderShipment.ShipmentStatusChanged += OrderShipment_ShipmentStatusChanged;

        }

        private void OrderShipment_ShipmentStatusChanged(object sender, Events.ShipmentStatusChangedEventArgs e)
        {
            _notificationRepository.SendNotification(sender, e);
        }
    }
}

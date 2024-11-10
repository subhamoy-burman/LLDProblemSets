using ECommerce.Events;
using ECommerce.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Repositories.Implementations
{
    internal class NotificationRepository : INotificationRepository
    {
        public void SendNotification(object sender, ShipmentStatusChangedEventArgs e)
        {
            
        }
    }
}

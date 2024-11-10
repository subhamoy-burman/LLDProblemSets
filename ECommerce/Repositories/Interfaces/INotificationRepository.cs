using ECommerce.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Repositories.Interfaces
{
    public interface INotificationRepository
    {
        void SendNotification(object sender, ShipmentStatusChangedEventArgs e);
    }
}

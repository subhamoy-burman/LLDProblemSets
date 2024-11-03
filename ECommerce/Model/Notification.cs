using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Model
{
    internal class Notification
    {
        public Guid NotificationId { get; set; }
        public string Content { get; set; }
        public NotificationType MyProperty { get; set; }
    }

    public enum NotificationType
    {
        EMAIL, SMS, PUSH_NOTIFICATION
    }
}

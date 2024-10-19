using LibraryManagement.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Models
{
    internal class NotificationSubscription
    {
        public Guid NotificationId { get; set; }
        public string? BookISBN { get; set; }
        public string? MembershipID { get; set; }
        public NotificationType TypeOfNotification { get; set; }
        public string? NotificationContent { get; set; }
        public DateTime? CreatedTime { get; set; }
    }
}

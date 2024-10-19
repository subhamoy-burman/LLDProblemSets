using LibraryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Services.Factories.Interface
{
    internal interface INotificationFactory
    {
        void ScheduleNotification(Members member, NotificationSubscription notificationSubscription);
    }
}

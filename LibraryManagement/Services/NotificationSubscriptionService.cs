using LibraryManagement.Models;
using LibraryManagement.Repositories.Interfaces;
using LibraryManagement.Services.Factories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Services
{
    internal class NotificationSubscriptionService
    {
        private readonly INotificationSubscription _notificationSubscription;
        private readonly INotificationFactory _notificationFactory;
        public NotificationSubscriptionService(INotificationSubscription notificationSubscription, INotificationFactory notificationFactory) {
            _notificationSubscription = notificationSubscription;
            _notificationFactory = notificationFactory;
        }

        public void NotifyMe(Members member, string ISBN, NotificationSubscription notificationSubscription)
        {
            _notificationSubscription.AddNotificationSubscription(member, ISBN);
            _notificationFactory.ScheduleNotification(member, notificationSubscription);
        }

        public void CancelMyNotification(Members member, string ISBN, NotificationSubscription notificationSubscription)
        {
            _notificationSubscription.CancelNotificationSubscription(member, ISBN);
            _notificationFactory.ScheduleNotification(member, notificationSubscription);
        }

    }
}

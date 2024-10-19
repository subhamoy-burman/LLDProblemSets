using LibraryManagement.Models;
using LibraryManagement.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Repositories
{
    internal class NotificationSubscriptionRepository : INotificationSubscription
    {
        public void AddNotificationSubscription(Members user, string ISBN)
        {
            throw new NotImplementedException();
        }

        public void CancelNotificationSubscription(Members user, string ISBN)
        {
            throw new NotImplementedException();
        }
    }
}

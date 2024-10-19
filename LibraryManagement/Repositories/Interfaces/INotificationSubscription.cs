using LibraryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Repositories.Interfaces
{
    internal interface INotificationSubscription
    {
        void AddNotificationSubscription(Members user, string ISBN);
        void CancelNotificationSubscription(Members user, string ISBN);
        
    }
}

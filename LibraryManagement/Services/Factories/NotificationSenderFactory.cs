using LibraryManagement.Infrastructure.Interfaces;
using LibraryManagement.Models;
using LibraryManagement.Services.Factories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Services.Factories
{
    internal class NotificationSenderFactory : INotificationFactory
    {
        private readonly IScheduleEmail _scheduledEmail;
        private readonly IScheduleSms _scheduledSms;
        private readonly IScheduleWhatsApp _scheduledWhatsApp;

        public NotificationSenderFactory(IScheduleEmail email, IScheduleSms sms, IScheduleWhatsApp whatsApp)
        {
            _scheduledEmail = email;
            _scheduledSms = sms;
            _scheduledWhatsApp = whatsApp;
        }

        public void ScheduleNotification(Members member, NotificationSubscription notificationSubscription)
        {
            if(notificationSubscription.TypeOfNotification == Models.Enums.NotificationType.Email)
            {
                _scheduledEmail.ScheduleEmail(member);
            }
            else if(notificationSubscription.TypeOfNotification == Models.Enums.NotificationType.SMS)
            {
                _scheduledSms.ScheduleSms(member);
            }
            else if(notificationSubscription.TypeOfNotification == Models.Enums.NotificationType.WhatsApp)
            {
                _scheduledWhatsApp.ScheduleWhatsAppMessage(member);
            }
            
        }
    }
}

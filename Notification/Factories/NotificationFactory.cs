using Notification.ConcreateClasses;
using Notification.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Notification.Factories
{
    public class NotificationFactory
    {
        public INotification CreateNotification(string notificationType)
        {
            switch(notificationType.ToLower())
            {
                case "email":
                    return new EmailNotification();
                case "sms":
                    return new SMSNotification();
                default:
                    throw new ArgumentException("Unknown notification type.");
            }

        }
    }
}
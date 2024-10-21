using Notification.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Notification.ConcreateClasses
{
    public class SMSNotification : INotification
    {
        public void Notify(string message)
        {
            System.Diagnostics.Debug.WriteLine($"SMS Notification: {message}");
        }
    }
}
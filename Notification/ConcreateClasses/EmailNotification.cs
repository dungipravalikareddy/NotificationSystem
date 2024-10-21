using Notification.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Notification.ConcreateClasses
{
    public class EmailNotification: INotification
    {
        public void Notify(string message)
        {
            System.Diagnostics.Debug.WriteLine($"Email Notification: {message}");
        }
    }
}
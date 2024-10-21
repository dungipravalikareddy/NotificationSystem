﻿using Notification.Factories;
using Notification.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web.Management;

namespace Notification
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1

    {
        public string SendNotification(Payload payload)
        {
            try
            {
                NotificationFactory factory = new NotificationFactory();
                INotification notification = factory.CreateNotification(payload.Type);

                notification.Notify(payload.Message);

                return $"{payload.Message}:{payload.Type} Notification sent successfully!";
            }
            catch (ArgumentException ex)
            {
                return ex.Message;

            }
        }
    }
}

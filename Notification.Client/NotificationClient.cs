using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification.Client
{
    public class NotificationClient
    {
        public  string CallServiceMethod(string message, string type)
        {

            // Create an instance of the client


            using (Service1Client client = new Service1Client())
            {
                // Create a new Payload object
                Payload payload = new Payload
                {
                    Message = message,
                    Type = type
                };


                try
                {
                    // Call the SendNotification method
                    string response = client.SendNotification(payload);

                    // Output the response from the service
                    System.Console.WriteLine("Service response: " + response);


                    return response; 
                }
                catch (Exception ex)
                {
                 
                    throw new Exception("Error occurred while sending notification: " + ex.Message, ex);
                }

            }
        }
    }
}

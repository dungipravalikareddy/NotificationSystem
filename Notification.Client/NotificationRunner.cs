using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification.Client
{
    public class NotificationRunner
    {

        public void RunClient()
        {
            var notificationService = new NotificationClient();

            try
            {

                string response = notificationService.CallServiceMethod("This is test Message", "email");


            }
            catch (Exception ex)
            {
                // Handle the error accordingly
                Console.WriteLine("Error occurred: " + ex.Message);
            }
        }




       
    }
}

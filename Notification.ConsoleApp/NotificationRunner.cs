using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification.ConsoleApp
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
                System.Console.WriteLine("Error occurred: " + ex.Message);
            }
        }




       
    }
}

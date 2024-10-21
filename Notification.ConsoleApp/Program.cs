using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Notification.Client;

namespace Notification.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of NotificationRunner (assuming this is from the Notification.Client)
            NotificationRunner runner = new NotificationRunner();

            // Run the client to send the notification
            runner.RunClient();

            // Output message to the console
            Console.WriteLine("Notification sent."); // Explicitly use System.Console to avoid conflict
            Console.ReadLine(); // Keep the console open

        }
    }
}

using Notification.Client;
using System; // Ensure this is present


namespace Notification.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of NotificationRunner (assuming this is from the Notification.Client)
            NotificationRunner runner = new NotificationRunner();

            // Run the client to send the notification
            runner.RunClient();

            // Output message to the console
            System.Console.WriteLine("Notification sent."); // Explicitly use System.Console to avoid conflict
        }
    }
}
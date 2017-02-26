using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeProjectDecoupling
{
    public interface INotificationAction
    {
        void ActOnNotification(string message);
    }

    class EventLogWriter : INotificationAction
    {
        public void ActOnNotification(string message)
        {
            Console.WriteLine($"Log Entry:{message}");
        }
    }

    class EmailSender : INotificationAction
    {
        public void ActOnNotification(string message)
        {
            Console.WriteLine($"Email Sent:{message}");
        }
    }

    class SMSAlert : INotificationAction
    {
        public void ActOnNotification(string message)
        {
            Console.WriteLine($" SMS Alert: {message}");
        }
    }
}

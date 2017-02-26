using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeProjectDecoupling
{
    class Program
    {
        static Random rand = new Random();
        public static void Main(string[] args)
        {
            AppPoolWatcher watcher = null;
            // We're declaring that writer 'can do' ActOnNotification(), not that it 'is a' anything
            INotificationAction writer;
            for (int i = 0; i < 9; i++)
            {
                int level = rand.Next(3);
                // Severity level :
                // 0: Log
                // 1: Email
                // 2: SMS
                // I'm assuming the Business requirements state to only do one of these things each time
                switch (level)
                {
                    case 2:
                        {
                            // NOW we're declaring that writer 'is a' SMSSender
                            writer = new SMSAlert();
                            watcher = new AppPoolWatcher();
                            // The calling class sends the action and the message directly to Notify()
                            watcher.Notify(writer,"*** TEXT Alert ***");
                            break;
                        }
                    case 1:
                        {
                            // NOW we're declaring that writer 'is a' EmailSender
                            writer = new EmailSender();
                            watcher = new AppPoolWatcher();
                            // The calling class sends the action and the message directly to Notify()
                            watcher.Notify(writer,"** Email Alert **");
                            break;

                        }
                    case 0:
                        {
                            // NOW we're declaring that writer 'is a' EventLogWriter
                            writer = new EventLogWriter();
                            watcher = new AppPoolWatcher();
                            // The calling class sends the action and the message directly to Notify()
                            watcher.Notify(writer, "* Here's my message *");
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            }


            
            Console.ReadKey();
        }
    }
}

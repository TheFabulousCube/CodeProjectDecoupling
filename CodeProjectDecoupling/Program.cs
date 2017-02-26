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
            // In Proterty Injection, I've set the concrete classes as openly available
            EventLogWriter writer = new EventLogWriter();
            EmailSender sender = new EmailSender();
            SMSAlert texter = new SMSAlert();
            AppPoolWatcher watcher = new AppPoolWatcher(); 

            for (int i = 0; i < 25; i++)
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
                            // One part of the program may decide which concrete class to use . . .
                            watcher.Action = texter;
                            break;
                        }
                    case 1:
                        {
                            // One part of the program may decide which concrete class to use . . .
                            watcher.Action = sender;
                            break;

                        }
                    case 0:
                        {
                            // One part of the program may decide which concrete class to use . . .
                            watcher.Action = writer;
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
                // . . . and then another part decides what parameter to send
                watcher.Notify("Notification from Main()");
            }


            
            Console.ReadKey();
        }
    }
}

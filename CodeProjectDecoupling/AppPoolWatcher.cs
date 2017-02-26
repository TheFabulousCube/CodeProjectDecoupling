using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeProjectDecoupling
{
    class AppPoolWatcher
    {
        INotificationAction action = null;
 

        public void Notify(string message, int level)
        {
            INotificationAction action = null;
            // Severity level :
            // 0: Log
            // 1: Email
            // 2: SMS
            // I'm assuming the Business requirements state to only do one of these things each time
            switch (level)
            {
                case 2:
                    {
                        if (action == null)
                        {
                            action = new SMSAlert();
                        }
                        break;
                    }
                case 1:
                    {
                        if (action == null)
                        {
                            action = new EmailSender();
                        }
                        break;

                    }
                case 0:
                    {
                        if (action == null)
                        {
                            action = new EventLogWriter();
                        }
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
            action.ActOnNotification(message);
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeProjectDecoupling
{
    class AppPoolWatcher
    {
        EventLogWriter writer = null;
        EmailSender email = null;
        SMSAlert sms = null;

        // Severity level :
        // 0: Log
        // 1: Email
        // 2: SMS
        // I'm assuming the Business requirements state to only do one of these things each time
        public void Notify(string message, int level)
        {
            // protect against invalid severity levels
            level = (level > 2) ? 2 : level;
            level = (level < 0) ? 0 : level;
            switch (level)
            {
                case 2:
                    {
                        if (sms == null)
                        {
                            sms = new SMSAlert();
                        }
                        sms.Text(message);
                        break;
                    }
                case 1:
                    {
                        if (email == null)
                        {
                            email = new EmailSender();
                        }
                        email.Send(message);

                        break;

                    }
                case 0:
                    {
                        if (writer == null)
                        {
                            writer = new EventLogWriter();
                        }
                        writer.Write(message);
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
            if (level >= 1)
            {
            }
        }
    }

    class EventLogWriter
    {
        public void Write(string message)
        {
            Console.WriteLine($"Log Entry:{message}");
        }
    }

    class EmailSender
    {
        public void Send(string message)
        {
            Console.WriteLine($"Email Sent:{message}");
        }
    }

    class SMSAlert
    {
        public void Text(string message)
        {
            Console.WriteLine($" SMS Alert: {message}");
        }
    }
}

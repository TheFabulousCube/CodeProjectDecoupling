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

        // The action is now a property that can be set publicly by the calling class
        // Be careful if another class changes the parameter for 'Action'
        public INotificationAction Action
        {
            get { return action; }
            set { action = value; }
        }
        // Any class or method may send a message
        public void Notify(string message)
        {
            action.ActOnNotification(message);
        }
    }

}

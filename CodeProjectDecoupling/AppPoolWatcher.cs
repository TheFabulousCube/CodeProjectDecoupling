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
        // Using Constructor Injection
        // Now we've put the responsibility of selecting which method back on the
        // calling class (in this case, Main())

            // With Method injection the AppPoolWatcher doesn't handle creating classes, they are passed in directly.

        public void Notify(INotificationAction concreteAction, string message)
        {
            this.action = concreteAction;
            action.ActOnNotification(message);
        }
    }

}

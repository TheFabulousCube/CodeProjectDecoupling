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
        public AppPoolWatcher(INotificationAction concreteImplemetation)
        {
            this.action = concreteImplemetation;
        }

        public void Notify(string message)
        {

            action.ActOnNotification(message);
        }
    }

}

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
}

using Exo_Observer.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Observer.Interfaces
{
    public interface IObserver
    {
        public void Update(ISubject sender, NotificationEventArgs e);
        
    }
}

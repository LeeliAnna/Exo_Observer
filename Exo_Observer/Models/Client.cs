using Exo_Observer.Events;
using Exo_Observer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Observer.Models
{
    public class Client : IObserver
    {
        public void Update(ISubject sender, NotificationEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}

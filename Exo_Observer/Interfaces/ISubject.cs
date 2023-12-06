using Exo_Observer.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Observer.Interfaces
{
    public interface ISubject
    {
        //protected Action<ISubject,NotificationEventArgs> ObserverEvent { get; set; }

        public string Description { get; set; }

        public void Abonnement(IObserver observer);

        public void Desabonnement(IObserver observer);

        public void Notification(ISubject sender, NotificationEventArgs e);
    }
}

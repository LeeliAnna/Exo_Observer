using Exo_Observer.Events;
using Exo_Observer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Observer.Models
{
    public class Media : ISubject
    {

        public string Name { get; set; }
        public string Description { get; set; }

        public Media(string name, string description)
        {
            Name = name;
            Description = description;
        }

        Action<ISubject, NotificationEventArgs> ObserverEvent { get; set; }

        public void Abonnement(IObserver observer)
        {
            ObserverEvent += observer.Update;
        }

        public void Desabonnement(IObserver observer)
        {
            if (ObserverEvent is not null)
            {
                ObserverEvent -= observer.Update;
            }
        }

        public void Notification(ISubject sender, NotificationEventArgs e)
        {
            ObserverEvent?.Invoke(sender, e);
        }

        
    }
}

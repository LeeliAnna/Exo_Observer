using Exo_Observer.Events;
using Exo_Observer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Observer.Models
{
    public class Magazine : ISubject
    {

        public string Name { get; set; }

        public Magazine(string name)
        {
            Name = name;
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

        public void Notification()
        {
            ObserverEvent?.Invoke(this, new NotificationEventArgs());
         
        }

        
    }
}

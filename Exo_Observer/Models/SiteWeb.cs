using Exo_Observer.Events;
using Exo_Observer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Observer.Models
{
    public class SiteWeb : ISubject
    {
        Action<ISubject, NotificationEventArgs> ISubject.ObserverEvent { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Abonnement(IObserver observer)
        {
            throw new NotImplementedException();
        }

        public void Desabonnement(IObserver observer)
        {
            throw new NotImplementedException();
        }

        public void Notification()
        {
            throw new NotImplementedException();
        }

        void ISubject.Abonnement(IObserver observer)
        {
            throw new NotImplementedException();
        }

        void ISubject.Desabonnement(IObserver observer)
        {
            throw new NotImplementedException();
        }

        void ISubject.Notification()
        {
            throw new NotImplementedException();
        }
    }
}

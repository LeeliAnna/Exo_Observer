using Exo_Observer.Enums;
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

        public string Name { get; set; }


        public Client(string name)
        {
            Name = name;
        }


        
        public void Update(ISubject sender, NotificationEventArgs e)
        {
            if (sender is Magazine magazine)
            {
                switch (e._notificationType)
                {
                    case NotificationType.Publicite:
                        Console.WriteLine($"Client {Name}, notifier pour une publicité par {magazine}.");
                        break;
                    case NotificationType.Nouveaute:
                        Console.WriteLine($"Client {Name}, notifier pour une nouveauté par {magazine}.");
                        break;
                }
            }
            else if (sender is SiteWeb site)
            {
                switch (e._notificationType)
                {
                    case NotificationType.Publicite:
                        Console.WriteLine($"Client {Name}, notifier pour une publicité par {site}.");
                        break;
                    case NotificationType.Nouveaute:
                        Console.WriteLine($"Client {Name}, notifier pour une nouveauté par {site}.");
                        break;
                }
            }

        }
    }
}

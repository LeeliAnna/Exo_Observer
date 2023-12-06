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
            if (sender is not null)
            {
                switch (e._notificationType)
                {
                    case NotificationType.Publicite:
                        Console.WriteLine($"Client {Name}, notifié pour une publicité par {sender.Description}.");
                        break;
                    case NotificationType.Nouveaute:
                        Console.WriteLine($"Client {Name}, notifié pour une nouveauté par {sender.Description}.");
                        break;
                }
            }
            

        }
    }
}

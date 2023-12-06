using Exo_Observer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Observer.Events
{
    public class NotificationEventArgs : EventArgs
    {
        // Créaion des propriété de mon évènement
        public NotificationType _notificationType { get; set; }

        public string Message { get; set; }

        // Constructeur d'évènement
        public NotificationEventArgs(NotificationType notificationType, string message)
        {
            _notificationType = notificationType;
            Message = message;
        }

    }
}

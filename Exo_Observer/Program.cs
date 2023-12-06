using Exo_Observer.Models;

namespace Exo_Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client Coucou = new Client("Coucou");
            Client Hibou = new Client("Hibou");
            Client Chouchou = new Client("Chouchou");

            Media MonMagazine = new Media("Tutu", "magazine");
            Media MonSite = new Media("Amazon", "site web");

            MonMagazine.Abonnement(Hibou);
            MonMagazine.Abonnement(Coucou);
            MonSite.Abonnement(Chouchou);

            MonMagazine.Notification(MonMagazine, new Events.NotificationEventArgs(Enums.NotificationType.Publicite, "Nouvelle recette de cuisine inrattable!"));
            MonSite.Notification(MonSite, new Events.NotificationEventArgs(Enums.NotificationType.Nouveaute, "Nouvel promos pour vous!"));


        }
    }
}
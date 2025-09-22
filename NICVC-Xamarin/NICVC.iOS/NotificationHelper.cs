using NICVC.iOS;
using NICVC.Notification;
using Xamarin.Forms;

[assembly: Dependency(typeof(NotificationHelper))]
namespace NICVC.iOS
{
    class NotificationHelper : INotification
    {
        public void CreateNotification(string title, string message)
        {
            new NotificationDelegate().RegisterNotification(title, message);
        }
    }
}
namespace Avans_DevOps.Domain.ObserverPattern
{
    public interface INotificationListener
    {
        public string SendNotification(string message);
        public string Update(string message);
    }
}

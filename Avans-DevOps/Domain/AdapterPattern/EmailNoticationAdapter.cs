using Avans_DevOps.Domain.ObserverPattern;

namespace Avans_DevOps.Domain.AdapterPattern
{
    public class EmailNoticationAdapter : INotificationListener
    {
        private EmailThirdPartyLibary _emailThirdPartyLibary;
        public EmailNoticationAdapter()
        {
            _emailThirdPartyLibary = new EmailThirdPartyLibary();
        }
        public string SendNotification(string message)
        {
            return _emailThirdPartyLibary.SendEmail(message);
        }

        public string Update(string message)
        {
            return _emailThirdPartyLibary.Update(message);
        }
    }
}

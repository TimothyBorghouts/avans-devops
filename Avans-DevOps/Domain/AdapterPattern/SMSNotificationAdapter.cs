using Avans_DevOps.Domain.ObserverPattern;

namespace Avans_DevOps.Domain.AdapterPattern
{
    public class SMSNotificationAdapter : INotificationListener
    {
        private SMSThirdPartyLibary _smsThirdPartyLibary;
        public SMSNotificationAdapter()
        {
            _smsThirdPartyLibary = new SMSThirdPartyLibary();
        }
        public string SendNotification(string message)
        {
            return _smsThirdPartyLibary.SendSMS(message);
        }

        public string Update(string message)
        {
            return _smsThirdPartyLibary.Update(message);
        }
    }
}

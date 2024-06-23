using Avans_DevOps.Domain.ObserverPattern;

namespace Avans_DevOps.Domain.AdapterPattern
{
    public class SlackNoticationAdapter : INotificationListener
    {
        private SlackThirdPartyLibary _slackThirdPartyLibary;
        public SlackNoticationAdapter()
        {
            _slackThirdPartyLibary = new SlackThirdPartyLibary();
        }

        public string SendNotification(string message)
        {
            return _slackThirdPartyLibary.SendSlack(message);
        }

        public string Update(string message)
        {
            return _slackThirdPartyLibary.Update(message);
        }
    }
}

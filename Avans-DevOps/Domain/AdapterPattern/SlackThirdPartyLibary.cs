namespace Avans_DevOps.Domain.AdapterPattern
{
    public class SlackThirdPartyLibary
    {
        public SlackThirdPartyLibary()
        {
        }

        public string SendSlack(string message)
        {
            return $"Slack: {message}";
        }

        public string Update(string message)
        {
            return $"Updating...";
        }
    }
}

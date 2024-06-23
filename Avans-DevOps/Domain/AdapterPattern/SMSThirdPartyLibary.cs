namespace Avans_DevOps.Domain.AdapterPattern
{
    public class SMSThirdPartyLibary
    {
        public SMSThirdPartyLibary()
        {
        }
        public string SendSMS(string message)
        {
            return $"SMS: {message}";
        }

        public string Update(string message)
        {
            return $"Updating...";
        }
    }
}

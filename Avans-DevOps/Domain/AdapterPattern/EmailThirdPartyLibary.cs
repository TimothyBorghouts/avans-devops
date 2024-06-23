namespace Avans_DevOps.Domain.AdapterPattern
{
    public class EmailThirdPartyLibary
    {
        public EmailThirdPartyLibary()
        {
        }
        public string SendEmail(string message)
        {
            return $"Email: {message}";
        }

        public string Update(string message)
        {
            return $"Updating...";
        }
    }
}

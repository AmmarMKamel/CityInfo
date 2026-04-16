namespace CityInfo.API.Services
{
    public class CloudMailService : IMailService
    {
        private readonly string _mailFrom;
        private readonly string _mailTo;

        public CloudMailService(IConfiguration configuration)
        {
            _mailFrom = configuration["mailSettings:mailFromAddress"]!;
            _mailTo = configuration["mailSettings:mailToAddress"]!;
        }

        public void SendEmail(string subject, string message)
        {
            Console.WriteLine($"Mail from {_mailFrom} to {_mailTo}, with {nameof(CloudMailService)}");
            Console.WriteLine($"Subject: {subject}");
            Console.WriteLine($"Message: {message}");
        }
    }
}

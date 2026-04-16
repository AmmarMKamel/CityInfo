namespace CityInfo.API.Services
{
    public class LocalMailService : IMailService
    {
        private readonly string _mailFrom = "noreply@mycompany.com";
        private readonly string _mailTo = "admin@mycompany.com";

        public void SendEmail(string subject, string message)
        {
            Console.WriteLine($"Mail from {_mailFrom} to {_mailTo}, with {nameof(LocalMailService)}");
            Console.WriteLine($"Subject: {subject}");
            Console.WriteLine($"Message: {message}");
        }
    }
}

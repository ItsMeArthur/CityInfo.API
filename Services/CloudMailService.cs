namespace CityInfo.API.Services
{
    public class CloudMailService: IMailService
    {
        private readonly string mailTo = string.Empty;
        private readonly string mailFrom = string.Empty;

        public CloudMailService(IConfiguration configuration)
        {
            mailTo = configuration["mailSettings:mailToAddress"];
            mailFrom = configuration["mailSettings:mailFromAddress"];
        }

        public void Send(string subject, string message)
        {
            System.Diagnostics.Debug.WriteLine($"Mail from {mailFrom} to {mailTo}, with {nameof(CloudMailService)}.");
            System.Diagnostics.Debug.WriteLine($"Subject: {subject}");
            System.Diagnostics.Debug.WriteLine($"Message: {message}");
        }
    }
}

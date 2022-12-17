using Dependence_Injection.Src;
using System.Net.Mail;

namespace Dependence_Injection
{
  internal class Program
  {
    static void Main(string[] args)
    {
      SmtpClient smtpClient = new SmtpClient();

      IEmailService emailService = new EmailService(smtpClient);
      emailService.SendEmail("user@example.com", "Hello", "Hello, how are you?");
    }
  }
}

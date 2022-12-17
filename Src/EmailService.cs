using System.Net;
using System.Net.Mail;

namespace Dependence_Injection.Src
{
  internal class EmailService : IEmailService
  {
    private readonly SmtpClient FsmtpClient;

    public EmailService(SmtpClient smtpClient)
    {
      FsmtpClient = smtpClient;
    }

    public void SendEmail(string ATo, string ASubject, string ABody)
    {
      // Use the _smtpClient to send the email

      FsmtpClient.Host = "smtp.example.com";
      FsmtpClient.Port = 587;
      FsmtpClient.EnableSsl = true;
      FsmtpClient.Credentials = new NetworkCredential("username", "password");

      // Crie a mensagem de e-mail
      MailMessage message = new MailMessage
      {
        From = new MailAddress("sender@example.com")
      };

      message.To.Add(ATo);
      message.Subject = ASubject;
      message.Body = ABody;

      // Envie o e-mail
      FsmtpClient.Send(message);
    }
  }
}

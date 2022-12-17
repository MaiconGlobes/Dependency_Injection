namespace Dependence_Injection.Src
{
  internal interface IEmailService
  {
    void SendEmail(string ATo, string ASubject, string ABody);
  }
}

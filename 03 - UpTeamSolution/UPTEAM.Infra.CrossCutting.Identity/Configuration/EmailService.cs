using System;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.Identity;
using System.Web.Configuration;

namespace UPTEAM.Infra.CrossCutting.Identity.Configuration
{
    public class EmailService : IIdentityMessageService
    {
        public Task SendAsync(IdentityMessage message)
        {
            // Habilitar o envio de e-mail
                var text = HttpUtility.HtmlEncode(message.Body);

                var msg = new MailMessage {From = new MailAddress("admin@portal.com.br", "Admin do Portal")};

                msg.To.Add(new MailAddress(message.Destination));
                msg.Subject = message.Subject;
                msg.AlternateViews.Add(AlternateView.CreateAlternateViewFromString(text, null, MediaTypeNames.Text.Plain));
                msg.AlternateViews.Add(AlternateView.CreateAlternateViewFromString(text, null, MediaTypeNames.Text.Html));

                var smtpClient = new SmtpClient("smtp-mail.outlook.com", Convert.ToInt32(587));

                var credentials = new NetworkCredential(WebConfigurationManager.AppSettings["ContaDeEmail"],
                    WebConfigurationManager.AppSettings["SenhaEmail"]);

                smtpClient.Credentials = credentials;
                smtpClient.EnableSsl = true;
                smtpClient.Send(msg);

            return Task.FromResult(0);
        }
    }
}
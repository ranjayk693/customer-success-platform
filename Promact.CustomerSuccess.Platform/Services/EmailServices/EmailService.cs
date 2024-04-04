
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Extensions.Options;
using MimeKit;
using Promact.CustomerSuccess.Platform.Entities;

namespace Promact.CustomerSuccess.Platform.Services.EmailServices
{
    public class EmailService:IEmailService
    {
        private readonly IConfiguration _config;
        private readonly EmailSender _emailSettings;
        public EmailService(IOptions<EmailSender> options, IConfiguration config)
        {
            _emailSettings = options.Value;
            _config = config;
        }


        /*Function to send the email*/
        public async Task SendEmailAsync(EmailDto request)
        {
            var email = new MimeMessage();
            email.Sender = MailboxAddress.Parse(_config.GetValue<string>("EmailAuth:email"));
            email.To.Add(MailboxAddress.Parse(request.To));
            email.Subject = request.Subject;
            var builder = new BodyBuilder();
            builder.HtmlBody = request.Body;
            email.Body = builder.ToMessageBody();

            using var smtp = new SmtpClient();
            smtp.Connect(_config.GetValue<string>("EmailAuth:service"), 587, SecureSocketOptions.StartTls);
            smtp.Authenticate(_config.GetValue<string>("EmailAuth:email"), _config.GetValue<string>("EmailAuth:password"));
            await smtp.SendAsync(email);
            smtp.Disconnect(true);
        }
    }
}

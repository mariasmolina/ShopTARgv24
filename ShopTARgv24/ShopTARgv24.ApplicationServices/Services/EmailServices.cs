using Microsoft.Extensions.Configuration;
using MimeKit;
using ShopTARgv24.Core.Dto;

namespace ShopTARgv24.ApplicationServices.Services
{
    public class EmailServices
    {
        private readonly IConfiguration _config;

        public EmailServices(IConfiguration config)
        {
            _config = config;
        }

        public void SendEmail(EmailDto dto)
        {
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse(_config.GetSection("EmailUserName").Value));
            email.To.Add(MailboxAddress.Parse(dto.To));
            email.Subject = dto.Subject;

            var builder = new BodyBuilder
            {
                HtmlBody = dto.Body
            };
            
            // vaja teha foreach, kus saab lisafa mitu faili
            // vaja kasutada kontrolli, kus kui faili pole, siis ei lisa
            if (dto.Attachment != null)
            {
                foreach (var file in dto.Attachment)
                {
                    using var target = new MemoryStream();
                    file.CopyTo(target);
                    var fileBytes = target.ToArray();
                    builder.Attachments.Add(file.FileName, fileBytes, ContentType.Parse(file.ContentType));
                }
            }

            email.Body = builder.ToMessageBody();
        }
    }
}

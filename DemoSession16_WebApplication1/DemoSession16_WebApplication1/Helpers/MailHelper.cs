using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.Net;
using System.Net.Mail;
using System.Diagnostics;

namespace DemoSession16_WebApplication1.Helpers
{
    public class MailHelper
    {
        private IConfiguration configuration;

        public MailHelper(IConfiguration _configuration)
        {
            configuration = _configuration;
        }

        public bool Send(string from,string to,string subject, string content)
        {
            try
            {
                var host = configuration["Gmail:Host"].ToString();
                var port = int.Parse(configuration["Gmail:Port"].ToString());
                var username = configuration["Gmail:Username"].ToString();
                var password = configuration["Gmail:Password"].ToString();
                var enable = bool.Parse(configuration["Gmail:SMTP:StartTLS:Enable"].ToString());
                var smtpClient = new SmtpClient
                {
                    Host = host,
                    Port = port,
                    EnableSsl = enable,
                    Credentials = new NetworkCredential(username, password)
                };
                var mailMessage = new MailMessage(from, to, subject, content);
                mailMessage.IsBodyHtml = true;
                smtpClient.Send(mailMessage);
                return true;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                return false;
            }
        }

        public bool Send(string from, string to, string subject, string content, string attachment)
        {
            try
            {
                var host = configuration["Gmail:Host"].ToString();
                var port = int.Parse(configuration["Gmail:Port"].ToString());
                var username = configuration["Gmail:Username"].ToString();
                var password = configuration["Gmail:Password"].ToString();
                var enable = bool.Parse(configuration["Gmail:SMTP:StartTLS:Enable"].ToString());
                var smtpClient = new SmtpClient
                {
                    Host = host,
                    Port = port,
                    EnableSsl = enable,
                    Credentials = new NetworkCredential(username, password)
                };
                var mailMessage = new MailMessage(from, to, subject, content);
                mailMessage.IsBodyHtml = true;
                if (attachment != null)
                {
                    mailMessage.Attachments.Add(new Attachment(attachment));
                }
                smtpClient.Send(mailMessage);
                return true;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                return false;
            }
        }

        public bool Send(string from, string to, string subject, string content, List<string> attachments)
        {
            try
            {
                var host = configuration["Gmail:Host"].ToString();
                var port = int.Parse(configuration["Gmail:Port"].ToString());
                var username = configuration["Gmail:Username"].ToString();
                var password = configuration["Gmail:Password"].ToString();
                var enable = bool.Parse(configuration["Gmail:SMTP:StartTLS:Enable"].ToString());
                var smtpClient = new SmtpClient
                {
                    Host = host,
                    Port = port,
                    EnableSsl = enable,
                    Credentials = new NetworkCredential(username, password)
                };
                var mailMessage = new MailMessage(from, to, subject, content);
                mailMessage.IsBodyHtml = true;
                if (attachments != null && attachments.Count>0)
                {
                    foreach(var attachment in attachments)
                    {
                        mailMessage.Attachments.Add(new Attachment(attachment));
                    }
                }
                smtpClient.Send(mailMessage);
                return true;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                return false;
            }
        }
    }
}

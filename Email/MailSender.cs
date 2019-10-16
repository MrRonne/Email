using System;
using System.Collections.Generic;

namespace Email
{
    public class MailSender
    {
        private readonly List<string> recipients;
        public readonly string Title;
        public readonly string Body;

        public MailSender(string recipient, string body)
            : this(recipient, body, body.Substring(0, Math.Min(50, body.Length)))
        { }

        public MailSender(string recipient, string body, string title)
        {
            recipients = new List<string> {recipient};
            Body = body;
            Title = title;
        }

        public IEnumerable<string> GetRecipients()
        {
            foreach (var recipient in recipients)
            {
                yield return recipient;
            }
        }

        public void AddRecipient(string recipient)
        {
            recipients.Add(recipient);
        }

        public IEnumerable<Mail> GetMails()
        {
            foreach (var recipient in recipients)
            {
                yield return new Mail(recipient, Title, Body);
            }
        }

        public void SendMails()
        {
            foreach (var mail in GetMails())
            {
                //Mail sending
                throw new NotImplementedException();
            }
        }
    }
}
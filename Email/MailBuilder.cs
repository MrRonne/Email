using System;
using System.Text;

namespace Email
{
    public class MailBuilder
    {
        public string Title => title.ToString();
        private readonly StringBuilder title;
        public string Body => body.ToString();
        private readonly StringBuilder body;

        public MailBuilder(string body)
        {
            title = new StringBuilder();
            if (!string.IsNullOrEmpty(body))
                this.body = new StringBuilder(body);
            else
                throw new ArgumentException();
        }

        public void SetBody(string newBody)
        {
            if (!string.IsNullOrEmpty(newBody))
            {
                body.Clear();
                body.Append(newBody);
            }
            else
                throw new ArgumentException();
        }

        public void SetTitle(string newTitle)
        {
            title.Clear();
            title.Append(newTitle);
        }

        public void AddBodyText(string text)
        {
            body.Append(text);
        }

        public void AddBodyLine(string line)
        {
            body.AppendLine(line);
        }

        public MailSender GetSender(string recipient)
        {
            return new MailSender(recipient, Body, Title);
        }
    }
}
namespace Email
{
    public class Mail
    {
        public string To { get; private set; }
        public string Title { get; private set; }
        public string Body { get; private set; }

        public Mail(string to, string title, string body)
        {
            To = to;
            Title = title;
            Body = body;
        }

        public void ChangeRecipient(string newRecipient)
        {
            To = newRecipient;
        }
    }
}
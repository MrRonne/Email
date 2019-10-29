using System;
using System.Linq;

namespace Email
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new MailBuilder("Hello, world!");
            builder.AddBodyLine("From Ronne");
            builder.SetTitle("3 task");
            var sender = builder.GetSender("usu.courses@gmail.com");
            sender.AddRecipient("mr.ronne@yandex.ru");
            if (sender.GetRecipients().Count() != sender.GetMails().Count())
                throw new Exception("Something went wrong");
            sender.SendMails();
        }
    }
}

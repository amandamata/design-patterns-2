using System;

namespace DesignPatterns2.Cap6
{
    public class EmailSender : ISender
    {
        public void Send(IMessage message)
        {
            Console.WriteLine("Sending email message");
            Console.WriteLine(message.Format());
        }
    }
}

using System;

namespace DesignPatterns2.Cap6
{
    public class SmsSender : ISender
    {
        public void Send(IMessage message)
        {
            Console.WriteLine("Sending sms message");
            Console.WriteLine(message.Format());
        }
    }
}

using System;

namespace DesignPatterns2.bridge
{
    public class ClientMessage : IMessage
    {
        public string Name { get; }
        public ISender Sender { get; set; }

        public ClientMessage(string name)
        {
            Name = name;
        }

        public void Send()
        {
            Sender.Send(this);
        }

        public string Format()
        {
            return String.Format("Sending message to client {0}", Name);
        }
    }
}

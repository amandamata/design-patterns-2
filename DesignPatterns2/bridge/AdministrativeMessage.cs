namespace DesignPatterns2.bridge
{
    public class AdministrativeMessage : IMessage
    {
        private string Name { get; }
        public ISender Sender { get; set; }

        public AdministrativeMessage(string name)
        {
            Name = name;
        }

        public void Send()
        {
            Sender.Send(this);
        }

        public string Format()
        {
            return string.Format("Sending message to admintistrator {0}", Name);
        }
    }
}

namespace DesignPatterns2.bridge
{
    public interface IMessage
    {
        ISender Sender { get; set; }

        void Send();
        string Format();
    }
}

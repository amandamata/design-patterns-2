namespace DesignPatterns2.Cap6
{
    public interface IMessage
    {
        ISender Sender { get; set; }

        void Send();
        string Format();
    }
}

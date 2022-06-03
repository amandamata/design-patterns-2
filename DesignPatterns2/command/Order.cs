using System;

namespace DesignPatterns2.command
{
    public class Order
    {
        public string Client { get; private set; }
        public double Value { get; private set; }
        public DateTime EndDate { get; private set; }
        public Status Status { get; private set; }

        public Order(string client, double value)
        {
            Client = client;
            Value = value;
            Status = Status.New;
        }

        public void Pay()
        {
            Status = Status.Paid;
        }

        public void End()
        {
            Status = Status.Delivered;
            EndDate = DateTime.Now;
        }
    }
}

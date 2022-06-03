
using System;

namespace DesignPatterns2.command
{
    public class PayOrder : ICommand
    {
        private Order Order;

        public PayOrder(Order order)
        {
            Order = order;
        }

        public void Execute()
        {
            Console.WriteLine("Paying order {0} ", Order.Client);
            Order.Pay();
        }
    }
}

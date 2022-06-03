using System;

namespace DesignPatterns2.command
{
    internal class EndOrder : ICommand
    {
        private readonly Order Order;

        public EndOrder(Order order)
        {
            Order = order;
        }

        public void Execute()
        {
            Console.WriteLine("Ending order {0} ", Order.Client);
            Order.End();
        }
    }
}

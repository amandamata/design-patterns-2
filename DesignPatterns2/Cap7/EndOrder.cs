using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2.Cap7
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

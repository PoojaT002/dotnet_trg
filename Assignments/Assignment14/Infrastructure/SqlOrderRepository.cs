using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment14.Contracts;

namespace Assignment14.Infrastructure
{
    internal sealed class SqlOrderRepository : IOrderRespository
    {
        public void Save(IOrder order)
        {
            Console.WriteLine($"Order {order.Id} saved to DB");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment14.Contracts;

namespace Assignment14.Infrastructure
{
    internal interface IOrderRespository
    {
        void Save(IOrder order);
    }
}

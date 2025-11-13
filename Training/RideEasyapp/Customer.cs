using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RideEasyapp
{
    internal class Customer
    {
        public string Name;
        public string Phone;
        public int LoyaltyPoints;

        public Customer(string n,string p, int pts)
        {
            Name = n; 
            Phone = p; 
            LoyaltyPoints = pts;
        }
    }
}

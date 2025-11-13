using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RideEasyapp
{
    internal class Vehicle
    {
        public string Type;
        public decimal BaseFare;
        public decimal PerKm;

        public Vehicle(string t, decimal baseFare, decimal rate)
        {
            Type = t;
            BaseFare = baseFare;
            PerKm = rate;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RideEasyapp
{
    internal class Ride
    {
        public DateTime Date;
        public decimal Distance;
        public Vehicle VehicleInfo;

        public Ride(DateTime d,decimal dist,Vehicle v)
        {
            Date = d;
            Distance = dist;
            VehicleInfo = v;
        }
        public void ComputeBill(out decimal sub, out decimal gst, out decimal total,params string[] addOns)
        {
            sub = VehicleInfo.BaseFare + (VehicleInfo.PerKm * Distance) + Pricing.AddOnsCost(addOns);
            if (Pricing.TryGetWeekendSurcharge(Date, out decimal pct))
                sub += sub * pct;

            gst = Pricing.CalculateGST(sub);
            total = sub + gst;
        }
    }
}

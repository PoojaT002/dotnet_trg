using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace RideEasyapp
{
    static class Pricing
    {
        public static decimal CalculateGST(decimal amount)
        {
            return amount * 0.18m;
        }
        public static bool TryGetWeekendSurcharge(DateTime rideDate, out decimal percent)
        {
            if(rideDate.DayOfWeek==DayOfWeek.Saturday || rideDate.DayOfWeek==DayOfWeek.Sunday)
            {
                percent = 0.10m;
                return true;
            }
            percent = 0;
            return false;
        }

        public static decimal AddOnsCost(params string[] addOns)
        {
            decimal cost = 0;
            foreach (string a in addOns)
            {
                string add = a.ToLower();
                
                    if (add == "priority-pickup")
                        cost += 120;
                    else if (add == "fast-tag") 
                        cost += 80;
                    else if (add == "extra-luggage")
                        cost += 50;
                    else if (add == "child-seat") 
                        cost += 50;
                
                
            }
            return cost;
        }
            public static void TryApplyCoupon_ByValue(decimal total,decimal couponAmount)
            {
                decimal copy = total - couponAmount;
               

            }
        public static void ApplyCoupon_ByRef(ref decimal total,decimal couponAmount)
        {
            total -= couponAmount;
        }
        public static void RedeemLoyalty(ref int points,ref decimal total)
        {
            if (points>=100)
            {
                total -= 120;
                points = 0;
            }
        }
        }
    }


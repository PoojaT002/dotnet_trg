using Assignment14.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment14.Domain
{
    public class Order : IOrder
    {
        public int Id { get; set; }
        public string BuyerEmail { get;  set; }
        public string ShipToCity { get;  set; }
        public double TotalWeightKg { get;  set; }
        public ILineItem[] Items { get;  set; }
        public decimal TotalAmount { get; set; }
        public OrderStatus Status { get; set; } 

        public Order(int id, string buyerEmail, string shipToCity, double totalWeightKg, ILineItem[] items)
        {
            Id = id;
            BuyerEmail = buyerEmail;
            ShipToCity = shipToCity;
            TotalWeightKg = totalWeightKg;
            Items = items;
            Status = OrderStatus.Created;
        }
    }
}

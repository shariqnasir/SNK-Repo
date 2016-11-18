using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KashmirFood.API.Models
{
    public class Order
    {
        public string OrderId { get; set; }
        public Guid UserId { get; set; }
        public string Address { get; set; }
        public DateTime PlacedOn { get; set; }
        public int OrderType { get; set; } //DineIn,Pickup,Delivery
        public DateTime ReadyOn { get; set; }
        public string Status { get; set; } //Pending Confirmation,In Progress,Dined In/Picked Up/Delivered,Returned
        public Guid TransactionId { get; set; }

        //item
        public Decimal CostPrice { get; set; }
        public Decimal SellingPrice { get; set; }
        public decimal Tax1 { get; set; }
        public decimal Tax2 { get; set; }
        public decimal Tax3 { get; set; }
        public decimal Discount { get; set; }
        public string ItemName { get; set; }
        public string MenuGroupName { get; set; }
        public Guid RestaurantId { get; set; }
        public decimal BalanceAmount { get; set; }
    }

    public class Transaction
    {
        public Guid TransactionId { get; set; }
        public Guid PaymentModeId { get; set; }

    }
}
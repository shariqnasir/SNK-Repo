using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KashmirFood.API.Models
{
    public class MenuItem
    {
        public Guid MenuItemId { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public int Type { get; set; } //DineIn, PickUp, Delivery
        public Decimal CostPrice { get; set; }
        public Decimal SellingPrice { get; set; }
        public decimal Tax1 { get; set; }
        public decimal Tax2 { get; set; }
        public decimal Tax3 { get; set; }
        public decimal Discount { get; set; }
        //public virtual IEnumerable<MenuGroup> MenuGroups { get; set; }

    }
}
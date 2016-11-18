using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KashmirFood.API.Models
{
    public class MasterInfo
    {
        public Guid Id { get; set; }
        public Guid RestaurantId { get; set; }
        public Decimal CRate { get; set; }
        public decimal BillAmount { get; set; }
        public DateTime BillDueDate { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KashmirFood.API.Models
{
    public class Restaurant
    {
        public Guid RestaurantId { get; set; }
        public string Name { get; set; }
        public string AddressLine1 { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public decimal RankAmount { get; set; }
        public bool Active { get; set; }
        public string LoginId { get; set; }
        public string Password { get; set; }
        public DateTime SubscriptionEndsOn { get; set; }
        public string Code { get; set; }
        public string LastInvNum { get; set; }
    }
}
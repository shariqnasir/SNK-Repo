using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KashmirFood.API.Models
{
    public class MenuGroupItem
    {
        public Guid Id { get; set; }
        public Guid MenuGroupId { get; set; }
        public Guid MenuItemId { get; set; }
    }
}
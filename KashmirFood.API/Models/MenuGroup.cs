using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KashmirFood.API.Models
{
    public class MenuGroup
    {
        public Guid MenuGroupId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public Guid RestaurtId { get; set; }
    }
}
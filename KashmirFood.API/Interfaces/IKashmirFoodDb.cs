using KashmirFood.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KashmirFood.API.Interfaces
{
    public interface IKashmirFoodDb
    {
        IQueryable<MasterInfo> MasterInfos { get; }
        IQueryable<MenuGroup> MenuGroups { get; }
        IQueryable<MenuGroupItem> MenuGroupItems { get; }
        IQueryable<MenuItem> MenuItems { get; }
        IQueryable<Order> Orders { get; }
        IQueryable<PaymentMode> PaymentModes { get; }
        IQueryable<Restaurant> Restaurants { get; }
        IQueryable<Role> Roles { get; }
        IQueryable<User> Users { get; }
        IQueryable<UserRole> UserRoles { get; }
    }
}

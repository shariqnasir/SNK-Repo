using KashmirFood.API.Interfaces;
using KashmirFood.API.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace KashmirFood.API.Repository
{
    public class KashmirFoodContext : IdentityDbContext<IdentityUser>, IKashmirFoodDb
    {
        public KashmirFoodContext() : base("KFConnection")
        {
        
        }

        public DbSet<MasterInfo> MasterInfos { get; set; }
        IQueryable<MasterInfo> IKashmirFoodDb.MasterInfos
        {
            get { return MasterInfos; }
        }

        public DbSet<MenuGroup> MenuGroups { get; set; }
        IQueryable<MenuGroup> IKashmirFoodDb.MenuGroups
        {
            get { return MenuGroups; }
        }

        public DbSet<MenuGroupItem> MenuGroupItems { get; set; }
        IQueryable<MenuGroupItem> IKashmirFoodDb.MenuGroupItems
        {
            get { return MenuGroupItems; }
        }

        public DbSet<MenuItem> MenuItems { get; set; }
        IQueryable<MenuItem> IKashmirFoodDb.MenuItems
        {
            get { return MenuItems; }
        }

        public DbSet<Order> Orders { get; set; }
        IQueryable<Order> IKashmirFoodDb.Orders
        {
            get { return Orders; }
        }

        public DbSet<PaymentMode> PaymentModes { get; set; }
        IQueryable<PaymentMode> IKashmirFoodDb.PaymentModes
        {
            get { return PaymentModes; }
        }

        public DbSet<Restaurant> Restaurants { get; set; }
        IQueryable<Restaurant> IKashmirFoodDb.Restaurants
        {
            get { return Restaurants; }
        }

        public DbSet<Role> Roles { get; set; }
        IQueryable<Role> IKashmirFoodDb.Roles
        {
            get { return Roles; }
        }

        public DbSet<User> Users { get; set; }
        IQueryable<User> IKashmirFoodDb.Users
        {
            get { return Users; }
        }

        public DbSet<UserRole> UserRoles { get; set; }
        IQueryable<UserRole> IKashmirFoodDb.UserRoles
        {
            get { return UserRoles; }
        }


    }
}
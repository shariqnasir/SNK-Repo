using KashmirFood.API.DTO;
using KashmirFood.API.Interfaces;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace KashmirFood.API.Repository
{
    public class AuthRepository : IDisposable //: GenericRepository<KashmirFoodDb, AuthModel>
    {
        private KashmirFoodContext _ctx;
        private UserManager<IdentityUser> _userManager;

        public AuthRepository()
        {
            _ctx = new KashmirFoodContext();
            _userManager = new UserManager<IdentityUser>(new UserStore<IdentityUser>(_ctx));
        }

        public async Task<IdentityResult> RegisterUser(AuthUserDTO authDTO)
        {
            IdentityUser user = new IdentityUser
            {
                UserName = authDTO.UserName
            };

            var result = await _userManager.CreateAsync(user, authDTO.Password);
            if (result != null && result.Succeeded)
            {
                var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new KashmirFoodContext()));
                var currUsername = _userManager.FindByName(authDTO.UserName);
                IdentityResult roleResult;
                if (roleManager.Roles.Count() == 0)
                {
                    roleManager.Create(new IdentityRole { Name = "SuperAdmin" });
                    roleManager.Create(new IdentityRole { Name = "RestaurantOwner" });
                    roleManager.Create(new IdentityRole { Name = "Customer" });
                }
                
                if (authDTO.Restaurant)
                {
                    roleResult = _userManager.AddToRole(currUsername.Id, "RestaurantOwner");
                    
                }
                else
                {
                    roleResult = _userManager.AddToRole(currUsername.Id, "Customer");                
                }
                if (roleResult != null && !roleResult.Succeeded)
                {
                    result.Errors.Union(roleResult.Errors);
                }
            }
            return result;
        }
        public async Task<IdentityUser> FindUser(string userName, string password)
        {
            IdentityUser user = await _userManager.FindAsync(userName, password);

            return user;
        }
        public void Dispose()
        {
            _ctx.Dispose();
            _userManager.Dispose();
        }
    }

     
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KashmirFood.API.Repository;
using KashmirFood.API.Interfaces;
using KashmirFood.API.Models;

namespace KashmirFood.Data.Repository
{
    public class UserRoleRepository : GenericRepository<KashmirFoodContext, UserRole>, IUserRoleRepository
    {
    }
}

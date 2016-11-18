using KashmirFood.API.Interfaces;
using KashmirFood.API.Models;
using KashmirFood.API.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KashmirFood.Data.Repository
{
    public class MenuGroupRepository : GenericRepository<KashmirFoodContext,MenuGroup>, IMenuGroupRepository
    {
    }
}

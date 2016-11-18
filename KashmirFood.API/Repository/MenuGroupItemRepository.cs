using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KashmirFood.API.Repository;
using KashmirFood.API.Models;
using KashmirFood.API.Interfaces;

namespace KashmirFood.Data.Repository
{
    public class MenuGroupItemRepository : GenericRepository<KashmirFoodContext, MenuGroupItem>, IMenuGroupItemRepository
    {
    }
}

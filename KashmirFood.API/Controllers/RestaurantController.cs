using KashmirFood.API.Interfaces;
using KashmirFood.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace KashmirFood.API.Controllers
{
    public class RestaurantController : ApiController
    {
        private IRestaurantRepository repoRestaurant;
        public RestaurantController()
        {
            repoRestaurant = new RestaurantRepository();
        }

        [Authorize]
        public string Get()
        {
            return "ddfd";
        }
    }
}

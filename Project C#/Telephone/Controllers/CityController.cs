using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Telephone.Models;

namespace Telephone.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CityController : ControllerBase
    {
      
        [HttpGet]
        public IEnumerable<City> Get()
        {
            using (var context = new telephoneContext())
            {
                //add city

                //City city = new City();
                //city.NameCity = "Spain";

                //context.City.Add(city);

                //context.SaveChanges();
                //update
                //City city = context.City.Where(city => city.NameCity == "Spain").FirstOrDefault<City>();
               //city.DiscountPercent = "10";
               //delete
               // City city = context.City.Where(city => city.NameCity == "Spain").FirstOrDefault();
                //context.City.Remove(city);
               // context.SaveChanges();

                //get all city
                return context.City.Where(city => city.IdCity == 1).ToList();
            }
        }
    }
}

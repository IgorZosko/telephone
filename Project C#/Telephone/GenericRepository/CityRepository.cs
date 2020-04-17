using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telephone.Interfaces.Repository;
using Telephone.Models;
using Telephone.GenericRepository;

namespace Telephone.GenericRepository
{
    public class CityRepository : GenericRepository<City>, ICityRepository
    {
        public CityRepository(telephoneContext context) : base(context)
        {

        }
    }
}

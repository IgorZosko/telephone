using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telephone.Interfaces.Repository;
using Telephone.Models;
using Telephone.GenericRepository;

namespace WebApiEF.Repository.SQL_Repository
{
    public class SubscribesRepository : GenericRepository<Subscribe>, ISubscribesRepository
    {
        public SubscribesRepository(telephoneContext context) : base(context)
        {

        }
    }
}

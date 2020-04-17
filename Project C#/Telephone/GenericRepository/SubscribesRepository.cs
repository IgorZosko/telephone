using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telephone.Interfaces.Repository;
using Telephone.Models;


namespace Telephone.GenericRepository
{
    public class SubscribesRepository : GenericRepository<Subscribe>, ISubscribesRepository
    {
        public SubscribesRepository(telephoneContext context) : base(context)
        {

        }
    }
}

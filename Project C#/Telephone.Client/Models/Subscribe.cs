using System;
using System.Collections.Generic;

namespace Telephone.Models
{
    public partial class Subscribe
    {

        public int IdAbonent { get; set; }
        public string NumberPhone { get; set; }
        public string Inpp { get; set; }
        public string Street { get; set; }
        public string BankAccount { get; set; }

        public virtual ICollection<Talk> Talk { get; set; }

        public Subscribe()
        {

        }
    }
}

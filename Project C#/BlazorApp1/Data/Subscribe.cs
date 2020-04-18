using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public partial class Subscribe
    {
        public Subscribe()
        {
            
        }

        public int IdAbonent { get; set; }
        public string NumberPhone { get; set; }
        public string Inpp { get; set; }
        public string Street { get; set; }
        public string BankAccount { get; set; }

        public virtual ICollection<Talk> Talk { get; set; }
    }
}

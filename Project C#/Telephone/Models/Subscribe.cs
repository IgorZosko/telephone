using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Telephone.Models
{
    public partial class Subscribe
    {
        
        public int IdAbonent { get; set; }
        [Required]
        public string NumberPhone { get; set; }
        [Required]
        public string Inpp { get; set; }
        [Required]
        public string Street { get; set; }
        [Required]
        public string BankAccount { get; set; }

        public virtual ICollection<Talk> Talk { get; set; }

    }
}

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace BlazorApp1.Data
{
    public partial class City
    {
        public City()
        {
            Talk = new HashSet<Talk>();
        }

        public int IdCity { get; set; }
        public string NameCity { get; set; }
        public string RatePm { get; set; }
        public string RateAm { get; set; }
        public string DiscountPercent { get; set; }

        public virtual ICollection<Talk> Talk { get; set; }
    }
}

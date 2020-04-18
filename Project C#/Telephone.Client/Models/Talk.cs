using System;
using System.Collections.Generic;

namespace Telephone.Models
{
    public partial class Talk
    {
        public int IdTalk { get; set; }
        public int IdAbonent { get; set; }
        public int IdCity { get; set; }
        public string TimeTalk { get; set; }
        public DateTime? Ddate { get; set; }
        public string TimeOfDate { get; set; }

        public virtual Subscribe IdAbonentNavigation { get; set; }
        public virtual City IdCityNavigation { get; set; }
    }
}

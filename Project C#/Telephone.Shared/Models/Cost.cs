using System;
using System.Collections.Generic;

namespace Telephone.Models
{
    public partial class Cost
    {
        public int IdTalk { get; set; }
        public decimal? Cost1 { get; set; }
        public decimal? Discount { get; set; }

        public virtual Talk IdTalkNavigation { get; set; }
    }
}

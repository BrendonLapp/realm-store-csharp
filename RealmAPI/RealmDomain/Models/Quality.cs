using System;
using System.Collections.Generic;

#nullable disable

namespace RealmDomain.Models
{
    public partial class Quality
    {
        public Quality()
        {
            Inventories = new HashSet<Inventory>();
        }

        public int QualityId { get; set; }
        public decimal PercentageDiscount { get; set; }
        public string QualityName { get; set; }
        public string QualityShortName { get; set; }

        public virtual ICollection<Inventory> Inventories { get; set; }
    }
}

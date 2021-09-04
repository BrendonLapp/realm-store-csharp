using System;
using System.Collections.Generic;

#nullable disable

namespace RealmDomain.Models
{
    public partial class Orderstatus
    {
        public Orderstatus()
        {
            Orders = new HashSet<Order>();
        }

        public int StatusId { get; set; }
        public string StatusName { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}

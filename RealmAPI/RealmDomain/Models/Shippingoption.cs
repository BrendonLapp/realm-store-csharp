using System;
using System.Collections.Generic;

#nullable disable

namespace RealmDomain.Models
{
    public partial class Shippingoption
    {
        public Shippingoption()
        {
            Orders = new HashSet<Order>();
        }

        public int ShippingId { get; set; }
        public string ShippingName { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}

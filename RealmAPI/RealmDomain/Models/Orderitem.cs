using System;
using System.Collections.Generic;

#nullable disable

namespace RealmDomain.Models
{
    public partial class Orderitem
    {
        public int OrderItemId { get; set; }
        public int OrderId { get; set; }
        public int? InventoryId { get; set; }
        public int OrderQuantity { get; set; }
        public decimal OrderItemPrice { get; set; }

        public virtual Inventory Inventory { get; set; }
        public virtual Order Order { get; set; }
    }
}

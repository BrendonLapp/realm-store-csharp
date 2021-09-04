using System;
using System.Collections.Generic;

#nullable disable

namespace RealmDomain.Models
{
    public partial class Inventory
    {
        public Inventory()
        {
            Orderitems = new HashSet<Orderitem>();
        }

        public int InventoryId { get; set; }
        public int? CardId { get; set; }
        public int? SealedProductId { get; set; }
        public int Quantity { get; set; }
        public int QualityId { get; set; }
        public ulong? FirstEdition { get; set; }

        public virtual Card Card { get; set; }
        public virtual Quality Quality { get; set; }
        public virtual ICollection<Orderitem> Orderitems { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace RealmDomain.Models
{
    public partial class Sealedproduct
    {
        public int SealedProductId { get; set; }
        public int SetId { get; set; }
        public string SealedProductName { get; set; }
        public decimal Price { get; set; }

        public virtual Set Set { get; set; }
    }
}

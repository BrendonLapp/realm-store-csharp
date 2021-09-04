using System;
using System.Collections.Generic;

#nullable disable

namespace RealmDomain.Models
{
    public partial class Order
    {
        public Order()
        {
            Orderitems = new HashSet<Orderitem>();
        }

        public int OrderId { get; set; }
        public int ShippingId { get; set; }
        public int StatusId { get; set; }
        public string ShippingAddress { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public decimal? ShippingPrice { get; set; }
        public DateTime SaleDate { get; set; }
        public string UpdatedBy { get; set; }
        public decimal SubTotal { get; set; }
        public decimal? Pst { get; set; }
        public decimal? Hst { get; set; }
        public decimal? Gst { get; set; }
        public decimal Total { get; set; }

        public virtual Shippingoption Shipping { get; set; }
        public virtual Orderstatus Status { get; set; }
        public virtual ICollection<Orderitem> Orderitems { get; set; }
    }
}

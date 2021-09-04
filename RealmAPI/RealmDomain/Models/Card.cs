using System;
using System.Collections.Generic;

#nullable disable

namespace RealmDomain.Models
{
    public partial class Card
    {
        public Card()
        {
            Inventories = new HashSet<Inventory>();
        }

        public int CardId { get; set; }
        public int SetId { get; set; }
        public string CardCodeInSet { get; set; }
        public string CardName { get; set; }
        public string Rarity { get; set; }
        public decimal Price { get; set; }
        public string ElementalType { get; set; }
        public string SubType { get; set; }
        public string SuperType { get; set; }
        public string PictureLink { get; set; }
        public string PictureSmallLink { get; set; }
        public string ApiimageId { get; set; }

        public virtual Set Set { get; set; }
        public virtual ICollection<Inventory> Inventories { get; set; }
    }
}

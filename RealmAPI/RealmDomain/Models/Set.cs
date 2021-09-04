using System;
using System.Collections.Generic;

#nullable disable

namespace RealmDomain.Models
{
    public partial class Set
    {
        public Set()
        {
            Cards = new HashSet<Card>();
            Sealedproducts = new HashSet<Sealedproduct>();
        }

        public int SetId { get; set; }
        public string SetCode { get; set; }
        public int GameId { get; set; }
        public string SetName { get; set; }
        public DateTime ReleaseDate { get; set; }

        public virtual Game Game { get; set; }
        public virtual ICollection<Card> Cards { get; set; }
        public virtual ICollection<Sealedproduct> Sealedproducts { get; set; }
    }
}

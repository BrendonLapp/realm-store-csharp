using System;
using System.Collections.Generic;

#nullable disable

namespace RealmDomain.Models
{
    public partial class Game
    {
        public Game()
        {
            Sets = new HashSet<Set>();
        }

        public int GameId { get; set; }
        public string GameName { get; set; }

        public virtual ICollection<Set> Sets { get; set; }
    }
}

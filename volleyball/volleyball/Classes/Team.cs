using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace volleyball.Classes
{
    internal class Team
    {
        private Player[] roster;
        private int points;

        public Team(Player[] roster)
        {
            this.roster = roster;
            points = 0;
        }

        public Team(Player player)
        {
            this.roster = new Player[] { player, player, player, player, player, player };
        }

        public int Points { get => points; set => points = value; }
    }
}

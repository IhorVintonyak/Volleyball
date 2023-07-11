using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace volleyball.Classes
{
    internal class Game
    {
        private Team teamA;
        private Team teamB;
        private int maxPoints;

        public Game(Team teamA, Team teamB)
        {
            this.teamA = teamA;
            this.teamB = teamB;
            this.MaxPoints = 10;
        }

        public int MaxPoints { get => maxPoints; set => maxPoints = value; }

        public void controkMaxPoints()
        {
            if(teamA.Points==teamB.Points && teamA.Points==(maxPoints-1))
            maxPoints++;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace volleyball.Classes
{
    internal class Ball
    {
        private Team lastTouched;
        private int position;
        private int difficulty;

        internal Team LastTouched { get => lastTouched; set => lastTouched = value; }
        public int Position { get => position; set => position = value; }
        public int Difficulty { get => difficulty; set => difficulty = value; }

        public Ball(Team lastTouched, int position, int difficulty)
        {
            this.lastTouched = lastTouched;
            this.position = position;
            this.difficulty = difficulty;
        }

        public Ball(Team lastTouched)
        {
            this.lastTouched = lastTouched;
            position = 1;
            difficulty = 0;
        }

        public void ballMoved(int position, int difficulty)
        {
            this.position = position;
            this.difficulty = difficulty;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace volleyball.Classes
{
    internal class Player
    {
        //Overall information
        private string name;
        private string surname;
        private int number;

        //Characteristics 
        private int serve;
        private int defence;
        private int set;
        private int attack;
        private int block;
        private int dig;

        //Temporal values
        private int position;
        private bool used;
        private bool lastTouch;

        public Player()
        {
            name = "John";
            surname = "Doe";
            number = 1;
            serve = 60;
            defence = 70;
            set = 50;
            attack = 50;
            block = 50;
            dig = 70;
    }

        public Player(string name, string surname, int number)
        {
            this.name = name;
            this.surname = surname;
            this.number = number;
        }

        public void touched() {
            used = true;
            lastTouch = true;
        }
        public void Serve(int positionOfTarget,Ball ball)
        {
            ball.ballMoved(positionOfTarget, serve);
        }

        public bool Defence(Ball ball)
        {
            // return false is mean that defence is not good enough
            int result = defence - ball.Difficulty;
            if (result < 0)
            {
                return false;
            }
            ball.ballMoved(3, result);
            return true;
        }

        public bool Set(int positionOfTarget, Ball ball)
        {
            int result = set - ball.Difficulty;
            if (result < 0)
            {
                return false;
            }
            ball.ballMoved(positionOfTarget, result);
            return true;
        }

        public bool Attack(int positionOfTarget, Ball ball)
        {
            if (ball.Difficulty < 0)
            {
                return false;
            }
            int result = ball.Difficulty + attack;
            ball.ballMoved(positionOfTarget, result);
            return true;
        }

        public void Block(Ball ball)
        {
            int result = block - ball.Difficulty;
            ball.ballMoved(ball.Position, result);
        }

        public bool Dig(Ball ball)
        {
            int result = dig - ball.Difficulty;
            if (result < 0)
            {
                return false;
            }
            ball.ballMoved(3, result);
            return true;
        }
    }
}

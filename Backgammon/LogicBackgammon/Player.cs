using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicBackgammon
{
    public abstract class Player
    {
        public enum GameStatus
        {
            Start,
            Out,
            Finish
        };

        private string name;
        private int sum;
        private GameStatus status;

        public string Name
        {
            get
            {
                return name;
            }
        }

        public int Sum
        {
            get
            {
                return sum;
            }
        }

        public GameStatus Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
            }
        }

        public Player(string name)
        {
            status = GameStatus.Start;
            sum = 167;
        }

        public void UpdateSum(int steps)
        {
            sum -= steps;
        }

        public abstract void DoMove();

    }
}

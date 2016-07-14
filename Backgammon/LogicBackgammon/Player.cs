using System.Drawing;

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
        private Color color;

        public Player(string name, Color color)
        {
            this.color = color;
            status = GameStatus.Start;
            sum = 167;
        }

        public Color PlayerColor
        {
            get { return color; }
        }

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

        public void UpdateSum(int steps)
        {
            sum -= steps;
        }

        public abstract void DoMove();

    }
}

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
        private Rulls rulls;

        public Player(string name, Color color)
        {
            this.color = color;
            status = GameStatus.Start;
            sum = 167;
            this.name = name;
            if(color == Color.Red)
            {
                rulls = new RedRulls();
            }
            else
            {
                rulls = new BlueRulls();
            }
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

        public Rulls Rull
        {
            get { return rulls; }
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

        public bool IsValidMoves(int cube)
        {
            return rulls.IsValidMoves(cube, Status);
        }

        public abstract bool DoMove(int from, int steps);
    }
}
